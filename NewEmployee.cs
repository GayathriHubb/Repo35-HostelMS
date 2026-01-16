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
    public partial class FormNewEmp : Form
    {
        public FormNewEmp()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void FormNewEmp_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchEmpId();
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
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into NewEmployees (EmpName, Gender, PhnNum, EmailId, HomeTown, IdProof, Designation, DateInsert) Values (@empname, @gndr, @phnum, @email, @hmtwn, @idprf, @desig, @dtins)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@empname", TxtBxEmpName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                            inscmd.Parameters.AddWithValue("@phnum", MTBPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@email", TxtBxEmail.Text ?? string.Empty);
                            inscmd.Parameters.AddWithValue("@hmtwn", TxtBxHTown.Text.Trim());
                            inscmd.Parameters.AddWithValue("@idprf", TxtBxIdProof.Text.Trim());
                            inscmd.Parameters.AddWithValue("@desig", CmbBxDesignation.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);    

                            inscmd.ExecuteNonQuery();
                            MessageBox.Show("Employee Registration Successfull \nNote the EmployeeId", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "EmpSave");
                    }
                }
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        
        private void FetchEmpId()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Count(*) From NewEmployees";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            int id = Convert.ToInt32(res);
                            LbEmpId.Text = $"{id + 1}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchMembId");
                }
            }
        }

        private void ClearFields()
        {
            LbEmpId.Text = string.Empty;
            TxtBxEmpName.Clear();
            TxtBxHTown.Clear();
            TxtBxIdProof.Clear();   
            MTBPhnNum.Clear();
            TxtBxEmail.Clear();
            CmbBxGender.ResetText();
            CmbBxDesignation.ResetText();
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
