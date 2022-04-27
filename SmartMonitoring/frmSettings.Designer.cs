namespace SmartMonitoring
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.savetxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlsmtpsettings = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SET_KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSettingsList = new System.Windows.Forms.DataGridView();
            this.hosttxt = new System.Windows.Forms.TextBox();
            this.porttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendernametxt = new System.Windows.Forms.TextBox();
            this.pnlsmtpsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSettingsList)).BeginInit();
            this.SuspendLayout();
            // 
            // savetxt
            // 
            this.savetxt.Location = new System.Drawing.Point(620, 461);
            this.savetxt.Name = "savetxt";
            this.savetxt.Size = new System.Drawing.Size(92, 23);
            this.savetxt.TabIndex = 25;
            this.savetxt.Text = "OK";
            this.savetxt.UseVisualStyleBackColor = true;
            this.savetxt.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlsmtpsettings
            // 
            this.pnlsmtpsettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsmtpsettings.Controls.Add(this.label1);
            this.pnlsmtpsettings.Controls.Add(this.sendernametxt);
            this.pnlsmtpsettings.Controls.Add(this.label7);
            this.pnlsmtpsettings.Controls.Add(this.label6);
            this.pnlsmtpsettings.Controls.Add(this.passwordtxt);
            this.pnlsmtpsettings.Controls.Add(this.emailtxt);
            this.pnlsmtpsettings.Controls.Add(this.label5);
            this.pnlsmtpsettings.Controls.Add(this.label4);
            this.pnlsmtpsettings.Controls.Add(this.porttxt);
            this.pnlsmtpsettings.Controls.Add(this.hosttxt);
            this.pnlsmtpsettings.Location = new System.Drawing.Point(242, 16);
            this.pnlsmtpsettings.Name = "pnlsmtpsettings";
            this.pnlsmtpsettings.Size = new System.Drawing.Size(571, 439);
            this.pnlsmtpsettings.TabIndex = 27;
            this.pnlsmtpsettings.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 220;
            // 
            // SET_KEY
            // 
            this.SET_KEY.DataPropertyName = "SET_KEY";
            this.SET_KEY.HeaderText = "SET_KEY";
            this.SET_KEY.Name = "SET_KEY";
            this.SET_KEY.ReadOnly = true;
            this.SET_KEY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SET_KEY.Visible = false;
            this.SET_KEY.Width = 15;
            // 
            // gvSettingsList
            // 
            this.gvSettingsList.AllowUserToAddRows = false;
            this.gvSettingsList.AllowUserToDeleteRows = false;
            this.gvSettingsList.BackgroundColor = System.Drawing.Color.White;
            this.gvSettingsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSettingsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSettingsList.ColumnHeadersVisible = false;
            this.gvSettingsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SET_KEY,
            this.Description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSettingsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvSettingsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvSettingsList.Location = new System.Drawing.Point(11, 11);
            this.gvSettingsList.Name = "gvSettingsList";
            this.gvSettingsList.ReadOnly = true;
            this.gvSettingsList.RowHeadersVisible = false;
            this.gvSettingsList.RowTemplate.Height = 30;
            this.gvSettingsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSettingsList.ShowEditingIcon = false;
            this.gvSettingsList.Size = new System.Drawing.Size(225, 441);
            this.gvSettingsList.TabIndex = 26;
            this.gvSettingsList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSettingsList_RowEnter);
            // 
            // hosttxt
            // 
            this.hosttxt.AllowDrop = true;
            this.hosttxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosttxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hosttxt.Location = new System.Drawing.Point(100, 16);
            this.hosttxt.Name = "hosttxt";
            this.hosttxt.Size = new System.Drawing.Size(305, 23);
            this.hosttxt.TabIndex = 25;
            this.hosttxt.TabStop = false;
            // 
            // porttxt
            // 
            this.porttxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porttxt.Location = new System.Drawing.Point(100, 44);
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(305, 23);
            this.porttxt.TabIndex = 27;
            this.porttxt.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Host Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailtxt
            // 
            this.emailtxt.AllowDrop = true;
            this.emailtxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.emailtxt.Location = new System.Drawing.Point(100, 73);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(305, 23);
            this.emailtxt.TabIndex = 29;
            this.emailtxt.TabStop = false;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(100, 107);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(305, 23);
            this.passwordtxt.TabIndex = 31;
            this.passwordtxt.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sender Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sendernametxt
            // 
            this.sendernametxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendernametxt.Location = new System.Drawing.Point(98, 139);
            this.sendernametxt.Name = "sendernametxt";
            this.sendernametxt.Size = new System.Drawing.Size(305, 23);
            this.sendernametxt.TabIndex = 33;
            this.sendernametxt.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 492);
            this.Controls.Add(this.savetxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlsmtpsettings);
            this.Controls.Add(this.gvSettingsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlsmtpsettings.ResumeLayout(false);
            this.pnlsmtpsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSettingsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button savetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlsmtpsettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn SET_KEY;
        private System.Windows.Forms.DataGridView gvSettingsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendernametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.TextBox hosttxt;
    }
}