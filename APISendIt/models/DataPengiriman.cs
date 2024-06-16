using System.Diagnostics.Contracts;

namespace APISendIt.models
{
    public class DataPengiriman
    {
            public DataPengiriman(string nama, int berat, string alamatTujuan, int jarak, string nomorTelepon, string metodePembayaran)
            {
                Contract.Requires(!string.IsNullOrEmpty(nama));
                Contract.Requires(!int.IsNegative(berat));
                Contract.Requires(!string.IsNullOrEmpty(alamatTujuan));
                Contract.Requires(!int.IsNegative(jarak));
                Contract.Requires(!string.IsNullOrEmpty(metodePembayaran));
            }
    }
}
