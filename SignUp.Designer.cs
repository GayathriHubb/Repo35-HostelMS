namespace HostelMS
{
    partial class FormSignUp
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
            this.LbLine = new System.Windows.Forms.Label();
            this.LbsignInForm = new System.Windows.Forms.Label();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.TxtBxUn = new System.Windows.Forms.TextBox();
            this.LbPswrd = new System.Windows.Forms.Label();
            this.LbUN = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.TxtBxCnfmPswrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbLine
            // 
            this.LbLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.LbLine.Location = new System.Drawing.Point(0, 130);
            this.LbLine.Name = "LbLine";
            this.LbLine.Size = new System.Drawing.Size(778, 5);
            this.LbLine.TabIndex = 25;
            // 
            // LbsignInForm
            // 
            this.LbsignInForm.AutoSize = true;
            this.LbsignInForm.Font = new System.Drawing.Font("Cabin Sketch", 12F, System.Drawing.FontStyle.Bold);
            this.LbsignInForm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbsignInForm.Location = new System.Drawing.Point(309, 90);
            this.LbsignInForm.Name = "LbsignInForm";
            this.LbsignInForm.Size = new System.Drawing.Size(160, 28);
            this.LbsignInForm.TabIndex = 24;
            this.LbsignInForm.Text = "SIGNUP FORM";
            this.LbsignInForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.AutoSize = true;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnSignIn.Location = new System.Drawing.Point(302, 530);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(150, 50);
            this.BtnSignIn.TabIndex = 3;
            this.BtnSignIn.Text = "SignIn";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(285, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Already Have an Acc ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(437, 319);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(154, 25);
            this.ChkBxPswrd.TabIndex = 7;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnClear.Location = new System.Drawing.Point(409, 380);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 50);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AutoSize = true;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnSignUp.Location = new System.Drawing.Point(208, 380);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(150, 50);
            this.BtnSignUp.TabIndex = 1;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(291, 219);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPswrd.TabIndex = 5;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // TxtBxUn
            // 
            this.TxtBxUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUn.Location = new System.Drawing.Point(291, 163);
            this.TxtBxUn.Name = "TxtBxUn";
            this.TxtBxUn.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUn.TabIndex = 4;
            // 
            // LbPswrd
            // 
            this.LbPswrd.AutoSize = true;
            this.LbPswrd.Font = new System.Drawing.Font("Ramabhadra", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPswrd.Location = new System.Drawing.Point(162, 219);
            this.LbPswrd.Name = "LbPswrd";
            this.LbPswrd.Size = new System.Drawing.Size(119, 38);
            this.LbPswrd.TabIndex = 15;
            this.LbPswrd.Text = "Password";
            this.LbPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUN
            // 
            this.LbUN.AutoSize = true;
            this.LbUN.Font = new System.Drawing.Font("Ramabhadra", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUN.Location = new System.Drawing.Point(160, 163);
            this.LbUN.Name = "LbUN";
            this.LbUN.Size = new System.Drawing.Size(121, 38);
            this.LbUN.TabIndex = 14;
            this.LbUN.Text = "Username";
            this.LbUN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Cabin Sketch", 20F, System.Drawing.FontStyle.Bold);
            this.LbHeading.Location = new System.Drawing.Point(126, 20);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(517, 47);
            this.LbHeading.TabIndex = 13;
            this.LbHeading.Text = "Hostel Management System";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxCnfmPswrd
            // 
            this.TxtBxCnfmPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCnfmPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCnfmPswrd.Location = new System.Drawing.Point(291, 271);
            this.TxtBxCnfmPswrd.Name = "TxtBxCnfmPswrd";
            this.TxtBxCnfmPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxCnfmPswrd.TabIndex = 6;
            this.TxtBxCnfmPswrd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ramabhadra", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.TxtBxCnfmPswrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbLine);
            this.Controls.Add(this.LbsignInForm);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxtBxPswrd);
            this.Controls.Add(this.TxtBxUn);
            this.Controls.Add(this.LbPswrd);
            this.Controls.Add(this.LbUN);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLine;
        private System.Windows.Forms.Label LbsignInForm;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.TextBox TxtBxUn;
        private System.Windows.Forms.Label LbPswrd;
        private System.Windows.Forms.Label LbUN;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.TextBox TxtBxCnfmPswrd;
        private System.Windows.Forms.Label label2;
    }
}