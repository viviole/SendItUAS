using System.Data;
using System.Diagnostics.Contracts;

namespace APISendIt.models
{
    public class PengirimAPI : UsersAPI
    {
        public PengirimAPI(string namaLengkap, string username, string password, string usia) : base(namaLengkap, username, password, usia)
        {
            Contract.Requires(!string.IsNullOrEmpty(namaLengkap));
            Contract.Requires(!string.IsNullOrEmpty(username));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(usia));
            Contract.Ensures(Role == Role.Pengirim);

            Role = Role.Pengirim;
        }

        public PengirimAPI() { }
    }
}