﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using APISendIt.models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace APISendIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PengirimanController : ControllerBase
    {
        private static List<Pengiriman> pengirimanList = new List<Pengiriman>();
        private static List<Users> usersList = new List<Users>(); // Simulasi daftar pengguna
        private readonly ILogger<PengirimanController> _logger;
        private static readonly Random random = new Random(); // Tambahkan random di sini

        public PengirimanController(ILogger<PengirimanController> logger)
        {
            _logger = logger;

            // Contoh data pengguna
            usersList.Add(new Users("Kurir Satu", "kurir1", "password1", "30") { Id = 1, role = Role.Kurir });
            usersList.Add(new Users("Kurir Dua", "kurir2", "password2", "28") { Id = 2, role = Role.Kurir });
            usersList.Add(new Users("Pengirim Satu", "pengirim1", "password3", "25") { Id = 3, role = Role.Pengirim });
        }

        // GET: api/<PengirimanController>
        [HttpGet]
        public IEnumerable<Pengiriman> Get()
        {
            return pengirimanList;
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
        public ActionResult Post([FromBody] Pengiriman pengiriman)
        {
            // Ambil semua kurir dengan peran 'Kurir'
            var kurirList = usersList.Where(u => u.role == Role.Kurir).ToList();
            if (!kurirList.Any())
            {
                return BadRequest("Tidak ada kurir yang tersedia.");
            }

            // Pilih kurir secara acak
            var randomKurir = kurirList[random.Next(kurirList.Count)];

            pengiriman.IdKurir = randomKurir.Id; // Tetapkan IdKurir
            pengiriman.Id = pengirimanList.Count + 1;
            pengirimanList.Add(pengiriman);

            _logger.LogInformation($"Received new data: {JsonConvert.SerializeObject(pengiriman)}");

            return Ok();
        }

        // EDIT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Pengiriman pengiriman)
        {
            var existingPengiriman = pengirimanList.FirstOrDefault(p => p.Id == id);
            if (existingPengiriman == null)
            {
                return NotFound();
            }
            existingPengiriman.Nama = pengiriman.Nama;
            existingPengiriman.Berat = pengiriman.Berat;
            existingPengiriman.AlamatTujuan = pengiriman.AlamatTujuan;
            existingPengiriman.Jarak = pengiriman.Jarak;
            existingPengiriman.NomorTelepon = pengiriman.NomorTelepon;
            existingPengiriman.MetodePembayaran = pengiriman.MetodePembayaran;
            existingPengiriman.Harga = pengiriman.Harga;
            existingPengiriman.Status = pengiriman.Status;
            existingPengiriman.IdKurir = pengiriman.IdKurir;
            return NoContent();
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