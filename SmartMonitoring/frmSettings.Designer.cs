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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDailyFrequency = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pnlLogSettings = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.pnlFileDownload = new System.Windows.Forms.Panel();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlFileProcessing = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SET_KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSettingsList = new System.Windows.Forms.DataGridView();
            this.pnlEmailNotification = new System.Windows.Forms.Panel();
            this.pnlLogSettings.SuspendLayout();
            this.pnlFileDownload.SuspendLayout();
            this.pnlFileProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSettingsList)).BeginInit();
            this.pnlEmailNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Create new file every day";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 14);
            this.label13.TabIndex = 17;
            this.label13.Text = "Reading Files Jobs";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(108, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(453, 2);
            this.label14.TabIndex = 16;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "MB";
            // 
            // cboDailyFrequency
            // 
            this.cboDailyFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDailyFrequency.FormattingEnabled = true;
            this.cboDailyFrequency.Items.AddRange(new object[] {
            "Send notification email to vendor",
            "Block the gateway"});
            this.cboDailyFrequency.Location = new System.Drawing.Point(245, 333);
            this.cboDailyFrequency.Name = "cboDailyFrequency";
            this.cboDailyFrequency.Size = new System.Drawing.Size(196, 21);
            this.cboDailyFrequency.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Action to take";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "days";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(29, 333);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(44, 20);
            this.textBox8.TabIndex = 20;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(7, 312);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(434, 17);
            this.checkBox16.TabIndex = 19;
            this.checkBox16.Text = "Do not process readings if reading date is older than file date with specific thr" +
    "eashold";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "days";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(51, 117);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(44, 20);
            this.textBox9.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(29, 286);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(44, 20);
            this.textBox7.TabIndex = 17;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(7, 265);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(369, 17);
            this.checkBox15.TabIndex = 16;
            this.checkBox15.Text = "Do not process readings if reading date is older than specific threashold";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(7, 104);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(285, 17);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "Accept and process files from not approved gateways";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 81);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(257, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Accept and process files from inactive gateways";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 58);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(355, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Accept and process unencrypted files (RDS) from drive-by gateways";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Browse ...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(29, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(394, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Create new file if current file age (creation date) exceeded specific threshold";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "days";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(319, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Create new file if current file size exceeded specific threshold";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(7, 79);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(347, 17);
            this.checkBox14.TabIndex = 2;
            this.checkBox14.Text = "Rename files if found in backup folder by adding a timestamp suffix";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(457, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Location to move old files to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "days";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "percent to raise the alert if reached";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 5;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(330, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Raise alert if file content (lines count) is increased or decreased";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // pnlLogSettings
            // 
            this.pnlLogSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogSettings.Controls.Add(this.radioButton3);
            this.pnlLogSettings.Controls.Add(this.label10);
            this.pnlLogSettings.Controls.Add(this.textBox9);
            this.pnlLogSettings.Controls.Add(this.radioButton2);
            this.pnlLogSettings.Controls.Add(this.radioButton1);
            this.pnlLogSettings.Controls.Add(this.label13);
            this.pnlLogSettings.Controls.Add(this.label14);
            this.pnlLogSettings.Controls.Add(this.label11);
            this.pnlLogSettings.Controls.Add(this.textBox10);
            this.pnlLogSettings.Location = new System.Drawing.Point(441, 19);
            this.pnlLogSettings.Name = "pnlLogSettings";
            this.pnlLogSettings.Size = new System.Drawing.Size(571, 439);
            this.pnlLogSettings.TabIndex = 29;
            this.pnlLogSettings.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(51, 69);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(44, 20);
            this.textBox10.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(325, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Send failure email to the following accounts (separated by comma)";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(31, 60);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox11.Size = new System.Drawing.Size(532, 47);
            this.textBox11.TabIndex = 11;
            this.textBox11.Text = "malfifi@nwc.com.sa, mragab@nwc.com.sa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Run Email Notification job every";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 176);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(450, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Move files to another folder/thread if their creation date is older than specific" +
    " threashold";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(175, 13);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(44, 20);
            this.textBox12.TabIndex = 8;
            this.textBox12.Text = "5";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(339, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Accept and process unencrypted files (RDS) from fixed gateways";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(7, 56);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(238, 17);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Download files from not approved gateways";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(7, 33);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(210, 17);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Download files from inactive gateways";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "minutes between creation date and download date";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 123);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 20);
            this.textBox6.TabIndex = 5;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(7, 102);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(342, 17);
            this.checkBox12.TabIndex = 4;
            this.checkBox12.Text = "Download files only if their creation date is older specific threshold";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // pnlFileDownload
            // 
            this.pnlFileDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFileDownload.Controls.Add(this.checkBox8);
            this.pnlFileDownload.Controls.Add(this.checkBox9);
            this.pnlFileDownload.Controls.Add(this.label6);
            this.pnlFileDownload.Controls.Add(this.textBox6);
            this.pnlFileDownload.Controls.Add(this.checkBox12);
            this.pnlFileDownload.Controls.Add(this.checkBox13);
            this.pnlFileDownload.Controls.Add(this.checkBox14);
            this.pnlFileDownload.Location = new System.Drawing.Point(264, 26);
            this.pnlFileDownload.Name = "pnlFileDownload";
            this.pnlFileDownload.Size = new System.Drawing.Size(571, 439);
            this.pnlFileDownload.TabIndex = 28;
            this.pnlFileDownload.Visible = false;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(7, 10);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(216, 17);
            this.checkBox13.TabIndex = 3;
            this.checkBox13.Text = "Download files from unknown gateways";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(292, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Add new gateways automatically and process their files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(223, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "minutes";
            // 
            // pnlFileProcessing
            // 
            this.pnlFileProcessing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFileProcessing.Controls.Add(this.cboDailyFrequency);
            this.pnlFileProcessing.Controls.Add(this.label9);
            this.pnlFileProcessing.Controls.Add(this.label8);
            this.pnlFileProcessing.Controls.Add(this.textBox8);
            this.pnlFileProcessing.Controls.Add(this.checkBox16);
            this.pnlFileProcessing.Controls.Add(this.label7);
            this.pnlFileProcessing.Controls.Add(this.textBox7);
            this.pnlFileProcessing.Controls.Add(this.checkBox15);
            this.pnlFileProcessing.Controls.Add(this.checkBox7);
            this.pnlFileProcessing.Controls.Add(this.checkBox6);
            this.pnlFileProcessing.Controls.Add(this.checkBox5);
            this.pnlFileProcessing.Controls.Add(this.button3);
            this.pnlFileProcessing.Controls.Add(this.textBox3);
            this.pnlFileProcessing.Controls.Add(this.label3);
            this.pnlFileProcessing.Controls.Add(this.label2);
            this.pnlFileProcessing.Controls.Add(this.textBox2);
            this.pnlFileProcessing.Controls.Add(this.checkBox4);
            this.pnlFileProcessing.Controls.Add(this.label1);
            this.pnlFileProcessing.Controls.Add(this.textBox1);
            this.pnlFileProcessing.Controls.Add(this.checkBox3);
            this.pnlFileProcessing.Controls.Add(this.checkBox2);
            this.pnlFileProcessing.Controls.Add(this.checkBox1);
            this.pnlFileProcessing.Location = new System.Drawing.Point(762, 13);
            this.pnlFileProcessing.Name = "pnlFileProcessing";
            this.pnlFileProcessing.Size = new System.Drawing.Size(571, 439);
            this.pnlFileProcessing.TabIndex = 27;
            this.pnlFileProcessing.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSettingsList.DefaultCellStyle = dataGridViewCellStyle1;
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
            // pnlEmailNotification
            // 
            this.pnlEmailNotification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmailNotification.Controls.Add(this.label16);
            this.pnlEmailNotification.Controls.Add(this.textBox11);
            this.pnlEmailNotification.Controls.Add(this.label12);
            this.pnlEmailNotification.Controls.Add(this.label15);
            this.pnlEmailNotification.Controls.Add(this.textBox12);
            this.pnlEmailNotification.Location = new System.Drawing.Point(240, 13);
            this.pnlEmailNotification.Name = "pnlEmailNotification";
            this.pnlEmailNotification.Size = new System.Drawing.Size(571, 439);
            this.pnlEmailNotification.TabIndex = 30;
            this.pnlEmailNotification.Visible = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 492);
            this.Controls.Add(this.pnlLogSettings);
            this.Controls.Add(this.pnlFileDownload);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlFileProcessing);
            this.Controls.Add(this.gvSettingsList);
            this.Controls.Add(this.pnlEmailNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlLogSettings.ResumeLayout(false);
            this.pnlLogSettings.PerformLayout();
            this.pnlFileDownload.ResumeLayout(false);
            this.pnlFileDownload.PerformLayout();
            this.pnlFileProcessing.ResumeLayout(false);
            this.pnlFileProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSettingsList)).EndInit();
            this.pnlEmailNotification.ResumeLayout(false);
            this.pnlEmailNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDailyFrequency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel pnlLogSettings;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Panel pnlFileDownload;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlFileProcessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn SET_KEY;
        private System.Windows.Forms.DataGridView gvSettingsList;
        private System.Windows.Forms.Panel pnlEmailNotification;
    }
}