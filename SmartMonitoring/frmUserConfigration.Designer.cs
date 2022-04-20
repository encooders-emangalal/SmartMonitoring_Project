namespace SmartMonitoring
{
    partial class frmUserConfigration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserConfigration));
            this.nametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnJobLocation = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(76, 70);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(251, 20);
            this.nametxt.TabIndex = 2;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(76, 114);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(251, 20);
            this.emailtxt.TabIndex = 3;
            // 
            // gvUsers
            // 
            this.gvUsers.AllowUserToAddRows = false;
            this.gvUsers.AllowUserToDeleteRows = false;
            this.gvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvUsers.BackgroundColor = System.Drawing.Color.White;
            this.gvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvUsers.Location = new System.Drawing.Point(12, 18);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.ReadOnly = true;
            this.gvUsers.RowHeadersWidth = 25;
            this.gvUsers.RowTemplate.Height = 30;
            this.gvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUsers.ShowEditingIcon = false;
            this.gvUsers.Size = new System.Drawing.Size(359, 555);
            this.gvUsers.TabIndex = 26;
            this.gvUsers.SelectionChanged += new System.EventHandler(this.gvUsers_SelectionChanged_1);
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.emailtxt);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Location = new System.Drawing.Point(377, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 350);
            this.panel1.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 18);
            this.label20.TabIndex = 24;
            this.label20.Text = "Email";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnCancel,
            this.btnJobLocation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(412, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnJobLocation
            // 
            this.btnJobLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJobLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnJobLocation.Image")));
            this.btnJobLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobLocation.Name = "btnJobLocation";
            this.btnJobLocation.Size = new System.Drawing.Size(36, 36);
            this.btnJobLocation.Text = "Deactivate";
            this.btnJobLocation.Click += new System.EventHandler(this.btnJobLocation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUserConfigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvUsers);
            this.Name = "frmUserConfigration";
            this.Text = "User Configration";
            this.Load += new System.EventHandler(this.frmUserConfigration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnJobLocation;
        private System.Windows.Forms.ToolStripButton btnCancel;
    }
}