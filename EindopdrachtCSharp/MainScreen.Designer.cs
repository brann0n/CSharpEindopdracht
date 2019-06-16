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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
			this.MainScreenTabControl = new System.Windows.Forms.TabControl();
			this.tpActueel = new System.Windows.Forms.TabPage();
			this.tbTrend = new System.Windows.Forms.TabPage();
			this.tpOpties = new System.Windows.Forms.TabPage();
			this.TaskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verversenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.MainScreenTabControl.SuspendLayout();
			this.tpActueel.SuspendLayout();
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
			this.tpActueel.Controls.Add(this.button1);
			this.tpActueel.Location = new System.Drawing.Point(4, 22);
			this.tpActueel.Name = "tpActueel";
			this.tpActueel.Size = new System.Drawing.Size(426, 310);
			this.tpActueel.TabIndex = 0;
			this.tpActueel.Text = "Actueel";
			this.tpActueel.UseVisualStyleBackColor = true;
			// 
			// tbTrend
			// 
			this.tbTrend.BackgroundImage = global::EindopdrachtCSharp.Properties.Resources.Artboard_1Normal;
			this.tbTrend.Location = new System.Drawing.Point(4, 22);
			this.tbTrend.Name = "tbTrend";
			this.tbTrend.Size = new System.Drawing.Size(426, 310);
			this.tbTrend.TabIndex = 1;
			this.tbTrend.Text = "Trend";
			this.tbTrend.UseVisualStyleBackColor = true;
			// 
			// tpOpties
			// 
			this.tpOpties.BackgroundImage = global::EindopdrachtCSharp.Properties.Resources.Artboard_1Normal;
			this.tpOpties.Location = new System.Drawing.Point(4, 22);
			this.tpOpties.Name = "tpOpties";
			this.tpOpties.Size = new System.Drawing.Size(426, 310);
			this.tpOpties.TabIndex = 2;
			this.tpOpties.Text = "Opties";
			this.tpOpties.UseVisualStyleBackColor = true;
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
			this.contextMenuStrip1.Size = new System.Drawing.Size(100, 126);
			// 
			// overToolStripMenuItem
			// 
			this.overToolStripMenuItem.Name = "overToolStripMenuItem";
			this.overToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.overToolStripMenuItem.Text = "Over";
			// 
			// verversenToolStripMenuItem
			// 
			this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
			this.verversenToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.verversenToolStripMenuItem.Text = "Verversen";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(96, 6);
			// 
			// optiesToolStripMenuItem
			// 
			this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
			this.optiesToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.optiesToolStripMenuItem.Text = "Opties";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// sluitenToolStripMenuItem
			// 
			this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
			this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.sluitenToolStripMenuItem.Text = "Sluiten";
			this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.SluitenToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(61, 92);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
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
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainScreenTabControl;
        private System.Windows.Forms.TabPage tpActueel;
        private System.Windows.Forms.TabPage tbTrend;
        private System.Windows.Forms.TabPage tpOpties;
        private System.Windows.Forms.NotifyIcon TaskbarIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verversenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Button button1;
	}
}

