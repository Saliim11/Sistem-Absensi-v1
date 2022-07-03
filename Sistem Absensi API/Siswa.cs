using System;
namespace sistem_absensi
{
    public class Siswa
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string nama { get; set; }
    
        public Siswa(string id, string username, string password, string role, string nama)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
            this.nama = nama;
        }
    }
}
