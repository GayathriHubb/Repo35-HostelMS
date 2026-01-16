namespace HostelMS
{
    partial class Form1Login
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
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbUN = new System.Windows.Forms.Label();
            this.LbPswrd = new System.Windows.Forms.Label();
            this.TxtBxUn = new System.Windows.Forms.TextBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.LbFrgtPswrd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.LbsignInForm = new System.Windows.Forms.Label();
            this.LbLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Cabin Sketch", 20F, System.Drawing.FontStyle.Bold);
            this.LbHeading.Location = new System.Drawing.Point(81, 20);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(517, 47);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "Hostel Management System";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbUN
            // 
            this.LbUN.AutoSize = true;
            this.LbUN.Font = new System.Drawing.Font("Ramabhadra", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUN.Location = new System.Drawing.Point(117, 145);
            this.LbUN.Name = "LbUN";
            this.LbUN.Size = new System.Drawing.Size(121, 38);
            this.LbUN.TabIndex = 1;
            this.LbUN.Text = "Username";
            this.LbUN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPswrd
            // 
            this.LbPswrd.AutoSize = true;
            this.LbPswrd.Font = new System.Drawing.Font("Ramabhadra", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPswrd.Location = new System.Drawing.Point(117, 201);
            this.LbPswrd.Name = "LbPswrd";
            this.LbPswrd.Size = new System.Drawing.Size(119, 38);
            this.LbPswrd.TabIndex = 2;
            this.LbPswrd.Text = "Password";
            this.LbPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxUn
            // 
            this.TxtBxUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUn.Location = new System.Drawing.Point(246, 146);
            this.TxtBxUn.Name = "TxtBxUn";
            this.TxtBxUn.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUn.TabIndex = 4;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(246, 202);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPswrd.TabIndex = 5;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnLogin.Location = new System.Drawing.Point(162, 305);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(150, 50);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnClear.Location = new System.Drawing.Point(363, 305);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 50);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(390, 255);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(154, 25);
            this.ChkBxPswrd.TabIndex = 6;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // LbFrgtPswrd
            // 
            this.LbFrgtPswrd.AutoSize = true;
            this.LbFrgtPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbFrgtPswrd.Font = new System.Drawing.Font("Lato", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFrgtPswrd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbFrgtPswrd.Location = new System.Drawing.Point(254, 380);
            this.LbFrgtPswrd.Name = "LbFrgtPswrd";
            this.LbFrgtPswrd.Size = new System.Drawing.Size(171, 24);
            this.LbFrgtPswrd.TabIndex = 7;
            this.LbFrgtPswrd.Text = "Forgot Password ?";
            this.LbFrgtPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbFrgtPswrd.Click += new System.EventHandler(this.LbFrgtPswrd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(247, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Don\'t Have an Acc ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AutoSize = true;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.BlueViolet;
            this.BtnSignUp.Location = new System.Drawing.Point(264, 474);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(150, 50);
            this.BtnSignUp.TabIndex = 3;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // LbsignInForm
            // 
            this.LbsignInForm.AutoSize = true;
            this.LbsignInForm.Font = new System.Drawing.Font("Cabin Sketch", 12F, System.Drawing.FontStyle.Bold);
            this.LbsignInForm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbsignInForm.Location = new System.Drawing.Point(236, 80);
            this.LbsignInForm.Name = "LbsignInForm";
            this.LbsignInForm.Size = new System.Drawing.Size(153, 28);
            this.LbsignInForm.TabIndex = 11;
            this.LbsignInForm.Text = "SIGNIN FORM";
            this.LbsignInForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbLine
            // 
            this.LbLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.LbLine.Location = new System.Drawing.Point(0, 120);
            this.LbLine.Name = "LbLine";
            this.LbLine.Size = new System.Drawing.Size(678, 5);
            this.LbLine.TabIndex = 12;
            // 
            // Form1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.LbLine);
            this.Controls.Add(this.LbsignInForm);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbFrgtPswrd);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBxPswrd);
            this.Controls.Add(this.TxtBxUn);
            this.Controls.Add(this.LbPswrd);
            this.Controls.Add(this.LbUN);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1Login";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbUN;
        private System.Windows.Forms.Label LbPswrd;
        private System.Windows.Forms.TextBox TxtBxUn;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Label LbFrgtPswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label LbsignInForm;
        private System.Windows.Forms.Label LbLine;
    }
}

