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
    public partial class FormUpdDelEmps : Form
    {
        public FormUpdDelEmps()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void UpdDelEmps_Load(object sender, EventArgs e)
        {

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
                                TxtBxEmpName.Text = (string)sdr["EmpName"];
                                CmbBxGender.Text = (string)sdr["Gender"];
                                TxtBxHTown.Text = (string)sdr["HomeTown"];
                                TxtBxIdProof.Text = (string)sdr["IdProof"];
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                TxtBxEmail.Text = (sdr["EmailId"] != null) ? (string)sdr["EmailId"] : string.Empty;
                                CmbBxDesignation.Text = (string)sdr["Designation"];
                                CmbBxWorkingStatus.Text = (string)sdr["WorkingStatus"];
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

        private void Gn2BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(TxtBxEmail.Text) && !Solutions.ValdEmail(TxtBxEmail.Text))
            {
                MessageBox.Show("Invalid Email...", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Update EmpId: {TxtBxEmpId.Text.Trim()} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string upddata1 = "Update NewEmployees Set EmpName = @empname, PhnNum = @phnnum, EmailId = @email, HomeTown = @hmtwn, IdProof = @idprf, WorkingStatus = @wksts Where NewEmpId = @empid";
                            using (SqlCommand updcmd1 = new SqlCommand(upddata1, sqlcon))
                            {
                                updcmd1.Parameters.AddWithValue("@empname", TxtBxEmpName.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                                updcmd1.Parameters.AddWithValue("@email", TxtBxEmail.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@hmtwn", TxtBxHTown.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@idprf", TxtBxIdProof.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@wksts", CmbBxWorkingStatus.Text.Trim());
                                updcmd1.Parameters.AddWithValue("@empid", TxtBxEmpId.Text.Trim());

                                updcmd1.ExecuteNonQuery();

                                MessageBox.Show("Employee Info Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "EmpUpd");
                        }
                    }
                }
            }
        }

        private void Gn2BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxEmpId.Text))
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete EmpId: {TxtBxEmpId.Text} ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From NewEmployees Where NewEmpId = @empid";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@empid", TxtBxEmpId.Text);

                                delcmd.ExecuteNonQuery();
                                MessageBox.Show("Employee Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "EmpDelete");
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
            TxtBxEmpId.Clear();
            TxtBxEmpName.Clear();
            TxtBxHTown.Clear();
            TxtBxIdProof.Clear();
            TxtBxEmail.Clear();
            MTBPhnNum.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxDesignation.SelectedIndex = -1;
            CmbBxWorkingStatus.SelectedIndex = -1;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxEmpName.Text) || string.IsNullOrEmpty(TxtBxIdProof.Text) || string.IsNullOrEmpty(TxtBxHTown.Text) || !MTBPhnNum.MaskCompleted ||
                CmbBxDesignation.SelectedIndex == -1 || CmbBxGender.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }
    }
}
