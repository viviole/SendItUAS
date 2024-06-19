using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
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
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
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
            Contract.Ensures(this.Umur == umur);

            this.NamaLengkap = namaLengkap;
            this.UserName = username;
            this.Umur = umur;
            this.Id = new Random().Next();

            // Generate salt and hash the password
            this.Salt = GenerateSalt();
            this.PasswordHash = HashPassword(password, this.Salt);
        }

        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        private string HashPassword(string password, string salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            return Convert.ToBase64String(hash);
        }

        public Users() { }
    }
}