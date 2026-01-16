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
    public partial class FormMembsFees : Form
    {
        public FormMembsFees()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";
        HostelFuncs hstlfncs = new HostelFuncs();

        private void MembsFees_Load(object sender, EventArgs e)
        {

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    SetDGVRecord(null);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FormRoomsLoad");
                }
            }
        }

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
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                TxtBxRoomNum.Text = Convert.ToInt64(sdr["RoomNum"]).ToString();
                                TxtBxLiveStatus.Text = (string)sdr["LivingStatus"];

                                SetDGVRecord(Convert.ToInt64(TxtBxMembId.Text));
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

        private void Gn2BtnPay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxMembId.Text) && NUDAmount.Value > 0)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Fees Where MembId = @mbid AND FeesMonth = @fsmnth";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@mbid", TxtBxMembId.Text);
                            selcmd.Parameters.AddWithValue("@fsmnth", DTP1.Text);
                            int rc = Convert.ToInt32(selcmd.ExecuteScalar());
                            if (rc == 0)
                            {
                                string insdata = "Insert Into Fees (MembId, FeesMonth, Amount, DateInsert) Values (@mbid, @fsmnth, @amnt, @dtins)";
                                using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@mbid", TxtBxMembId.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@fsmnth", DTP1.Text);
                                    inscmd.Parameters.AddWithValue("@amnt", NUDAmount.Value);
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    inscmd.ExecuteNonQuery();
                                    SetDGVRecord(Convert.ToInt64(TxtBxMembId.Text));
                                    MessageBox.Show($"Fees for Month {DTP1.Text} Paid", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"No Dues Of {DTP1.Text} Left", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                                
                        }

                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnPay");
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void SetDGVRecord(Int64? MembId)
        {
            string seldata = $"Select * From Fees Where MembId = '{MembId}'";
            DataTable dt = hstlfncs.GetData(seldata);
            DGVFees.DataSource = dt;

            LbTRC.Text = DGVFees.Rows.Count.ToString();
        }

        private void ClearFields()
        {
            TxtBxMembId.Clear();
            TxtBxMembName.Clear();
            TxtBxHTown.Clear();
            TxtBxRoomNum.Clear();
            TxtBxLiveStatus.Clear();
            MTBPhnNum.Clear();
            DTP1.ResetText();   
            NUDAmount.Value = 0;
            SetDGVRecord(null);
        }
            
    }
}
