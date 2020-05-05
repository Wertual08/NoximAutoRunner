using NoximAutoRunner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NoximAutoRunner
{
    public partial class RunnerForm : Form
    {
        private MessageQueue LogQueue = new MessageQueue();
        private BackgroundWorker[] ExecutionWorkers;
        private int ThreadsCount;
        private int GroupsCount, ResultsCount;
        private bool GraphDirty = false;
        private ExecutionResult[][] ExecutionResults;
        private string[] ExecutionNames;
        private decimal[] ExecutionSteps;
        private struct ExecutionResult
        {
            public decimal TotalReceivedPackets;
            public decimal TotalReceivedFlits;
            public decimal ReceivedIdealFlitsRatio;
            public decimal LastTimeFlitReceived;
            public decimal GlobalAverageDelayCycles;
            public decimal MaxDelayCycles;
            public decimal NetworkThroughputFlitsCycle;
            public decimal AverageIPThroughputFlitsCycleIP;
            public decimal TotalEnergyJ;
            public decimal DynamicEnergyJ;
            public decimal StaticEnergyJ;
            public void Parse(string str)
            {
                int ind;
                var entries = new string[11];
                entries[0] = "% Total received packets: ";
                entries[1] = "% Total received flits: ";
                entries[2] = "% Received/Ideal flits Ratio: ";
                entries[3] = "% Last time flit received: ";
                entries[4] = "% Global average delay (cycles): ";
                entries[5] = "% Max delay (cycles): ";
                entries[6] = "% Network throughput (flits/cycle): ";
                entries[7] = "% Average IP throughput (flits/cycle/IP): ";
                entries[8] = "% Total energy (J): ";
                entries[9] = "% Dynamic energy (J): ";
                entries[10] = "% Static energy (J): ";
                if ((ind = str.IndexOf(entries[0])) >= 0 && (ind += entries[0].Length) >= 0) TotalReceivedPackets = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[1])) >= 0 && (ind += entries[1].Length) >= 0) TotalReceivedFlits = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[2])) >= 0 && (ind += entries[2].Length) >= 0) ReceivedIdealFlitsRatio = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[3])) >= 0 && (ind += entries[3].Length) >= 0) LastTimeFlitReceived = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[4])) >= 0 && (ind += entries[4].Length) >= 0) GlobalAverageDelayCycles = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[5])) >= 0 && (ind += entries[5].Length) >= 0) MaxDelayCycles = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[6])) >= 0 && (ind += entries[6].Length) >= 0) NetworkThroughputFlitsCycle = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[7])) >= 0 && (ind += entries[7].Length) >= 0) AverageIPThroughputFlitsCycleIP = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[8])) >= 0 && (ind += entries[8].Length) >= 0) TotalEnergyJ = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[9])) >= 0 && (ind += entries[9].Length) >= 0) DynamicEnergyJ = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
                if ((ind = str.IndexOf(entries[10])) >= 0 && (ind += entries[10].Length) >= 0) StaticEnergyJ = decimal.Parse(str.Substring(ind, str.IndexOf('\n', ind) - ind), NumberStyles.Any);
            }
            public decimal this[int i]
            {
                get
                {
                    switch (i)
                    {
                    case 0: return TotalReceivedPackets;
                    case 1: return TotalReceivedFlits;
                    case 2: return ReceivedIdealFlitsRatio;
                    case 3: return LastTimeFlitReceived;
                    case 4: return GlobalAverageDelayCycles;
                    case 5: return MaxDelayCycles;
                    case 6: return NetworkThroughputFlitsCycle;
                    case 7: return AverageIPThroughputFlitsCycleIP;
                    case 8: return TotalEnergyJ;
                    case 9: return DynamicEnergyJ;
                    case 10: return StaticEnergyJ;
                    default: return 0m;
                    }
                }
                set
                {
                    switch (i)
                    {
                        case 0: TotalReceivedPackets = value; break;
                        case 1: TotalReceivedFlits = value; break;
                        case 2: ReceivedIdealFlitsRatio = value; break;
                        case 3: LastTimeFlitReceived = value; break;
                        case 4: GlobalAverageDelayCycles = value; break;
                        case 5: MaxDelayCycles = value; break;
                        case 6: NetworkThroughputFlitsCycle = value; break;
                        case 7: AverageIPThroughputFlitsCycleIP = value; break;
                        case 8: TotalEnergyJ = value; break;
                        case 9: DynamicEnergyJ = value; break;
                        case 10: StaticEnergyJ = value; break;
                    }
                }
            }
            public static readonly int Count = 11;
            static public string Title(int i)
            {
                switch (i)
                {
                    case 0: return "Total received packets";
                    case 1: return "Total received flits";
                    case 2: return "Received/Ideal flits Ratio";
                    case 3: return "Last time flit received";
                    case 4: return "Global average delay (cycles)";
                    case 5: return "Max delay (cycles)";
                    case 6: return "Network throughput (flits / cycle)";
                    case 7: return "Average IP throughput (flits/ cycle / IP)";
                    case 8: return "Total energy (J)";
                    case 9: return "Dynamic energy (J)";
                    case 10: return "Static energy (J)";
                    default: return "";
                }
            }
        }
        private class ThreadArguments
        {
            public string Executable;
            public string Config;
            public string Arguments;
            public decimal LowerBound;
            public decimal Step;
            public decimal HigherBound;
            public ExecutionResult[] Results;
        }
        private string SettingsPath;

        private void BuildGraph()
        {
            GraphDirty = false;
            ResultsChart.Series.Clear();
            if (ExecutionResults == null) return;
            int ind = ResultsListBox.SelectedIndex;
            ResultsChart.ChartAreas[0].AxisY.Title = ExecutionResult.Title(ind);
            for (int i = 0; i < ExecutionResults.Length; i++)
            {
                var group = ExecutionResults[i];
                var series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.Name = ExecutionNames[i];
                series.BorderWidth = 3;
                
                for (int j = 0; j < group.Length; j++)
                {
                    series.Points.AddXY((double)ExecutionSteps[j], (double)group[j][ind]);
                }
                ResultsChart.Series.Add(series);
            }
            ResultsChart.ResetAutoValues();
        }

        public RunnerForm()
        {
            InitializeComponent();
            ResultsListBox.SelectedIndex = 0;
            SettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "config.ini");

            try
            {
                if (File.Exists(SettingsPath))
                {
                    using (var file = File.OpenText(SettingsPath))
                    {
                        ExecutableTextBox.Text = file.ReadLine();
                        ConfigsTextBox.Text = file.ReadLine();
                        FilterTextBox.Text = file.ReadLine();
                        ArgumentsTextBox.Text = file.ReadLine();
                        LowerNumeric.Value = decimal.Parse(file.ReadLine());
                        StepNumeric.Value = decimal.Parse(file.ReadLine());
                        HigherNumeric.Value = decimal.Parse(file.ReadLine());
                        NameTextBox.Text = file.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not load configuration file.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(ExecutableTextBox.Text));
                var configs = Directory.GetFiles(ConfigsTextBox.Text, FilterTextBox.Text, SearchOption.AllDirectories);
                ExecutionWorkers = new BackgroundWorker[GroupsCount = ThreadsCount = configs.Length];
                ExecutionResults = new ExecutionResult[ThreadsCount][];
                ExecutionNames = new string[ThreadsCount];

                for (int i = 0; i < ThreadsCount; i++) ExecutionNames[i] = Path.GetFileNameWithoutExtension(configs[i]);

                var lb = LowerNumeric.Value;
                var hb = HigherNumeric.Value;
                var s = StepNumeric.Value;
                ResultsCount = (int)((hb - lb) / s) + 1;
                ExecutionSteps = new decimal[ResultsCount];
                int j = 0;
                for (decimal i = lb; i <= hb; i += s) ExecutionSteps[j++] = i;

                for (int i = 0; i < ThreadsCount; i++)
                    ExecutionResults[i] = new ExecutionResult[ResultsCount];

                for (int i = 0; i < ThreadsCount; i++)
                {
                    ExecutionWorkers[i] = new BackgroundWorker();
                    ExecutionWorkers[i].DoWork += ExecutionWorker_DoWork;
                    ExecutionWorkers[i].RunWorkerCompleted += ExecutionWorker_RunWorkerCompleted;
                    
                    var args = new ThreadArguments();
                    args.Executable = Path.GetFileName(ExecutableTextBox.Text);
                    args.Config = configs[i];
                    args.Arguments = ArgumentsTextBox.Text;
                    args.LowerBound = LowerNumeric.Value;
                    args.Step = StepNumeric.Value; 
                    args.HigherBound = HigherNumeric.Value;
                    args.Results = ExecutionResults[i];

                    ExecutionWorkers[i].RunWorkerAsync(args);
                    LogQueue.Put("Execution with config [" + args.Config + "] started...");
                }

                StartButton.Enabled = false;
                BuildGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not start execution.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecutionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = e.Argument;
            var args = e.Argument as ThreadArguments;
            int j = 0;
            for (decimal i = args.LowerBound; i <= args.HigherBound; i += args.Step)
            {
                Process p = new Process();
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.FileName = args.Executable;
                p.StartInfo.Arguments = "-config " + "\"" + args.Config + "\" " + args.Arguments.Replace("%VAR", i.ToString());
                p.StartInfo.WorkingDirectory = Path.GetDirectoryName(args.Executable);

                LogQueue.Put("Starting execution with arguments [" + p.StartInfo.Arguments + "]...");
                p.Start();
                string s = p.StandardOutput.ReadToEnd();
                args.Results[j++].Parse(s);
                //LogQueue.Put(s);
                p.WaitForExit();
                LogQueue.Put("Execution with arguments [" + p.StartInfo.Arguments + "] finished.");
                GraphDirty = true;
            }
        }
        private void ExecutionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                var result = e.Result as ThreadArguments;
                ThreadsCount--;
                LogQueue.Put("Execution with config [" + result.Config + "] finished.");
                if (ThreadsCount <= 0)
                {
                    StartButton.Enabled = true;
                    BuildGraph();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not finish thread execution.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MessagePump_Tick(object sender, EventArgs e)
        {
            string message;
            while ((message = LogQueue.Get()) != null) 
                LogTextBox.AppendText(message + Environment.NewLine);
            if (GraphDirty) BuildGraph();
        }

        private void StepNumeric_ValueChanged(object sender, EventArgs e)
        {
            IntervalNumeric.Value = StepNumeric.Value;
        }
        private void IntervalNumeric_ValueChanged(object sender, EventArgs e)
        {
            ResultsChart.ChartAreas[0].AxisX.Interval = (double)IntervalNumeric.Value;
            decimal val = IntervalNumeric.Value;
            int count = 0;
            var sp = val.ToString().Split('.');
            if (sp.Length == 2) count = sp[1].Length;
            while (sp[1][count - 1] == '0') count--;
            ResultsChart.ChartAreas[0].AxisX.LabelStyle.Format = "F" + count;
        }
        private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildGraph();
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultsChart.ChartAreas[0].AxisX.Title = NameTextBox.Text;
        }

        private void RunnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (var file = File.CreateText(SettingsPath))
                {
                    file.WriteLine(ExecutableTextBox.Text);
                    file.WriteLine(ConfigsTextBox.Text);
                    file.WriteLine(FilterTextBox.Text);
                    file.WriteLine(ArgumentsTextBox.Text);
                    file.WriteLine(LowerNumeric.Value);
                    file.WriteLine(StepNumeric.Value);
                    file.WriteLine(HigherNumeric.Value);
                    file.WriteLine(NameTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not save configuration file.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (ExecutionResults == null) return;

            try
            {
                using (var file = File.CreateText("exports.txt"))
                {
                    file.Write("\t\t");
                    for (int x = 0; x < GroupsCount; x++)
                    {
                        file.Write(ExecutionNames[x] + new string('\t', ExecutionResult.Count + 1));
                    }
                    file.WriteLine();

                    file.Write(NameTextBox.Text + "\t\t");
                    for (int x = 0; x < GroupsCount; x++)
                    {
                        for (int i = 0; i < ExecutionResult.Count; i++) file.Write(ExecutionResult.Title(i) + "\t");
                        file.Write("\t");
                    }
                    file.WriteLine();

                    for (int y = 0; y < ResultsCount; y++)
                    {
                        file.Write(ExecutionSteps[y] + "\t\t");
                        for (int x = 0; x < GroupsCount; x++)
                        {
                            for (int i = 0; i < ExecutionResult.Count; i++) file.Write(ExecutionResults[x][y][i] + "\t");
                            file.Write("\t");
                        }
                        file.WriteLine();
                    }
                }

                for (int i = 0; i < ExecutionResult.Count; i++)
                {
                    ResultsListBox.SelectedIndex = i;
                    using (var bmp = new Bitmap(ResultsChart.ClientSize.Width, ResultsChart.ClientSize.Height))
                    {
                        ResultsChart.DrawToBitmap(bmp, new Rectangle(0, 0, ResultsChart.ClientSize.Width, ResultsChart.ClientSize.Height));
                        var type = ExecutionResult.Title(i);
                        foreach (var c in Path.GetInvalidFileNameChars()) type = type.Replace(c, '-');
                        bmp.Save("Graph [" + type + "].png", ImageFormat.Png);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not export results.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
