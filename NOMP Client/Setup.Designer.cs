namespace NOMP_Client
{
    partial class Setup
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
            this.labelHardwareName = new System.Windows.Forms.Label();
            this.labelHardwareType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageGFX = new System.Windows.Forms.TabPage();
            this.tabPageCPU = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelGFX = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabelNVIDIA = new System.Windows.Forms.LinkLabel();
            this.linkLabelAMD = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlInfo.SuspendLayout();
            this.tabPageGFX.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHardwareName
            // 
            this.labelHardwareName.AutoSize = true;
            this.labelHardwareName.Location = new System.Drawing.Point(111, 53);
            this.labelHardwareName.Name = "labelHardwareName";
            this.labelHardwareName.Size = new System.Drawing.Size(35, 13);
            this.labelHardwareName.TabIndex = 1;
            this.labelHardwareName.Text = "model";
            // 
            // labelHardwareType
            // 
            this.labelHardwareType.AutoSize = true;
            this.labelHardwareType.Location = new System.Drawing.Point(111, 27);
            this.labelHardwareType.Name = "labelHardwareType";
            this.labelHardwareType.Size = new System.Drawing.Size(27, 13);
            this.labelHardwareType.TabIndex = 2;
            this.labelHardwareType.Text = "type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hardware Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hardware Model:";
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlInfo.Controls.Add(this.tabPageGFX);
            this.tabControlInfo.Controls.Add(this.tabPageCPU);
            this.tabControlInfo.Location = new System.Drawing.Point(6, 17);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(424, 168);
            this.tabControlInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlInfo.TabIndex = 5;
            // 
            // tabPageGFX
            // 
            this.tabPageGFX.Controls.Add(this.label6);
            this.tabPageGFX.Controls.Add(this.label5);
            this.tabPageGFX.Controls.Add(this.linkLabelGFX);
            this.tabPageGFX.Controls.Add(this.label4);
            this.tabPageGFX.Location = new System.Drawing.Point(4, 25);
            this.tabPageGFX.Name = "tabPageGFX";
            this.tabPageGFX.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGFX.Size = new System.Drawing.Size(416, 146);
            this.tabPageGFX.TabIndex = 0;
            this.tabPageGFX.Text = "GFX";
            this.tabPageGFX.UseVisualStyleBackColor = true;
            // 
            // tabPageCPU
            // 
            this.tabPageCPU.Controls.Add(this.label8);
            this.tabPageCPU.Controls.Add(this.linkLabelAMD);
            this.tabPageCPU.Controls.Add(this.linkLabelNVIDIA);
            this.tabPageCPU.Controls.Add(this.label7);
            this.tabPageCPU.Controls.Add(this.label1);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 25);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(416, 139);
            this.tabPageCPU.TabIndex = 2;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Install latest drivers for your graphics card.";
            // 
            // linkLabelGFX
            // 
            this.linkLabelGFX.AutoSize = true;
            this.linkLabelGFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGFX.Location = new System.Drawing.Point(22, 40);
            this.linkLabelGFX.Name = "linkLabelGFX";
            this.linkLabelGFX.Size = new System.Drawing.Size(122, 13);
            this.linkLabelGFX.TabIndex = 1;
            this.linkLabelGFX.TabStop = true;
            this.linkLabelGFX.Text = "Download {0} Driver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "After installing the latest drivers click continue.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "This is important!";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tabControlInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 192);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelHardwareName);
            this.groupBox2.Controls.Add(this.labelHardwareType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detected Mining Hardware";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "No graphics card was detected, but don\'t worry! You can still mine using your CPU" +
    ".";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 45);
            this.label7.TabIndex = 1;
            this.label7.Text = "If you have an NVIDIA or AMD/ATI card installed, then try updating your drivers a" +
    "nd restart this app";
            // 
            // linkLabelNVIDIA
            // 
            this.linkLabelNVIDIA.AutoSize = true;
            this.linkLabelNVIDIA.Location = new System.Drawing.Point(10, 67);
            this.linkLabelNVIDIA.Name = "linkLabelNVIDIA";
            this.linkLabelNVIDIA.Size = new System.Drawing.Size(76, 13);
            this.linkLabelNVIDIA.TabIndex = 2;
            this.linkLabelNVIDIA.TabStop = true;
            this.linkLabelNVIDIA.Text = "NVIDA Drivers";
            // 
            // linkLabelAMD
            // 
            this.linkLabelAMD.AutoSize = true;
            this.linkLabelAMD.Location = new System.Drawing.Point(10, 89);
            this.linkLabelAMD.Name = "linkLabelAMD";
            this.linkLabelAMD.Size = new System.Drawing.Size(89, 13);
            this.linkLabelAMD.TabIndex = 3;
            this.linkLabelAMD.TabStop = true;
            this.linkLabelAMD.Text = "AMD/ATI Drivers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Otherwise, click continue to mine with your CPU";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(277, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 309);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setup";
            this.Text = "Setup";
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageGFX.ResumeLayout(false);
            this.tabPageGFX.PerformLayout();
            this.tabPageCPU.ResumeLayout(false);
            this.tabPageCPU.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHardwareName;
        private System.Windows.Forms.Label labelHardwareType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageGFX;
        private System.Windows.Forms.LinkLabel linkLabelGFX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageCPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelAMD;
        private System.Windows.Forms.LinkLabel linkLabelNVIDIA;
        private System.Windows.Forms.Button button1;
    }
}