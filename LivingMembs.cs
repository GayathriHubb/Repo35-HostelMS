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
    public partial class FormAllMembsLiving : Form
    {
        public FormAllMembsLiving()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\HostelMS\Hostel.mdf;Integrated Security = True";

        private void AllMembsLiving_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select NewMembers.NewMembsId as MembId, MembName, PhnNum, EmailId, HomeTown, IdProof, RoomNum, LivingStatus From NewMembers Where LivingStatus = @lvsts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@lvsts", "Yes");
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVAllMembsLive.DataSource = dt;   
                        LbTRC.Text = DGVAllMembsLive.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "MembsLoad");    
                }
            }
        }
    }
}
