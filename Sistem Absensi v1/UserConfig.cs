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
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public string fileConfig = "users.json";

        public UserConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception e)
            {
                //throw;
                Console.WriteLine("File tidak ditemukan! \n" + e);
            }
        }

        private User ReadConfigFile()
        {
            string jsonStringFromFile = File.ReadAllText(path + "/" + fileConfig);
            uConf = JsonConvert.DeserializeObject<User>(jsonStringFromFile);
            return uConf;
        }

    }
}
