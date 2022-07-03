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
    public class User
    {
        public List<users> user { get; set; }

        //public User() { }

        public User(List<users> user)
        {
            this.user = user;
        }

    }

    public class users
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
