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
    public partial class FormWorkingEmps : Form
    {
        public FormWorkingEmps()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void FormWorkingEmps_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select NewEmployees.NewEmpId as EmpId, EmpName, PhnNum, EmailId, HomeTown, IdProof, Designation, WorkingStatus From NewEmployees Where WorkingStatus = @wksts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@wksts", "Yes");
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVWorkingEmps.DataSource = dt;
                        LbTRC.Text = DGVWorkingEmps.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "EmpssLoad");
                }
            }
        }
    }
}

