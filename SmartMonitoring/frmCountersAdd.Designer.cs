namespace SmartMonitoring
{
    partial class frmCountersAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvMonitors = new System.Windows.Forms.DataGridView();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.category_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCounters = new System.Windows.Forms.DataGridView();
            this.counter_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance_total_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance_all_prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance_blank_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvInstances = new System.Windows.Forms.DataGridView();
            this.instance_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instance_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSelInstanceID = new System.Windows.Forms.TextBox();
            this.txtSelCounterInstanceBlank = new System.Windows.Forms.TextBox();
            this.txtSelCounterInstancePrefix = new System.Windows.Forms.TextBox();
            this.txtSelCounterInstanceTotal = new System.Windows.Forms.TextBox();
            this.txtSelCounterDescription = new System.Windows.Forms.TextBox();
            this.txtSelCategoryName = new System.Windows.Forms.TextBox();
            this.txtSelCounterID = new System.Windows.Forms.TextBox();
            this.txtSelMonitorID = new System.Windows.Forms.TextBox();
            this.txtSelInstanceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCounters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstances)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvMonitors
            // 
            this.gvMonitors.AllowUserToAddRows = false;
            this.gvMonitors.AllowUserToDeleteRows = false;
            this.gvMonitors.AllowUserToResizeColumns = false;
            this.gvMonitors.AllowUserToResizeRows = false;
            this.gvMonitors.BackgroundColor = System.Drawing.Color.White;
            this.gvMonitors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvMonitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMonitors.ColumnHeadersVisible = false;
            this.gvMonitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category_id,
            this.category_image,
            this.category_description});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMonitors.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvMonitors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvMonitors.Location = new System.Drawing.Point(11, 10);
            this.gvMonitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvMonitors.Name = "gvMonitors";
            this.gvMonitors.ReadOnly = true;
            this.gvMonitors.RowHeadersVisible = false;
            this.gvMonitors.RowHeadersWidth = 25;
            this.gvMonitors.RowTemplate.Height = 44;
            this.gvMonitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonitors.ShowEditingIcon = false;
            this.gvMonitors.Size = new System.Drawing.Size(271, 353);
            this.gvMonitors.TabIndex = 27;
            this.gvMonitors.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMonitors_RowEnter);
            // 
            // category_id
            // 
            this.category_id.DataPropertyName = "category_id";
            this.category_id.HeaderText = "category_id";
            this.category_id.MinimumWidth = 6;
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            this.category_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category_id.Visible = false;
            this.category_id.Width = 70;
            // 
            // category_image
            // 
            this.category_image.HeaderText = "";
            this.category_image.MinimumWidth = 6;
            this.category_image.Name = "category_image";
            this.category_image.ReadOnly = true;
            this.category_image.Width = 40;
            // 
            // category_description
            // 
            this.category_description.DataPropertyName = "category_description";
            this.category_description.HeaderText = "Monitor";
            this.category_description.MinimumWidth = 6;
            this.category_description.Name = "category_description";
            this.category_description.ReadOnly = true;
            this.category_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category_description.Width = 150;
            // 
            // gvCounters
            // 
            this.gvCounters.AllowUserToAddRows = false;
            this.gvCounters.AllowUserToDeleteRows = false;
            this.gvCounters.BackgroundColor = System.Drawing.Color.White;
            this.gvCounters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCounters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counter_id,
            this.counter_description,
            this.category_name,
            this.instance_total_name,
            this.instance_all_prefix,
            this.instance_blank_name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCounters.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvCounters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvCounters.Location = new System.Drawing.Point(289, 10);
            this.gvCounters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvCounters.Name = "gvCounters";
            this.gvCounters.ReadOnly = true;
            this.gvCounters.RowHeadersWidth = 25;
            this.gvCounters.RowTemplate.Height = 30;
            this.gvCounters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCounters.ShowEditingIcon = false;
            this.gvCounters.Size = new System.Drawing.Size(352, 353);
            this.gvCounters.TabIndex = 28;
            this.gvCounters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCounters_RowEnter);
            // 
            // counter_id
            // 
            this.counter_id.DataPropertyName = "counter_id";
            this.counter_id.HeaderText = "counter_id";
            this.counter_id.MinimumWidth = 6;
            this.counter_id.Name = "counter_id";
            this.counter_id.ReadOnly = true;
            this.counter_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.counter_id.Visible = false;
            this.counter_id.Width = 70;
            // 
            // counter_description
            // 
            this.counter_description.DataPropertyName = "counter_description";
            this.counter_description.HeaderText = "Counter";
            this.counter_description.MinimumWidth = 6;
            this.counter_description.Name = "counter_description";
            this.counter_description.ReadOnly = true;
            this.counter_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.counter_description.Width = 150;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "category_name";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Visible = false;
            this.category_name.Width = 125;
            // 
            // instance_total_name
            // 
            this.instance_total_name.DataPropertyName = "instance_total_name";
            this.instance_total_name.HeaderText = "instance_total_name";
            this.instance_total_name.MinimumWidth = 6;
            this.instance_total_name.Name = "instance_total_name";
            this.instance_total_name.ReadOnly = true;
            this.instance_total_name.Visible = false;
            this.instance_total_name.Width = 125;
            // 
            // instance_all_prefix
            // 
            this.instance_all_prefix.DataPropertyName = "instance_all_prefix";
            this.instance_all_prefix.HeaderText = "instance_all_prefix";
            this.instance_all_prefix.MinimumWidth = 6;
            this.instance_all_prefix.Name = "instance_all_prefix";
            this.instance_all_prefix.ReadOnly = true;
            this.instance_all_prefix.Visible = false;
            this.instance_all_prefix.Width = 125;
            // 
            // instance_blank_name
            // 
            this.instance_blank_name.DataPropertyName = "instance_blank_name";
            this.instance_blank_name.HeaderText = "instance_blank_name";
            this.instance_blank_name.MinimumWidth = 6;
            this.instance_blank_name.Name = "instance_blank_name";
            this.instance_blank_name.ReadOnly = true;
            this.instance_blank_name.Visible = false;
            this.instance_blank_name.Width = 125;
            // 
            // gvInstances
            // 
            this.gvInstances.AllowUserToAddRows = false;
            this.gvInstances.AllowUserToDeleteRows = false;
            this.gvInstances.BackgroundColor = System.Drawing.Color.White;
            this.gvInstances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvInstances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInstances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instance_id,
            this.instance_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvInstances.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvInstances.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvInstances.Location = new System.Drawing.Point(649, 10);
            this.gvInstances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvInstances.Name = "gvInstances";
            this.gvInstances.ReadOnly = true;
            this.gvInstances.RowHeadersWidth = 25;
            this.gvInstances.RowTemplate.Height = 30;
            this.gvInstances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvInstances.ShowEditingIcon = false;
            this.gvInstances.Size = new System.Drawing.Size(300, 353);
            this.gvInstances.TabIndex = 29;
            this.gvInstances.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvInstances_RowEnter);
            // 
            // instance_id
            // 
            this.instance_id.HeaderText = "instance_id";
            this.instance_id.MinimumWidth = 6;
            this.instance_id.Name = "instance_id";
            this.instance_id.ReadOnly = true;
            this.instance_id.Width = 125;
            // 
            // instance_name
            // 
            this.instance_name.DataPropertyName = "instance_name";
            this.instance_name.HeaderText = "Instance";
            this.instance_name.MinimumWidth = 6;
            this.instance_name.Name = "instance_name";
            this.instance_name.ReadOnly = true;
            this.instance_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.instance_name.Width = 150;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 373);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(939, 2);
            this.label21.TabIndex = 30;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(827, 383);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 28);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(696, 383);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 28);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSelInstanceID);
            this.panel1.Controls.Add(this.txtSelCounterInstanceBlank);
            this.panel1.Controls.Add(this.txtSelCounterInstancePrefix);
            this.panel1.Controls.Add(this.txtSelCounterInstanceTotal);
            this.panel1.Controls.Add(this.txtSelCounterDescription);
            this.panel1.Controls.Add(this.txtSelCategoryName);
            this.panel1.Controls.Add(this.txtSelCounterID);
            this.panel1.Controls.Add(this.txtSelMonitorID);
            this.panel1.Controls.Add(this.txtSelInstanceName);
            this.panel1.Location = new System.Drawing.Point(19, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 302);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // txtSelInstanceID
            // 
            this.txtSelInstanceID.Location = new System.Drawing.Point(79, 233);
            this.txtSelInstanceID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelInstanceID.Name = "txtSelInstanceID";
            this.txtSelInstanceID.ReadOnly = true;
            this.txtSelInstanceID.Size = new System.Drawing.Size(132, 22);
            this.txtSelInstanceID.TabIndex = 8;
            // 
            // txtSelCounterInstanceBlank
            // 
            this.txtSelCounterInstanceBlank.Location = new System.Drawing.Point(79, 203);
            this.txtSelCounterInstanceBlank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelCounterInstanceBlank.Name = "txtSelCounterInstanceBlank";
            this.txtSelCounterInstanceBlank.ReadOnly = true;
            this.txtSelCounterInstanceBlank.Size = new System.Drawing.Size(132, 22);
            this.txtSelCounterInstanceBlank.TabIndex = 7;
            // 
            // txtSelCounterInstancePrefix
            // 
            this.txtSelCounterInstancePrefix.Location = new System.Drawing.Point(79, 171);
            this.txtSelCounterInstancePrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelCounterInstancePrefix.Name = "txtSelCounterInstancePrefix";
            this.txtSelCounterInstancePrefix.ReadOnly = true;
            this.txtSelCounterInstancePrefix.Size = new System.Drawing.Size(132, 22);
            this.txtSelCounterInstancePrefix.TabIndex = 6;
            // 
            // txtSelCounterInstanceTotal
            // 
            this.txtSelCounterInstanceTotal.Location = new System.Drawing.Point(79, 139);
            this.txtSelCounterInstanceTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelCounterInstanceTotal.Name = "txtSelCounterInstanceTotal";
            this.txtSelCounterInstanceTotal.ReadOnly = true;
            this.txtSelCounterInstanceTotal.Size = new System.Drawing.Size(132, 22);
            this.txtSelCounterInstanceTotal.TabIndex = 5;
            // 
            // txtSelCounterDescription
            // 
            this.txtSelCounterDescription.Location = new System.Drawing.Point(79, 75);
            this.txtSelCounterDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelCounterDescription.Name = "txtSelCounterDescription";
            this.txtSelCounterDescription.ReadOnly = true;
            this.txtSelCounterDescription.Size = new System.Drawing.Size(132, 22);
            this.txtSelCounterDescription.TabIndex = 4;
            // 
            // txtSelCategoryName
            // 
            this.txtSelCategoryName.Location = new System.Drawing.Point(79, 107);
            this.txtSelCategoryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelCategoryName.Name = "txtSelCategoryName";
            this.txtSelCategoryName.ReadOnly = true;
            this.txtSelCategoryName.Size = new System.Drawing.Size(132, 22);
            this.txtSelCategoryName.TabIndex = 3;
            // 
            // txtSelCounterID
            // 
            this.txtSelCounterID.Location = new System.Drawing.Point(79, 43);
            this.txtSelCounterID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelCounterID.Name = "txtSelCounterID";
            this.txtSelCounterID.ReadOnly = true;
            this.txtSelCounterID.Size = new System.Drawing.Size(132, 22);
            this.txtSelCounterID.TabIndex = 2;
            // 
            // txtSelMonitorID
            // 
            this.txtSelMonitorID.Location = new System.Drawing.Point(79, 11);
            this.txtSelMonitorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelMonitorID.Name = "txtSelMonitorID";
            this.txtSelMonitorID.ReadOnly = true;
            this.txtSelMonitorID.Size = new System.Drawing.Size(132, 22);
            this.txtSelMonitorID.TabIndex = 1;
            // 
            // txtSelInstanceName
            // 
            this.txtSelInstanceName.Location = new System.Drawing.Point(79, 263);
            this.txtSelInstanceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelInstanceName.Name = "txtSelInstanceName";
            this.txtSelInstanceName.ReadOnly = true;
            this.txtSelInstanceName.Size = new System.Drawing.Size(132, 22);
            this.txtSelInstanceName.TabIndex = 0;
            // 
            // frmCountersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.gvInstances);
            this.Controls.Add(this.gvCounters);
            this.Controls.Add(this.gvMonitors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountersAdd";
            this.ShowInTaskbar = false;
            this.Text = "Add Counters";
            this.Load += new System.EventHandler(this.frmCountersAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCounters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstances)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMonitors;
        private System.Windows.Forms.DataGridView gvCounters;
        private System.Windows.Forms.DataGridView gvInstances;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSelCounterID;
        private System.Windows.Forms.TextBox txtSelMonitorID;
        private System.Windows.Forms.TextBox txtSelInstanceName;
        private System.Windows.Forms.TextBox txtSelCategoryName;
        private System.Windows.Forms.TextBox txtSelCounterDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn instance_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn instance_name;
        private System.Windows.Forms.TextBox txtSelCounterInstanceBlank;
        private System.Windows.Forms.TextBox txtSelCounterInstancePrefix;
        private System.Windows.Forms.TextBox txtSelCounterInstanceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn instance_total_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn instance_all_prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn instance_blank_name;
        private System.Windows.Forms.TextBox txtSelInstanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.DataGridViewImageColumn category_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_description;
    }
}