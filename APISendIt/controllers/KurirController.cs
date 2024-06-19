using Microsoft.AspNetCore.Mvc;
using System;
using APISendIt.models;
using System.Diagnostics;

namespace APISendIt.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KurirController : ControllerBase
    {
        public static List<KurirAPI> KurirData = new List<KurirAPI>
        {
            new KurirAPI("Hasan Pane", "NPane", "password123", "19"),
            new KurirAPI("Marjauza Naswansyah", "MNaswan", "password456", "20"),
            new KurirAPI("Nizar Rasyiid", " ", "password789", "21")
        };

        [HttpGet]
        public IEnumerable<KurirAPI> Get()

        {
            Console.WriteLine("Mengambil data semua kurir");
            foreach (var kurir in KurirData)
            {
                Console.WriteLine($"Kurir ID: {kurir.Id}, Nama: {kurir.NamaLengkap}");
            }
            return KurirData;
        }

        [HttpGet("{id}")]
        public KurirAPI? Get(int id)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");

            for (int i = 0; i < KurirData.Count; i++)
            {
                if (KurirData[i].Id == id)
                {
                    return KurirData[i];
                }
            }

            return null;
        }

        [HttpPost("registerKurir")]
        public IActionResult RegisterKurir([FromBody] KurirAPI kurir)
        {
            if (kurir == null)
            {
                return BadRequest("Invalid Kurir data");
            }

            // Perform the registration logic
            KurirData.Add(kurir);
            return Ok();
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] KurirAPI value)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");
            Debug.Assert(value != null, "Data Kurir tidak boleh kosong");

            for (int i = 0; i < KurirData.Count; i++)
            {
                if (KurirData[i].Id == id)
                {
                    KurirData[i] = value;
                }
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");

            for (int i = 0; i < KurirData.Count; i++)
            {
                if (KurirData[i].Id == id)
                {
                    KurirData.RemoveAt(i);

                }
            }
        }
    }

}