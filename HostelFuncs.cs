using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelMS
{
    internal class HostelFuncs
    {
        public HostelFuncs() { }    
         
        protected SqlConnection GetConn()
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CSharp\\WinFormsNetFmwk1\\HostelMS\\Hostel.mdf;Integrated Security=True";
            return sqlcon;  
        }

        public DataTable GetData(string query)
        {
            DataTable dt;
            using (SqlConnection sqlcon = GetConn())
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public int GetCount(string query)
        {
            int count = 0;
            using (SqlConnection sqlcon = GetConn())
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        count = (int)result;
                    }
                }
            }
            return count;
        }

        public void SetData(string query, string msg)
        {

        }
    }
}
