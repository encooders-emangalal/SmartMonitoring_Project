namespace SmartMonitoring.BackEnd
{
    partial class frmServerMonitor
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
            this.lblServerID = new System.Windows.Forms.Label();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblResults01 = new System.Windows.Forms.Label();
            this.progressBar01 = new System.Windows.Forms.ProgressBar();
            this.lblStatus01 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServerID
            // 
            this.lblServerID.AutoSize = true;
            this.lblServerID.Location = new System.Drawing.Point(12, 9);
            this.lblServerID.Name = "lblServerID";
            this.lblServerID.Size = new System.Drawing.Size(15, 13);
            this.lblServerID.TabIndex = 0;
            this.lblServerID.Text = "#";
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(529, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 23);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel Processing";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(374, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 23);
            this.btnStart.TabIndex = 120;
            this.btnStart.Text = "Start Processing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(301, 12);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(68, 17);
            this.chkIsActive.TabIndex = 122;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblResults01
            // 
            this.lblResults01.AutoSize = true;
            this.lblResults01.Location = new System.Drawing.Point(12, 298);
            this.lblResults01.Name = "lblResults01";
            this.lblResults01.Size = new System.Drawing.Size(15, 13);
            this.lblResults01.TabIndex = 124;
            this.lblResults01.Text = "#";
            // 
            // progressBar01
            // 
            this.progressBar01.Location = new System.Drawing.Point(15, 315);
            this.progressBar01.Name = "progressBar01";
            this.progressBar01.Size = new System.Drawing.Size(663, 23);
            this.progressBar01.TabIndex = 123;
            // 
            // lblStatus01
            // 
            this.lblStatus01.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblStatus01.Location = new System.Drawing.Point(286, 341);
            this.lblStatus01.Name = "lblStatus01";
            this.lblStatus01.Size = new System.Drawing.Size(75, 27);
            this.lblStatus01.TabIndex = 125;
            this.lblStatus01.Text = "#";
            this.lblStatus01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 38);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(664, 245);
            this.txtOutput.TabIndex = 126;
            // 
            // frmServerMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 376);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblResults01);
            this.Controls.Add(this.progressBar01);
            this.Controls.Add(this.lblStatus01);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lblServerID);
            this.Name = "frmServerMonitor";
            this.Text = "frmServerMonitor";
            this.Load += new System.EventHandler(this.frmServerMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerID;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblResults01;
        private System.Windows.Forms.ProgressBar progressBar01;
        private System.Windows.Forms.Label lblStatus01;
        private System.Windows.Forms.TextBox txtOutput;
    }
}