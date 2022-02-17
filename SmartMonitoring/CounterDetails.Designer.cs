namespace SmartMonitoring
{
    partial class CounterDetails
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
            this.txtCounterDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCounterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCounterUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObjectPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstanceId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInstanceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCounterDescription
            // 
            this.txtCounterDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounterDescription.Location = new System.Drawing.Point(199, 52);
            this.txtCounterDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounterDescription.Name = "txtCounterDescription";
            this.txtCounterDescription.ReadOnly = true;
            this.txtCounterDescription.Size = new System.Drawing.Size(509, 26);
            this.txtCounterDescription.TabIndex = 47;
            this.txtCounterDescription.Text = "CPU Usage";
            this.txtCounterDescription.TextChanged += new System.EventHandler(this.txtCounterDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Counter Description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCounterName
            // 
            this.txtCounterName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounterName.Location = new System.Drawing.Point(199, 100);
            this.txtCounterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounterName.Name = "txtCounterName";
            this.txtCounterName.ReadOnly = true;
            this.txtCounterName.Size = new System.Drawing.Size(509, 26);
            this.txtCounterName.TabIndex = 49;
            this.txtCounterName.Text = "% Processor Time";
            this.txtCounterName.TextChanged += new System.EventHandler(this.txtCounterName_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Counter Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCounterUnit
            // 
            this.txtCounterUnit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounterUnit.Location = new System.Drawing.Point(199, 148);
            this.txtCounterUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounterUnit.Name = "txtCounterUnit";
            this.txtCounterUnit.ReadOnly = true;
            this.txtCounterUnit.Size = new System.Drawing.Size(509, 26);
            this.txtCounterUnit.TabIndex = 51;
            this.txtCounterUnit.Text = "%";
            this.txtCounterUnit.TextChanged += new System.EventHandler(this.txtCounterUnit_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Counter Unit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObjectPrefix
            // 
            this.txtObjectPrefix.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjectPrefix.Location = new System.Drawing.Point(199, 201);
            this.txtObjectPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtObjectPrefix.Name = "txtObjectPrefix";
            this.txtObjectPrefix.ReadOnly = true;
            this.txtObjectPrefix.Size = new System.Drawing.Size(509, 26);
            this.txtObjectPrefix.TabIndex = 53;
            this.txtObjectPrefix.Text = "CPU";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "Object Prefix:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInstanceId
            // 
            this.txtInstanceId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstanceId.Location = new System.Drawing.Point(199, 253);
            this.txtInstanceId.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstanceId.Name = "txtInstanceId";
            this.txtInstanceId.ReadOnly = true;
            this.txtInstanceId.Size = new System.Drawing.Size(509, 26);
            this.txtInstanceId.TabIndex = 55;
            this.txtInstanceId.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Instance ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInstanceName
            // 
            this.txtInstanceName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstanceName.Location = new System.Drawing.Point(199, 304);
            this.txtInstanceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstanceName.Name = "txtInstanceName";
            this.txtInstanceName.ReadOnly = true;
            this.txtInstanceName.Size = new System.Drawing.Size(509, 26);
            this.txtInstanceName.TabIndex = 57;
            this.txtInstanceName.Text = "CPU 0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 26);
            this.label6.TabIndex = 56;
            this.label6.Text = "Instance Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 352);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(695, 2);
            this.label10.TabIndex = 58;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(611, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 32);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CounterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 416);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInstanceName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInstanceId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObjectPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCounterUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCounterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCounterDescription);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(739, 463);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(739, 463);
            this.Name = "CounterDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCounterDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCounterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCounterUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObjectPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstanceId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInstanceName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
    }
}