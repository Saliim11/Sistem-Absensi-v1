using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sistem_absensi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        private static List<User> siswaList = new List<User>() {
            new User("12345", "radenrafi", "abcde123","Tim IT","Raden Rafi Alif Akbar"),
            new User("1111111", "rizkyramdhan", "rizkyganteng117","Siswa","Rizky Ramdhan Nugraha")
        };

        // GET: api/<SiswaController>
        [HttpGet(" Ambil data Siswa")]
        public IEnumerable<User> Get()
        {
            return siswaList;
        }

        // GET api/<ValuesController>/5
        [HttpGet(" Ambil data Siswa by id")]
        public User Get(int id)
        {
            return siswaList[id];
        }

        // POST api/<ValuesController>
        [HttpPost(" Simpan data Siswa")]
        public void Post([FromBody] User value)
        {
            if (cekPassword(value.password))
            {
                siswaList.Add(value);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete(" Delete data Siswa")]
        public void Delete(int id)
        {
            siswaList.RemoveAt(id); 
        }
        public static bool cekPassword(string password)
        {
            if (password.Length <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
