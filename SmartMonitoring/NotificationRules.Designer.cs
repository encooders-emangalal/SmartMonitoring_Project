namespace SmartMonitoring
{
    partial class NotificationRules
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvRules = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNotifText = new System.Windows.Forms.TextBox();
            this.txtActionId = new System.Windows.Forms.TextBox();
            this.txtDisplayLevel = new System.Windows.Forms.TextBox();
            this.txtROccureInterval = new System.Windows.Forms.TextBox();
            this.txtROccureType = new System.Windows.Forms.TextBox();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.txtRMathSymbol = new System.Windows.Forms.TextBox();
            this.txtRField = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this._Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ruleField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ruleMathSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._rukeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._occuranceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._occuranceInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._notificationTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rule_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRules)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rules";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(103, 291);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 335);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(748, 1);
            this.label21.TabIndex = 31;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(676, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 31);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvRules
            // 
            this.gvRules.AllowUserToAddRows = false;
            this.gvRules.AllowUserToDeleteRows = false;
            this.gvRules.AllowUserToResizeRows = false;
            this.gvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRules.BackgroundColor = System.Drawing.Color.White;
            this.gvRules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Condition,
            this._status,
            this._action,
            this._ruleField,
            this._ruleMathSymbol,
            this._rukeValue,
            this._occuranceType,
            this._occuranceInterval,
            this._notificationTxt,
            this.displayLevel,
            this.actionId,
            this.rule_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvRules.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvRules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gvRules.Location = new System.Drawing.Point(13, 33);
            this.gvRules.Margin = new System.Windows.Forms.Padding(4);
            this.gvRules.MultiSelect = false;
            this.gvRules.Name = "gvRules";
            this.gvRules.ReadOnly = true;
            this.gvRules.RowHeadersVisible = false;
            this.gvRules.RowHeadersWidth = 25;
            this.gvRules.RowTemplate.Height = 30;
            this.gvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRules.ShowEditingIcon = false;
            this.gvRules.Size = new System.Drawing.Size(748, 251);
            this.gvRules.TabIndex = 34;
            this.gvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRules_CellClick);
            this.gvRules.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRules_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNotifText);
            this.panel1.Controls.Add(this.txtActionId);
            this.panel1.Controls.Add(this.txtDisplayLevel);
            this.panel1.Controls.Add(this.txtROccureInterval);
            this.panel1.Controls.Add(this.txtROccureType);
            this.panel1.Controls.Add(this.txtRValue);
            this.panel1.Controls.Add(this.txtRMathSymbol);
            this.panel1.Controls.Add(this.txtRField);
            this.panel1.Location = new System.Drawing.Point(358, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 185);
            this.panel1.TabIndex = 35;
            // 
            // txtNotifText
            // 
            this.txtNotifText.Location = new System.Drawing.Point(31, 163);
            this.txtNotifText.Name = "txtNotifText";
            this.txtNotifText.Size = new System.Drawing.Size(138, 22);
            this.txtNotifText.TabIndex = 7;
            // 
            // txtActionId
            // 
            this.txtActionId.Location = new System.Drawing.Point(31, 137);
            this.txtActionId.Name = "txtActionId";
            this.txtActionId.Size = new System.Drawing.Size(138, 22);
            this.txtActionId.TabIndex = 6;
            // 
            // txtDisplayLevel
            // 
            this.txtDisplayLevel.Location = new System.Drawing.Point(31, 109);
            this.txtDisplayLevel.Name = "txtDisplayLevel";
            this.txtDisplayLevel.Size = new System.Drawing.Size(138, 22);
            this.txtDisplayLevel.TabIndex = 5;
            // 
            // txtROccureInterval
            // 
            this.txtROccureInterval.Location = new System.Drawing.Point(31, 81);
            this.txtROccureInterval.Name = "txtROccureInterval";
            this.txtROccureInterval.Size = new System.Drawing.Size(138, 22);
            this.txtROccureInterval.TabIndex = 4;
            // 
            // txtROccureType
            // 
            this.txtROccureType.Location = new System.Drawing.Point(31, 58);
            this.txtROccureType.Name = "txtROccureType";
            this.txtROccureType.Size = new System.Drawing.Size(138, 22);
            this.txtROccureType.TabIndex = 3;
            // 
            // txtRValue
            // 
            this.txtRValue.Location = new System.Drawing.Point(31, 39);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.Size = new System.Drawing.Size(138, 22);
            this.txtRValue.TabIndex = 2;
            // 
            // txtRMathSymbol
            // 
            this.txtRMathSymbol.Location = new System.Drawing.Point(31, 18);
            this.txtRMathSymbol.Name = "txtRMathSymbol";
            this.txtRMathSymbol.Size = new System.Drawing.Size(138, 22);
            this.txtRMathSymbol.TabIndex = 1;
            // 
            // txtRField
            // 
            this.txtRField.Location = new System.Drawing.Point(31, 0);
            this.txtRField.Name = "txtRField";
            this.txtRField.Size = new System.Drawing.Size(138, 22);
            this.txtRField.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(586, 342);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 31);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // _Condition
            // 
            this._Condition.HeaderText = "Condition";
            this._Condition.MinimumWidth = 100;
            this._Condition.Name = "_Condition";
            this._Condition.ReadOnly = true;
            // 
            // _status
            // 
            this._status.HeaderText = "Status";
            this._status.MinimumWidth = 50;
            this._status.Name = "_status";
            this._status.ReadOnly = true;
            // 
            // _action
            // 
            this._action.HeaderText = "Action";
            this._action.MinimumWidth = 50;
            this._action.Name = "_action";
            this._action.ReadOnly = true;
            // 
            // _ruleField
            // 
            this._ruleField.HeaderText = "Rule Field";
            this._ruleField.MinimumWidth = 6;
            this._ruleField.Name = "_ruleField";
            this._ruleField.ReadOnly = true;
            // 
            // _ruleMathSymbol
            // 
            this._ruleMathSymbol.HeaderText = "Rule Math Symbol";
            this._ruleMathSymbol.MinimumWidth = 6;
            this._ruleMathSymbol.Name = "_ruleMathSymbol";
            this._ruleMathSymbol.ReadOnly = true;
            // 
            // _rukeValue
            // 
            this._rukeValue.HeaderText = "Rule Value";
            this._rukeValue.MinimumWidth = 6;
            this._rukeValue.Name = "_rukeValue";
            this._rukeValue.ReadOnly = true;
            // 
            // _occuranceType
            // 
            this._occuranceType.HeaderText = "Occurance Type";
            this._occuranceType.MinimumWidth = 6;
            this._occuranceType.Name = "_occuranceType";
            this._occuranceType.ReadOnly = true;
            // 
            // _occuranceInterval
            // 
            this._occuranceInterval.HeaderText = "Occurance Interval";
            this._occuranceInterval.MinimumWidth = 6;
            this._occuranceInterval.Name = "_occuranceInterval";
            this._occuranceInterval.ReadOnly = true;
            // 
            // _notificationTxt
            // 
            this._notificationTxt.HeaderText = "Notification Text";
            this._notificationTxt.MinimumWidth = 6;
            this._notificationTxt.Name = "_notificationTxt";
            this._notificationTxt.ReadOnly = true;
            // 
            // displayLevel
            // 
            this.displayLevel.HeaderText = "Display Level";
            this.displayLevel.MinimumWidth = 6;
            this.displayLevel.Name = "displayLevel";
            this.displayLevel.ReadOnly = true;
            // 
            // actionId
            // 
            this.actionId.HeaderText = "Action ID";
            this.actionId.MinimumWidth = 6;
            this.actionId.Name = "actionId";
            this.actionId.ReadOnly = true;
            // 
            // rule_id
            // 
            this.rule_id.HeaderText = "Rule ID";
            this.rule_id.MinimumWidth = 6;
            this.rule_id.Name = "rule_id";
            this.rule_id.ReadOnly = true;
            // 
            // NotificationRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(772, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvRules);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 426);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 426);
            this.Name = "NotificationRules";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Name - Edit Counter";
            this.Load += new System.EventHandler(this.EditCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRules)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gvRules;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRMathSymbol;
        private System.Windows.Forms.TextBox txtRField;
        private System.Windows.Forms.TextBox txtNotifText;
        private System.Windows.Forms.TextBox txtActionId;
        private System.Windows.Forms.TextBox txtDisplayLevel;
        private System.Windows.Forms.TextBox txtROccureType;
        private System.Windows.Forms.TextBox txtROccureInterval;
        private System.Windows.Forms.TextBox txtRValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
        private System.Windows.Forms.DataGridViewTextBoxColumn _action;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ruleField;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ruleMathSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn _rukeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn _occuranceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _occuranceInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn _notificationTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rule_id;
    }
}