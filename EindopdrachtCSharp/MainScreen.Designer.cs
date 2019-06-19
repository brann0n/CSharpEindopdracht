namespace EindopdrachtCSharp
{
    partial class MainScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
			this.MainScreenTabControl = new System.Windows.Forms.TabControl();
			this.tpActueel = new System.Windows.Forms.TabPage();
			this.lblWindActueel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblAirActueel = new System.Windows.Forms.Label();
			this.lblTemperatureActueel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblWeatherLongActueel = new System.Windows.Forms.Label();
			this.lblWeatherInfoActueel = new System.Windows.Forms.Label();
			this.weatherIcon = new System.Windows.Forms.PictureBox();
			this.lblLocationActueel = new System.Windows.Forms.Label();
			this.tbTrend = new System.Windows.Forms.TabPage();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lbl_graphCityName = new System.Windows.Forms.Label();
			this.tpOpties = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.radio_fahrenheit = new System.Windows.Forms.RadioButton();
			this.radio_celsius = new System.Windows.Forms.RadioButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btn_options = new System.Windows.Forms.Button();
			this.lbl_interval = new System.Windows.Forms.Label();
			this.txt_cityname = new System.Windows.Forms.TextBox();
			this.lbl_citySearch = new System.Windows.Forms.Label();
			this.TaskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verversenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshTimer = new System.Windows.Forms.Timer(this.components);
			this.lblLastUpdate = new System.Windows.Forms.Label();
			this.tempratuurPlaceholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.MainScreenTabControl.SuspendLayout();
			this.tpActueel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
			this.tbTrend.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.tpOpties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainScreenTabControl
			// 
			this.MainScreenTabControl.Controls.Add(this.tpActueel);
			this.MainScreenTabControl.Controls.Add(this.tbTrend);
			this.MainScreenTabControl.Controls.Add(this.tpOpties);
			this.MainScreenTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainScreenTabControl.Location = new System.Drawing.Point(0, 0);
			this.MainScreenTabControl.Name = "MainScreenTabControl";
			this.MainScreenTabControl.SelectedIndex = 0;
			this.MainScreenTabControl.Size = new System.Drawing.Size(434, 336);
			this.MainScreenTabControl.TabIndex = 0;
			// 
			// tpActueel
			// 
			this.tpActueel.BackgroundImage = global::EindopdrachtCSharp.Properties.Resources.Artboard_1Normal;
			this.tpActueel.Controls.Add(this.lblLastUpdate);
			this.tpActueel.Controls.Add(this.lblWindActueel);
			this.tpActueel.Controls.Add(this.label7);
			this.tpActueel.Controls.Add(this.lblAirActueel);
			this.tpActueel.Controls.Add(this.lblTemperatureActueel);
			this.tpActueel.Controls.Add(this.label4);
			this.tpActueel.Controls.Add(this.label3);
			this.tpActueel.Controls.Add(this.lblWeatherLongActueel);
			this.tpActueel.Controls.Add(this.lblWeatherInfoActueel);
			this.tpActueel.Controls.Add(this.weatherIcon);
			this.tpActueel.Controls.Add(this.lblLocationActueel);
			this.tpActueel.Location = new System.Drawing.Point(4, 22);
			this.tpActueel.Name = "tpActueel";
			this.tpActueel.Size = new System.Drawing.Size(426, 310);
			this.tpActueel.TabIndex = 0;
			this.tpActueel.Text = "Actueel";
			this.tpActueel.UseVisualStyleBackColor = true;
			// 
			// lblWindActueel
			// 
			this.lblWindActueel.AutoSize = true;
			this.lblWindActueel.Location = new System.Drawing.Point(119, 250);
			this.lblWindActueel.Name = "lblWindActueel";
			this.lblWindActueel.Size = new System.Drawing.Size(86, 13);
			this.lblWindActueel.TabIndex = 10;
			this.lblWindActueel.Text = "NO met 18 km/h";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(76, 250);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Wind:";
			// 
			// lblAirActueel
			// 
			this.lblAirActueel.AutoSize = true;
			this.lblAirActueel.Location = new System.Drawing.Point(119, 220);
			this.lblAirActueel.Name = "lblAirActueel";
			this.lblAirActueel.Size = new System.Drawing.Size(30, 13);
			this.lblAirActueel.TabIndex = 8;
			this.lblAirActueel.Text = "90 %";
			// 
			// lblTemperatureActueel
			// 
			this.lblTemperatureActueel.AutoSize = true;
			this.lblTemperatureActueel.Location = new System.Drawing.Point(119, 188);
			this.lblTemperatureActueel.Name = "lblTemperatureActueel";
			this.lblTemperatureActueel.Size = new System.Drawing.Size(27, 13);
			this.lblTemperatureActueel.TabIndex = 7;
			this.lblTemperatureActueel.Text = "0 °C";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Luchtvochtigheid:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tempratuur:";
			// 
			// lblWeatherLongActueel
			// 
			this.lblWeatherLongActueel.AutoSize = true;
			this.lblWeatherLongActueel.Location = new System.Drawing.Point(119, 139);
			this.lblWeatherLongActueel.Name = "lblWeatherLongActueel";
			this.lblWeatherLongActueel.Size = new System.Drawing.Size(66, 13);
			this.lblWeatherLongActueel.TabIndex = 4;
			this.lblWeatherLongActueel.Text = "no meatballs";
			// 
			// lblWeatherInfoActueel
			// 
			this.lblWeatherInfoActueel.AutoSize = true;
			this.lblWeatherInfoActueel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWeatherInfoActueel.Location = new System.Drawing.Point(119, 121);
			this.lblWeatherInfoActueel.Name = "lblWeatherInfoActueel";
			this.lblWeatherInfoActueel.Size = new System.Drawing.Size(43, 18);
			this.lblWeatherInfoActueel.TabIndex = 3;
			this.lblWeatherInfoActueel.Text = "SUN";
			// 
			// weatherIcon
			// 
			this.weatherIcon.Location = new System.Drawing.Point(41, 96);
			this.weatherIcon.Name = "weatherIcon";
			this.weatherIcon.Size = new System.Drawing.Size(70, 70);
			this.weatherIcon.TabIndex = 2;
			this.weatherIcon.TabStop = false;
			// 
			// lblLocationActueel
			// 
			this.lblLocationActueel.AutoSize = true;
			this.lblLocationActueel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocationActueel.Location = new System.Drawing.Point(117, 96);
			this.lblLocationActueel.Name = "lblLocationActueel";
			this.lblLocationActueel.Size = new System.Drawing.Size(132, 25);
			this.lblLocationActueel.TabIndex = 1;
			this.lblLocationActueel.Text = "Plaats, Land";
			// 
			// tbTrend
			// 
			this.tbTrend.BackgroundImage = global::EindopdrachtCSharp.Properties.Resources.Artboard_1Normal;
			this.tbTrend.Controls.Add(this.chart1);
			this.tbTrend.Controls.Add(this.lbl_graphCityName);
			this.tbTrend.Location = new System.Drawing.Point(4, 22);
			this.tbTrend.Name = "tbTrend";
			this.tbTrend.Size = new System.Drawing.Size(426, 310);
			this.tbTrend.TabIndex = 1;
			this.tbTrend.Text = "Trend";
			this.tbTrend.UseVisualStyleBackColor = true;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(22, 83);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(396, 219);
			this.chart1.TabIndex = 3;
			this.chart1.Text = "chart1";
			// 
			// lbl_graphCityName
			// 
			this.lbl_graphCityName.AutoSize = true;
			this.lbl_graphCityName.Location = new System.Drawing.Point(19, 58);
			this.lbl_graphCityName.Name = "lbl_graphCityName";
			this.lbl_graphCityName.Size = new System.Drawing.Size(42, 13);
			this.lbl_graphCityName.TabIndex = 2;
			this.lbl_graphCityName.Text = "Emmen";
			// 
			// tpOpties
			// 
			this.tpOpties.BackgroundImage = global::EindopdrachtCSharp.Properties.Resources.Artboard_1Normal;
			this.tpOpties.Controls.Add(this.label2);
			this.tpOpties.Controls.Add(this.radio_fahrenheit);
			this.tpOpties.Controls.Add(this.radio_celsius);
			this.tpOpties.Controls.Add(this.checkBox1);
			this.tpOpties.Controls.Add(this.label1);
			this.tpOpties.Controls.Add(this.numericUpDown1);
			this.tpOpties.Controls.Add(this.btn_options);
			this.tpOpties.Controls.Add(this.lbl_interval);
			this.tpOpties.Controls.Add(this.txt_cityname);
			this.tpOpties.Controls.Add(this.lbl_citySearch);
			this.tpOpties.Location = new System.Drawing.Point(4, 22);
			this.tpOpties.Name = "tpOpties";
			this.tpOpties.Size = new System.Drawing.Size(426, 310);
			this.tpOpties.TabIndex = 2;
			this.tpOpties.Text = "Opties";
			this.tpOpties.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Weergave: ";
			// 
			// radio_fahrenheit
			// 
			this.radio_fahrenheit.AutoSize = true;
			this.radio_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radio_fahrenheit.Location = new System.Drawing.Point(170, 196);
			this.radio_fahrenheit.Name = "radio_fahrenheit";
			this.radio_fahrenheit.Size = new System.Drawing.Size(75, 17);
			this.radio_fahrenheit.TabIndex = 19;
			this.radio_fahrenheit.Text = "Fahrenheit";
			this.radio_fahrenheit.UseVisualStyleBackColor = true;
			// 
			// radio_celsius
			// 
			this.radio_celsius.AutoSize = true;
			this.radio_celsius.Checked = true;
			this.radio_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radio_celsius.Location = new System.Drawing.Point(106, 196);
			this.radio_celsius.Name = "radio_celsius";
			this.radio_celsius.Size = new System.Drawing.Size(58, 17);
			this.radio_celsius.TabIndex = 18;
			this.radio_celsius.TabStop = true;
			this.radio_celsius.Text = "Celsius";
			this.radio_celsius.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(40, 123);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 17);
			this.checkBox1.TabIndex = 17;
			this.checkBox1.Text = "Enable interval";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(235, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "(In seconden)";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(97, 153);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(132, 20);
			this.numericUpDown1.TabIndex = 15;
			this.numericUpDown1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// btn_options
			// 
			this.btn_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_options.Location = new System.Drawing.Point(332, 267);
			this.btn_options.Name = "btn_options";
			this.btn_options.Size = new System.Drawing.Size(86, 35);
			this.btn_options.TabIndex = 14;
			this.btn_options.Text = "OK";
			this.btn_options.UseVisualStyleBackColor = true;
			this.btn_options.Click += new System.EventHandler(this.Btn_options_Click);
			// 
			// lbl_interval
			// 
			this.lbl_interval.AutoSize = true;
			this.lbl_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_interval.Location = new System.Drawing.Point(53, 155);
			this.lbl_interval.Name = "lbl_interval";
			this.lbl_interval.Size = new System.Drawing.Size(48, 13);
			this.lbl_interval.TabIndex = 13;
			this.lbl_interval.Text = "Interval: ";
			// 
			// txt_cityname
			// 
			this.txt_cityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cityname.Location = new System.Drawing.Point(78, 86);
			this.txt_cityname.Name = "txt_cityname";
			this.txt_cityname.Size = new System.Drawing.Size(132, 20);
			this.txt_cityname.TabIndex = 12;
			this.txt_cityname.Text = "Emmen";
			// 
			// lbl_citySearch
			// 
			this.lbl_citySearch.AutoSize = true;
			this.lbl_citySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_citySearch.Location = new System.Drawing.Point(37, 89);
			this.lbl_citySearch.Name = "lbl_citySearch";
			this.lbl_citySearch.Size = new System.Drawing.Size(36, 13);
			this.lbl_citySearch.TabIndex = 11;
			this.lbl_citySearch.Text = "Plaats";
			// 
			// TaskbarIcon
			// 
			this.TaskbarIcon.ContextMenuStrip = this.contextMenuStrip1;
			this.TaskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskbarIcon.Icon")));
			this.TaskbarIcon.Text = "NHL Stenden Weerstation";
			this.TaskbarIcon.Visible = true;
			this.TaskbarIcon.BalloonTipClicked += new System.EventHandler(this.TaskbarIcon_BalloonTipClicked);
			this.TaskbarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskbarIcon_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempratuurPlaceholderToolStripMenuItem,
            this.toolStripSeparator3,
            this.overToolStripMenuItem,
            this.verversenToolStripMenuItem,
            this.toolStripSeparator2,
            this.optiesToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.sluitenToolStripMenuItem});
			this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.ShowImageMargin = false;
			this.contextMenuStrip1.Size = new System.Drawing.Size(212, 188);
			// 
			// overToolStripMenuItem
			// 
			this.overToolStripMenuItem.Name = "overToolStripMenuItem";
			this.overToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.overToolStripMenuItem.Text = "Over";
			this.overToolStripMenuItem.Click += new System.EventHandler(this.OverToolStripMenuItem_Click);
			// 
			// verversenToolStripMenuItem
			// 
			this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
			this.verversenToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.verversenToolStripMenuItem.Text = "Verversen";
			this.verversenToolStripMenuItem.Click += new System.EventHandler(this.VerversenToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
			// 
			// optiesToolStripMenuItem
			// 
			this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
			this.optiesToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.optiesToolStripMenuItem.Text = "Opties";
			this.optiesToolStripMenuItem.Click += new System.EventHandler(this.OptiesToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// sluitenToolStripMenuItem
			// 
			this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
			this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.sluitenToolStripMenuItem.Text = "Sluiten";
			this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.SluitenToolStripMenuItem_Click);
			// 
			// refreshTimer
			// 
			this.refreshTimer.Interval = 60000;
			this.refreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
			// 
			// lblLastUpdate
			// 
			this.lblLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLastUpdate.AutoSize = true;
			this.lblLastUpdate.Enabled = false;
			this.lblLastUpdate.Location = new System.Drawing.Point(297, 292);
			this.lblLastUpdate.Name = "lblLastUpdate";
			this.lblLastUpdate.Size = new System.Drawing.Size(71, 13);
			this.lblLastUpdate.TabIndex = 11;
			this.lblLastUpdate.Text = "last updated: ";
			// 
			// tempratuurPlaceholderToolStripMenuItem
			// 
			this.tempratuurPlaceholderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.tempratuurPlaceholderToolStripMenuItem.Name = "tempratuurPlaceholderToolStripMenuItem";
			this.tempratuurPlaceholderToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.tempratuurPlaceholderToolStripMenuItem.Text = "tempratuur placeholder";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 336);
			this.Controls.Add(this.MainScreenTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainScreen";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "NHL Stenden Weerstation";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
			this.MainScreenTabControl.ResumeLayout(false);
			this.tpActueel.ResumeLayout(false);
			this.tpActueel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
			this.tbTrend.ResumeLayout(false);
			this.tbTrend.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.tpOpties.ResumeLayout(false);
			this.tpOpties.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainScreenTabControl;
        private System.Windows.Forms.TabPage tpActueel;
        private System.Windows.Forms.TabPage tbTrend;
        private System.Windows.Forms.TabPage tpOpties;
        private System.Windows.Forms.NotifyIcon TaskbarIcon;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verversenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btn_options;
		private System.Windows.Forms.Label lbl_interval;
		private System.Windows.Forms.TextBox txt_cityname;
		private System.Windows.Forms.Label lbl_citySearch;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label lbl_graphCityName;
		private System.Windows.Forms.Timer refreshTimer;
		public System.Windows.Forms.PictureBox weatherIcon;
		public System.Windows.Forms.Label lblLocationActueel;
		public System.Windows.Forms.Label lblWeatherInfoActueel;
		public System.Windows.Forms.Label lblWeatherLongActueel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label lblWindActueel;
		public System.Windows.Forms.Label lblAirActueel;
		public System.Windows.Forms.Label lblTemperatureActueel;
		public System.Windows.Forms.Label lblLastUpdate;
		public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		public System.Windows.Forms.RadioButton radio_fahrenheit;
		public System.Windows.Forms.RadioButton radio_celsius;
		private System.Windows.Forms.ToolStripMenuItem tempratuurPlaceholderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

