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
            this.lbname = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(26, 18);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(35, 13);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(26, 61);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(32, 13);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "Email";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(110, 18);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(225, 20);
            this.nametxt.TabIndex = 2;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(110, 58);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(225, 20);
            this.emailtxt.TabIndex = 3;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(416, 18);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // gvUsers
            // 
            this.gvUsers.AllowUserToAddRows = false;
            this.gvUsers.AllowUserToDeleteRows = false;
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Location = new System.Drawing.Point(12, 102);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.ReadOnly = true;
            this.gvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUsers.Size = new System.Drawing.Size(492, 326);
            this.gvUsers.TabIndex = 5;
            this.gvUsers.SelectionChanged += new System.EventHandler(this.gvUsers_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUserConfigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvUsers);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbname);
            this.Name = "frmUserConfigration";
            this.Text = "User Configration";
            this.Load += new System.EventHandler(this.frmUserConfigration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.Button button1;
    }
}