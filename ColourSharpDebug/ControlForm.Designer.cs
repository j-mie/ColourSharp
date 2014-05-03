namespace ColourSharpDebug
{
    partial class ControlForm
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
            this.redSlider = new System.Windows.Forms.TrackBar();
            this.greenSlider = new System.Windows.Forms.TrackBar();
            this.blueSlider = new System.Windows.Forms.TrackBar();
            this.sendButton = new System.Windows.Forms.Button();
            this.rLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.COMConnect = new System.Windows.Forms.Button();
            this.COMDisconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.COMPorts = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // redSlider
            // 
            this.redSlider.BackColor = System.Drawing.Color.Red;
            this.redSlider.Location = new System.Drawing.Point(12, 12);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(341, 45);
            this.redSlider.TabIndex = 0;
            this.redSlider.Scroll += new System.EventHandler(this.redSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.BackColor = System.Drawing.Color.Lime;
            this.greenSlider.Location = new System.Drawing.Point(12, 63);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(341, 45);
            this.greenSlider.TabIndex = 1;
            this.greenSlider.Scroll += new System.EventHandler(this.greenSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.BackColor = System.Drawing.Color.Blue;
            this.blueSlider.Location = new System.Drawing.Point(12, 114);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(341, 45);
            this.blueSlider.TabIndex = 2;
            this.blueSlider.Scroll += new System.EventHandler(this.blueSlider_Scroll);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(12, 205);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(341, 39);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.BackColor = System.Drawing.Color.Red;
            this.rLabel.ForeColor = System.Drawing.Color.White;
            this.rLabel.Location = new System.Drawing.Point(12, 162);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(13, 13);
            this.rLabel.TabIndex = 4;
            this.rLabel.Text = "0";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.BackColor = System.Drawing.Color.Lime;
            this.gLabel.Location = new System.Drawing.Point(53, 162);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(13, 13);
            this.gLabel.TabIndex = 5;
            this.gLabel.Text = "0";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.Blue;
            this.bLabel.ForeColor = System.Drawing.Color.White;
            this.bLabel.Location = new System.Drawing.Point(94, 162);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(13, 13);
            this.bLabel.TabIndex = 6;
            this.bLabel.Text = "0";
            // 
            // COMConnect
            // 
            this.COMConnect.Enabled = false;
            this.COMConnect.Location = new System.Drawing.Point(12, 252);
            this.COMConnect.Name = "COMConnect";
            this.COMConnect.Size = new System.Drawing.Size(144, 23);
            this.COMConnect.TabIndex = 7;
            this.COMConnect.Text = "Connect";
            this.COMConnect.UseVisualStyleBackColor = true;
            this.COMConnect.Click += new System.EventHandler(this.COMConnect_Click);
            // 
            // COMDisconnect
            // 
            this.COMDisconnect.Enabled = false;
            this.COMDisconnect.Location = new System.Drawing.Point(162, 252);
            this.COMDisconnect.Name = "COMDisconnect";
            this.COMDisconnect.Size = new System.Drawing.Size(144, 23);
            this.COMDisconnect.TabIndex = 8;
            this.COMDisconnect.Text = "Disconnect";
            this.COMDisconnect.UseVisualStyleBackColor = true;
            this.COMDisconnect.Click += new System.EventHandler(this.COMDisconnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // COMPorts
            // 
            this.COMPorts.FormattingEnabled = true;
            this.COMPorts.Location = new System.Drawing.Point(12, 178);
            this.COMPorts.Name = "COMPorts";
            this.COMPorts.Size = new System.Drawing.Size(341, 21);
            this.COMPorts.TabIndex = 10;
            this.COMPorts.SelectedIndexChanged += new System.EventHandler(this.COMPorts_SelectedIndexChanged);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 287);
            this.Controls.Add(this.COMPorts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COMDisconnect);
            this.Controls.Add(this.COMConnect);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.blueSlider);
            this.Controls.Add(this.greenSlider);
            this.Controls.Add(this.redSlider);
            this.Name = "ControlForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redSlider;
        private System.Windows.Forms.TrackBar greenSlider;
        private System.Windows.Forms.TrackBar blueSlider;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Button COMConnect;
        private System.Windows.Forms.Button COMDisconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMPorts;
        private System.IO.Ports.SerialPort serialPort;
    }
}

