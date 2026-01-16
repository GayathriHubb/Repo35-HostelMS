using MethodsFW;
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

namespace HostelMS
{
    public partial class FormUpdDelMembs : Form
    {
        public FormUpdDelMembs()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";
        HostelFuncs hstlfncs = new HostelFuncs();

        private void Gn2BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxMembId.Text))
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();
                        string seldata = "Select * From NewMembers Where NewMembsId = @membid";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@membid", TxtBxMembId.Text.Trim());
                            SqlDataReader sdr = selcmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                TxtBxMembName.Text = (string)sdr["MembName"];
                                TxtBxHTown.Text = (string)sdr["HomeTown"];
                                TxtBxIdProof.Text = (string)sdr["IdProof"];
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                TxtBxEmail.Text = (sdr["EmailId"] != null) ? (string)sdr["EmailId"] : string.Empty;
                                TxtBxRoomNum.Text = Convert.ToInt64(sdr["RoomNum"]).ToString();
                                CmbBxLiveStatus.Text = (string)sdr["LivingStatus"];
                            }
                            else
                            {
                                MessageBox.Show("MemberId Doesn't Exist", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                ClearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSearch");
                    }
                }
            }
            else
            {
                ClearFields();  
            }
        }

        private void Gn2BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                return; 
            }
            if (!string.IsNullOrEmpty(TxtBxEmail.Text) && !Solutions.ValdEmail(TxtBxEmail.Text))
            {
                MessageBox.Show("Invalid Email...", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Update MembId: {TxtBxMembId.Text.Trim()} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string upddata1 = "Update NewMembers Set MembName = @mbname, PhnNum = @phnnum, EmailId = @email, HomeTown = @hmtwn, IdProof = @idprf, RoomNum = @rmnum, LivingStatus = @lvsts Where NewMembsId = @mbid";
                            using (SqlCommand updcmd1 = new SqlCommand(upddata1, sqlcon))
                            {
                                updcmd1.Parameters.AddWithValue("@mbname", TxtBxMembName.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                                updcmd1.Parameters.AddWithValue("@email", TxtBxEmail.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@hmtwn", TxtBxHTown.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@idprf", TxtBxIdProof.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@rmnum", TxtBxRoomNum.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@lvsts", CmbBxLiveStatus.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@mbid", TxtBxMembId.Text.Trim());

                                updcmd1.ExecuteNonQuery();

                                MessageBox.Show("Room Member Info Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                string upddata2 = "Update Rooms Set BookStatus = @bksts Where RoomNum = @rmnum";
                                using (SqlCommand updcmd2 = new SqlCommand(upddata2, sqlcon))
                                {
                                    updcmd2.Parameters.AddWithValue("@bksts", CmbBxLiveStatus.Text);
                                    updcmd2.Parameters.AddWithValue("@rmnum", TxtBxRoomNum.Text);

                                    updcmd2.ExecuteNonQuery();
                                }
                                ClearFields();  
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "MembUpd");
                        }
                    }
                }
            }
        }

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxMembId.Text))
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete MembId: {TxtBxMembId.Text} ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From NewMembers Where MembId = @mbid";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@mbid", TxtBxMembId.Text);

                                delcmd.ExecuteNonQuery();
                                MessageBox.Show("Room Member Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();  
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "MembDelete");
                        }
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
            TxtBxMembId.Clear();    
            TxtBxMembName.Clear();
            TxtBxHTown.Clear();
            TxtBxEmail.Clear();
            TxtBxIdProof.Clear();   
            TxtBxRoomNum.Clear();  
            MTBPhnNum.Clear();
            CmbBxLiveStatus.SelectedIndex = -1; ;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxMembName.Text) || string.IsNullOrEmpty(TxtBxHTown.Text) || string.IsNullOrEmpty(TxtBxIdProof.Text) || !MTBPhnNum.MaskCompleted || string.IsNullOrEmpty(TxtBxRoomNum.Text) || CmbBxLiveStatus.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }
    }
}
