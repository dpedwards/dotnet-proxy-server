namespace ProxyServer
{
    partial class frmMain
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
            this.cmbIPAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExternalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInternalPort = new System.Windows.Forms.TextBox();
            this.chkRewriteHostHeaders = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIPAddress
            // 
            this.cmbIPAddress.FormattingEnabled = true;
            this.cmbIPAddress.Location = new System.Drawing.Point(12, 25);
            this.cmbIPAddress.Name = "cmbIPAddress";
            this.cmbIPAddress.Size = new System.Drawing.Size(188, 21);
            this.cmbIPAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Own IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "External Port";
            // 
            // txtExternalPort
            // 
            this.txtExternalPort.Location = new System.Drawing.Point(12, 65);
            this.txtExternalPort.Name = "txtExternalPort";
            this.txtExternalPort.Size = new System.Drawing.Size(188, 20);
            this.txtExternalPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Internal Port";
            // 
            // txtInternalPort
            // 
            this.txtInternalPort.Location = new System.Drawing.Point(12, 104);
            this.txtInternalPort.Name = "txtInternalPort";
            this.txtInternalPort.Size = new System.Drawing.Size(188, 20);
            this.txtInternalPort.TabIndex = 5;
            // 
            // chkRewriteHostHeaders
            // 
            this.chkRewriteHostHeaders.AutoSize = true;
            this.chkRewriteHostHeaders.Location = new System.Drawing.Point(12, 130);
            this.chkRewriteHostHeaders.Name = "chkRewriteHostHeaders";
            this.chkRewriteHostHeaders.Size = new System.Drawing.Size(126, 17);
            this.chkRewriteHostHeaders.TabIndex = 6;
            this.chkRewriteHostHeaders.Text = "Rewrite host headers";
            this.chkRewriteHostHeaders.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(125, 153);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 185);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkRewriteHostHeaders);
            this.Controls.Add(this.txtInternalPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExternalPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIPAddress);
            this.Name = "frmMain";
            this.Text = "ProxyServer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExternalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInternalPort;
        private System.Windows.Forms.CheckBox chkRewriteHostHeaders;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

