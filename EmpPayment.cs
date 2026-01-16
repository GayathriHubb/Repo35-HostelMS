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
    public partial class FormEmpPayment : Form
    {
        public FormEmpPayment()
        {
            InitializeComponent();
        }


        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";
        HostelFuncs hstlfncs = new HostelFuncs();

        private void EmpPayment_Load(object sender, EventArgs e)
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
            if (!string.IsNullOrEmpty(TxtBxEmpId.Text))
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();
                        string seldata = "Select * From NewEmployees Where NewEmpId = @empid";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@empid", TxtBxEmpId.Text.Trim());
                            SqlDataReader sdr = selcmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                TxtBxMembName.Text = (string)sdr["EmpName"];
                                TxtBxHTown.Text = (string)sdr["HomeTown"];
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                TxtBxDesignation.Text = (string)sdr["Designation"];
                                TxtBxWorkStatus.Text = (string)sdr["WorkingStatus"];

                                SetDGVRecord(Convert.ToInt32(TxtBxEmpId.Text));
                            }
                            else
                            {
                                MessageBox.Show("EmployeeId Doesn't Exist", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
            if (!string.IsNullOrEmpty(TxtBxEmpId.Text) && NUDAmount.Value > 0)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Salary Where EmpId = @empid AND SalaryMonth = @smnth";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@empid", TxtBxEmpId.Text);
                            selcmd.Parameters.AddWithValue("@smnth", DTP1.Text);
                            int rc = Convert.ToInt32(selcmd.ExecuteScalar());
                            if (rc == 0)
                            {
                                string insdata = "Insert Into Salary (EmpId, SalaryMonth, Amount, DateInsert) Values (@empid, @smnth, @amnt, @dtins)";
                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@empid", TxtBxEmpId.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@smnth", DTP1.Text);
                                    inscmd.Parameters.AddWithValue("@amnt", NUDAmount.Value);
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    inscmd.ExecuteNonQuery();
                                    SetDGVRecord(Convert.ToInt32(TxtBxEmpId.Text));
                                    MessageBox.Show($"Salary for Month {DTP1.Text} Paid Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Payment of {DTP1.Text} Already Done", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }

                        }

                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnPaySalary");
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void SetDGVRecord(Int64? EmpId)
        {
            string seldata = $"Select * From Salary Where EmpId = '{EmpId}'";
            DataTable dt = hstlfncs.GetData(seldata);
            DGVSalary.DataSource = dt;

            LbTRC.Text = DGVSalary.Rows.Count.ToString();
        }

        private void ClearFields()
        {
            TxtBxEmpId.Clear();
            TxtBxMembName.Clear();
            TxtBxHTown.Clear();
            TxtBxDesignation.Clear();
            MTBPhnNum.Clear();
            NUDAmount.Value = 0;
            DTP1.ResetText();
            TxtBxWorkStatus.Clear();
            SetDGVRecord(null);
        }
    }
}
