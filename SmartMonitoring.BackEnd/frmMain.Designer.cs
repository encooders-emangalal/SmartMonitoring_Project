namespace SmartMonitoring.BackEnd
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblActiveFormTitle = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.pnlServersList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(670, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Location = new System.Drawing.Point(170, 38);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(707, 366);
            this.pnlChildForm.TabIndex = 4;
            // 
            // lblActiveFormTitle
            // 
            this.lblActiveFormTitle.AutoSize = true;
            this.lblActiveFormTitle.Location = new System.Drawing.Point(168, 21);
            this.lblActiveFormTitle.Name = "lblActiveFormTitle";
            this.lblActiveFormTitle.Size = new System.Drawing.Size(15, 13);
            this.lblActiveFormTitle.TabIndex = 5;
            this.lblActiveFormTitle.Text = "#";
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(180, 340);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(15, 13);
            this.lblMessage1.TabIndex = 6;
            this.lblMessage1.Tag = "SERV-00";
            this.lblMessage1.Text = "#";
            this.lblMessage1.Visible = false;
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(180, 382);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(15, 13);
            this.lblMessage2.TabIndex = 7;
            this.lblMessage2.Tag = "SERV-01";
            this.lblMessage2.Text = "#";
            this.lblMessage2.Visible = false;
            // 
            // pnlServersList
            // 
            this.pnlServersList.AutoScroll = true;
            this.pnlServersList.Location = new System.Drawing.Point(4, 37);
            this.pnlServersList.Name = "pnlServersList";
            this.pnlServersList.Size = new System.Drawing.Size(162, 367);
            this.pnlServersList.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(293, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 55);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Tag = "#";
            this.label2.Text = "#";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 410);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlServersList);
            this.Controls.Add(this.lblActiveFormTitle);
            this.Controls.Add(this.pnlChildForm);
            this.Name = "frmMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Label lblActiveFormTitle;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Panel pnlServersList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

