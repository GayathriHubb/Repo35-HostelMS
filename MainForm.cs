using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HostelMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure to Quit ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            e.Cancel = true;
        }

        private void Gn2BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure to Logout ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Form1Login frmlgn = new Form1Login();
                frmlgn.Show();
                Hide();
            }
        }

        bool lbvisible = true;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (lbvisible)
            {
                LbHeading.Visible = true;
                lbvisible = false;
            }
            else
            {
                LbHeading.Visible = false;
                lbvisible = true;
            }
        }

        private void MainBtns_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            switch (btn.Name)
            {
                case "Gn2BtnRooms":
                    FormRooms frmrms = new FormRooms();
                    frmrms.Show();
                    break;

                case "Gn2BtnNewMembs":
                    FormNewMembs frmmembs = new FormNewMembs();
                    frmmembs.Show();
                    break;

                case "Gn2BtnUpdDelMembs":
                    FormUpdDelMembs frmupddelmbs = new FormUpdDelMembs();
                    frmupddelmbs.Show();
                    break;

                case "Gn2BtnMembsFees":
                    FormMembsFees frmmembsfs = new FormMembsFees();
                    frmmembsfs.Show();
                    break;

                case "Gn2BtnAllMembsLiving":
                    FormAllMembsLiving frmallmembslv = new FormAllMembsLiving();
                    frmallmembslv.Show();
                    break;

                case "Gn2BtnLeavedMembs":
                    FormVacantMembs frmvacmembs = new FormVacantMembs();
                    frmvacmembs.Show();
                    break;

                case "Gn2BtnNewEmps":
                    FormNewEmp frmnewemps = new FormNewEmp();   
                    frmnewemps.Show();
                    break;

                case "Gn2BtnUpdDelEmps":
                    FormUpdDelEmps frmupddelemps = new FormUpdDelEmps();
                    frmupddelemps.Show();
                    break;

                case "Gn2BtnEmpsPay":
                    FormEmpPayment frmemppayment = new FormEmpPayment();    
                    frmemppayment.Show();
                    break;

                case "Gn2BtnAllEmpsWork":
                    FormWorkingEmps frmwkemps = new FormWorkingEmps();
                    frmwkemps.Show();
                    break;

                case "Gn2BtnLeavedEmps":
                    FormLeavedEmps frmlvdemps = new FormLeavedEmps();
                    frmlvdemps.Show();
                    break;
                default: break;
            }

        }
    }
}
