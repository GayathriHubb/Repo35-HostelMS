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

namespace HostelMS
{
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUn.Text) || string.IsNullOrEmpty(TxtBxPswrd.Text))
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
                        string seldata = "Select Count(*) From Users Where Username = @un AND Password = @pswrd";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", TxtBxUn.Text.Trim());
                            selcmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());

                            int rc = 0;
                            object res = selcmd.ExecuteScalar();
                            if (res != DBNull.Value)
                            {
                                rc = Convert.ToInt32(res);
                            }

                            if (rc > 0)
                            {
                                MessageBox.Show("Login Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                MainForm mnfrm = new MainForm();
                                mnfrm.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SignIn");
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUn.Clear();
            TxtBxPswrd.Clear();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frmSignUp = new FormSignUp();
            frmSignUp.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

        private void LbFrgtPswrd_Click(object sender, EventArgs e)
        {
            FormFrgtPswrd frgtpswrd = new FormFrgtPswrd();
            frgtpswrd.ShowDialog();
        }
            
    }
}
