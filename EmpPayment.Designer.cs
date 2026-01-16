namespace HostelMS
{
    partial class FormEmpPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpPayment));
            this.LbTRC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVSalary = new System.Windows.Forms.DataGridView();
            this.TxtBxWorkStatus = new System.Windows.Forms.TextBox();
            this.NUDAmount = new System.Windows.Forms.NumericUpDown();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.TxtBxEmpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBxHTown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.TxtBxDesignation = new System.Windows.Forms.TextBox();
            this.TxtBxMembName = new System.Windows.Forms.TextBox();
            this.LbRmNum = new System.Windows.Forms.Label();
            this.LbEmpId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Gn2BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnPay = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTRC
            // 
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbTRC.Location = new System.Drawing.Point(120, 611);
            this.LbTRC.Name = "LbTRC";
            this.LbTRC.Size = new System.Drawing.Size(32, 21);
            this.LbTRC.TabIndex = 79;
            this.LbTRC.Text = "{?}";
            this.LbTRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 91;
            this.label4.Text = "Total Rows:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVSalary
            // 
            this.DGVSalary.AllowUserToAddRows = false;
            this.DGVSalary.AllowUserToDeleteRows = false;
            this.DGVSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSalary.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVSalary.ColumnHeadersHeight = 34;
            this.DGVSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVSalary.EnableHeadersVisualStyles = false;
            this.DGVSalary.Location = new System.Drawing.Point(7, 360);
            this.DGVSalary.Name = "DGVSalary";
            this.DGVSalary.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSalary.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVSalary.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVSalary.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVSalary.RowTemplate.Height = 28;
            this.DGVSalary.Size = new System.Drawing.Size(965, 240);
            this.DGVSalary.TabIndex = 90;
            // 
            // TxtBxWorkStatus
            // 
            this.TxtBxWorkStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxWorkStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxWorkStatus.Location = new System.Drawing.Point(650, 231);
            this.TxtBxWorkStatus.Name = "TxtBxWorkStatus";
            this.TxtBxWorkStatus.Size = new System.Drawing.Size(304, 34);
            this.TxtBxWorkStatus.TabIndex = 89;
            // 
            // NUDAmount
            // 
            this.NUDAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDAmount.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.NUDAmount.Location = new System.Drawing.Point(650, 180);
            this.NUDAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDAmount.Name = "NUDAmount";
            this.NUDAmount.Size = new System.Drawing.Size(300, 34);
            this.NUDAmount.TabIndex = 77;
            // 
            // DTP1
            // 
            this.DTP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTP1.CustomFormat = "MMMM yyyy";
            this.DTP1.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP1.Location = new System.Drawing.Point(650, 126);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(300, 34);
            this.DTP1.TabIndex = 78;
            // 
            // TxtBxEmpId
            // 
            this.TxtBxEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmpId.Font = new System.Drawing.Font("Aleo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmpId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBxEmpId.Location = new System.Drawing.Point(140, 71);
            this.TxtBxEmpId.Name = "TxtBxEmpId";
            this.TxtBxEmpId.Size = new System.Drawing.Size(230, 36);
            this.TxtBxEmpId.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 88;
            this.label1.Text = "WorkingStatus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxHTown
            // 
            this.TxtBxHTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxHTown.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxHTown.Location = new System.Drawing.Point(650, 72);
            this.TxtBxHTown.Name = "TxtBxHTown";
            this.TxtBxHTown.Size = new System.Drawing.Size(304, 34);
            this.TxtBxHTown.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 87;
            this.label2.Text = "HomeTown";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(140, 179);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(250, 34);
            this.MTBPhnNum.TabIndex = 74;
            // 
            // TxtBxDesignation
            // 
            this.TxtBxDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxDesignation.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDesignation.Location = new System.Drawing.Point(140, 231);
            this.TxtBxDesignation.Name = "TxtBxDesignation";
            this.TxtBxDesignation.Size = new System.Drawing.Size(254, 34);
            this.TxtBxDesignation.TabIndex = 75;
            // 
            // TxtBxMembName
            // 
            this.TxtBxMembName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxMembName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxMembName.Location = new System.Drawing.Point(140, 125);
            this.TxtBxMembName.Name = "TxtBxMembName";
            this.TxtBxMembName.Size = new System.Drawing.Size(356, 34);
            this.TxtBxMembName.TabIndex = 73;
            // 
            // LbRmNum
            // 
            this.LbRmNum.AutoSize = true;
            this.LbRmNum.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRmNum.Location = new System.Drawing.Point(513, 185);
            this.LbRmNum.Name = "LbRmNum";
            this.LbRmNum.Size = new System.Drawing.Size(111, 22);
            this.LbRmNum.TabIndex = 86;
            this.LbRmNum.Text = "Due Amount";
            this.LbRmNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbEmpId
            // 
            this.LbEmpId.AutoSize = true;
            this.LbEmpId.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpId.Location = new System.Drawing.Point(20, 78);
            this.LbEmpId.Name = "LbEmpId";
            this.LbEmpId.Size = new System.Drawing.Size(61, 22);
            this.LbEmpId.TabIndex = 85;
            this.LbEmpId.Text = "EmpId";
            this.LbEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 84;
            this.label8.Text = "PhnNum";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 83;
            this.label7.Text = "Designation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 82;
            this.label6.Text = "MonthYear";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbHeading.Location = new System.Drawing.Point(350, 12);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(279, 34);
            this.LbHeading.TabIndex = 81;
            this.LbHeading.Text = "Employees Payment";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "EmpName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2BtnSearch
            // 
            this.Gn2BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnSearch.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnSearch.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnSearch.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnSearch.Image")));
            this.Gn2BtnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnSearch.ImageSize = new System.Drawing.Size(16, 16);
            this.Gn2BtnSearch.Location = new System.Drawing.Point(375, 73);
            this.Gn2BtnSearch.Name = "Gn2BtnSearch";
            this.Gn2BtnSearch.Size = new System.Drawing.Size(121, 33);
            this.Gn2BtnSearch.TabIndex = 1;
            this.Gn2BtnSearch.Text = "Search";
            this.Gn2BtnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Gn2BtnSearch.Click += new System.EventHandler(this.Gn2BtnSearch_Click);
            // 
            // Gn2BtnClear
            // 
            this.Gn2BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnClear.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnClear.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnClear.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnClear.Image")));
            this.Gn2BtnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnClear.ImageSize = new System.Drawing.Size(25, 25);
            this.Gn2BtnClear.Location = new System.Drawing.Point(526, 285);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(180, 45);
            this.Gn2BtnClear.TabIndex = 3;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Gn2BtnClear.TextOffset = new System.Drawing.Point(-10, 0);
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // Gn2BtnPay
            // 
            this.Gn2BtnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnPay.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnPay.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnPay.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnPay.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnPay.Image")));
            this.Gn2BtnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnPay.ImageSize = new System.Drawing.Size(18, 18);
            this.Gn2BtnPay.Location = new System.Drawing.Point(272, 285);
            this.Gn2BtnPay.Name = "Gn2BtnPay";
            this.Gn2BtnPay.Size = new System.Drawing.Size(180, 45);
            this.Gn2BtnPay.TabIndex = 2;
            this.Gn2BtnPay.Text = "Pay Salary";
            this.Gn2BtnPay.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnPay.Click += new System.EventHandler(this.Gn2BtnPay_Click);
            // 
            // FormEmpPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVSalary);
            this.Controls.Add(this.TxtBxWorkStatus);
            this.Controls.Add(this.NUDAmount);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.TxtBxEmpId);
            this.Controls.Add(this.Gn2BtnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxHTown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gn2BtnClear);
            this.Controls.Add(this.Gn2BtnPay);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.TxtBxDesignation);
            this.Controls.Add(this.TxtBxMembName);
            this.Controls.Add(this.LbRmNum);
            this.Controls.Add(this.LbEmpId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmpPayment";
            this.Text = "Hostel  Management";
            this.Load += new System.EventHandler(this.EmpPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVSalary;
        private System.Windows.Forms.TextBox TxtBxWorkStatus;
        private System.Windows.Forms.NumericUpDown NUDAmount;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.TextBox TxtBxEmpId;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBxHTown;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnPay;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.TextBox TxtBxDesignation;
        private System.Windows.Forms.TextBox TxtBxMembName;
        private System.Windows.Forms.Label LbRmNum;
        private System.Windows.Forms.Label LbEmpId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label label3;
    }
}