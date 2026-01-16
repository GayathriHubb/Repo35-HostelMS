using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MethodsFW;

namespace HostelMS
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";
   
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            bool signup = Solutions.SignUpProcess(TxtBxUn.Text.Trim(), TxtBxPswrd.Text.Trim(), TxtBxCnfmPswrd.Text.Trim());
            if (signup)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();
                        string insdata = "Insert Into Users (Username, Password, DateCreate) Values (@un, @pswrd, @dtcrt)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@un", TxtBxUn.Text.Trim());
                            inscmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dtcrt", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            MessageBox.Show("SignUp Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            Form1Login frmlgn = new Form1Login();   
                            frmlgn.Show();
                            Hide();
                        }
                    }
                    catch (SqlException ex)
                    {
                        string tempun = Solutions.CapitalizeFirstLetter1(TxtBxUn.Text.Trim());
                        MessageBox.Show($"Username: {tempun} is Existing Already/Something Went Wrong", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        Debug.WriteLine(ex.Message, "Username");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SignUp");
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUn.Clear();
            TxtBxPswrd.Clear();
            TxtBxCnfmPswrd.Clear();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Form1Login frmlgn = new Form1Login();
            frmlgn.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
