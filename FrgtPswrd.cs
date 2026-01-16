using MethodsFW;
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
    public partial class FormFrgtPswrd : Form
    {
        public FormFrgtPswrd()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void BtnResetPswrd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtBxUn.Text))
            {
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();
                        string seldata = "Select Count(*) From Users Where Username = @un";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", TxtBxUn.Text.Trim());
                            int rc = 0;
                            object res = selcmd.ExecuteScalar();    
                            if (res != DBNull.Value)
                            {
                                rc = (int)res;
                            }

                            if (rc > 0)
                            {
                                TxtBxPassword.Text = Solutions.SetPassword();


                                string upddata = "Update Users Set Password = @pswrd Where Username = @un";
                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@un", TxtBxUn.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@pswrd", TxtBxPassword.Text);

                                    updcmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username", "Warning");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "ResetPswrd");
                    }
                }
            }
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPassword.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
