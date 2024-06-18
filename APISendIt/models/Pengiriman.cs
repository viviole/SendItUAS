using System.Diagnostics.Contracts;

namespace APISendIt.models
{
    public class Pengiriman
    {
        public Pengiriman(string nama, int berat, string alamatTujuan, int jarak, string nomorTelepon, string metodePembayaran, int harga, int idKurir)
        {
            Contract.Requires(!string.IsNullOrEmpty(nama));
            Contract.Requires(berat >= 0);
            Contract.Requires(!string.IsNullOrEmpty(alamatTujuan));
            Contract.Requires(jarak >= 0);
            Contract.Requires(!string.IsNullOrEmpty(nomorTelepon));
            Contract.Requires(!string.IsNullOrEmpty(metodePembayaran));
            Contract.Requires(harga >= 0);

            Nama = nama;
            Berat = berat;
            AlamatTujuan = alamatTujuan;
            Jarak = jarak;
            NomorTelepon = nomorTelepon;
            MetodePembayaran = metodePembayaran;
            Harga = harga;
            IdKurir = idKurir;
            Status = "On Progress"; // Nilai default
        }

        public int Id { get; set; }
        public string Nama { get; set; }
        public int Berat { get; set; }
        public string AlamatTujuan { get; set; }
        public int Jarak { get; set; }
        public string NomorTelepon { get; set; }
        public string MetodePembayaran { get; set; }
        public int Harga { get; set; }
        public int IdKurir { get; set; }
        public string Status { get; set; }
    }
}
