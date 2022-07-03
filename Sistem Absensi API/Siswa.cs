using System;
namespace sistem_absensi
{
    public class Siswa
    {
        public DateTime date { get; set; }
        public string nama { get; set; }
        public string nim { get; set; }
        public string kelas { get; set; }
        public Siswa(DateTime date,string nama, string nim, string kelas)
        { 
            this.date = DateTime.Now;
            this.nama = nama;
            this.nim = nim;
            this.kelas = kelas; 
        }
    }
}
