namespace SmartMonitoring
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PCounter0 = new System.Diagnostics.PerformanceCounter();
            this.lblProcessorUtilization = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProcessorSpeed = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblProcessorBaseSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProcessorProcessesCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProcessorThreadsCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProcessorUpTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.cboCounters = new System.Windows.Forms.ComboBox();
            this.cboInstances = new System.Windows.Forms.ComboBox();
            this.btnDisplayCounterResult = new System.Windows.Forms.Button();
            this.lblCounterResult = new System.Windows.Forms.Label();
            this.lblHDDFreeSpace = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHDDTotalSpace = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMemoryTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMemoryAvailable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMemoryUsed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProcessorId = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblProcessorName = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblProcessorCoresCount = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblProcessorCoresEnabledCount = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblProcessorLogicalCount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblProcessorMaxClockSpeed = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblProcessorLoadPercentage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCounter0)).BeginInit();
            this.SuspendLayout();
            // 
            // PCounter0
            // 
            this.PCounter0.CategoryName = "Memory";
            this.PCounter0.CounterName = "Available MBytes";
            // 
            // lblProcessorUtilization
            // 
            this.lblProcessorUtilization.AutoSize = true;
            this.lblProcessorUtilization.Location = new System.Drawing.Point(155, 172);
            this.lblProcessorUtilization.Name = "lblProcessorUtilization";
            this.lblProcessorUtilization.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorUtilization.TabIndex = 0;
            this.lblProcessorUtilization.Text = "#";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Processor Utilization:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Processor Speed";
            // 
            // lblProcessorSpeed
            // 
            this.lblProcessorSpeed.AutoSize = true;
            this.lblProcessorSpeed.Location = new System.Drawing.Point(155, 192);
            this.lblProcessorSpeed.Name = "lblProcessorSpeed";
            this.lblProcessorSpeed.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorSpeed.TabIndex = 4;
            this.lblProcessorSpeed.Text = "#";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblProcessorBaseSpeed
            // 
            this.lblProcessorBaseSpeed.AutoSize = true;
            this.lblProcessorBaseSpeed.Location = new System.Drawing.Point(155, 212);
            this.lblProcessorBaseSpeed.Name = "lblProcessorBaseSpeed";
            this.lblProcessorBaseSpeed.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorBaseSpeed.TabIndex = 6;
            this.lblProcessorBaseSpeed.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Processor Base Speed";
            // 
            // lblProcessorProcessesCount
            // 
            this.lblProcessorProcessesCount.AutoSize = true;
            this.lblProcessorProcessesCount.Location = new System.Drawing.Point(155, 231);
            this.lblProcessorProcessesCount.Name = "lblProcessorProcessesCount";
            this.lblProcessorProcessesCount.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorProcessesCount.TabIndex = 8;
            this.lblProcessorProcessesCount.Text = "#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Processor Processes Count";
            // 
            // lblProcessorThreadsCount
            // 
            this.lblProcessorThreadsCount.AutoSize = true;
            this.lblProcessorThreadsCount.Location = new System.Drawing.Point(155, 251);
            this.lblProcessorThreadsCount.Name = "lblProcessorThreadsCount";
            this.lblProcessorThreadsCount.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorThreadsCount.TabIndex = 10;
            this.lblProcessorThreadsCount.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Processor Threads Count";
            // 
            // lblProcessorUpTime
            // 
            this.lblProcessorUpTime.AutoSize = true;
            this.lblProcessorUpTime.Location = new System.Drawing.Point(155, 271);
            this.lblProcessorUpTime.Name = "lblProcessorUpTime";
            this.lblProcessorUpTime.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorUpTime.TabIndex = 12;
            this.lblProcessorUpTime.Text = "#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Processor Up Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "#";
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(72, 12);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(283, 21);
            this.cboCategories.TabIndex = 14;
            this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
            // 
            // cboCounters
            // 
            this.cboCounters.FormattingEnabled = true;
            this.cboCounters.Location = new System.Drawing.Point(72, 66);
            this.cboCounters.Name = "cboCounters";
            this.cboCounters.Size = new System.Drawing.Size(283, 21);
            this.cboCounters.TabIndex = 15;
            // 
            // cboInstances
            // 
            this.cboInstances.FormattingEnabled = true;
            this.cboInstances.Location = new System.Drawing.Point(72, 39);
            this.cboInstances.Name = "cboInstances";
            this.cboInstances.Size = new System.Drawing.Size(283, 21);
            this.cboInstances.TabIndex = 16;
            // 
            // btnDisplayCounterResult
            // 
            this.btnDisplayCounterResult.Location = new System.Drawing.Point(15, 93);
            this.btnDisplayCounterResult.Name = "btnDisplayCounterResult";
            this.btnDisplayCounterResult.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayCounterResult.TabIndex = 17;
            this.btnDisplayCounterResult.Text = "GET";
            this.btnDisplayCounterResult.UseVisualStyleBackColor = true;
            this.btnDisplayCounterResult.Click += new System.EventHandler(this.btnDisplayCounterResult_Click);
            // 
            // lblCounterResult
            // 
            this.lblCounterResult.AutoSize = true;
            this.lblCounterResult.Location = new System.Drawing.Point(104, 98);
            this.lblCounterResult.Name = "lblCounterResult";
            this.lblCounterResult.Size = new System.Drawing.Size(15, 13);
            this.lblCounterResult.TabIndex = 18;
            this.lblCounterResult.Text = "#";
            // 
            // lblHDDFreeSpace
            // 
            this.lblHDDFreeSpace.AutoSize = true;
            this.lblHDDFreeSpace.Location = new System.Drawing.Point(155, 386);
            this.lblHDDFreeSpace.Name = "lblHDDFreeSpace";
            this.lblHDDFreeSpace.Size = new System.Drawing.Size(15, 13);
            this.lblHDDFreeSpace.TabIndex = 20;
            this.lblHDDFreeSpace.Text = "#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Free Space";
            // 
            // lblHDDTotalSpace
            // 
            this.lblHDDTotalSpace.AutoSize = true;
            this.lblHDDTotalSpace.Location = new System.Drawing.Point(155, 369);
            this.lblHDDTotalSpace.Name = "lblHDDTotalSpace";
            this.lblHDDTotalSpace.Size = new System.Drawing.Size(15, 13);
            this.lblHDDTotalSpace.TabIndex = 22;
            this.lblHDDTotalSpace.Text = "#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total Space";
            // 
            // lblMemoryTotal
            // 
            this.lblMemoryTotal.AutoSize = true;
            this.lblMemoryTotal.Location = new System.Drawing.Point(155, 308);
            this.lblMemoryTotal.Name = "lblMemoryTotal";
            this.lblMemoryTotal.Size = new System.Drawing.Size(15, 13);
            this.lblMemoryTotal.TabIndex = 24;
            this.lblMemoryTotal.Text = "#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Memory Total:";
            // 
            // lblMemoryAvailable
            // 
            this.lblMemoryAvailable.AutoSize = true;
            this.lblMemoryAvailable.Location = new System.Drawing.Point(155, 343);
            this.lblMemoryAvailable.Name = "lblMemoryAvailable";
            this.lblMemoryAvailable.Size = new System.Drawing.Size(15, 13);
            this.lblMemoryAvailable.TabIndex = 26;
            this.lblMemoryAvailable.Text = "#";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Memory Available:";
            // 
            // lblMemoryUsed
            // 
            this.lblMemoryUsed.AutoSize = true;
            this.lblMemoryUsed.Location = new System.Drawing.Point(155, 325);
            this.lblMemoryUsed.Name = "lblMemoryUsed";
            this.lblMemoryUsed.Size = new System.Drawing.Size(15, 13);
            this.lblMemoryUsed.TabIndex = 28;
            this.lblMemoryUsed.Text = "#";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Memory Used:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Processor Id:";
            // 
            // lblProcessorId
            // 
            this.lblProcessorId.AutoSize = true;
            this.lblProcessorId.Location = new System.Drawing.Point(557, 179);
            this.lblProcessorId.Name = "lblProcessorId";
            this.lblProcessorId.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorId.TabIndex = 29;
            this.lblProcessorId.Text = "#";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "System Name:";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Location = new System.Drawing.Point(557, 161);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(15, 13);
            this.lblSystemName.TabIndex = 31;
            this.lblSystemName.Text = "#";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(414, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Processor Name:";
            // 
            // lblProcessorName
            // 
            this.lblProcessorName.AutoSize = true;
            this.lblProcessorName.Location = new System.Drawing.Point(557, 199);
            this.lblProcessorName.Name = "lblProcessorName";
            this.lblProcessorName.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorName.TabIndex = 33;
            this.lblProcessorName.Text = "#";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(414, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "NumberOfCores:";
            // 
            // lblProcessorCoresCount
            // 
            this.lblProcessorCoresCount.AutoSize = true;
            this.lblProcessorCoresCount.Location = new System.Drawing.Point(557, 219);
            this.lblProcessorCoresCount.Name = "lblProcessorCoresCount";
            this.lblProcessorCoresCount.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorCoresCount.TabIndex = 35;
            this.lblProcessorCoresCount.Text = "#";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(414, 247);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "NumberOfEnabledCores:";
            // 
            // lblProcessorCoresEnabledCount
            // 
            this.lblProcessorCoresEnabledCount.AutoSize = true;
            this.lblProcessorCoresEnabledCount.Location = new System.Drawing.Point(557, 247);
            this.lblProcessorCoresEnabledCount.Name = "lblProcessorCoresEnabledCount";
            this.lblProcessorCoresEnabledCount.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorCoresEnabledCount.TabIndex = 37;
            this.lblProcessorCoresEnabledCount.Text = "#";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(414, 269);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "NumberOfLogicalProcessors:";
            // 
            // lblProcessorLogicalCount
            // 
            this.lblProcessorLogicalCount.AutoSize = true;
            this.lblProcessorLogicalCount.Location = new System.Drawing.Point(557, 269);
            this.lblProcessorLogicalCount.Name = "lblProcessorLogicalCount";
            this.lblProcessorLogicalCount.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorLogicalCount.TabIndex = 39;
            this.lblProcessorLogicalCount.Text = "#";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(414, 291);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "MaxClockSpeed:";
            // 
            // lblProcessorMaxClockSpeed
            // 
            this.lblProcessorMaxClockSpeed.AutoSize = true;
            this.lblProcessorMaxClockSpeed.Location = new System.Drawing.Point(557, 291);
            this.lblProcessorMaxClockSpeed.Name = "lblProcessorMaxClockSpeed";
            this.lblProcessorMaxClockSpeed.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorMaxClockSpeed.TabIndex = 41;
            this.lblProcessorMaxClockSpeed.Text = "#";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(414, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "LoadPercentage:";
            // 
            // lblProcessorLoadPercentage
            // 
            this.lblProcessorLoadPercentage.AutoSize = true;
            this.lblProcessorLoadPercentage.Location = new System.Drawing.Point(557, 311);
            this.lblProcessorLoadPercentage.Name = "lblProcessorLoadPercentage";
            this.lblProcessorLoadPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblProcessorLoadPercentage.TabIndex = 43;
            this.lblProcessorLoadPercentage.Text = "#";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Category";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Instance";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Counter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 438);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblProcessorLoadPercentage);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblProcessorMaxClockSpeed);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblProcessorLogicalCount);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblProcessorCoresEnabledCount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblProcessorCoresCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblProcessorName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProcessorId);
            this.Controls.Add(this.lblMemoryUsed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMemoryAvailable);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblMemoryTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblHDDTotalSpace);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHDDFreeSpace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCounterResult);
            this.Controls.Add(this.btnDisplayCounterResult);
            this.Controls.Add(this.cboInstances);
            this.Controls.Add(this.cboCounters);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProcessorUpTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblProcessorThreadsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblProcessorProcessesCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProcessorBaseSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProcessorSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProcessorUtilization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCounter0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter PCounter0;
        private System.Windows.Forms.Label lblProcessorUtilization;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProcessorSpeed;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblProcessorBaseSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProcessorProcessesCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProcessorThreadsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProcessorUpTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.ComboBox cboCounters;
        private System.Windows.Forms.ComboBox cboInstances;
        private System.Windows.Forms.Button btnDisplayCounterResult;
        private System.Windows.Forms.Label lblCounterResult;
        private System.Windows.Forms.Label lblHDDFreeSpace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHDDTotalSpace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMemoryTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMemoryAvailable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMemoryUsed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProcessorId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblProcessorName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblProcessorCoresCount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblProcessorCoresEnabledCount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblProcessorLogicalCount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblProcessorMaxClockSpeed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblProcessorLoadPercentage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
    }
}

