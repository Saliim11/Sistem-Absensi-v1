using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Absensi_v1
{
    internal class UserConfig
    {
        public User uConf;

        public UserConfig()
        {
            try
            {
                ReadJSON();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e);
                //throw;
            }
            
        }
        public User ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string jsonString = File.ReadAllText(path + "/users.json");

            User printUser = JsonConvert.DeserializeObject<User>(jsonString);

            return printUser;
        }
    }
}
