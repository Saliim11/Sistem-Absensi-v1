using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Absensi_v1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public void genrRegister<N>(N nama, N username, N password, N role)
        {

        }

        public string getNama()
        {
            return textBox1.Text;
        }

        public string getUsername()
        {
            return textBox2.Text;
        }

        public string getPassword()
        {
            return textBox3.Text;
        }

        public string getRole()
        {
            if (radioButton1.Checked == true)
            {
                return radioButton1.Text;
            }
            else
            {
                return radioButton2.Text;
            }
        }

        public string getId()
        {
            Random rand = new Random();
            int x = rand.Next(100000, 900000);
            return x.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserConfig uc = new UserConfig();
            uc.WriteConfigFile(getId(),getUsername(), getPassword(), getRole(), getNama());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
