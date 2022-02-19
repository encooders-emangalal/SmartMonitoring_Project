namespace SmartMonitoring
{
    partial class AddAction
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
            this.cbRuleField = new System.Windows.Forms.ComboBox();
            this.cbRuleMathSymbol = new System.Windows.Forms.ComboBox();
            this.nudRuleValue = new System.Windows.Forms.NumericUpDown();
            this.cbOccureType = new System.Windows.Forms.ComboBox();
            this.nudOccuranceInterval = new System.Windows.Forms.NumericUpDown();
            this.cbDisplayLevel = new System.Windows.Forms.ComboBox();
            this.cbNotification = new System.Windows.Forms.ComboBox();
            this.txtNotification = new System.Windows.Forms.TextBox();
            this.btnNotification = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cbExAction = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOccuranceInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRuleField
            // 
            this.cbRuleField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRuleField.DisplayMember = "sgsrhrs";
            this.cbRuleField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuleField.FormattingEnabled = true;
            this.cbRuleField.Items.AddRange(new object[] {
            "If Current Value",
            "If Average Value",
            "If Maximum Value",
            "If Minimum Value"});
            this.cbRuleField.Location = new System.Drawing.Point(12, 12);
            this.cbRuleField.Name = "cbRuleField";
            this.cbRuleField.Size = new System.Drawing.Size(207, 26);
            this.cbRuleField.TabIndex = 0;
            this.cbRuleField.ValueMember = "sgsrhrs";
            // 
            // cbRuleMathSymbol
            // 
            this.cbRuleMathSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRuleMathSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuleMathSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuleMathSymbol.FormattingEnabled = true;
            this.cbRuleMathSymbol.Items.AddRange(new object[] {
            "More Than",
            "Less Than",
            "Equals",
            "Not Equal"});
            this.cbRuleMathSymbol.Location = new System.Drawing.Point(225, 12);
            this.cbRuleMathSymbol.Name = "cbRuleMathSymbol";
            this.cbRuleMathSymbol.Size = new System.Drawing.Size(158, 26);
            this.cbRuleMathSymbol.TabIndex = 1;
            // 
            // nudRuleValue
            // 
            this.nudRuleValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRuleValue.Location = new System.Drawing.Point(389, 14);
            this.nudRuleValue.Name = "nudRuleValue";
            this.nudRuleValue.Size = new System.Drawing.Size(127, 22);
            this.nudRuleValue.TabIndex = 2;
            // 
            // cbOccureType
            // 
            this.cbOccureType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOccureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOccureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOccureType.FormattingEnabled = true;
            this.cbOccureType.Items.AddRange(new object[] {
            "For n Occurance",
            "For Specific Period of Time(in Second)"});
            this.cbOccureType.Location = new System.Drawing.Point(12, 53);
            this.cbOccureType.Name = "cbOccureType";
            this.cbOccureType.Size = new System.Drawing.Size(371, 26);
            this.cbOccureType.TabIndex = 3;
            // 
            // nudOccuranceInterval
            // 
            this.nudOccuranceInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOccuranceInterval.Location = new System.Drawing.Point(389, 56);
            this.nudOccuranceInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOccuranceInterval.Name = "nudOccuranceInterval";
            this.nudOccuranceInterval.Size = new System.Drawing.Size(127, 22);
            this.nudOccuranceInterval.TabIndex = 4;
            this.nudOccuranceInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDisplayLevel
            // 
            this.cbDisplayLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisplayLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplayLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisplayLevel.FormattingEnabled = true;
            this.cbDisplayLevel.Items.AddRange(new object[] {
            "Show Error",
            "Show Warning",
            "Show Message"});
            this.cbDisplayLevel.Location = new System.Drawing.Point(13, 94);
            this.cbDisplayLevel.Name = "cbDisplayLevel";
            this.cbDisplayLevel.Size = new System.Drawing.Size(504, 26);
            this.cbDisplayLevel.TabIndex = 5;
            // 
            // cbNotification
            // 
            this.cbNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNotification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotification.FormattingEnabled = true;
            this.cbNotification.Items.AddRange(new object[] {
            "No Action",
            "Play Notification Sound",
            "Send HTML E-mail Notification",
            "Send Text E-mail Notification"});
            this.cbNotification.Location = new System.Drawing.Point(13, 138);
            this.cbNotification.Name = "cbNotification";
            this.cbNotification.Size = new System.Drawing.Size(271, 26);
            this.cbNotification.TabIndex = 6;
            this.cbNotification.SelectedIndexChanged += new System.EventHandler(this.cbNotification_SelectedIndexChanged);
            // 
            // txtNotification
            // 
            this.txtNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotification.Location = new System.Drawing.Point(293, 138);
            this.txtNotification.Multiline = true;
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(191, 27);
            this.txtNotification.TabIndex = 7;
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotification.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.Location = new System.Drawing.Point(487, 138);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(30, 28);
            this.btnNotification.TabIndex = 8;
            this.btnNotification.Text = "...";
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 176);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(503, 1);
            this.label21.TabIndex = 32;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbExAction
            // 
            this.cbExAction.AutoSize = true;
            this.cbExAction.Location = new System.Drawing.Point(14, 198);
            this.cbExAction.Name = "cbExAction";
            this.cbExAction.Size = new System.Drawing.Size(123, 21);
            this.cbExAction.TabIndex = 33;
            this.cbExAction.Text = "Execute Action";
            this.cbExAction.UseVisualStyleBackColor = true;
            this.cbExAction.Visible = false;
            this.cbExAction.CheckedChanged += new System.EventHandler(this.cbExAction_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 37);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(343, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 37);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 234);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbExAction);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.txtNotification);
            this.Controls.Add(this.cbNotification);
            this.Controls.Add(this.cbDisplayLevel);
            this.Controls.Add(this.nudOccuranceInterval);
            this.Controls.Add(this.cbOccureType);
            this.Controls.Add(this.nudRuleValue);
            this.Controls.Add(this.cbRuleMathSymbol);
            this.Controls.Add(this.cbRuleField);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 281);
            this.Name = "AddAction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Action";
            this.Load += new System.EventHandler(this.AddAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRuleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOccuranceInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRuleField;
        private System.Windows.Forms.ComboBox cbRuleMathSymbol;
        private System.Windows.Forms.NumericUpDown nudRuleValue;
        private System.Windows.Forms.ComboBox cbOccureType;
        private System.Windows.Forms.NumericUpDown nudOccuranceInterval;
        private System.Windows.Forms.ComboBox cbDisplayLevel;
        private System.Windows.Forms.ComboBox cbNotification;
        private System.Windows.Forms.TextBox txtNotification;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbExAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}