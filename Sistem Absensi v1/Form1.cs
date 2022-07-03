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
    public partial class Form1 : Form
    {
       // public static Form1 instance;
        //StateLogin stateLogin = new StateLogin();
        UserConfig config = new UserConfig();

        string username;
        string password;

        public Form1()
        {
            InitializeComponent();
            //instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            username = input_Username.Text;
            password = input_Password.Text;
            Debug.Assert(password.Length >= 8, "Panjang password harus melebihi 8 karakter");

            FuncLogin<String>(username, password);
            
        }

        public void FuncLogin<T>(T username, T password)
        {
            dynamic user = username;
            dynamic pass = password;

            foreach (var item in config.uConf.user)
            {
                if (user == item.username && pass == item.password)
                {
                    StateLogin.activeTrigger(StateLogin.Trigger.Login);
                    Debug.WriteLine("kondisi setelah login: "+StateLogin.currentState);

                    switch (item.role)
                    {
                        case "Siswa":
                            MainSiswa mainSiswa = new MainSiswa();
                            mainSiswa.namaUser = item.nama;

                            this.Hide();
                            mainSiswa.ShowDialog();
                            this.Close();
                            break;

                        case "Guru":
                            MainGuru mainGuru = new MainGuru();
                            mainGuru.namaUser = item.nama;

                            this.Hide();
                            mainGuru.ShowDialog();
                            this.Close();
                            break;

                        case "Wakil Kepala Sekolah":
                            MainWakasek mainWakasek = new MainWakasek();
                            mainWakasek.namaUser = item.nama;

                            this.Hide();
                            mainWakasek.ShowDialog();
                            this.Close();
                            break;

                        case "Tim IT":
                            MainTimIT mainTimIT = new MainTimIT();
                            mainTimIT.namaUser = item.nama;

                            this.Hide();
                            mainTimIT.ShowDialog();
                            this.Close();
                            break;
                    }

                    break;
                }
            }
            if(StateLogin.currentState == StateLogin.State.Offline)
            {
                MessageBox.Show("username/password salah!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSwitchRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
