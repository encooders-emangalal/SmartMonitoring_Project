namespace SmartMonitoring
{
    partial class ExportCounter
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
            this.cbSelectExportTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToCSVFile = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectExportTime
            // 
            this.cbSelectExportTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectExportTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectExportTime.FormattingEnabled = true;
            this.cbSelectExportTime.Items.AddRange(new object[] {
            "Last Week",
            "Last Month",
            "Last 3 Months",
            "Last 6 Months",
            "All Data"});
            this.cbSelectExportTime.Location = new System.Drawing.Point(113, 52);
            this.cbSelectExportTime.Name = "cbSelectExportTime";
            this.cbSelectExportTime.Size = new System.Drawing.Size(623, 28);
            this.cbSelectExportTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Export:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(18, 137);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(180, 35);
            this.btnExportToExcel.TabIndex = 48;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // btnExportToCSVFile
            // 
            this.btnExportToCSVFile.Location = new System.Drawing.Point(204, 137);
            this.btnExportToCSVFile.Name = "btnExportToCSVFile";
            this.btnExportToCSVFile.Size = new System.Drawing.Size(213, 35);
            this.btnExportToCSVFile.TabIndex = 49;
            this.btnExportToCSVFile.Text = "Export to CSV File";
            this.btnExportToCSVFile.UseVisualStyleBackColor = true;
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Location = new System.Drawing.Point(423, 137);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(174, 35);
            this.btnExportToPDF.TabIndex = 50;
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(603, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 35);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ExportCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 192);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportToPDF);
            this.Controls.Add(this.btnExportToCSVFile);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectExportTime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 239);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 239);
            this.Name = "ExportCounter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Name - Export Counter Data";
            this.Load += new System.EventHandler(this.ExportCounter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectExportTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToCSVFile;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Button btnClose;
    }
}