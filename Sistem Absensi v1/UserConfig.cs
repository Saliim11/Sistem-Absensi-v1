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
                WriteConfigFile();
                Console.WriteLine("File tidak ditemukan! \n" + e);
            }
        }

        private User ReadConfigFile()
        {
            string jsonStringFromFile = File.ReadAllText(path + "/" + fileConfig);
            uConf = JsonConvert.DeserializeObject<User>(jsonStringFromFile);
            return uConf;
        }

        private void WriteConfigFile()
        {

            string json = File.ReadAllText(path + "/" + fileConfig);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            Register reg = new Register();
            jsonObj["user"].Add();
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", output);
        }

    }
}
