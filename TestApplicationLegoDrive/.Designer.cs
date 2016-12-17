namespace TestApplicationLegoDrive
{
    partial class TestLegoDrive
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
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.driveGroupBox = new System.Windows.Forms.GroupBox();
            this.btDrop = new System.Windows.Forms.Button();
            this.btGrab = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.driveButton = new System.Windows.Forms.Button();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connectionGroupBox.SuspendLayout();
            this.driveGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.refreshButton);
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.portListBox);
            this.connectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.Location = new System.Drawing.Point(18, 18);
            this.connectionGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionGroupBox.Size = new System.Drawing.Size(570, 295);
            this.connectionGroupBox.TabIndex = 0;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(376, 51);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(140, 55);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(376, 228);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(140, 51);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(376, 137);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(140, 54);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portListBox
            // 
            this.portListBox.FormattingEnabled = true;
            this.portListBox.ItemHeight = 29;
            this.portListBox.Location = new System.Drawing.Point(9, 51);
            this.portListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(334, 207);
            this.portListBox.TabIndex = 0;
            // 
            // driveGroupBox
            // 
            this.driveGroupBox.Controls.Add(this.btDrop);
            this.driveGroupBox.Controls.Add(this.btGrab);
            this.driveGroupBox.Controls.Add(this.stopButton);
            this.driveGroupBox.Controls.Add(this.driveButton);
            this.driveGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveGroupBox.Location = new System.Drawing.Point(663, 18);
            this.driveGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.driveGroupBox.Name = "driveGroupBox";
            this.driveGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.driveGroupBox.Size = new System.Drawing.Size(231, 295);
            this.driveGroupBox.TabIndex = 1;
            this.driveGroupBox.TabStop = false;
            this.driveGroupBox.Text = "Drive";
            // 
            // btDrop
            // 
            this.btDrop.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btDrop.Location = new System.Drawing.Point(66, 228);
            this.btDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDrop.Name = "btDrop";
            this.btDrop.Size = new System.Drawing.Size(112, 51);
            this.btDrop.TabIndex = 3;
            this.btDrop.Text = "Drop";
            this.btDrop.UseVisualStyleBackColor = true;
            this.btDrop.Click += new System.EventHandler(this.btDrop_Click);
            // 
            // btGrab
            // 
            this.btGrab.Location = new System.Drawing.Point(66, 171);
            this.btGrab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGrab.Name = "btGrab";
            this.btGrab.Size = new System.Drawing.Size(112, 51);
            this.btGrab.TabIndex = 2;
            this.btGrab.Text = "Grab";
            this.btGrab.UseVisualStyleBackColor = true;
            this.btGrab.Click += new System.EventHandler(this.btGrab_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(66, 110);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 51);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // driveButton
            // 
            this.driveButton.Location = new System.Drawing.Point(66, 51);
            this.driveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.driveButton.Name = "driveButton";
            this.driveButton.Size = new System.Drawing.Size(112, 49);
            this.driveButton.TabIndex = 0;
            this.driveButton.Text = "Drive";
            this.driveButton.UseVisualStyleBackColor = true;
            this.driveButton.Click += new System.EventHandler(this.driveButton_Click);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.statusListBox);
            this.statusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGroupBox.Location = new System.Drawing.Point(63, 375);
            this.statusGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusGroupBox.Size = new System.Drawing.Size(831, 232);
            this.statusGroupBox.TabIndex = 2;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status";
            // 
            // statusListBox
            // 
            this.statusListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.statusListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.ItemHeight = 29;
            this.statusListBox.Location = new System.Drawing.Point(207, 35);
            this.statusListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(408, 149);
            this.statusListBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TestLegoDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 658);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.driveGroupBox);
            this.Controls.Add(this.connectionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestLegoDrive";
            this.Text = "AGVAPPv1";
            this.connectionGroupBox.ResumeLayout(false);
            this.driveGroupBox.ResumeLayout(false);
            this.statusGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.GroupBox driveGroupBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button driveButton;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.ListBox statusListBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btDrop;
        private System.Windows.Forms.Button btGrab;
    }
}

