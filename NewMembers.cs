using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MethodsFW;


namespace HostelMS
{
    public partial class FormNewMembs : Form
    {
        public FormNewMembs()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        HostelFuncs hstlfncs = new HostelFuncs();
        private void FormNewMembs_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchRoomNumsInCB();
                    FetchMembId();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FormRoomsLoad");
                }
            }
        }

       
        private void Gn2BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields...", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            if (!string.IsNullOrEmpty(TxtBxEmail.Text) && !Solutions.ValdEmail(TxtBxEmail.Text))
            {
                MessageBox.Show("Invalid Email...", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into NewMembers (MembName, PhnNum, EmailId, HomeTown, IdProof, RoomNum, DateInsert) Values (@mbname, @phnnum, @email, @hmtwn, @idproof, @rmnum, @dtins)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@mbname", TxtBxMembName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@email", TxtBxEmail.Text ?? string.Empty);
                            inscmd.Parameters.AddWithValue("@hmtwn", TxtBxHTown.Text.Trim());
                            inscmd.Parameters.AddWithValue("@idproof", TxtBxIdProof.Text.Trim());
                            inscmd.Parameters.AddWithValue("@rmnum", CmbBxRoomNum.Text);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            MessageBox.Show("Room Member Registration Successfull \nNote the MemberId", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            
                        }

                        string upddata = "Update Rooms Set BookStatus = @bksts Where RoomNum = @rmnum";
                        using (SqlCommand updcmd =  new SqlCommand(upddata, sqlcon))
                        {
                            updcmd.Parameters.AddWithValue("@rmnum", CmbBxRoomNum.Text);
                            updcmd.Parameters.AddWithValue("@bksts", "Yes");

                            updcmd.ExecuteNonQuery() ;
                        }
                        ClearFields();
                        FetchRoomNumsInCB();
                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine(ex.Message, "SqlMembSave");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "MembSave");
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            LbMembId.Text = "{?}";
            TxtBxMembName.Clear();  
            TxtBxHTown.Clear();
            TxtBxEmail.Clear();
            TxtBxIdProof.Clear();   
            MTBPhnNum.Clear();
            CmbBxRoomNum.ResetText();
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxMembName.Text) || string.IsNullOrEmpty(TxtBxHTown.Text) || string.IsNullOrEmpty(TxtBxIdProof.Text) || !MTBPhnNum.MaskCompleted || CmbBxRoomNum.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        private void FetchRoomNumsInCB()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    CmbBxRoomNum.Items.Clear();
                    sqlcon.Open();
                    string seldata = "Select RoomNum From Rooms Where RoomStatus = @rmsts AND BookStatus = @bksts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@rmsts", "Active");
                        selcmd.Parameters.AddWithValue("@bksts", "No");

                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Int64 roomnum = (Int64)sdr["RoomNum"];
                            CmbBxRoomNum.Items.Add(roomnum);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchRoomNums");
                }
            }
        }

        private void FetchMembId()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Count(*) From NewMembers";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            int id = Convert.ToInt32(res);
                            LbMembId.Text = $"{id + 1}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchMembId");
                }
            }
        }
    }
}
