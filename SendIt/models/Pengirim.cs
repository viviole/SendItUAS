using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendIt.models
{
    public class Pengirim : Users
    {
        public Pengirim(string namaLengkap, string username, string password, string usia) : base(namaLengkap, username, password, usia)
        {
            Contract.Requires(!string.IsNullOrEmpty(namaLengkap));
            Contract.Requires(!string.IsNullOrEmpty(username));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(usia));
            Contract.Ensures(this.Role == Role.Pengirim);

            this.Role = Role.Pengirim;
        }
        public Pengirim() { }
    }
}
