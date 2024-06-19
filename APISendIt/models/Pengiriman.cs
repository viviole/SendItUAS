using System.Diagnostics.Contracts;

namespace APISendIt.models
{
    public class Pengiriman
    {
        public Pengiriman(string nama, int berat, string alamatTujuan, string alamatJemput, int jarak, string nomorTelepon, string metodePembayaran, int harga, int idKurir,int idPengirim)
        {
            Contract.Requires(!string.IsNullOrEmpty(nama), "Nama tidak boleh kosong");
            Contract.Requires(berat >= 0, "Berat tidak boleh negatif");
            Contract.Requires(!string.IsNullOrEmpty(alamatTujuan), "Alamat tujuan tidak boleh kosong");
            Contract.Requires(!string.IsNullOrEmpty(alamatJemput), "Alamat jemput tidak boleh kosong");
            Contract.Requires(jarak >= 0, "Jarak tidak boleh negatif");
            Contract.Requires(!string.IsNullOrEmpty(nomorTelepon), "Nomor telepon tidak boleh kosong");
            Contract.Requires(!string.IsNullOrEmpty(metodePembayaran), "Metode pembayaran tidak boleh kosong");
            Contract.Requires(harga >= 0, "Harga tidak boleh negatif");
            Contract.Requires(idKurir > 0, "ID Kurir harus angka positif");
            Contract.Requires(idPengirim > 0, "ID Kurir harus angka positif");

            Nama = nama;
            Berat = berat;
            AlamatTujuan = alamatTujuan;
            AlamatJemput = alamatJemput;
            Jarak = jarak;
            NomorTelepon = nomorTelepon;
            MetodePembayaran = metodePembayaran;
            Harga = harga;
            IdKurir = idKurir;
            IdPengirim = idPengirim;
            Status = "On Progress"; // Nilai default
        }

        public int Id { get; set; }
        public string Nama { get; set; }
        public int Berat { get; set; }
        public string AlamatTujuan { get; set; }
        public string AlamatJemput { get; set; }
        public int Jarak { get; set; }
        public string NomorTelepon { get; set; }
        public string MetodePembayaran { get; set; }
        public int Harga { get; set; }
        public int IdKurir { get; set; }
        public int IdPengirim { get; set; }
        public string Status { get; set; }
    }
}
