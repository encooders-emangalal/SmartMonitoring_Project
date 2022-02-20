namespace SmartMonitoring
{
    partial class CounterData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSelectDataTime = new System.Windows.Forms.ComboBox();
            this.btnDisplayData = new System.Windows.Forms.Button();
            this.gvCounterData = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCounterData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectDataTime
            // 
            this.cbSelectDataTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectDataTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectDataTime.FormattingEnabled = true;
            this.cbSelectDataTime.Items.AddRange(new object[] {
            "Last Week",
            "Last Month",
            "Last 3 Months",
            "Last 6 Months",
            "All Data"});
            this.cbSelectDataTime.Location = new System.Drawing.Point(12, 12);
            this.cbSelectDataTime.Name = "cbSelectDataTime";
            this.cbSelectDataTime.Size = new System.Drawing.Size(298, 28);
            this.cbSelectDataTime.TabIndex = 0;
            // 
            // btnDisplayData
            // 
            this.btnDisplayData.Location = new System.Drawing.Point(317, 12);
            this.btnDisplayData.Name = "btnDisplayData";
            this.btnDisplayData.Size = new System.Drawing.Size(147, 30);
            this.btnDisplayData.TabIndex = 1;
            this.btnDisplayData.Text = "Display Data";
            this.btnDisplayData.UseVisualStyleBackColor = true;
            this.btnDisplayData.Click += new System.EventHandler(this.btnDisplayData_Click);
            // 
            // gvCounterData
            // 
            this.gvCounterData.AllowUserToAddRows = false;
            this.gvCounterData.AllowUserToDeleteRows = false;
            this.gvCounterData.AllowUserToResizeRows = false;
            this.gvCounterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCounterData.BackgroundColor = System.Drawing.Color.White;
            this.gvCounterData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCounterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCounterData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTime,
            this.counterValue});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCounterData.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvCounterData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvCounterData.Location = new System.Drawing.Point(12, 56);
            this.gvCounterData.Margin = new System.Windows.Forms.Padding(4);
            this.gvCounterData.MultiSelect = false;
            this.gvCounterData.Name = "gvCounterData";
            this.gvCounterData.ReadOnly = true;
            this.gvCounterData.RowHeadersVisible = false;
            this.gvCounterData.RowHeadersWidth = 25;
            this.gvCounterData.RowTemplate.Height = 30;
            this.gvCounterData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCounterData.ShowEditingIcon = false;
            this.gvCounterData.Size = new System.Drawing.Size(835, 316);
            this.gvCounterData.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 388);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(835, 2);
            this.label21.TabIndex = 36;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(725, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 31);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 410);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(123, 31);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(180, 410);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(154, 31);
            this.lblAverage.TabIndex = 39;
            this.lblAverage.Text = "Avg: 5.2 %";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinimum
            // 
            this.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinimum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.Location = new System.Drawing.Point(351, 410);
            this.lblMinimum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(154, 31);
            this.lblMinimum.TabIndex = 40;
            this.lblMinimum.Text = "Min: 1.0 %";
            this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaximum
            // 
            this.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaximum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximum.Location = new System.Drawing.Point(530, 410);
            this.lblMaximum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(154, 31);
            this.lblMaximum.TabIndex = 41;
            this.lblMaximum.Text = "Max: 9.0 %";
            this.lblMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Time";
            this.dateTime.MinimumWidth = 6;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // counterValue
            // 
            this.counterValue.HeaderText = "Counter Value";
            this.counterValue.MinimumWidth = 6;
            this.counterValue.Name = "counterValue";
            this.counterValue.ReadOnly = true;
            // 
            // CounterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 453);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.gvCounterData);
            this.Controls.Add(this.btnDisplayData);
            this.Controls.Add(this.cbSelectDataTime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(878, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(878, 500);
            this.Name = "CounterData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Name - Counter Data";
            this.Load += new System.EventHandler(this.CounterData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCounterData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectDataTime;
        private System.Windows.Forms.Button btnDisplayData;
        private System.Windows.Forms.DataGridView gvCounterData;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterValue;
    }
}