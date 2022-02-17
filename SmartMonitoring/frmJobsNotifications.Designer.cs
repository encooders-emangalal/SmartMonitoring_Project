namespace SmartMonitoring
{
    partial class frmJobsNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobsNotifications));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboJobFrequency = new System.Windows.Forms.ComboBox();
            this.tsbActivate = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJobLocation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label18 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnJobStart = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnJobStop = new System.Windows.Forms.ToolStripButton();
            this.gvPushJobs = new System.Windows.Forms.DataGridView();
            this.JOB_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOB_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOB_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmailNotification = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPushJobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEmailNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboJobFrequency
            // 
            this.cboJobFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobFrequency.FormattingEnabled = true;
            this.cboJobFrequency.Items.AddRange(new object[] {
            "Server",
            "Oracle DB",
            "SQL Server DB"});
            this.cboJobFrequency.Location = new System.Drawing.Point(127, 118);
            this.cboJobFrequency.Name = "cboJobFrequency";
            this.cboJobFrequency.Size = new System.Drawing.Size(121, 21);
            this.cboJobFrequency.TabIndex = 6;
            // 
            // tsbActivate
            // 
            this.tsbActivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbActivate.Image = ((System.Drawing.Image)(resources.GetObject("tsbActivate.Image")));
            this.tsbActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActivate.Name = "tsbActivate";
            this.tsbActivate.Size = new System.Drawing.Size(36, 36);
            this.tsbActivate.Text = "Activate";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entity Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnJobLocation
            // 
            this.btnJobLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJobLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnJobLocation.Image")));
            this.btnJobLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobLocation.Name = "btnJobLocation";
            this.btnJobLocation.Size = new System.Drawing.Size(36, 36);
            this.btnJobLocation.Text = "Deactivate";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Duplicate";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 18);
            this.label18.TabIndex = 21;
            this.label18.Text = "Is Active";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(128, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Delete";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(128, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(131, 22);
            this.textBox7.TabIndex = 39;
            this.textBox7.Text = "RCBU";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 18);
            this.label20.TabIndex = 24;
            this.label20.Text = "CCB Division";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnJobStart
            // 
            this.btnJobStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJobStart.Image = ((System.Drawing.Image)(resources.GetObject("btnJobStart.Image")));
            this.btnJobStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobStart.Name = "btnJobStart";
            this.btnJobStart.Size = new System.Drawing.Size(36, 36);
            this.btnJobStart.Text = "New";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "RCBU Missing Meters";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJobStart,
            this.btnJobStop,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.tsbActivate,
            this.btnJobLocation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnJobStop
            // 
            this.btnJobStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnJobStop.Image = ((System.Drawing.Image)(resources.GetObject("btnJobStop.Image")));
            this.btnJobStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobStop.Name = "btnJobStop";
            this.btnJobStop.Size = new System.Drawing.Size(36, 36);
            this.btnJobStop.Text = "Save";
            // 
            // gvPushJobs
            // 
            this.gvPushJobs.AllowUserToAddRows = false;
            this.gvPushJobs.AllowUserToDeleteRows = false;
            this.gvPushJobs.BackgroundColor = System.Drawing.Color.White;
            this.gvPushJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPushJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPushJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JOB_ID,
            this.JOB_NAME,
            this.JOB_STATUS});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPushJobs.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvPushJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvPushJobs.Location = new System.Drawing.Point(8, 8);
            this.gvPushJobs.Name = "gvPushJobs";
            this.gvPushJobs.ReadOnly = true;
            this.gvPushJobs.RowHeadersWidth = 25;
            this.gvPushJobs.RowTemplate.Height = 30;
            this.gvPushJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPushJobs.ShowEditingIcon = false;
            this.gvPushJobs.Size = new System.Drawing.Size(310, 538);
            this.gvPushJobs.TabIndex = 25;
            // 
            // JOB_ID
            // 
            this.JOB_ID.DataPropertyName = "JOB_ID";
            this.JOB_ID.HeaderText = "Job ID";
            this.JOB_ID.Name = "JOB_ID";
            this.JOB_ID.ReadOnly = true;
            this.JOB_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.JOB_ID.Visible = false;
            this.JOB_ID.Width = 70;
            // 
            // JOB_NAME
            // 
            this.JOB_NAME.DataPropertyName = "JOB_NAME";
            this.JOB_NAME.HeaderText = "Job Name";
            this.JOB_NAME.Name = "JOB_NAME";
            this.JOB_NAME.ReadOnly = true;
            this.JOB_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.JOB_NAME.Width = 150;
            // 
            // JOB_STATUS
            // 
            this.JOB_STATUS.DataPropertyName = "JOB_STATUS";
            this.JOB_STATUS.HeaderText = "Status";
            this.JOB_STATUS.Name = "JOB_STATUS";
            this.JOB_STATUS.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pnlEmailNotification);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.cboJobFrequency);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(324, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 539);
            this.panel1.TabIndex = 26;
            // 
            // pnlEmailNotification
            // 
            this.pnlEmailNotification.Controls.Add(this.label27);
            this.pnlEmailNotification.Controls.Add(this.label28);
            this.pnlEmailNotification.Controls.Add(this.textBox13);
            this.pnlEmailNotification.Controls.Add(this.textBox14);
            this.pnlEmailNotification.Controls.Add(this.label29);
            this.pnlEmailNotification.Controls.Add(this.label30);
            this.pnlEmailNotification.Controls.Add(this.textBox15);
            this.pnlEmailNotification.Controls.Add(this.checkBox12);
            this.pnlEmailNotification.Controls.Add(this.label31);
            this.pnlEmailNotification.Controls.Add(this.label32);
            this.pnlEmailNotification.Location = new System.Drawing.Point(13, 337);
            this.pnlEmailNotification.Name = "pnlEmailNotification";
            this.pnlEmailNotification.Size = new System.Drawing.Size(538, 159);
            this.pnlEmailNotification.TabIndex = 28;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(271, 106);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 18);
            this.label27.TabIndex = 34;
            this.label27.Text = "minutes";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(32, 106);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(179, 18);
            this.label28.TabIndex = 33;
            this.label28.Text = "Check for job failure during last";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(214, 104);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(51, 22);
            this.textBox13.TabIndex = 32;
            this.textBox13.Text = "60";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(35, 64);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox14.Size = new System.Drawing.Size(495, 36);
            this.textBox14.TabIndex = 31;
            this.textBox14.Text = "00:00, 01:00, 02:00, 03:00, 12:00, 14:45, 15:00, 16:15, 18:30";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(32, 43);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(292, 19);
            this.label29.TabIndex = 30;
            this.label29.Text = "Check for job failure on the following time interval";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(32, 133);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(326, 18);
            this.label30.TabIndex = 29;
            this.label30.Text = "Send email only if count of failure occurences are at least:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(364, 131);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(51, 22);
            this.textBox15.TabIndex = 28;
            this.textBox15.Text = "1";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(9, 22);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(177, 17);
            this.checkBox12.TabIndex = 26;
            this.checkBox12.Text = "Enable Failure Email Notification";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(2, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 14);
            this.label31.TabIndex = 25;
            this.label31.Text = "Email Notification";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(103, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(427, 2);
            this.label32.TabIndex = 24;
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Server",
            "Oracle DB",
            "SQL Server DB"});
            this.comboBox1.Location = new System.Drawing.Point(127, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Entity Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CPU",
            "Memory",
            "Storage"});
            this.comboBox2.Location = new System.Drawing.Point(127, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 18);
            this.label14.TabIndex = 42;
            this.label14.Text = "Parameter";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmJobsNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.Controls.Add(this.gvPushJobs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmJobsNotifications";
            this.Text = "Notification Jobs";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPushJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEmailNotification.ResumeLayout(false);
            this.pnlEmailNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboJobFrequency;
        private System.Windows.Forms.ToolStripButton tsbActivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnJobLocation;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolStripButton btnJobStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnJobStop;
        private System.Windows.Forms.DataGridView gvPushJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_STATUS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEmailNotification;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
    }
}