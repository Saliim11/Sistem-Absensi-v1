using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sistem_absensi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        private static List<Siswa> siswaList = new List<Siswa>() {
            new Siswa("12345", "radenrafi", "abcde123","Tim IT","Raden Rafi Alif Akbar"),
            new Siswa("09876", "qalbunsaliim", "qwerty123","Wakil Kepala Sekolah","Muhammad Qalbun Saliim")
        };

        // GET: api/<SiswaController>
        [HttpGet]
        public IEnumerable<Siswa> Get()
        {
            return siswaList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Siswa Get(int id)
        {
            return siswaList[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Siswa value)
        {
            siswaList.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            siswaList.RemoveAt(id); 
        }
    }
}
