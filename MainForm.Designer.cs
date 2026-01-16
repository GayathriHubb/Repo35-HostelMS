namespace HostelMS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LbHeading = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Gn2BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnEmpsPay = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAllEmpsWork = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnLeavedEmps = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnNewEmps = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnLeavedMembs = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnUpdDelEmps = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnMembsFees = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAllMembsLiving = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnUpdDelMembs = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnNewMembs = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.PicBxHostel = new System.Windows.Forms.PictureBox();
            this.Pnl1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxHostel)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.LbHeading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbHeading.Font = new System.Drawing.Font("Cabin Sketch", 14F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.LbHeading.Location = new System.Drawing.Point(47, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(226, 32);
            this.LbHeading.TabIndex = 14;
            this.LbHeading.Text = "BLOOMS HOSTEL";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.Pnl1.Controls.Add(this.Gn2BtnLogout);
            this.Pnl1.Controls.Add(this.Gn2BtnEmpsPay);
            this.Pnl1.Controls.Add(this.Gn2BtnAllEmpsWork);
            this.Pnl1.Controls.Add(this.Gn2BtnLeavedEmps);
            this.Pnl1.Controls.Add(this.Gn2BtnNewEmps);
            this.Pnl1.Controls.Add(this.Gn2BtnLeavedMembs);
            this.Pnl1.Controls.Add(this.Gn2BtnUpdDelEmps);
            this.Pnl1.Controls.Add(this.Gn2BtnMembsFees);
            this.Pnl1.Controls.Add(this.Gn2BtnAllMembsLiving);
            this.Pnl1.Controls.Add(this.Gn2BtnUpdDelMembs);
            this.Pnl1.Controls.Add(this.Gn2BtnNewMembs);
            this.Pnl1.Controls.Add(this.Gn2BtnRooms);
            this.Pnl1.Controls.Add(this.LbHeading);
            this.Pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(320, 644);
            this.Pnl1.TabIndex = 15;
            // 
            // Gn2BtnLogout
            // 
            this.Gn2BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gn2BtnLogout.Animated = true;
            this.Gn2BtnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.Indigo;
            this.Gn2BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnLogout.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnLogout.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Gn2BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnLogout.Image")));
            this.Gn2BtnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLogout.Location = new System.Drawing.Point(0, 600);
            this.Gn2BtnLogout.Name = "Gn2BtnLogout";
            this.Gn2BtnLogout.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnLogout.TabIndex = 27;
            this.Gn2BtnLogout.Text = "Logout";
            this.Gn2BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLogout.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnLogout.Click += new System.EventHandler(this.Gn2BtnLogout_Click);
            // 
            // Gn2BtnEmpsPay
            // 
            this.Gn2BtnEmpsPay.Animated = true;
            this.Gn2BtnEmpsPay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnEmpsPay.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnEmpsPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnEmpsPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnEmpsPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnEmpsPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnEmpsPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnEmpsPay.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnEmpsPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gn2BtnEmpsPay.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnEmpsPay.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnEmpsPay.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnEmpsPay.Image")));
            this.Gn2BtnEmpsPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnEmpsPay.Location = new System.Drawing.Point(-3, 450);
            this.Gn2BtnEmpsPay.Name = "Gn2BtnEmpsPay";
            this.Gn2BtnEmpsPay.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnEmpsPay.TabIndex = 26;
            this.Gn2BtnEmpsPay.Text = "Employees Payment";
            this.Gn2BtnEmpsPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnEmpsPay.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnEmpsPay.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnAllEmpsWork
            // 
            this.Gn2BtnAllEmpsWork.Animated = true;
            this.Gn2BtnAllEmpsWork.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnAllEmpsWork.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnAllEmpsWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnAllEmpsWork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAllEmpsWork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAllEmpsWork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnAllEmpsWork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnAllEmpsWork.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnAllEmpsWork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gn2BtnAllEmpsWork.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnAllEmpsWork.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnAllEmpsWork.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnAllEmpsWork.Image")));
            this.Gn2BtnAllEmpsWork.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnAllEmpsWork.Location = new System.Drawing.Point(0, 500);
            this.Gn2BtnAllEmpsWork.Name = "Gn2BtnAllEmpsWork";
            this.Gn2BtnAllEmpsWork.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnAllEmpsWork.TabIndex = 25;
            this.Gn2BtnAllEmpsWork.Text = "All Employee Working";
            this.Gn2BtnAllEmpsWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnAllEmpsWork.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnAllEmpsWork.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnLeavedEmps
            // 
            this.Gn2BtnLeavedEmps.Animated = true;
            this.Gn2BtnLeavedEmps.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnLeavedEmps.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnLeavedEmps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnLeavedEmps.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLeavedEmps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLeavedEmps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnLeavedEmps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnLeavedEmps.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnLeavedEmps.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gn2BtnLeavedEmps.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnLeavedEmps.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnLeavedEmps.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnLeavedEmps.Image")));
            this.Gn2BtnLeavedEmps.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLeavedEmps.Location = new System.Drawing.Point(0, 550);
            this.Gn2BtnLeavedEmps.Name = "Gn2BtnLeavedEmps";
            this.Gn2BtnLeavedEmps.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnLeavedEmps.TabIndex = 24;
            this.Gn2BtnLeavedEmps.Text = "Leaved Employees";
            this.Gn2BtnLeavedEmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLeavedEmps.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnLeavedEmps.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnNewEmps
            // 
            this.Gn2BtnNewEmps.Animated = true;
            this.Gn2BtnNewEmps.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnNewEmps.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnNewEmps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnNewEmps.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnNewEmps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnNewEmps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnNewEmps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnNewEmps.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnNewEmps.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Gn2BtnNewEmps.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnNewEmps.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnNewEmps.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnNewEmps.Image")));
            this.Gn2BtnNewEmps.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnNewEmps.Location = new System.Drawing.Point(0, 350);
            this.Gn2BtnNewEmps.Name = "Gn2BtnNewEmps";
            this.Gn2BtnNewEmps.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnNewEmps.TabIndex = 23;
            this.Gn2BtnNewEmps.Text = "New Employees";
            this.Gn2BtnNewEmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnNewEmps.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnNewEmps.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnLeavedMembs
            // 
            this.Gn2BtnLeavedMembs.Animated = true;
            this.Gn2BtnLeavedMembs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnLeavedMembs.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnLeavedMembs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnLeavedMembs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLeavedMembs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLeavedMembs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnLeavedMembs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnLeavedMembs.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnLeavedMembs.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Gn2BtnLeavedMembs.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnLeavedMembs.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnLeavedMembs.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnLeavedMembs.Image")));
            this.Gn2BtnLeavedMembs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLeavedMembs.Location = new System.Drawing.Point(0, 300);
            this.Gn2BtnLeavedMembs.Name = "Gn2BtnLeavedMembs";
            this.Gn2BtnLeavedMembs.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnLeavedMembs.TabIndex = 22;
            this.Gn2BtnLeavedMembs.Text = "Leaved Members";
            this.Gn2BtnLeavedMembs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLeavedMembs.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnLeavedMembs.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnUpdDelEmps
            // 
            this.Gn2BtnUpdDelEmps.Animated = true;
            this.Gn2BtnUpdDelEmps.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnUpdDelEmps.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnUpdDelEmps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnUpdDelEmps.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpdDelEmps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpdDelEmps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnUpdDelEmps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnUpdDelEmps.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnUpdDelEmps.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Gn2BtnUpdDelEmps.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnUpdDelEmps.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnUpdDelEmps.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnUpdDelEmps.Image")));
            this.Gn2BtnUpdDelEmps.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnUpdDelEmps.Location = new System.Drawing.Point(0, 400);
            this.Gn2BtnUpdDelEmps.Name = "Gn2BtnUpdDelEmps";
            this.Gn2BtnUpdDelEmps.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnUpdDelEmps.TabIndex = 20;
            this.Gn2BtnUpdDelEmps.Text = "Update and Delete Employees";
            this.Gn2BtnUpdDelEmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnUpdDelEmps.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnUpdDelEmps.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnMembsFees
            // 
            this.Gn2BtnMembsFees.Animated = true;
            this.Gn2BtnMembsFees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnMembsFees.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnMembsFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnMembsFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnMembsFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnMembsFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnMembsFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnMembsFees.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnMembsFees.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Gn2BtnMembsFees.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnMembsFees.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnMembsFees.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnMembsFees.Image")));
            this.Gn2BtnMembsFees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnMembsFees.Location = new System.Drawing.Point(0, 200);
            this.Gn2BtnMembsFees.Name = "Gn2BtnMembsFees";
            this.Gn2BtnMembsFees.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnMembsFees.TabIndex = 19;
            this.Gn2BtnMembsFees.Text = "Members Fees";
            this.Gn2BtnMembsFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnMembsFees.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnMembsFees.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnAllMembsLiving
            // 
            this.Gn2BtnAllMembsLiving.Animated = true;
            this.Gn2BtnAllMembsLiving.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnAllMembsLiving.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnAllMembsLiving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnAllMembsLiving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAllMembsLiving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAllMembsLiving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnAllMembsLiving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnAllMembsLiving.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnAllMembsLiving.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Gn2BtnAllMembsLiving.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnAllMembsLiving.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnAllMembsLiving.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnAllMembsLiving.Image")));
            this.Gn2BtnAllMembsLiving.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnAllMembsLiving.Location = new System.Drawing.Point(0, 250);
            this.Gn2BtnAllMembsLiving.Name = "Gn2BtnAllMembsLiving";
            this.Gn2BtnAllMembsLiving.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnAllMembsLiving.TabIndex = 18;
            this.Gn2BtnAllMembsLiving.Text = "All Members Living";
            this.Gn2BtnAllMembsLiving.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnAllMembsLiving.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnAllMembsLiving.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnUpdDelMembs
            // 
            this.Gn2BtnUpdDelMembs.Animated = true;
            this.Gn2BtnUpdDelMembs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnUpdDelMembs.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnUpdDelMembs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnUpdDelMembs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpdDelMembs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpdDelMembs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnUpdDelMembs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnUpdDelMembs.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnUpdDelMembs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gn2BtnUpdDelMembs.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnUpdDelMembs.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnUpdDelMembs.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnUpdDelMembs.Image")));
            this.Gn2BtnUpdDelMembs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnUpdDelMembs.Location = new System.Drawing.Point(0, 150);
            this.Gn2BtnUpdDelMembs.Name = "Gn2BtnUpdDelMembs";
            this.Gn2BtnUpdDelMembs.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnUpdDelMembs.TabIndex = 17;
            this.Gn2BtnUpdDelMembs.Text = "Update and Delete Members";
            this.Gn2BtnUpdDelMembs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnUpdDelMembs.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnUpdDelMembs.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnNewMembs
            // 
            this.Gn2BtnNewMembs.Animated = true;
            this.Gn2BtnNewMembs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnNewMembs.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnNewMembs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnNewMembs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnNewMembs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnNewMembs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnNewMembs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnNewMembs.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnNewMembs.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Gn2BtnNewMembs.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnNewMembs.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnNewMembs.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnNewMembs.Image")));
            this.Gn2BtnNewMembs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnNewMembs.Location = new System.Drawing.Point(0, 100);
            this.Gn2BtnNewMembs.Name = "Gn2BtnNewMembs";
            this.Gn2BtnNewMembs.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnNewMembs.TabIndex = 16;
            this.Gn2BtnNewMembs.Text = "New Members";
            this.Gn2BtnNewMembs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnNewMembs.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnNewMembs.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnRooms
            // 
            this.Gn2BtnRooms.Animated = true;
            this.Gn2BtnRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gn2BtnRooms.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.Gn2BtnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnRooms.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnRooms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Gn2BtnRooms.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnRooms.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnRooms.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnRooms.Image")));
            this.Gn2BtnRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnRooms.ImageOffset = new System.Drawing.Point(5, 0);
            this.Gn2BtnRooms.Location = new System.Drawing.Point(0, 50);
            this.Gn2BtnRooms.Name = "Gn2BtnRooms";
            this.Gn2BtnRooms.Size = new System.Drawing.Size(320, 35);
            this.Gn2BtnRooms.TabIndex = 15;
            this.Gn2BtnRooms.Text = "Manage Rooms";
            this.Gn2BtnRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnRooms.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnRooms.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Pnl2
            // 
            this.Pnl2.Controls.Add(this.PicBxHostel);
            this.Pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl2.Location = new System.Drawing.Point(320, 0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(858, 644);
            this.Pnl2.TabIndex = 16;
            // 
            // PicBxHostel
            // 
            this.PicBxHostel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBxHostel.Image = ((System.Drawing.Image)(resources.GetObject("PicBxHostel.Image")));
            this.PicBxHostel.Location = new System.Drawing.Point(0, 0);
            this.PicBxHostel.Name = "PicBxHostel";
            this.PicBxHostel.Size = new System.Drawing.Size(858, 644);
            this.PicBxHostel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBxHostel.TabIndex = 0;
            this.PicBxHostel.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hostel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxHostel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel Pnl1;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnRooms;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnNewEmps;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnLeavedMembs;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnUpdDelEmps;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnMembsFees;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAllMembsLiving;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnUpdDelMembs;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnNewMembs;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAllEmpsWork;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnLeavedEmps;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnEmpsPay;
        private System.Windows.Forms.Panel Pnl2;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnLogout;
        private System.Windows.Forms.PictureBox PicBxHostel;
    }
}