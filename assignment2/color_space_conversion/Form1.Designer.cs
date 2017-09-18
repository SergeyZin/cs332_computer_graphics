namespace color_space_conversion
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBW2 = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBW1 = new System.Windows.Forms.Button();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.groupBoxHSV = new System.Windows.Forms.GroupBox();
            this.ValV = new System.Windows.Forms.Label();
            this.ValS = new System.Windows.Forms.Label();
            this.ValH = new System.Windows.Forms.Label();
            this.SetHSV = new System.Windows.Forms.Button();
            this.trackBarVal = new System.Windows.Forms.TrackBar();
            this.trackBarSat = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartRGB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            this.groupBoxHSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRGB)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menuToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveToolStripMenuItem.Text = "Сохранить как...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 464);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(282, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.btnMoveRight);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btnMoveLeft);
            this.splitContainer1.Size = new System.Drawing.Size(890, 499);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(426, 478);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveRight.Location = new System.Drawing.Point(3, 473);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(417, 23);
            this.btnMoveRight.TabIndex = 1;
            this.btnMoveRight.TabStop = false;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 478);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveLeft.Location = new System.Drawing.Point(23, 473);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(417, 23);
            this.btnMoveLeft.TabIndex = 0;
            this.btnMoveLeft.TabStop = false;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBW2);
            this.groupBox1.Controls.Add(this.btnBlue);
            this.groupBox1.Controls.Add(this.btnRed);
            this.groupBox1.Controls.Add(this.btnSubtract);
            this.groupBox1.Controls.Add(this.btnGreen);
            this.groupBox1.Controls.Add(this.btnBW1);
            this.groupBox1.Location = new System.Drawing.Point(3, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвет";
            // 
            // btnBW2
            // 
            this.btnBW2.Location = new System.Drawing.Point(96, 61);
            this.btnBW2.Name = "btnBW2";
            this.btnBW2.Size = new System.Drawing.Size(108, 23);
            this.btnBW2.TabIndex = 6;
            this.btnBW2.Text = "Оттенки серого 2";
            this.btnBW2.UseVisualStyleBackColor = true;
            this.btnBW2.Click += new System.EventHandler(this.btnBW2_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(35, 97);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(54, 23);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(35, 25);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(54, 23);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(96, 97);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(108, 23);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "Разность";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(35, 61);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(54, 23);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBW1
            // 
            this.btnBW1.Location = new System.Drawing.Point(96, 25);
            this.btnBW1.Name = "btnBW1";
            this.btnBW1.Size = new System.Drawing.Size(108, 23);
            this.btnBW1.TabIndex = 5;
            this.btnBW1.Text = "Оттенки серого 1";
            this.btnBW1.UseVisualStyleBackColor = true;
            this.btnBW1.Click += new System.EventHandler(this.btnBW1_Click);
            // 
            // trackBarHue
            // 
            this.trackBarHue.Location = new System.Drawing.Point(35, 19);
            this.trackBarHue.Maximum = 255;
            this.trackBarHue.Minimum = -255;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(201, 45);
            this.trackBarHue.TabIndex = 8;
            this.trackBarHue.TickFrequency = 10;
            this.trackBarHue.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarHue.ValueChanged += new System.EventHandler(this.trackBarHue_Scroll);
            // 
            // groupBoxHSV
            // 
            this.groupBoxHSV.Controls.Add(this.ValV);
            this.groupBoxHSV.Controls.Add(this.ValS);
            this.groupBoxHSV.Controls.Add(this.ValH);
            this.groupBoxHSV.Controls.Add(this.SetHSV);
            this.groupBoxHSV.Controls.Add(this.trackBarVal);
            this.groupBoxHSV.Controls.Add(this.trackBarSat);
            this.groupBoxHSV.Controls.Add(this.trackBarHue);
            this.groupBoxHSV.Location = new System.Drawing.Point(3, 297);
            this.groupBoxHSV.Name = "groupBoxHSV";
            this.groupBoxHSV.Size = new System.Drawing.Size(242, 199);
            this.groupBoxHSV.TabIndex = 9;
            this.groupBoxHSV.TabStop = false;
            this.groupBoxHSV.Text = "HSV";
            this.groupBoxHSV.Enter += new System.EventHandler(this.groupBoxHSV_Enter);
            // 
            // ValV
            // 
            this.ValV.AutoSize = true;
            this.ValV.Location = new System.Drawing.Point(10, 135);
            this.ValV.Name = "ValV";
            this.ValV.Size = new System.Drawing.Size(13, 13);
            this.ValV.TabIndex = 14;
            this.ValV.Text = "0";
            this.ValV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValS
            // 
            this.ValS.AutoSize = true;
            this.ValS.Location = new System.Drawing.Point(10, 84);
            this.ValS.Name = "ValS";
            this.ValS.Size = new System.Drawing.Size(13, 13);
            this.ValS.TabIndex = 13;
            this.ValS.Text = "0";
            this.ValS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValH
            // 
            this.ValH.AutoSize = true;
            this.ValH.Location = new System.Drawing.Point(10, 33);
            this.ValH.Name = "ValH";
            this.ValH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValH.Size = new System.Drawing.Size(13, 13);
            this.ValH.TabIndex = 12;
            this.ValH.Text = "0";
            this.ValH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetHSV
            // 
            this.SetHSV.Location = new System.Drawing.Point(151, 170);
            this.SetHSV.Name = "SetHSV";
            this.SetHSV.Size = new System.Drawing.Size(85, 23);
            this.SetHSV.TabIndex = 11;
            this.SetHSV.Text = "Применить";
            this.SetHSV.UseVisualStyleBackColor = true;
            this.SetHSV.Click += new System.EventHandler(this.SetHSV_Click);
            // 
            // trackBarVal
            // 
            this.trackBarVal.Location = new System.Drawing.Point(35, 121);
            this.trackBarVal.Maximum = 255;
            this.trackBarVal.Minimum = -255;
            this.trackBarVal.Name = "trackBarVal";
            this.trackBarVal.Size = new System.Drawing.Size(201, 45);
            this.trackBarVal.TabIndex = 10;
            this.trackBarVal.TickFrequency = 10;
            this.trackBarVal.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarVal.ValueChanged += new System.EventHandler(this.trackBarVal_Scroll);
            // 
            // trackBarSat
            // 
            this.trackBarSat.Location = new System.Drawing.Point(35, 70);
            this.trackBarSat.Maximum = 255;
            this.trackBarSat.Minimum = -255;
            this.trackBarSat.Name = "trackBarSat";
            this.trackBarSat.Size = new System.Drawing.Size(201, 45);
            this.trackBarSat.TabIndex = 9;
            this.trackBarSat.TickFrequency = 10;
            this.trackBarSat.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSat.ValueChanged += new System.EventHandler(this.trackBarSat_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartRGB);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 150);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Гистограмма RGB";
            // 
            // chartRGB
            // 
            this.chartRGB.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.CustomLabels.Add(customLabel3);
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.CustomLabels.Add(customLabel4);
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartRGB.ChartAreas.Add(chartArea2);
            this.chartRGB.Location = new System.Drawing.Point(6, 19);
            this.chartRGB.Name = "chartRGB";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.DarkGray;
            series5.Name = "Series4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.LabelFormat = "\"\"";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.Points.Add(dataPoint2);
            series6.SmartLabelStyle.Enabled = false;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "Series2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Blue;
            series8.Legend = "Legend1";
            series8.Name = "Series3";
            this.chartRGB.Series.Add(series5);
            this.chartRGB.Series.Add(series6);
            this.chartRGB.Series.Add(series7);
            this.chartRGB.Series.Add(series8);
            this.chartRGB.Size = new System.Drawing.Size(230, 125);
            this.chartRGB.TabIndex = 0;
            this.chartRGB.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxHSV);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 499);
            this.panel1.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 551);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Color space conversion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            this.groupBoxHSV.ResumeLayout(false);
            this.groupBoxHSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRGB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBW1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.GroupBox groupBoxHSV;
        private System.Windows.Forms.TrackBar trackBarSat;
        private System.Windows.Forms.TrackBar trackBarVal;
        private System.Windows.Forms.Button btnBW2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRGB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SetHSV;
        private System.Windows.Forms.Label ValV;
        private System.Windows.Forms.Label ValS;
        private System.Windows.Forms.Label ValH;
    }
}

