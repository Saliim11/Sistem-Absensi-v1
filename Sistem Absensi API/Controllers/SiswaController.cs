using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sistem_absensi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        private static List<Siswa> siswaList = new List<Siswa>() {
            new Siswa(DateTime.Now,"rafi", "1302204116", "11G"),
            new Siswa(DateTime.Now,"Ucok", "1302204129", "11C")
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
