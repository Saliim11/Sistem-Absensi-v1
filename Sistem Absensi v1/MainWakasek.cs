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
    public partial class MainWakasek : Form
    {
        public string namaUser { get; set; }
        public MainWakasek()
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

        private void MainWakasek_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Hai, Pak " + namaUser;
        }
    }
}
