namespace HostelMS
{
    partial class FormFrgtPswrd
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
            this.PicBxFrgtPswrd = new System.Windows.Forms.PictureBox();
            this.BtnResetPswrd = new System.Windows.Forms.Button();
            this.TxtBxUn = new System.Windows.Forms.TextBox();
            this.LbUN = new System.Windows.Forms.Label();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxFrgtPswrd)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxFrgtPswrd
            // 
            this.PicBxFrgtPswrd.Image = global::HostelMS.Properties.Resources.ForgotPassword;
            this.PicBxFrgtPswrd.Location = new System.Drawing.Point(286, 80);
            this.PicBxFrgtPswrd.Name = "PicBxFrgtPswrd";
            this.PicBxFrgtPswrd.Size = new System.Drawing.Size(100, 100);
            this.PicBxFrgtPswrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxFrgtPswrd.TabIndex = 0;
            this.PicBxFrgtPswrd.TabStop = false;
            // 
            // BtnResetPswrd
            // 
            this.BtnResetPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetPswrd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BtnResetPswrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetPswrd.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.BtnResetPswrd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BtnResetPswrd.Location = new System.Drawing.Point(230, 284);
            this.BtnResetPswrd.Name = "BtnResetPswrd";
            this.BtnResetPswrd.Size = new System.Drawing.Size(210, 45);
            this.BtnResetPswrd.TabIndex = 1;
            this.BtnResetPswrd.Text = "Reset Password";
            this.BtnResetPswrd.UseVisualStyleBackColor = true;
            this.BtnResetPswrd.Click += new System.EventHandler(this.BtnResetPswrd_Click);
            // 
            // TxtBxUn
            // 
            this.TxtBxUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUn.Location = new System.Drawing.Point(230, 201);
            this.TxtBxUn.Name = "TxtBxUn";
            this.TxtBxUn.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUn.TabIndex = 2;
            // 
            // LbUN
            // 
            this.LbUN.AutoSize = true;
            this.LbUN.Font = new System.Drawing.Font("Ramabhadra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUN.Location = new System.Drawing.Point(99, 201);
            this.LbUN.Name = "LbUN";
            this.LbUN.Size = new System.Drawing.Size(121, 38);
            this.LbUN.TabIndex = 18;
            this.LbUN.Text = "Username";
            this.LbUN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.ChkBxPswrd.Location = new System.Drawing.Point(402, 431);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(148, 23);
            this.ChkBxPswrd.TabIndex = 3;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPassword.Location = new System.Drawing.Point(230, 379);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.Size = new System.Drawing.Size(320, 34);
            this.TxtBxPassword.TabIndex = 28;
            this.TxtBxPassword.UseSystemPasswordChar = true;
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.LbPassword.Location = new System.Drawing.Point(43, 386);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(176, 22);
            this.LbPassword.TabIndex = 27;
            this.LbPassword.Text = "Generated Password";
            this.LbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Ramabhadra", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LbHeading.Location = new System.Drawing.Point(184, 15);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(305, 53);
            this.LbHeading.TabIndex = 29;
            this.LbHeading.Text = "Hostel Management";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormFrgtPswrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.TxtBxPassword);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.BtnResetPswrd);
            this.Controls.Add(this.TxtBxUn);
            this.Controls.Add(this.LbUN);
            this.Controls.Add(this.PicBxFrgtPswrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFrgtPswrd";
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxFrgtPswrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxFrgtPswrd;
        private System.Windows.Forms.Button BtnResetPswrd;
        private System.Windows.Forms.TextBox TxtBxUn;
        private System.Windows.Forms.Label LbUN;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbHeading;
    }
}