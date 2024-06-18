using APISendIt.models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APISendIt.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PengirimControllerAPI : ControllerBase
    {
        public static List<PengirimAPI> PenggunaData = new List<PengirimAPI>
        {
            new PengirimAPI("Budi Yanto", "budiyanto", "password123", "27"),
            new PengirimAPI("Bob Sadino", "bobsadino", "password456", "55"),
            new PengirimAPI("Jonny Cage", "jonnycage", "password789", "39")
        };

        [HttpGet]
        public IEnumerable<PengirimAPI> Get()
        {
            Debug.Assert(PenggunaData != null, "Data Pengirim tidak boleh kosong");
            return PenggunaData;
        }

        [HttpGet("{id}")]
        public PengirimAPI? Get(int id)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");

            for (int i = 0; i < PenggunaData.Count; i++)
            {
                if (PenggunaData[i].Id == id)
                {
                    return PenggunaData[i];
                }
            }

            return null;
        }

        [HttpPost("registerPengirim")]
        public IActionResult RegisterPengirim([FromBody] PengirimAPI pengirim)
        {
            if (pengirim == null)
            {
                return BadRequest("Invalid Pengirim data");
            }

            // Perform the registration logic
            PenggunaData.Add(pengirim);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PengirimAPI value)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");
            Debug.Assert(value != null, "Nilai tidak boleh kosong");

            for (int i = 0; i < PenggunaData.Count; i++)
            {
                if (PenggunaData[i].Id == id)
                {
                    PenggunaData[i] = value;
                    return;
                }
            }

            Debug.Fail("Pengirim dengan ID tersebut tidak ditemukan");
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");

            for (int i = 0; i < PenggunaData.Count; i++)
            {
                if (PenggunaData[i].Id == id)
                {
                    PenggunaData.RemoveAt(i);
                    return;
                }
            }

            Debug.Fail("Pengirim dengan ID tersebut tidak ditemukan");
        }
    }
}
