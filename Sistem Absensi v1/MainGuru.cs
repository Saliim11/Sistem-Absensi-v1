using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Absensi_v1
{
    public partial class MainGuru : Form
    {
        public string namaUser { get; set; }
        public MainGuru()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin Logout?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StateLogin.activeTrigger(StateLogin.Trigger.Logout);
                Debug.WriteLine("kondisi setelah logout: " + StateLogin.currentState);

                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void MainGuru_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Hai, Pak " + namaUser;
        }

        private void check_in_Click(object sender, EventArgs e)
        {
            StateGuru.ActiveTrigger(StateGuru.Trigger.Check_in);
            Debug.WriteLine("kondisi setelah check in: " + StateGuru.currentState);
            
            check_in.Visible = false;
            check_out.Visible = true;
        }

        private void check_out_Click(object sender, EventArgs e)
        {
            StateGuru.ActiveTrigger(StateGuru.Trigger.Check_out);
            Debug.WriteLine("kondisi setelah check out: " + StateGuru.currentState);

            check_in.Visible = true;
            check_out.Visible = false;
        }
    }
}
