namespace HostelMS
{
    partial class FormLeavedEmps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbTRC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVLeftEmps = new System.Windows.Forms.DataGridView();
            this.LbHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLeftEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTRC
            // 
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbTRC.Location = new System.Drawing.Point(118, 610);
            this.LbTRC.Name = "LbTRC";
            this.LbTRC.Size = new System.Drawing.Size(32, 21);
            this.LbTRC.TabIndex = 77;
            this.LbTRC.Text = "{?}";
            this.LbTRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 78;
            this.label4.Text = "Total Rows:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVLeftEmps
            // 
            this.DGVLeftEmps.AllowUserToAddRows = false;
            this.DGVLeftEmps.AllowUserToDeleteRows = false;
            this.DGVLeftEmps.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVLeftEmps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLeftEmps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVLeftEmps.ColumnHeadersHeight = 34;
            this.DGVLeftEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVLeftEmps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVLeftEmps.EnableHeadersVisualStyles = false;
            this.DGVLeftEmps.Location = new System.Drawing.Point(7, 47);
            this.DGVLeftEmps.Name = "DGVLeftEmps";
            this.DGVLeftEmps.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLeftEmps.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVLeftEmps.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVLeftEmps.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVLeftEmps.RowTemplate.Height = 28;
            this.DGVLeftEmps.Size = new System.Drawing.Size(965, 550);
            this.DGVLeftEmps.TabIndex = 75;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbHeading.Location = new System.Drawing.Point(380, 12);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(219, 28);
            this.LbHeading.TabIndex = 76;
            this.LbHeading.Text = "Vacant Employees";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLeavedEmps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVLeftEmps);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLeavedEmps";
            this.Text = "Hostel Management";
            this.Load += new System.EventHandler(this.FormLeavedEmps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLeftEmps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVLeftEmps;
        private System.Windows.Forms.Label LbHeading;
    }
}