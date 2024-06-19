using System.Diagnostics.Contracts;

namespace APISendIt.models
{
    public class KurirAPI : UsersAPI
    {
        public KurirAPI(string namaLengkap, string username, string password, string umur) : base(namaLengkap, username, password, umur)
        {
            Contract.Requires(!string.IsNullOrEmpty(namaLengkap));
            Contract.Requires(!string.IsNullOrEmpty(username));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(umur));
            Contract.Ensures(Role == Role.Kurir);

            Role = Role.Kurir;
        }
        public KurirAPI() { }
    }
}