using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sistem_absensi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuruController : ControllerBase
    {
        private static List<User> guruList = new List<User>() {
            new User("34567" ,"firmanpanji", "lukaku000", "Guru", "Firman Panji Utama"),
            new User("09876" ,"qalbunsaliim", "qwerty123", "Wakil Kepala Sekolah", "Muhammad Qalbun Saliim")
        };
        // GET: api/<ValuesController>
        [HttpGet(" Ambil data Guru")]
        public IEnumerable<User> Get()
        {
            return guruList;
        }

        // GET api/<ValuesController>/5
        [HttpGet(" Ambil data Guru by id")]
        public User Get(int id)
        {
            return guruList[id];
        }

        // POST api/<ValuesController>
        [HttpPost(" Simpan data Guru")]
        public void Post([FromBody] User value)
        {
            if (cekPassword(value.password))
            {
                guruList.Add(value);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("Update data Guru")]
        public void Put(int id, [FromBody] string value)
        {
            guruList[id].id = value;
            guruList[id].username = value;
            guruList[id].password = value;
            guruList[id].password = value;
            guruList[id].role = value;
            guruList[id].nama = value;

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete(" Delete data Guru")]
        public void Delete(int id)
        {
            guruList.RemoveAt(id);
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
