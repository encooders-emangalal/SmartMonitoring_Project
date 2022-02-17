namespace SmartMonitoring
{
    partial class SelectNotificationSound
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
            this.dataGridViewSoundName = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.soundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoundName)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSoundName
            // 
            this.dataGridViewSoundName.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSoundName.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSoundName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoundName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soundName});
            this.dataGridViewSoundName.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSoundName.MultiSelect = false;
            this.dataGridViewSoundName.Name = "dataGridViewSoundName";
            this.dataGridViewSoundName.RowHeadersVisible = false;
            this.dataGridViewSoundName.RowHeadersWidth = 51;
            this.dataGridViewSoundName.RowTemplate.Height = 24;
            this.dataGridViewSoundName.Size = new System.Drawing.Size(476, 212);
            this.dataGridViewSoundName.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 236);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(476, 1);
            this.label21.TabIndex = 32;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 250);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(84, 31);
            this.btnPlay.TabIndex = 34;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(314, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 31);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 31);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // soundName
            // 
            this.soundName.HeaderText = "Sound Name";
            this.soundName.MinimumWidth = 6;
            this.soundName.Name = "soundName";
            this.soundName.ReadOnly = true;
            this.soundName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soundName.Width = 120;
            // 
            // SelectNotificationSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dataGridViewSoundName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 339);
            this.Name = "SelectNotificationSound";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Notification Sound";
            this.Load += new System.EventHandler(this.SelectNotificationSound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoundName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSoundName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn soundName;
    }
}