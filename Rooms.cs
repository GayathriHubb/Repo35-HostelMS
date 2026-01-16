using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace HostelMS
{
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        HostelFuncs hstlfns = new HostelFuncs();
        

        private void FormRooms_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchRoomsData();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FormRoomsLoad");
                }
            }
        }

        private void FetchRoomsData()
        {
            string seldata = "Select * From Rooms";
            DataTable dt = hstlfns.GetData(seldata);
            DGVRooms.DataSource = dt;
        }

        private void Gn2BtnAdd_Click(object sender, EventArgs e)
        {
            string rmsts = string.Empty;
            if (RdBtn1A.Checked) { rmsts = RdBtn1A.Text; }
            if (RdBtn1B.Checked) { rmsts = RdBtn1B.Text; }

            if (CheckEmptyFields1())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkdata = "Select Count(*) From Rooms Where RoomNum = @rmnum";
                        using (SqlCommand chkcmd = new SqlCommand(chkdata, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@rmnum", TxtBxRoomNum1.Text.Trim());
                            int rc = 0;
                            object res = chkcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }

                            if (rc >= 1)
                            {
                                MessageBox.Show($"RoomNum: {TxtBxRoomNum1.Text} Already Exists", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string insdata = "Insert Into Rooms (RoomNum, RoomStatus, DateInsert) Values (@rnum, @rst, @dtins)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@rnum", TxtBxRoomNum1.Text.Trim());
                            inscmd.Parameters.AddWithValue("@rst", rmsts);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            FetchRoomsData();
                            MessageBox.Show("Room Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        }

                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine(ex.Message, "SqlRoomsAdd");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "RoomsAdd");
                    }
                }
            }
        }

        private void Gn2BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxRoomNum2.Text))
            {
                string seldata = $"Select * From Rooms Where RoomNum = '{TxtBxRoomNum2.Text.Trim()}'";
                DataTable dt = hstlfns.GetData(seldata);

                try
                {
                    if (dt.Rows.Count == 0)
                    {
                        LbResponse2.Visible = true;
                        LbResponse2.Text = "No Room Exist";
                        RdBtn2A.Checked = RdBtn2B.Checked = false;
                    }
                    else
                    {
                        LbResponse2.Visible = true;
                        LbResponse2.Text = "Room Found";

                        string getrmsts = dt.Rows[0][2].ToString();
                        if (getrmsts == "Active") { RdBtn2A.Checked = true; }
                        if (getrmsts == "Inactive") { RdBtn2B.Checked = true; }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "BtnSearch");
                }
            }
            else
            {
                LbResponse2.Visible = false;
            }
            
        }
        
        private void Gn2BtnUpd_Click(object sender, EventArgs e)
        {
            string rmsts = string.Empty;
            if (RdBtn2A.Checked) { rmsts = RdBtn2A.Text; }
            if (RdBtn2B.Checked) { rmsts = RdBtn2B.Text; }

            if (CheckEmptyFields2())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Update RoomNum: {TxtBxRoomNum2.Text} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string upddata = "Update Rooms Set RoomStatus = @rmsts Where RoomNum = @rmnum";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@rmsts", rmsts);
                                updcmd.Parameters.AddWithValue("@rmnum", TxtBxRoomNum2.Text.Trim());

                                updcmd.ExecuteNonQuery();
                                FetchRoomsData();
                                MessageBox.Show("Room Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "RoomsUpd");
                        }
                    }
                    
                }
            }
        }

        private void Gn2BtnDel_Click(object sender, EventArgs e)
        {
            if (LbResponse2.Text == "Room Found")
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete RoomNum: {TxtBxRoomNum2.Text}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string deldata = "Delete From Rooms Where RoomNum = @rmnum";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@rmnum", TxtBxRoomNum2.Text.Trim());

                                delcmd.ExecuteNonQuery();
                                FetchRoomsData();
                                MessageBox.Show("Room Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "RoomsDel");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Trying to Delete Room Which Doesn't Exist", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool CheckEmptyFields1()
        {
            if (string.IsNullOrEmpty(TxtBxRoomNum1.Text) || (!RdBtn1A.Checked && !RdBtn1B.Checked))
            {
                return true;
            }
            return false;
        }

        private bool CheckEmptyFields2()
        {
            if (string.IsNullOrEmpty(TxtBxRoomNum2.Text) || (!RdBtn2A.Checked && !RdBtn2B.Checked))
            {
                return true;
            }
            return false;
        }

        private void ClearFields()
        {
            TxtBxRoomNum1.Clear();
            TxtBxRoomNum2.Clear();
            LbResponse2.Text = string.Empty;
            RdBtn1A.Checked = RdBtn1B.Checked = RdBtn2A.Checked = RdBtn2B.Checked = false;
        }

        
        
    }
}
