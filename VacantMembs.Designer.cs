namespace HostelMS
{
    partial class FormVacantMembs
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
            this.DGVVacantMembs = new System.Windows.Forms.DataGridView();
            this.LbHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVacantMembs)).BeginInit();
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
            this.LbTRC.TabIndex = 73;
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
            this.label4.TabIndex = 74;
            this.label4.Text = "Total Rows:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVVacantMembs
            // 
            this.DGVVacantMembs.AllowUserToAddRows = false;
            this.DGVVacantMembs.AllowUserToDeleteRows = false;
            this.DGVVacantMembs.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVVacantMembs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVVacantMembs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVVacantMembs.ColumnHeadersHeight = 34;
            this.DGVVacantMembs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVVacantMembs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVVacantMembs.EnableHeadersVisualStyles = false;
            this.DGVVacantMembs.Location = new System.Drawing.Point(7, 47);
            this.DGVVacantMembs.Name = "DGVVacantMembs";
            this.DGVVacantMembs.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVVacantMembs.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVVacantMembs.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVVacantMembs.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVVacantMembs.RowTemplate.Height = 28;
            this.DGVVacantMembs.Size = new System.Drawing.Size(965, 550);
            this.DGVVacantMembs.TabIndex = 1;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbHeading.Location = new System.Drawing.Point(387, 12);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 28);
            this.LbHeading.TabIndex = 72;
            this.LbHeading.Text = "Vacant Members";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormVacantMembs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVVacantMembs);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVacantMembs";
            this.Text = "Hostel Management";
            this.Load += new System.EventHandler(this.FormVacantMembs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVacantMembs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVVacantMembs;
        private System.Windows.Forms.Label LbHeading;
    }
}