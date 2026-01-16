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
    public partial class FormVacantMembs : Form
    {
        public FormVacantMembs()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void FormVacantMembs_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select NewMembers.NewMembsId as MembId, MembName, PhnNum, EmailId, HomeTown, IdProof, RoomNum, LivingStatus From NewMembers Where LivingStatus = @lvsts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@lvsts", "No");
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVVacantMembs.DataSource = dt;
                        LbTRC.Text = DGVVacantMembs.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "VacantMembsLoad");
                }
            }
        }
    }
}
