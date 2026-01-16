namespace HostelMS
{
    partial class FormNewEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewEmp));
            this.CmbBxDesignation = new System.Windows.Forms.ComboBox();
            this.TxtBxHTown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.LbEmpId = new System.Windows.Forms.Label();
            this.TxtBxEmail = new System.Windows.Forms.TextBox();
            this.TxtBxIdProof = new System.Windows.Forms.TextBox();
            this.TxtBxEmpName = new System.Windows.Forms.TextBox();
            this.LbRmNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbBxDesignation
            // 
            this.CmbBxDesignation.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxDesignation.FormattingEnabled = true;
            this.CmbBxDesignation.Items.AddRange(new object[] {
            "Hostel Incharge",
            "Accounts Manager",
            "Mess Staff",
            "Cleaning Staff"});
            this.CmbBxDesignation.Location = new System.Drawing.Point(230, 473);
            this.CmbBxDesignation.Name = "CmbBxDesignation";
            this.CmbBxDesignation.Size = new System.Drawing.Size(400, 36);
            this.CmbBxDesignation.TabIndex = 41;
            // 
            // TxtBxHTown
            // 
            this.TxtBxHTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxHTown.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxHTown.Location = new System.Drawing.Point(230, 363);
            this.TxtBxHTown.Name = "TxtBxHTown";
            this.TxtBxHTown.Size = new System.Drawing.Size(400, 34);
            this.TxtBxHTown.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "HomeTown";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2BtnClear
            // 
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
            this.Gn2BtnClear.Location = new System.Drawing.Point(504, 560);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(180, 45);
            this.Gn2BtnClear.TabIndex = 38;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // Gn2BtnSave
            // 
            this.Gn2BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnSave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnSave.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnSave.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnSave.Image")));
            this.Gn2BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnSave.Location = new System.Drawing.Point(305, 560);
            this.Gn2BtnSave.Name = "Gn2BtnSave";
            this.Gn2BtnSave.Size = new System.Drawing.Size(180, 45);
            this.Gn2BtnSave.TabIndex = 25;
            this.Gn2BtnSave.Text = "Save";
            this.Gn2BtnSave.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnSave.Click += new System.EventHandler(this.Gn2BtnSave_Click);
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(230, 253);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(400, 34);
            this.MTBPhnNum.TabIndex = 37;
            // 
            // LbEmpId
            // 
            this.LbEmpId.AutoSize = true;
            this.LbEmpId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbEmpId.Location = new System.Drawing.Point(230, 86);
            this.LbEmpId.Name = "LbEmpId";
            this.LbEmpId.Size = new System.Drawing.Size(47, 34);
            this.LbEmpId.TabIndex = 36;
            this.LbEmpId.Text = "{?}";
            this.LbEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmail.Location = new System.Drawing.Point(230, 308);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(400, 34);
            this.TxtBxEmail.TabIndex = 35;
            // 
            // TxtBxIdProof
            // 
            this.TxtBxIdProof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxIdProof.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxIdProof.Location = new System.Drawing.Point(230, 418);
            this.TxtBxIdProof.Name = "TxtBxIdProof";
            this.TxtBxIdProof.Size = new System.Drawing.Size(400, 34);
            this.TxtBxIdProof.TabIndex = 34;
            // 
            // TxtBxEmpName
            // 
            this.TxtBxEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmpName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmpName.Location = new System.Drawing.Point(230, 141);
            this.TxtBxEmpName.Name = "TxtBxEmpName";
            this.TxtBxEmpName.Size = new System.Drawing.Size(400, 34);
            this.TxtBxEmpName.TabIndex = 33;
            // 
            // LbRmNum
            // 
            this.LbRmNum.AutoSize = true;
            this.LbRmNum.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRmNum.Location = new System.Drawing.Point(64, 477);
            this.LbRmNum.Name = "LbRmNum";
            this.LbRmNum.Size = new System.Drawing.Size(144, 29);
            this.LbRmNum.TabIndex = 32;
            this.LbRmNum.Text = "Designation";
            this.LbRmNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "EmployeeId";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "PhnNum";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email Id";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Id Proof";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbHeading.Location = new System.Drawing.Point(358, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(217, 34);
            this.LbHeading.TabIndex = 27;
            this.LbHeading.Text = "Employees Info";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "EmpName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gender";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(230, 196);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(300, 36);
            this.CmbBxGender.TabIndex = 43;
            // 
            // FormNewEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.CmbBxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBxDesignation);
            this.Controls.Add(this.TxtBxHTown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gn2BtnClear);
            this.Controls.Add(this.Gn2BtnSave);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.LbEmpId);
            this.Controls.Add(this.TxtBxEmail);
            this.Controls.Add(this.TxtBxIdProof);
            this.Controls.Add(this.TxtBxEmpName);
            this.Controls.Add(this.LbRmNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewEmp";
            this.Text = "Hostel Management";
            this.Load += new System.EventHandler(this.FormNewEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBxDesignation;
        private System.Windows.Forms.TextBox TxtBxHTown;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnSave;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.Label LbEmpId;
        private System.Windows.Forms.TextBox TxtBxEmail;
        private System.Windows.Forms.TextBox TxtBxIdProof;
        private System.Windows.Forms.TextBox TxtBxEmpName;
        private System.Windows.Forms.Label LbRmNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBxGender;
    }
}