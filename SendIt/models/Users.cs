using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendIt.models
{
    public enum Role
    {
        Kurir,
        Pengirim

    }
    public class Users
    {
        public int Id { get; set; }
        public string NamaLengkap { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Umur { get; set; }
        public Role Role { get; set; }

        public Users(string namaLengkap, string username, string password, string umur)
        {
            Contract.Requires(!string.IsNullOrEmpty(namaLengkap));
            Contract.Requires(!string.IsNullOrEmpty(username));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(umur));
            Contract.Requires(umur.All(char.IsDigit));
            Contract.Ensures(this.NamaLengkap == namaLengkap);
            Contract.Ensures(this.UserName == username);
            Contract.Ensures(this.Password == password);
            Contract.Ensures(this.Umur == umur);

            Random random = new Random();
            this.NamaLengkap = namaLengkap;
            this.UserName = username;
            this.Umur = umur;
            this.Id = random.Next();
            this.Password = password;
        }

    }
}
