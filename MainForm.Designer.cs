namespace Aero_Visualizer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenAudio = new System.Windows.Forms.OpenFileDialog();
            this.FFTThink = new System.Windows.Forms.Timer(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.ColorTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colorOutput = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SFMLPanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Check_MintoTray = new System.Windows.Forms.CheckBox();
            this.DeviceList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayContextEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayContextRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayContextClose = new System.Windows.Forms.ToolStripMenuItem();
            this.SP = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabs.SuspendLayout();
            this.ColorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.DeviceTab.SuspendLayout();
            this.TrayContext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenAudio
            // 
            this.OpenAudio.Filter = "MP3 Files|*.mp3|WAV Files|*.wav";
            // 
            // FFTThink
            // 
            this.FFTThink.Interval = 1;
            this.FFTThink.Tick += new System.EventHandler(this.Think);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.ColorTab);
            this.tabs.Controls.Add(this.DeviceTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(976, 528);
            this.tabs.TabIndex = 4;
            // 
            // ColorTab
            // 
            this.ColorTab.BackColor = System.Drawing.SystemColors.Control;
            this.ColorTab.Controls.Add(this.splitContainer1);
            this.ColorTab.Location = new System.Drawing.Point(4, 22);
            this.ColorTab.Name = "ColorTab";
            this.ColorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ColorTab.Size = new System.Drawing.Size(968, 502);
            this.ColorTab.TabIndex = 1;
            this.ColorTab.Text = "Color Settings";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.colorOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(962, 496);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 10;
            // 
            // colorOutput
            // 
            this.colorOutput.BackColor = System.Drawing.Color.Red;
            this.colorOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorOutput.Location = new System.Drawing.Point(0, 0);
            this.colorOutput.Name = "colorOutput";
            this.colorOutput.Size = new System.Drawing.Size(962, 53);
            this.colorOutput.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SFMLPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(962, 439);
            this.splitContainer2.SplitterDistance = 337;
            this.splitContainer2.TabIndex = 11;
            // 
            // SFMLPanel
            // 
            this.SFMLPanel.AutoSize = true;
            this.SFMLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SFMLPanel.Location = new System.Drawing.Point(0, 0);
            this.SFMLPanel.Name = "SFMLPanel";
            this.SFMLPanel.Size = new System.Drawing.Size(962, 337);
            this.SFMLPanel.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(18, 34);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(530, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sensitivity:";
            // 
            // DeviceTab
            // 
            this.DeviceTab.BackColor = System.Drawing.SystemColors.Control;
            this.DeviceTab.Controls.Add(this.label4);
            this.DeviceTab.Controls.Add(this.comboBox1);
            this.DeviceTab.Controls.Add(this.Check_MintoTray);
            this.DeviceTab.Controls.Add(this.DeviceList);
            this.DeviceTab.Controls.Add(this.label3);
            this.DeviceTab.Location = new System.Drawing.Point(4, 22);
            this.DeviceTab.Name = "DeviceTab";
            this.DeviceTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeviceTab.Size = new System.Drawing.Size(968, 502);
            this.DeviceTab.TabIndex = 0;
            this.DeviceTab.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "COM Port";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Check_MintoTray
            // 
            this.Check_MintoTray.AutoSize = true;
            this.Check_MintoTray.Location = new System.Drawing.Point(6, 86);
            this.Check_MintoTray.Name = "Check_MintoTray";
            this.Check_MintoTray.Size = new System.Drawing.Size(98, 17);
            this.Check_MintoTray.TabIndex = 4;
            this.Check_MintoTray.Text = "Minimize to tray";
            this.Check_MintoTray.UseVisualStyleBackColor = true;
            // 
            // DeviceList
            // 
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.Location = new System.Drawing.Point(6, 19);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(335, 21);
            this.DeviceList.TabIndex = 2;
            this.DeviceList.SelectionChangeCommitted += new System.EventHandler(this.ChangeDevice);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Device to use for Aero Visaulizer";
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayContext;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Aero Visualizer";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TrayContext
            // 
            this.TrayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayContextEnable,
            this.TrayContextRestore,
            this.TrayContextClose});
            this.TrayContext.Name = "TrayContext";
            this.TrayContext.Size = new System.Drawing.Size(114, 70);
            // 
            // TrayContextEnable
            // 
            this.TrayContextEnable.Enabled = false;
            this.TrayContextEnable.Name = "TrayContextEnable";
            this.TrayContextEnable.Size = new System.Drawing.Size(113, 22);
            this.TrayContextEnable.Text = "Enable ";
            // 
            // TrayContextRestore
            // 
            this.TrayContextRestore.Name = "TrayContextRestore";
            this.TrayContextRestore.Size = new System.Drawing.Size(113, 22);
            this.TrayContextRestore.Text = "Restore";
            this.TrayContextRestore.Click += new System.EventHandler(this.TrayContextRestore_Click);
            // 
            // TrayContextClose
            // 
            this.TrayContextClose.Name = "TrayContextClose";
            this.TrayContextClose.Size = new System.Drawing.Size(113, 22);
            this.TrayContextClose.Text = "Close";
            this.TrayContextClose.Click += new System.EventHandler(this.TrayContextClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 528);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Aero Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabs.ResumeLayout(false);
            this.ColorTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.DeviceTab.ResumeLayout(false);
            this.DeviceTab.PerformLayout();
            this.TrayContext.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenAudio;
        private System.Windows.Forms.Timer FFTThink;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage ColorTab;
        private System.Windows.Forms.TabPage DeviceTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeviceList;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContext;
        private System.Windows.Forms.ToolStripMenuItem TrayContextEnable;
        private System.Windows.Forms.ToolStripMenuItem TrayContextRestore;
        private System.Windows.Forms.ToolStripMenuItem TrayContextClose;
        private System.Windows.Forms.CheckBox Check_MintoTray;
        private System.IO.Ports.SerialPort SP;
        private System.Windows.Forms.Panel SFMLPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel colorOutput;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

