namespace NoximAutoRunner
{
    partial class RunnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExecutableTextBox = new System.Windows.Forms.TextBox();
            this.ControlsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ImportButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ArgumentComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ThreadsNumeric = new System.Windows.Forms.NumericUpDown();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IntervalNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HigherNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StepNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LowerNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfigsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTabControl = new System.Windows.Forms.TabControl();
            this.ChartTabPage = new System.Windows.Forms.TabPage();
            this.LogTabPage = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ConfigTabPage = new System.Windows.Forms.TabPage();
            this.ChartPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.ViewTabPage = new System.Windows.Forms.TabPage();
            this.Color2Button = new System.Windows.Forms.Button();
            this.Color1Button = new System.Windows.Forms.Button();
            this.MessagePump = new System.Windows.Forms.Timer(this.components);
            this.ThreadsManager = new System.Windows.Forms.Timer(this.components);
            this.ChooseColorDialog = new System.Windows.Forms.ColorDialog();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.AxisTitleFSNumeric = new System.Windows.Forms.NumericUpDown();
            this.LegendsFSNumeric = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.AxisLabelsFSNumeric = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsSplitContainer)).BeginInit();
            this.ControlsSplitContainer.Panel1.SuspendLayout();
            this.ControlsSplitContainer.Panel2.SuspendLayout();
            this.ControlsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HigherNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerNumeric)).BeginInit();
            this.ResultTabControl.SuspendLayout();
            this.ChartTabPage.SuspendLayout();
            this.LogTabPage.SuspendLayout();
            this.ConfigTabPage.SuspendLayout();
            this.ViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AxisTitleFSNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegendsFSNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AxisLabelsFSNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsChart
            // 
            this.ResultsChart.BackColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 20;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 16;
            chartArea2.AxisX.LabelStyle.Format = "F2";
            chartArea2.AxisX.MaximumAutoSize = 10F;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            chartArea2.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX2.LabelAutoFitMinFontSize = 10;
            chartArea2.AxisX2.MaximumAutoSize = 10F;
            chartArea2.AxisX2.Minimum = 0D;
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.LabelAutoFitMaxFontSize = 20;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 16;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            chartArea2.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY2.LabelAutoFitMinFontSize = 10;
            chartArea2.AxisY2.Minimum = 0D;
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            chartArea2.BackColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.ResultsChart.ChartAreas.Add(chartArea2);
            this.ResultsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.AutoFitMinFontSize = 20;
            legend2.BackColor = System.Drawing.Color.Gray;
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.ResultsChart.Legends.Add(legend2);
            this.ResultsChart.Location = new System.Drawing.Point(3, 3);
            this.ResultsChart.Name = "ResultsChart";
            this.ResultsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.ResultsChart.Size = new System.Drawing.Size(777, 513);
            this.ResultsChart.TabIndex = 0;
            this.ResultsChart.Text = "chart1";
            // 
            // ExecutableTextBox
            // 
            this.ExecutableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecutableTextBox.Location = new System.Drawing.Point(3, 16);
            this.ExecutableTextBox.Name = "ExecutableTextBox";
            this.ExecutableTextBox.Size = new System.Drawing.Size(256, 20);
            this.ExecutableTextBox.TabIndex = 1;
            // 
            // ControlsSplitContainer
            // 
            this.ControlsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ControlsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ControlsSplitContainer.Name = "ControlsSplitContainer";
            // 
            // ControlsSplitContainer.Panel1
            // 
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ImportButton);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.StopButton);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ArgumentComboBox);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label11);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ThreadsNumeric);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ExportButton);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label10);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.NameTextBox);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label9);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.IntervalNumeric);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label8);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ArgumentsTextBox);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label7);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.HigherNumeric);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label6);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.StepNumeric);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label5);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.LowerNumeric);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label4);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ResultsListBox);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.StartButton);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label3);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.FilterTextBox);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label2);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ConfigsTextBox);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.label1);
            this.ControlsSplitContainer.Panel1.Controls.Add(this.ExecutableTextBox);
            // 
            // ControlsSplitContainer.Panel2
            // 
            this.ControlsSplitContainer.Panel2.Controls.Add(this.ResultTabControl);
            this.ControlsSplitContainer.Size = new System.Drawing.Size(1065, 549);
            this.ControlsSplitContainer.SplitterDistance = 266;
            this.ControlsSplitContainer.TabIndex = 4;
            // 
            // ImportButton
            // 
            this.ImportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportButton.Location = new System.Drawing.Point(149, 519);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(52, 23);
            this.ImportButton.TabIndex = 21;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(75, 519);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(66, 23);
            this.StopButton.TabIndex = 20;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ArgumentComboBox
            // 
            this.ArgumentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgumentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArgumentComboBox.FormattingEnabled = true;
            this.ArgumentComboBox.Items.AddRange(new object[] {
            "Input variable"});
            this.ArgumentComboBox.Location = new System.Drawing.Point(3, 414);
            this.ArgumentComboBox.Name = "ArgumentComboBox";
            this.ArgumentComboBox.Size = new System.Drawing.Size(256, 21);
            this.ArgumentComboBox.TabIndex = 1;
            this.ArgumentComboBox.SelectedIndexChanged += new System.EventHandler(this.ArgumentComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Threads";
            // 
            // ThreadsNumeric
            // 
            this.ThreadsNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreadsNumeric.Location = new System.Drawing.Point(184, 493);
            this.ThreadsNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ThreadsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadsNumeric.Name = "ThreadsNumeric";
            this.ThreadsNumeric.Size = new System.Drawing.Size(75, 20);
            this.ThreadsNumeric.TabIndex = 18;
            this.ThreadsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(207, 519);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(52, 23);
            this.ExportButton.TabIndex = 17;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Horizontal axis name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(3, 454);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(256, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Interval";
            // 
            // IntervalNumeric
            // 
            this.IntervalNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalNumeric.DecimalPlaces = 8;
            this.IntervalNumeric.Location = new System.Drawing.Point(3, 493);
            this.IntervalNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IntervalNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.IntervalNumeric.Name = "IntervalNumeric";
            this.IntervalNumeric.Size = new System.Drawing.Size(175, 20);
            this.IntervalNumeric.TabIndex = 14;
            this.IntervalNumeric.ValueChanged += new System.EventHandler(this.IntervalNumeric_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Executable arguments";
            // 
            // ArgumentsTextBox
            // 
            this.ArgumentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgumentsTextBox.Location = new System.Drawing.Point(3, 94);
            this.ArgumentsTextBox.Name = "ArgumentsTextBox";
            this.ArgumentsTextBox.Size = new System.Drawing.Size(256, 20);
            this.ArgumentsTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Higher bound";
            // 
            // HigherNumeric
            // 
            this.HigherNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HigherNumeric.DecimalPlaces = 8;
            this.HigherNumeric.Location = new System.Drawing.Point(3, 211);
            this.HigherNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HigherNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.HigherNumeric.Name = "HigherNumeric";
            this.HigherNumeric.Size = new System.Drawing.Size(256, 20);
            this.HigherNumeric.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Step";
            // 
            // StepNumeric
            // 
            this.StepNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepNumeric.DecimalPlaces = 8;
            this.StepNumeric.Location = new System.Drawing.Point(3, 172);
            this.StepNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StepNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.StepNumeric.Name = "StepNumeric";
            this.StepNumeric.Size = new System.Drawing.Size(256, 20);
            this.StepNumeric.TabIndex = 8;
            this.StepNumeric.ValueChanged += new System.EventHandler(this.StepNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lower bound";
            // 
            // LowerNumeric
            // 
            this.LowerNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerNumeric.DecimalPlaces = 8;
            this.LowerNumeric.Location = new System.Drawing.Point(3, 133);
            this.LowerNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LowerNumeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.LowerNumeric.Name = "LowerNumeric";
            this.LowerNumeric.Size = new System.Drawing.Size(256, 20);
            this.LowerNumeric.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Required results";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(3, 250);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(256, 160);
            this.ResultsListBox.TabIndex = 1;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(3, 519);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(66, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextBox.Location = new System.Drawing.Point(204, 55);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(55, 20);
            this.FilterTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Configs path";
            // 
            // ConfigsTextBox
            // 
            this.ConfigsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigsTextBox.Location = new System.Drawing.Point(3, 55);
            this.ConfigsTextBox.Name = "ConfigsTextBox";
            this.ConfigsTextBox.Size = new System.Drawing.Size(195, 20);
            this.ConfigsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Executable path";
            // 
            // ResultTabControl
            // 
            this.ResultTabControl.Controls.Add(this.ChartTabPage);
            this.ResultTabControl.Controls.Add(this.LogTabPage);
            this.ResultTabControl.Controls.Add(this.ConfigTabPage);
            this.ResultTabControl.Controls.Add(this.ViewTabPage);
            this.ResultTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTabControl.Location = new System.Drawing.Point(0, 0);
            this.ResultTabControl.Name = "ResultTabControl";
            this.ResultTabControl.SelectedIndex = 0;
            this.ResultTabControl.Size = new System.Drawing.Size(791, 545);
            this.ResultTabControl.TabIndex = 1;
            // 
            // ChartTabPage
            // 
            this.ChartTabPage.Controls.Add(this.ResultsChart);
            this.ChartTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChartTabPage.Name = "ChartTabPage";
            this.ChartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChartTabPage.Size = new System.Drawing.Size(783, 519);
            this.ChartTabPage.TabIndex = 0;
            this.ChartTabPage.Text = "Chart";
            this.ChartTabPage.UseVisualStyleBackColor = true;
            // 
            // LogTabPage
            // 
            this.LogTabPage.Controls.Add(this.LogTextBox);
            this.LogTabPage.Location = new System.Drawing.Point(4, 22);
            this.LogTabPage.Name = "LogTabPage";
            this.LogTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogTabPage.Size = new System.Drawing.Size(783, 519);
            this.LogTabPage.TabIndex = 1;
            this.LogTabPage.Text = "Log";
            this.LogTabPage.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(777, 513);
            this.LogTextBox.TabIndex = 0;
            // 
            // ConfigTabPage
            // 
            this.ConfigTabPage.Controls.Add(this.ChartPropertyGrid);
            this.ConfigTabPage.Location = new System.Drawing.Point(4, 22);
            this.ConfigTabPage.Name = "ConfigTabPage";
            this.ConfigTabPage.Size = new System.Drawing.Size(783, 519);
            this.ConfigTabPage.TabIndex = 2;
            this.ConfigTabPage.Text = "Chart configuratoin";
            this.ConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // ChartPropertyGrid
            // 
            this.ChartPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.ChartPropertyGrid.Name = "ChartPropertyGrid";
            this.ChartPropertyGrid.SelectedObject = this.ResultsChart;
            this.ChartPropertyGrid.Size = new System.Drawing.Size(783, 519);
            this.ChartPropertyGrid.TabIndex = 1;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Controls.Add(this.AxisLabelsFSNumeric);
            this.ViewTabPage.Controls.Add(this.label14);
            this.ViewTabPage.Controls.Add(this.LegendsFSNumeric);
            this.ViewTabPage.Controls.Add(this.label13);
            this.ViewTabPage.Controls.Add(this.AxisTitleFSNumeric);
            this.ViewTabPage.Controls.Add(this.label12);
            this.ViewTabPage.Controls.Add(this.Color2Button);
            this.ViewTabPage.Controls.Add(this.Color1Button);
            this.ViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Size = new System.Drawing.Size(783, 519);
            this.ViewTabPage.TabIndex = 3;
            this.ViewTabPage.Text = "View";
            this.ViewTabPage.UseVisualStyleBackColor = true;
            // 
            // Color2Button
            // 
            this.Color2Button.Location = new System.Drawing.Point(84, 3);
            this.Color2Button.Name = "Color2Button";
            this.Color2Button.Size = new System.Drawing.Size(75, 23);
            this.Color2Button.TabIndex = 1;
            this.Color2Button.Text = "Color 2";
            this.Color2Button.UseVisualStyleBackColor = true;
            this.Color2Button.Click += new System.EventHandler(this.Color2Button_Click);
            // 
            // Color1Button
            // 
            this.Color1Button.Location = new System.Drawing.Point(3, 3);
            this.Color1Button.Name = "Color1Button";
            this.Color1Button.Size = new System.Drawing.Size(75, 23);
            this.Color1Button.TabIndex = 0;
            this.Color1Button.Text = "Color 1";
            this.Color1Button.UseVisualStyleBackColor = true;
            this.Color1Button.Click += new System.EventHandler(this.Color1Button_Click);
            // 
            // MessagePump
            // 
            this.MessagePump.Enabled = true;
            this.MessagePump.Tick += new System.EventHandler(this.MessagePump_Tick);
            // 
            // ThreadsManager
            // 
            this.ThreadsManager.Tick += new System.EventHandler(this.ThreadsManager_Tick);
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "exports.txt";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Axis title font size";
            // 
            // AxisTitleFSNumeric
            // 
            this.AxisTitleFSNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AxisTitleFSNumeric.Location = new System.Drawing.Point(3, 496);
            this.AxisTitleFSNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AxisTitleFSNumeric.Name = "AxisTitleFSNumeric";
            this.AxisTitleFSNumeric.Size = new System.Drawing.Size(94, 20);
            this.AxisTitleFSNumeric.TabIndex = 3;
            this.AxisTitleFSNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AxisTitleFSNumeric.ValueChanged += new System.EventHandler(this.FontSizeNumeric_ValueChanged);
            // 
            // LegendsFSNumeric
            // 
            this.LegendsFSNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LegendsFSNumeric.Location = new System.Drawing.Point(204, 496);
            this.LegendsFSNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LegendsFSNumeric.Name = "LegendsFSNumeric";
            this.LegendsFSNumeric.Size = new System.Drawing.Size(94, 20);
            this.LegendsFSNumeric.TabIndex = 5;
            this.LegendsFSNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LegendsFSNumeric.ValueChanged += new System.EventHandler(this.FontSizeNumeric_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Legends font size";
            // 
            // AxisLabelsFSNumeric
            // 
            this.AxisLabelsFSNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AxisLabelsFSNumeric.Location = new System.Drawing.Point(103, 496);
            this.AxisLabelsFSNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AxisLabelsFSNumeric.Name = "AxisLabelsFSNumeric";
            this.AxisLabelsFSNumeric.Size = new System.Drawing.Size(95, 20);
            this.AxisLabelsFSNumeric.TabIndex = 7;
            this.AxisLabelsFSNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AxisLabelsFSNumeric.ValueChanged += new System.EventHandler(this.FontSizeNumeric_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 480);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Axis labels font size";
            // 
            // RunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 549);
            this.Controls.Add(this.ControlsSplitContainer);
            this.Name = "RunnerForm";
            this.Text = "NoC Simulation executer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunnerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).EndInit();
            this.ControlsSplitContainer.Panel1.ResumeLayout(false);
            this.ControlsSplitContainer.Panel1.PerformLayout();
            this.ControlsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlsSplitContainer)).EndInit();
            this.ControlsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HigherNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerNumeric)).EndInit();
            this.ResultTabControl.ResumeLayout(false);
            this.ChartTabPage.ResumeLayout(false);
            this.LogTabPage.ResumeLayout(false);
            this.LogTabPage.PerformLayout();
            this.ConfigTabPage.ResumeLayout(false);
            this.ViewTabPage.ResumeLayout(false);
            this.ViewTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AxisTitleFSNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegendsFSNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AxisLabelsFSNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsChart;
        private System.Windows.Forms.TextBox ExecutableTextBox;
        private System.Windows.Forms.SplitContainer ControlsSplitContainer;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfigsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl ResultTabControl;
        private System.Windows.Forms.TabPage ChartTabPage;
        private System.Windows.Forms.TabPage LogTabPage;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ArgumentsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown HigherNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown StepNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LowerNumeric;
        private System.Windows.Forms.Timer MessagePump;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown IntervalNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.TabPage ConfigTabPage;
        private System.Windows.Forms.PropertyGrid ChartPropertyGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ThreadsNumeric;
        private System.Windows.Forms.Timer ThreadsManager;
        private System.Windows.Forms.ComboBox ArgumentComboBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TabPage ViewTabPage;
        private System.Windows.Forms.Button Color2Button;
        private System.Windows.Forms.Button Color1Button;
        private System.Windows.Forms.ColorDialog ChooseColorDialog;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.NumericUpDown AxisTitleFSNumeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown AxisLabelsFSNumeric;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown LegendsFSNumeric;
        private System.Windows.Forms.Label label13;
    }
}

