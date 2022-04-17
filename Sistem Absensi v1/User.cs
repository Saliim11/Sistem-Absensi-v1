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

        public List<users> ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string jsonString = File.ReadAllText(path + "/users.json");

            User printUser = JsonConvert.DeserializeObject<User>(jsonString);
            /*foreach (var users in printUser.user)
            {
                Console.WriteLine("ID: " + users.id);
                Console.WriteLine("Username: " + users.username);
                Console.WriteLine("Password: " + users.password);
                Console.WriteLine("Role: " + users.role);
                Console.WriteLine("Nama: " + users.nama + "\n");
            }*/

            return printUser.user;
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
