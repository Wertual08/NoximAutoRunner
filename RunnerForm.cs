using Microsoft.SqlServer.Server;
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
        private struct PointD
        {
            public double X, Y;
            public PointD(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        private MessageQueue LogQueue = new MessageQueue();
        private List<BackgroundWorker> ExecutionWorkers = new List<BackgroundWorker>();
        private bool GraphDirty = false;

        private string HorizontalAxisName;

        private Dictionary<string, List<PointD>[]> ExecutionResults;

        private string ExecutablePath;
        private int GroupsCount, GroupCursor;
        private string[] ExecutionConfigs;
        private string[] ExecutionNames;
        private decimal ExecutionLowerBound;
        private decimal ExecutionProgress;
        private decimal ExecutionStep;
        private decimal ExecutionHigherBound;

        private class ThreadArguments
        {
            public string Executable;
            public string Config;
            public string Arguments;
            public decimal Variable;
            public int GroupIndex;
        }
        private class ThreadResult
        {
            public readonly double Variable;
            public readonly int Group;
            public readonly string[] Legends;
            public readonly double[] Values;

            private ThreadResult(int count, int group, double variable)
            {
                Variable = variable;
                Group = group;
                Legends = new string[count];
                Values = new double[count];
            }
            public static ThreadResult Parse(string data, int group, double variable)
            {
                var lines = data.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                int count = lines.Count((string l) => { return l.Trim().StartsWith("% "); });
                if (count < 1) return null;
                var result = new ThreadResult(count, group, variable);
                int ptr = 0;
                foreach (var line in lines)
                {
                    if (line.Trim().StartsWith("% "))
                    {
                        string raw = line.Trim().Substring(2).Trim();
                        int index = raw.LastIndexOf(':');
                        if (index < 0) return null;
                        result.Legends[ptr] = raw.Substring(0, index);
                        result.Values[ptr] = 0;
                        double.TryParse(raw.Substring(index + 1), NumberStyles.Any, null, out result.Values[ptr]);
                        ptr++;
                    }
                }
                return result;
            }
        }
        private string SettingsPath;

        private void SetBackColor1(Color color)
        {
            ResultsChart.BackColor = color;
        }
        private void SetBackColor2(Color color)
        {
            ResultsChart.BorderSkin.BackColor = color;
            ResultsChart.Legends[0].BackColor = color;
            ResultsChart.ChartAreas[0].BackColor = color;
        }
        private Color GetBackColor1()
        {
            return ResultsChart.BackColor;
        }
        private Color GetBackColor2()
        {
            return ResultsChart.BorderSkin.BackColor;
        }
        private static ChartDashStyle NextStyle(ChartDashStyle ds)
        {
            switch (ds)
            {
                case ChartDashStyle.Solid: return ChartDashStyle.Dash;
                case ChartDashStyle.Dash: return ChartDashStyle.Dot;
                case ChartDashStyle.Dot: return ChartDashStyle.DashDot;
                case ChartDashStyle.DashDot: return ChartDashStyle.DashDotDot;
                case ChartDashStyle.DashDotDot: return ChartDashStyle.Solid;
                default: return ChartDashStyle.Solid;
            }
        }
        private void BuildGraph()
        {
            GraphDirty = false;
            ResultsChart.Series.Clear();
            if (ExecutionResults == null || ResultsListBox.SelectedItem == null) return;
            int ind = ResultsListBox.SelectedIndex;
            ResultsChart.ChartAreas[0].AxisY.Title = ResultsListBox.SelectedItem as string;
            var results = ExecutionResults[ResultsListBox.SelectedItem as string];

            var dash_style = ChartDashStyle.Solid;
            for (int i = 0; i < GroupsCount; i++)
            {
                var series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.Name = ExecutionNames[i];
                series.BorderWidth = 3;
                series.BorderDashStyle = dash_style;
                dash_style = NextStyle(dash_style);
                
                for (int j = 0; j < results[i].Count; j++)
                {
                    if (ArgumentComboBox.SelectedIndex == 0)
                    {
                        series.Points.AddXY(results[i][j].X, results[i][j].Y);
                    }
                    else
                    {
                        var arguments = ExecutionResults[ArgumentComboBox.SelectedItem as string];
                        series.Points.AddXY(arguments[i][j].Y, results[i][j].Y);
                    }
                }
                ResultsChart.Series.Add(series);
            }

            ResultsChart.ResetAutoValues();
        }

        public RunnerForm()
        {
            InitializeComponent();
            SettingsPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "config.ini"));
            ArgumentComboBox.SelectedIndex = 0;

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
                        HorizontalAxisName = NameTextBox.Text = file.ReadLine();
                        SetBackColor1(Color.FromArgb(int.Parse(file.ReadLine())));
                        SetBackColor2(Color.FromArgb(int.Parse(file.ReadLine())));
                        ResultsChart.Palette = (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette), file.ReadLine());
                        int count = int.Parse(file.ReadLine());
                        var colors = new Color[count];
                        for (int i = 0; i < count; i++)
                            colors[i] = Color.FromArgb(int.Parse(file.ReadLine()));
                        ResultsChart.PaletteCustomColors = colors;
                        IntervalNumeric.Value = decimal.Parse(file.ReadLine());
                        ThreadsNumeric.Value = decimal.Parse(file.ReadLine());
                        AxisTitleFSNumeric.Value = decimal.Parse(file.ReadLine());
                        AxisLabelsFSNumeric.Value = decimal.Parse(file.ReadLine());
                        LegendsFSNumeric.Value = decimal.Parse(file.ReadLine());
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
                var configs = Directory.GetFiles(ConfigsTextBox.Text, FilterTextBox.Text, SearchOption.AllDirectories);
                GroupsCount = configs.Length;
                ExecutionResults = new Dictionary<string, List<PointD>[]>();
                ResultsListBox.Items.Clear();
                ArgumentComboBox.Items.Clear();
                ArgumentComboBox.Items.Add("Input variable");
                ArgumentComboBox.SelectedIndex = 0;
                ExecutionNames = new string[GroupsCount];
                ExecutionConfigs = new string[GroupsCount];

                for (int i = 0; i < GroupsCount; i++) ExecutionNames[i] = Path.GetFileNameWithoutExtension(configs[i]);
                for (int i = 0; i < GroupsCount; i++) ExecutionConfigs[i] = Path.GetFullPath(configs[i]);
                ExecutionProgress = LowerNumeric.Value;
                ExecutionLowerBound = LowerNumeric.Value;
                ExecutionHigherBound = HigherNumeric.Value;
                ExecutionStep = StepNumeric.Value;
                ExecutablePath = ExecutableTextBox.Text;

                StartButton.Enabled = false;
                StopButton.Enabled = true;
                ThreadsManager.Start();
                BuildGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not start execution.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartButton.Enabled = true;
                StopButton.Enabled = false;
                ThreadsManager.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not stop execution.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                ImportFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                if (ImportFileDialog.ShowDialog(this) != DialogResult.OK) return;
                using (var file = File.OpenText(ImportFileDialog.FileName))
                {
                    GroupsCount = 0;
                    ExecutionResults = new Dictionary<string, List<PointD>[]>();
                    ResultsListBox.Items.Clear();
                    ArgumentComboBox.Items.Clear();
                    ArgumentComboBox.Items.Add("Input variable");
                    ArgumentComboBox.SelectedIndex = 0;

                    int accumulated = 0;
                    string legend = "";
                    var legends = file.ReadLine().Split('\t');

                    foreach (var l in legends)
                    {
                        if (legend == l) accumulated++;
                        else if (legend != "")
                        {
                            var array = new List<PointD>[accumulated];
                            for (int i = 0; i < array.Length; i++) array[i] = new List<PointD>();
                            ExecutionResults.Add(legend, array);
                            ResultsListBox.Items.Add(legend);
                            ArgumentComboBox.Items.Add(legend);

                            if (accumulated > GroupsCount) GroupsCount = accumulated;
                            legend = l;
                            accumulated = 1;
                        }
                        else
                        {
                            legend = l;
                            accumulated = 1;
                        }
                    }

                    ExecutionNames = new string[GroupsCount];

                    var groups = file.ReadLine().Split('\t');

                    NameTextBox.Text = groups[0];
                    for (int i = 2; i < GroupsCount + 2; i++)
                    {
                        ExecutionNames[i - 2] = groups[i];
                    }

                    ExecutionLowerBound = decimal.MaxValue;
                    ExecutionHigherBound = decimal.MinValue;
                    int count = 0;
                    while (!file.EndOfStream)
                    {
                        count++;
                        var values = file.ReadLine().Split('\t');
                        var argument = decimal.Parse(values[0]);

                        if (argument < ExecutionLowerBound) ExecutionLowerBound = argument;
                        if (argument > ExecutionHigherBound) ExecutionHigherBound = argument;
                        
                        int i = 0;
                        foreach (var l in ExecutionResults)
                        {
                            for (int j = 0; j < GroupsCount; j++)
                            {
                                int ind = 2 + i * (GroupsCount + 1);
                                decimal value;
                                if (decimal.TryParse(values[ind], out value))
                                    l.Value[j].Add(new PointD((double)argument, (double)value));
                            }
                            i++;
                        }
                    }

                    LowerNumeric.Value = ExecutionLowerBound;
                    HigherNumeric.Value = ExecutionHigherBound;
                    StepNumeric.Value = ExecutionStep = (ExecutionHigherBound - ExecutionLowerBound) / (count - 1);

                    BuildGraph();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not import results.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (ExecutionResults == null || GroupsCount == 0 || ExecutionStep == 0) return;

            try
            {
                using (var file = File.CreateText("exports.txt"))
                {
                    file.Write("\t\t");
                    foreach (var legend in ExecutionResults)
                    {
                        for (int i = 0; i < GroupsCount; i++)
                            file.Write(legend.Key + "\t");
                        file.Write("\t");
                    }
                    file.WriteLine();

                    file.Write(NameTextBox.Text + "\t\t");
                    for (int i = 0; i < ExecutionResults.Count; i++)
                    {
                        for (int j = 0; j < GroupsCount; j++)
                            file.Write(ExecutionNames[j] + "\t");
                        file.Write("\t");
                    }
                    file.WriteLine();

                    int row = 0;
                    for (decimal v = ExecutionLowerBound; v <= ExecutionHigherBound; v += ExecutionStep)
                    {
                        file.Write(v + "\t\t");

                        foreach (var legend in ExecutionResults)
                        {
                            for (int i = 0; i < GroupsCount; i++)
                            {
                                var group = legend.Value[i];
                                if (row >= group.Count) file.Write("-\t");
                                else file.Write(group[row].Y + "\t");
                            }
                            file.Write("\t");
                        }

                        file.WriteLine();
                        row++;
                    }
                }

                foreach (var legend in ExecutionResults)
                {
                    ResultsListBox.SelectedItem = legend.Key;
                    using (var bmp = new Bitmap(ResultsChart.ClientSize.Width, ResultsChart.ClientSize.Height))
                    {
                        ResultsChart.DrawToBitmap(bmp, new Rectangle(0, 0, ResultsChart.ClientSize.Width, ResultsChart.ClientSize.Height));
                        var type = legend.Key;
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
            if (sp.Length == 2)
            {
                count = sp[1].Length;
                while (count > 0 && sp[1][count - 1] == '0') count--;
            }
            ResultsChart.ChartAreas[0].AxisX.LabelStyle.Format = "F" + count;
        }
        private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildGraph();
        }
        private void ArgumentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArgumentComboBox.SelectedIndex == 0)
            {
                NameTextBox.ReadOnly = false;
                NameTextBox.Text = HorizontalAxisName;
            }
            else
            {
                NameTextBox.ReadOnly = true;
                NameTextBox.Text = ArgumentComboBox.SelectedItem as string;
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultsChart.ChartAreas[0].AxisX.Title = NameTextBox.Text;
            if (!NameTextBox.ReadOnly) HorizontalAxisName = NameTextBox.Text;
            BuildGraph();
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
                    file.WriteLine(HorizontalAxisName);
                    file.WriteLine(GetBackColor1().ToArgb());
                    file.WriteLine(GetBackColor2().ToArgb());
                    file.WriteLine(ResultsChart.Palette);
                    file.WriteLine(ResultsChart.PaletteCustomColors.Length);
                    for (int i = 0; i < ResultsChart.PaletteCustomColors.Length; i++)
                        file.WriteLine(ResultsChart.PaletteCustomColors[i].ToArgb());
                    file.WriteLine(IntervalNumeric.Value);
                    file.WriteLine(ThreadsNumeric.Value);
                    file.WriteLine(AxisTitleFSNumeric.Value);
                    file.WriteLine(AxisLabelsFSNumeric.Value);
                    file.WriteLine(LegendsFSNumeric.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error: Can not save configuration file.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool SubmitWork(BackgroundWorker worker)
        {
            if (ExecutionProgress > ExecutionHigherBound || GroupsCount < 1) return false;

            var args = new ThreadArguments();
            args.Executable = ExecutablePath;
            args.Config = ExecutionConfigs[GroupCursor];
            args.Arguments = ArgumentsTextBox.Text;
            args.Variable = ExecutionProgress;
            args.GroupIndex = GroupCursor;

            GroupCursor++;
            if (GroupCursor >= GroupsCount)
            {
                GroupCursor = 0;
                ExecutionProgress += ExecutionStep;
            }

            worker.RunWorkerAsync(args);

            return true;
        }

        private void ThreadsManager_Tick(object sender, EventArgs e)
        {
            while (ThreadsNumeric.Value > ExecutionWorkers.Count)
            {
                var worker = new BackgroundWorker();
                worker.DoWork += ExecutionWorker_DoWork;
                worker.RunWorkerCompleted += ExecutionWorker_RunWorkerCompleted;
                ExecutionWorkers.Add(worker);
            }
            bool enquire_next = false;
            for (int i = 0; i < ExecutionWorkers.Count; i++)
            {
                var worker = ExecutionWorkers[i];
                if (worker.IsBusy)
                {
                    enquire_next = true;
                    continue;
                }
                if (ThreadsNumeric.Value < ExecutionWorkers.Count) ExecutionWorkers.RemoveAt(i--);
                else if (SubmitWork(worker))
                {
                    enquire_next = true;
                }
            }
            if (GraphDirty) BuildGraph();

            if (!enquire_next)
            {
                StartButton.Enabled = true;
                StopButton.Enabled = false;
                ThreadsManager.Stop();
            }
        }
        private void MessagePump_Tick(object sender, EventArgs e)
        {
            string message;
            while ((message = LogQueue.Get()) != null) LogTextBox.AppendText(message + Environment.NewLine);
        }

        private void ExecutionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var args = e.Argument as ThreadArguments;

            Process p = new Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = args.Executable;
            p.StartInfo.Arguments = "-config " + "\"" + args.Config + "\" " + args.Arguments.Replace("%VAR", args.Variable.ToString());
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(args.Executable);
            
            LogQueue.Put("Starting execution with arguments [" + p.StartInfo.Arguments + "]...");
            p.Start();
            string s = p.StandardOutput.ReadToEnd();

            e.Result = ThreadResult.Parse(s, args.GroupIndex, (double)args.Variable);

            p.WaitForExit();
            LogQueue.Put("Execution with arguments [" + p.StartInfo.Arguments + "] finished.");

        }

        private void ExecutionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                var result = e.Result as ThreadResult;
                if (result == null) return;

                for (int i = 0; i < result.Legends.Length; i++)
                {
                    if (!ExecutionResults.ContainsKey(result.Legends[i]))
                    {
                        var groups = new List<PointD>[GroupsCount];
                        for (int j = 0; j < GroupsCount; j++) groups[j] = new List<PointD>();
                        ExecutionResults.Add(result.Legends[i], groups);
                        var item = ResultsListBox.SelectedItem;
                        ResultsListBox.Items.Add(result.Legends[i]);
                        ResultsListBox.SelectedItem = item;

                        var itemc = ArgumentComboBox.SelectedItem;
                        ArgumentComboBox.Items.Add(result.Legends[i]);
                        ArgumentComboBox.SelectedItem = itemc;
                    }

                    var group = ExecutionResults[result.Legends[i]][result.Group];

                    int index = group.Count;
                    while (index - 1 >= 0 && group[index - 1].X > result.Variable) index--;

                    group.Insert(index, new PointD(result.Variable, result.Values[i]));
                }

                GraphDirty = true;
            }
            catch (Exception ex)
            {
                LogQueue.Put("Error: Can not finish thread execution." + Environment.NewLine + ex.ToString());
            }
        }

        private void Color1Button_Click(object sender, EventArgs e)
        {
            ChooseColorDialog.Color = GetBackColor1();
            ChooseColorDialog.ShowDialog(this);
            SetBackColor1(ChooseColorDialog.Color);
        }
        private void Color2Button_Click(object sender, EventArgs e)
        {
            ChooseColorDialog.Color = GetBackColor2();
            ChooseColorDialog.ShowDialog(this);
            SetBackColor2(ChooseColorDialog.Color);
        }
        private void FontSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            ResultsChart.ChartAreas[0].Axes[0].TitleFont = new Font(ResultsChart.ChartAreas[0].Axes[0].TitleFont.FontFamily, (int)AxisTitleFSNumeric.Value);
            ResultsChart.ChartAreas[0].Axes[1].TitleFont = new Font(ResultsChart.ChartAreas[0].Axes[1].TitleFont.FontFamily, (int)AxisTitleFSNumeric.Value);
            ResultsChart.ChartAreas[0].Axes[0].LabelAutoFitMinFontSize = (int)AxisLabelsFSNumeric.Value;
            ResultsChart.ChartAreas[0].Axes[0].LabelAutoFitMaxFontSize = (int)AxisLabelsFSNumeric.Value;
            ResultsChart.ChartAreas[0].Axes[1].LabelAutoFitMinFontSize = (int)AxisLabelsFSNumeric.Value;
            ResultsChart.ChartAreas[0].Axes[1].LabelAutoFitMaxFontSize = (int)AxisLabelsFSNumeric.Value;
            ResultsChart.Legends[0].Font = new Font(ResultsChart.Legends[0].Font.FontFamily, (int)LegendsFSNumeric.Value);
            BuildGraph();
        }
    }
}
