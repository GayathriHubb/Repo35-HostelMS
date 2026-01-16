namespace HostelMS
{
    partial class FormRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRooms));
            this.LbAddRm = new System.Windows.Forms.Label();
            this.LbUpdDelRm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVRooms = new System.Windows.Forms.DataGridView();
            this.TxtBxRoomNum2 = new System.Windows.Forms.TextBox();
            this.TxtBxRoomNum1 = new System.Windows.Forms.TextBox();
            this.LbResponse2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gn2HtmlToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.RdBtn1A = new System.Windows.Forms.RadioButton();
            this.RdBtn1B = new System.Windows.Forms.RadioButton();
            this.GroupBx1 = new System.Windows.Forms.GroupBox();
            this.GroupBx2 = new System.Windows.Forms.GroupBox();
            this.RdBtn2A = new System.Windows.Forms.RadioButton();
            this.RdBtn2B = new System.Windows.Forms.RadioButton();
            this.LbLine = new System.Windows.Forms.Label();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnDel = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnUpd = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRooms)).BeginInit();
            this.GroupBx1.SuspendLayout();
            this.GroupBx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbAddRm
            // 
            this.LbAddRm.AutoSize = true;
            this.LbAddRm.BackColor = System.Drawing.Color.LavenderBlush;
            this.LbAddRm.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddRm.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbAddRm.Location = new System.Drawing.Point(42, 10);
            this.LbAddRm.Name = "LbAddRm";
            this.LbAddRm.Size = new System.Drawing.Size(245, 34);
            this.LbAddRm.TabIndex = 0;
            this.LbAddRm.Text = "ADD NEW ROOM";
            this.LbAddRm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbUpdDelRm
            // 
            this.LbUpdDelRm.AutoSize = true;
            this.LbUpdDelRm.BackColor = System.Drawing.Color.LavenderBlush;
            this.LbUpdDelRm.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUpdDelRm.ForeColor = System.Drawing.Color.BlueViolet;
            this.LbUpdDelRm.Location = new System.Drawing.Point(537, 10);
            this.LbUpdDelRm.Name = "LbUpdDelRm";
            this.LbUpdDelRm.Size = new System.Drawing.Size(340, 34);
            this.LbUpdDelRm.TabIndex = 1;
            this.LbUpdDelRm.Text = "UPDATE | DELETE ROOM";
            this.LbUpdDelRm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room No.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room No.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVRooms
            // 
            this.DGVRooms.AllowUserToAddRows = false;
            this.DGVRooms.AllowUserToDeleteRows = false;
            this.DGVRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRooms.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Aleo SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVRooms.ColumnHeadersHeight = 34;
            this.DGVRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVRooms.EnableHeadersVisualStyles = false;
            this.DGVRooms.Location = new System.Drawing.Point(5, 324);
            this.DGVRooms.Name = "DGVRooms";
            this.DGVRooms.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVRooms.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVRooms.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVRooms.RowTemplate.Height = 28;
            this.DGVRooms.Size = new System.Drawing.Size(965, 310);
            this.DGVRooms.TabIndex = 4;
            // 
            // TxtBxRoomNum2
            // 
            this.TxtBxRoomNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxRoomNum2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxRoomNum2.Location = new System.Drawing.Point(661, 64);
            this.TxtBxRoomNum2.Name = "TxtBxRoomNum2";
            this.TxtBxRoomNum2.Size = new System.Drawing.Size(200, 37);
            this.TxtBxRoomNum2.TabIndex = 5;
            // 
            // TxtBxRoomNum1
            // 
            this.TxtBxRoomNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxRoomNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxRoomNum1.Location = new System.Drawing.Point(170, 64);
            this.TxtBxRoomNum1.Name = "TxtBxRoomNum1";
            this.TxtBxRoomNum1.Size = new System.Drawing.Size(200, 37);
            this.TxtBxRoomNum1.TabIndex = 6;
            // 
            // LbResponse2
            // 
            this.LbResponse2.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResponse2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LbResponse2.Location = new System.Drawing.Point(661, 109);
            this.LbResponse2.Name = "LbResponse2";
            this.LbResponse2.Size = new System.Drawing.Size(248, 33);
            this.LbResponse2.TabIndex = 14;
            this.LbResponse2.Text = "{?}";
            this.LbResponse2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbResponse2.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LavenderBlush;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(8, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "All Rooms";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gn2HtmlToolTip
            // 
            this.Gn2HtmlToolTip.AllowLinksHandling = true;
            this.Gn2HtmlToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // RdBtn1A
            // 
            this.RdBtn1A.AutoSize = true;
            this.RdBtn1A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdBtn1A.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn1A.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RdBtn1A.Location = new System.Drawing.Point(23, 41);
            this.RdBtn1A.Name = "RdBtn1A";
            this.RdBtn1A.Size = new System.Drawing.Size(86, 29);
            this.RdBtn1A.TabIndex = 17;
            this.RdBtn1A.TabStop = true;
            this.RdBtn1A.Text = "Active";
            this.RdBtn1A.UseVisualStyleBackColor = true;
            // 
            // RdBtn1B
            // 
            this.RdBtn1B.AutoSize = true;
            this.RdBtn1B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdBtn1B.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn1B.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RdBtn1B.Location = new System.Drawing.Point(117, 41);
            this.RdBtn1B.Name = "RdBtn1B";
            this.RdBtn1B.Size = new System.Drawing.Size(99, 29);
            this.RdBtn1B.TabIndex = 18;
            this.RdBtn1B.TabStop = true;
            this.RdBtn1B.Text = "Inactive";
            this.RdBtn1B.UseVisualStyleBackColor = true;
            // 
            // GroupBx1
            // 
            this.GroupBx1.Controls.Add(this.RdBtn1A);
            this.GroupBx1.Controls.Add(this.RdBtn1B);
            this.GroupBx1.Font = new System.Drawing.Font("Aleo SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBx1.ForeColor = System.Drawing.Color.BlueViolet;
            this.GroupBx1.Location = new System.Drawing.Point(52, 152);
            this.GroupBx1.Name = "GroupBx1";
            this.GroupBx1.Size = new System.Drawing.Size(240, 80);
            this.GroupBx1.TabIndex = 19;
            this.GroupBx1.TabStop = false;
            this.GroupBx1.Text = "RoomStatus";
            // 
            // GroupBx2
            // 
            this.GroupBx2.Controls.Add(this.RdBtn2A);
            this.GroupBx2.Controls.Add(this.RdBtn2B);
            this.GroupBx2.Font = new System.Drawing.Font("Aleo SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBx2.ForeColor = System.Drawing.Color.BlueViolet;
            this.GroupBx2.Location = new System.Drawing.Point(545, 152);
            this.GroupBx2.Name = "GroupBx2";
            this.GroupBx2.Size = new System.Drawing.Size(240, 80);
            this.GroupBx2.TabIndex = 20;
            this.GroupBx2.TabStop = false;
            this.GroupBx2.Text = "RoomStatus";
            // 
            // RdBtn2A
            // 
            this.RdBtn2A.AutoSize = true;
            this.RdBtn2A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdBtn2A.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn2A.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RdBtn2A.Location = new System.Drawing.Point(23, 41);
            this.RdBtn2A.Name = "RdBtn2A";
            this.RdBtn2A.Size = new System.Drawing.Size(86, 29);
            this.RdBtn2A.TabIndex = 17;
            this.RdBtn2A.TabStop = true;
            this.RdBtn2A.Text = "Active";
            this.RdBtn2A.UseVisualStyleBackColor = true;
            // 
            // RdBtn2B
            // 
            this.RdBtn2B.AutoSize = true;
            this.RdBtn2B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdBtn2B.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn2B.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RdBtn2B.Location = new System.Drawing.Point(117, 41);
            this.RdBtn2B.Name = "RdBtn2B";
            this.RdBtn2B.Size = new System.Drawing.Size(99, 29);
            this.RdBtn2B.TabIndex = 18;
            this.RdBtn2B.TabStop = true;
            this.RdBtn2B.Text = "Inactive";
            this.RdBtn2B.UseVisualStyleBackColor = true;
            // 
            // LbLine
            // 
            this.LbLine.BackColor = System.Drawing.Color.LavenderBlush;
            this.LbLine.Location = new System.Drawing.Point(0, 280);
            this.LbLine.Name = "LbLine";
            this.LbLine.Size = new System.Drawing.Size(978, 2);
            this.LbLine.TabIndex = 26;
            // 
            // Gn2BtnClear
            // 
            this.Gn2BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnClear.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnClear.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnClear.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnClear.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnClear.Location = new System.Drawing.Point(361, 236);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnClear.TabIndex = 4;
            this.Gn2BtnClear.Text = "CLEAR";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // Gn2BtnSearch
            // 
            this.Gn2BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnSearch.FillColor = System.Drawing.Color.Sienna;
            this.Gn2BtnSearch.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.Gn2BtnSearch.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnSearch.Image")));
            this.Gn2BtnSearch.ImageSize = new System.Drawing.Size(35, 35);
            this.Gn2BtnSearch.Location = new System.Drawing.Point(869, 62);
            this.Gn2BtnSearch.Name = "Gn2BtnSearch";
            this.Gn2BtnSearch.Size = new System.Drawing.Size(40, 40);
            this.Gn2BtnSearch.TabIndex = 15;
            this.Gn2HtmlToolTip.SetToolTip(this.Gn2BtnSearch, "Search");
            this.Gn2BtnSearch.Click += new System.EventHandler(this.Gn2BtnSearch_Click);
            // 
            // Gn2BtnDel
            // 
            this.Gn2BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnDel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnDel.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnDel.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnDel.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnDel.Image")));
            this.Gn2BtnDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnDel.Location = new System.Drawing.Point(737, 236);
            this.Gn2BtnDel.Name = "Gn2BtnDel";
            this.Gn2BtnDel.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnDel.TabIndex = 3;
            this.Gn2BtnDel.Text = "DELETE";
            this.Gn2BtnDel.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnDel.Click += new System.EventHandler(this.Gn2BtnDel_Click);
            // 
            // Gn2BtnUpd
            // 
            this.Gn2BtnUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnUpd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnUpd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnUpd.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnUpd.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnUpd.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnUpd.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnUpd.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnUpd.Image")));
            this.Gn2BtnUpd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnUpd.Location = new System.Drawing.Point(577, 236);
            this.Gn2BtnUpd.Name = "Gn2BtnUpd";
            this.Gn2BtnUpd.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnUpd.TabIndex = 2;
            this.Gn2BtnUpd.Text = "UPDATE";
            this.Gn2BtnUpd.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnUpd.Click += new System.EventHandler(this.Gn2BtnUpd_Click);
            // 
            // Gn2BtnAdd
            // 
            this.Gn2BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnAdd.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Gn2BtnAdd.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnAdd.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnAdd.HoverState.FillColor = System.Drawing.Color.SaddleBrown;
            this.Gn2BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("Gn2BtnAdd.Image")));
            this.Gn2BtnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnAdd.Location = new System.Drawing.Point(101, 236);
            this.Gn2BtnAdd.Name = "Gn2BtnAdd";
            this.Gn2BtnAdd.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnAdd.TabIndex = 1;
            this.Gn2BtnAdd.Text = "ADD";
            this.Gn2BtnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnAdd.TextOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnAdd.Click += new System.EventHandler(this.Gn2BtnAdd_Click);
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Gn2BtnClear);
            this.Controls.Add(this.LbLine);
            this.Controls.Add(this.GroupBx2);
            this.Controls.Add(this.GroupBx1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Gn2BtnSearch);
            this.Controls.Add(this.LbResponse2);
            this.Controls.Add(this.Gn2BtnDel);
            this.Controls.Add(this.Gn2BtnUpd);
            this.Controls.Add(this.Gn2BtnAdd);
            this.Controls.Add(this.TxtBxRoomNum1);
            this.Controls.Add(this.TxtBxRoomNum2);
            this.Controls.Add(this.DGVRooms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbUpdDelRm);
            this.Controls.Add(this.LbAddRm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRooms";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Hostel Management";
            this.Load += new System.EventHandler(this.FormRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRooms)).EndInit();
            this.GroupBx1.ResumeLayout(false);
            this.GroupBx1.PerformLayout();
            this.GroupBx2.ResumeLayout(false);
            this.GroupBx2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAddRm;
        private System.Windows.Forms.Label LbUpdDelRm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVRooms;
        private System.Windows.Forms.TextBox TxtBxRoomNum2;
        private System.Windows.Forms.TextBox TxtBxRoomNum1;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnAdd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnUpd;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnDel;
        private System.Windows.Forms.Label LbResponse2;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnSearch;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2HtmlToolTip Gn2HtmlToolTip;
        private System.Windows.Forms.RadioButton RdBtn1A;
        private System.Windows.Forms.RadioButton RdBtn1B;
        private System.Windows.Forms.GroupBox GroupBx1;
        private System.Windows.Forms.GroupBox GroupBx2;
        private System.Windows.Forms.RadioButton RdBtn2A;
        private System.Windows.Forms.RadioButton RdBtn2B;
        private System.Windows.Forms.Label LbLine;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnClear;
    }
}