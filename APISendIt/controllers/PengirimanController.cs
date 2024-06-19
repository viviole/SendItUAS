using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using APISendIt.models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Text;

namespace APISendIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PengirimanController : ControllerBase
    {
        private static List<Pengiriman> pengirimanList = new List<Pengiriman>();
        private static List<UsersAPI> usersList = new List<UsersAPI>(); // Simulasi daftar pengguna
        private readonly ILogger<PengirimanController> _logger;
        private static readonly Random random = new Random(); // Tambahkan random di sini

        public PengirimanController(ILogger<PengirimanController> logger)
        {
            _logger = logger;

            // Contoh data pengguna
            usersList.Add(new UsersAPI("Kurir Satu", "kurir1", "password1", "30") { Id = 1, Role = Role.Kurir });
            usersList.Add(new UsersAPI("Kurir Dua", "kurir2", "password2", "28") { Id = 2, Role = Role.Kurir });
            usersList.Add(new UsersAPI("Pengirim Satu", "pengirim1", "password3", "25") { Id = 3, Role = Role.Pengirim });
        }
        private async Task<List<KurirAPI>> GetKurirListFromKurirController()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:7150/api/Kurir");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var kurirList = JsonConvert.DeserializeObject<List<KurirAPI>>(jsonString);
                return kurirList ?? new List<KurirAPI>();
            }
            else
            {
                // Penanganan jika gagal mengambil data kurir
                // Misalnya, tampilkan pesan kesalahan atau kembalikan daftar kosong
                return new List<KurirAPI>();
            }
        }

        // GET: api/<PengirimanController>
        [HttpGet]
        public IEnumerable<Pengiriman> Get()
        {
            return pengirimanList;
        }

        // PUT method to update the status
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Pengiriman pengiriman)
        {
            var existingPengiriman = pengirimanList.FirstOrDefault(p => p.Id == id);
            if (existingPengiriman == null)
            {
                return NotFound();
            }

            existingPengiriman.Status = pengiriman.Status;
            return NoContent();
        }

        // GET api/<PengirimanController>/5
        [HttpGet("{id}")]
        public ActionResult<Pengiriman> Get(int id)
        {
            var pengiriman = pengirimanList.FirstOrDefault(p => p.Id == id);
            if (pengiriman == null)
            {
                return NotFound();
            }
            return pengiriman;
        }

        // POST api/<PengirimanController>
        [HttpPost]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Pengiriman pengiriman)
        {

            // Ambil daftar kurir dari KurirController
            var kurirList = await GetKurirListFromKurirController();

            if (!kurirList.Any())
            {
                return BadRequest("Tidak ada kurir yang tersedia.");
            }

            // Pilih kurir secara acak
            var randomKurir = kurirList[random.Next(kurirList.Count)];
            pengiriman.IdKurir = randomKurir.Id;

            // Tetapkan Id dan tambahkan ke pengirimanList
            pengiriman.Id = pengirimanList.Count + 1;
            pengirimanList.Add(pengiriman);

            _logger.LogInformation($"Received new data: {JsonConvert.SerializeObject(pengiriman)}");

            return Ok();
        }
        // DELETE api/<PengirimanController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pengiriman = pengirimanList.FirstOrDefault(p => p.Id == id);
            if (pengiriman == null)
            {
                return NotFound();
            }
            pengirimanList.Remove(pengiriman);
            return NoContent();
        }
    }
}
