﻿using Microsoft.AspNetCore.Mvc;
using System;
using APISendIt.models;
using System.Diagnostics;

namespace APISendIt.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KurirController : ControllerBase
    {
        public static List<Kurir> KurirData = new List<Kurir>
        {
            new Kurir("Hasan Pane", "NPane", "password123", "19"),
            new Kurir("Marjauza Naswansyah", "MNaswan", "password456", "20"),
            new Kurir("Nizar Rasyiid", "NRasyiid", "password789", "21")
        };

        [HttpGet]
        public IEnumerable<Kurir> Get()
        {
            Debug.Assert(KurirData != null, "Data Kurir tidak boleh kosong");
            return KurirData;
        }

        [HttpGet("{id}")]
        public Kurir? Get(int id)
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

        [HttpPost]
        public void Post([FromBody] Kurir value)
        {
            Debug.Assert(value != null, "Data Kurir tidak boleh kosong");

            KurirData.Add(value);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Kurir value)
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
