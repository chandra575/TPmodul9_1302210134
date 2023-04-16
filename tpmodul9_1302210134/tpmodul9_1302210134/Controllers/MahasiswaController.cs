using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210134.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Chandra Bayu Samudra", "1302210134"),
            new Mahasiswa("Samuel Firmansah", "1302213041"),
            new Mahasiswa("Bambang Haryanto", "1302213183"),
            new Mahasiswa("Abdurahman Whid", "1302213181"),
            new Mahasiswa("Siti Nurhayati", "1302213295")
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            dataMahasiswa.Add(newMahasiswa);
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
