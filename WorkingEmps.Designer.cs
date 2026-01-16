namespace HostelMS
{
    partial class FormWorkingEmps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbTRC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVWorkingEmps = new System.Windows.Forms.DataGridView();
            this.LbHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWorkingEmps)).BeginInit();
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
            // DGVWorkingEmps
            // 
            this.DGVWorkingEmps.AllowUserToAddRows = false;
            this.DGVWorkingEmps.AllowUserToDeleteRows = false;
            this.DGVWorkingEmps.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVWorkingEmps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVWorkingEmps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVWorkingEmps.ColumnHeadersHeight = 34;
            this.DGVWorkingEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVWorkingEmps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVWorkingEmps.EnableHeadersVisualStyles = false;
            this.DGVWorkingEmps.Location = new System.Drawing.Point(7, 47);
            this.DGVWorkingEmps.Name = "DGVWorkingEmps";
            this.DGVWorkingEmps.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVWorkingEmps.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVWorkingEmps.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVWorkingEmps.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVWorkingEmps.RowTemplate.Height = 28;
            this.DGVWorkingEmps.Size = new System.Drawing.Size(965, 550);
            this.DGVWorkingEmps.TabIndex = 71;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbHeading.Location = new System.Drawing.Point(371, 12);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(278, 28);
            this.LbHeading.TabIndex = 72;
            this.LbHeading.Text = "All Employees Working";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormWorkingEmps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVWorkingEmps);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWorkingEmps";
            this.Text = "Hostel Management";
            this.Load += new System.EventHandler(this.FormWorkingEmps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVWorkingEmps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVWorkingEmps;
        private System.Windows.Forms.Label LbHeading;
    }
}