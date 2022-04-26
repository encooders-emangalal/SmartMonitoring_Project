namespace SmartMonitoring
{
    partial class frmSystemSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemSettings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.valuetxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvSystemSetting = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPanal = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSystemSetting)).BeginInit();
            this.SearchPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnDelete,
            this.btnCancel,
            this.toolStripSeparator2,
            this.Close});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(406, 39);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 36);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = global::SmartMonitoring.Properties.Resources.cancel_32;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // Close
            // 
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Close.Image = global::SmartMonitoring.Properties.Resources.power;
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 36);
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // valuetxt
            // 
            this.valuetxt.AllowDrop = true;
            this.valuetxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuetxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.valuetxt.Location = new System.Drawing.Point(93, 48);
            this.valuetxt.Name = "valuetxt";
            this.valuetxt.Size = new System.Drawing.Size(305, 23);
            this.valuetxt.TabIndex = 2;
            this.valuetxt.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.typecb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.valuetxt);
            this.panel2.Location = new System.Drawing.Point(369, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 368);
            this.panel2.TabIndex = 31;
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(93, 85);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(302, 21);
            this.typecb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gvSystemSetting
            // 
            this.gvSystemSetting.AllowUserToAddRows = false;
            this.gvSystemSetting.AllowUserToDeleteRows = false;
            this.gvSystemSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSystemSetting.BackgroundColor = System.Drawing.Color.White;
            this.gvSystemSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSystemSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSystemSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSystemSetting.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvSystemSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvSystemSetting.Location = new System.Drawing.Point(5, 36);
            this.gvSystemSetting.Name = "gvSystemSetting";
            this.gvSystemSetting.ReadOnly = true;
            this.gvSystemSetting.RowHeadersWidth = 25;
            this.gvSystemSetting.RowTemplate.Height = 30;
            this.gvSystemSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSystemSetting.ShowEditingIcon = false;
            this.gvSystemSetting.Size = new System.Drawing.Size(350, 332);
            this.gvSystemSetting.TabIndex = 29;
            this.gvSystemSetting.SelectionChanged += new System.EventHandler(this.gvSystemSetting_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "sys_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "sys_value";
            this.name.HeaderText = "Value";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "sys_type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // SearchPanal
            // 
            this.SearchPanal.Controls.Add(this.gvSystemSetting);
            this.SearchPanal.Controls.Add(this.btnSearch);
            this.SearchPanal.Controls.Add(this.label2);
            this.SearchPanal.Controls.Add(this.txtSearch);
            this.SearchPanal.Location = new System.Drawing.Point(4, 12);
            this.SearchPanal.Name = "SearchPanal";
            this.SearchPanal.Size = new System.Drawing.Size(359, 371);
            this.SearchPanal.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::SmartMonitoring.Properties.Resources.Search2_16;
            this.btnSearch.Location = new System.Drawing.Point(332, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 19);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(49, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 23);
            this.txtSearch.TabIndex = 25;
            
            // 
            // frmSystemSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchPanal);
            this.Name = "frmSystemSettings";
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.frmSystemSettings_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSystemSetting)).EndInit();
            this.SearchPanal.ResumeLayout(false);
            this.SearchPanal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.TextBox valuetxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvSystemSetting;
        private System.Windows.Forms.Panel SearchPanal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typecb;
    }
}