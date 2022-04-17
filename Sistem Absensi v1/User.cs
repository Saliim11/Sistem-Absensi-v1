using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sistem_Absensi_v1
{
    internal class User
    {
        public List<users> user { get; set; }

        public User() { }

        public User(List<users> user)
        {
            this.user = user;
        }
        public static void Login<T>(T username, T password)
        {
            dynamic user = username;
            dynamic pass = password;
            
            UserConfig config = new UserConfig();
            //int panjang = config.uConf.user.Count;
            foreach (var item in config.uConf.user)
            {
                if(user == item.username && pass == item.password)
                {
                    MainSiswa mainSiswa = new MainSiswa();
                    Form1 form1 = new Form1();

                    form1.Hide();
                    mainSiswa.ShowDialog();
                    form1.Close();
                }
            }
        }

    }

    class users
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string nama { get; set; }

        public users(string id, string username, string password, string role, string nama)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
            this.nama = nama;
        }
    }
}
