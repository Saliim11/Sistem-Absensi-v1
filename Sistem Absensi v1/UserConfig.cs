using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Absensi_v1
{
    public class UserConfig
    {
        public User uConf;
        public static string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public static string fileConfig = "users.json";
        public string fullPath = path + "/" + fileConfig;

        public UserConfig()
        {
            try
            {
                ReadConfigFile();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("File tidak ditemukan! \n" + e);
            }
        }

        private User ReadConfigFile()
        {
            string jsonStringFromFile = File.ReadAllText(fullPath);
            uConf = JsonConvert.DeserializeObject<User>(jsonStringFromFile);
            return uConf;
        }

        public void WriteConfigFile(string id, string uname, string pw, string getrole, string nama)
        {
            File.SetAttributes("C:/Users/Panji/Documents/VS Community things/UNTUK UTS/Sistem-Absensi-v1-Panji/Sistem Absensi v1/users.json", FileAttributes.Normal);
            string json = File.ReadAllText(fullPath);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            Register reg = new Register();
            //jsonObj["user"].Add(JToken.FromObject(new users(reg.getId(), reg.getUsername(), reg.getPassword(), reg.getRole(), reg.getNama())));
            jsonObj["user"].Add(JToken.FromObject(new users(id, uname, pw, getrole, nama)));
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", output);
        }

    }
}
