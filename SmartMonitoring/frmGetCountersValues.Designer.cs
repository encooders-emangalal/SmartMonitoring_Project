namespace SmartMonitoring
{
    partial class frmGetCountersValues
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
            this.tmrThreads = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrThreads
            // 
            this.tmrThreads.Interval = 1000;
            this.tmrThreads.Tick += new System.EventHandler(this.tmrThreads_Tick);
            // 
            // frmGetCountersValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmGetCountersValues";
            this.Text = "frmGetCountersValues";
            this.Load += new System.EventHandler(this.frmGetCountersValues_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrThreads;
    }
}