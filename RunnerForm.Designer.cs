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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExecutableTextBox = new System.Windows.Forms.TextBox();
            this.ControlsSplitContainer = new System.Windows.Forms.SplitContainer();
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
            this.MessagePump = new System.Windows.Forms.Timer(this.components);
            this.ChartPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.ConfigTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsSplitContainer)).BeginInit();
            this.ControlsSplitContainer.Panel1.SuspendLayout();
            this.ControlsSplitContainer.Panel2.SuspendLayout();
            this.ControlsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HigherNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerNumeric)).BeginInit();
            this.ResultTabControl.SuspendLayout();
            this.ChartTabPage.SuspendLayout();
            this.LogTabPage.SuspendLayout();
            this.ConfigTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsChart
            // 
            this.ResultsChart.BackColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelStyle.Format = "F2";
            chartArea1.AxisX.MaximumAutoSize = 10F;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX2.MaximumAutoSize = 10F;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            chartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.ResultsChart.ChartAreas.Add(chartArea1);
            this.ResultsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.ResultsChart.Legends.Add(legend1);
            this.ResultsChart.Location = new System.Drawing.Point(3, 3);
            this.ResultsChart.Name = "ResultsChart";
            this.ResultsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ResultsChart.Series.Add(series1);
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
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(184, 519);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 17;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 438);
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
            this.IntervalNumeric.Size = new System.Drawing.Size(256, 20);
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
            this.ResultsListBox.Items.AddRange(new object[] {
            "Total received packets",
            "Total received flits",
            "Received/Ideal flits Ratio",
            "Last time flit received",
            "Global average delay (cycles)",
            "Max delay (cycles)",
            "Network throughput (flits/cycle)",
            "Average IP throughput (flits/cycle/IP)",
            "Total energy (J)",
            "Dynamic energy (J)",
            "Static energy (J)"});
            this.ResultsListBox.Location = new System.Drawing.Point(3, 250);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(256, 147);
            this.ResultsListBox.TabIndex = 1;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(3, 519);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
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
            // MessagePump
            // 
            this.MessagePump.Enabled = true;
            this.MessagePump.Tick += new System.EventHandler(this.MessagePump_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HigherNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerNumeric)).EndInit();
            this.ResultTabControl.ResumeLayout(false);
            this.ChartTabPage.ResumeLayout(false);
            this.LogTabPage.ResumeLayout(false);
            this.LogTabPage.PerformLayout();
            this.ConfigTabPage.ResumeLayout(false);
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
    }
}

