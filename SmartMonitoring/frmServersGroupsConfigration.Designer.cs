namespace SmartMonitoring
{
    partial class frmServersGroupsConfigration
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
            this.savebtn = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.gvServersGroups = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvServersGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(313, 26);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(60, 28);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(225, 20);
            this.nametxt.TabIndex = 6;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(9, 31);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(35, 13);
            this.lbname.TabIndex = 5;
            this.lbname.Text = "Name";
            // 
            // gvServersGroups
            // 
            this.gvServersGroups.AllowUserToAddRows = false;
            this.gvServersGroups.AllowUserToDeleteRows = false;
            this.gvServersGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServersGroups.Location = new System.Drawing.Point(12, 100);
            this.gvServersGroups.Name = "gvServersGroups";
            this.gvServersGroups.ReadOnly = true;
            this.gvServersGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvServersGroups.Size = new System.Drawing.Size(423, 282);
            this.gvServersGroups.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmServersGroupsConfigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvServersGroups);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.lbname);
            this.Name = "frmServersGroupsConfigration";
            this.Text = "Servers Groups Configration";
            this.Load += new System.EventHandler(this.frmServersGroupsConfigration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvServersGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.DataGridView gvServersGroups;
        private System.Windows.Forms.Button button1;
    }
}