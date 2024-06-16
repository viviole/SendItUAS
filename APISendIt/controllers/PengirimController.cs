using APISendIt.models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APISendIt.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PengirimController : ControllerBase
    {
        public static List<Pengirim> PenggunaData = new List<Pengirim>
        {
            new Pengirim("Budi Yanto", "budiyanto", "password123", "27"),
            new Pengirim("Bob Sadino", "bobsadino", "password456", "55"),
            new Pengirim("Jonny Cage", "jonnycage", "password789", "39")
        };

        [HttpGet]
        public IEnumerable<Pengirim> Get()
        {
            Debug.Assert(PenggunaData != null, "Data Pengirim tidak boleh kosong");
            return PenggunaData;
        }

        [HttpGet("{id}")]
        public Pengirim? Get(int id)
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

        [HttpPost]
        public void Post([FromBody] Pengirim value)
        {
            Debug.Assert(value != null, "Nilai tidak boleh kosong");
            PenggunaData.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pengirim value)
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
