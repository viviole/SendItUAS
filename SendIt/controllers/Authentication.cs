using Newtonsoft.Json;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SendIt.controllers
{
    internal class Authentication
    {
        private readonly string urlPengirim = "http://localhost:5069/api/Pengirim";
        private readonly string urlKurir = "http://localhost:5069/api/Kurir";

        private readonly HttpClient client = new HttpClient();
        private readonly Repository<Users> _userRepository;

        public Authentication()
        {
            _userRepository = new Repository<Users>(client);
        }

        private string HashPassword(string password, string salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            return Convert.ToBase64String(hash);
        }

        public async Task<Users> AunthenticateUser(string username, string password, Role role)
        {
            string urlAPI = role == Role.Kurir ? urlKurir : urlPengirim;

            try
            {
                List<Users> users = await _userRepository.GetAll(urlAPI);
                Users loggedInUser = null;

                foreach (Users user in users)
                {
                    string inputPasswordHash = HashPassword(password, user.Salt);
                    if (user.UserName == username && user.PasswordHash == inputPasswordHash)
                    {
                        if (loggedInUser != null)
                        {
                            return null;
                        }
                        loggedInUser = user;
                    }
                }
                return loggedInUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> RegisterUser(string namaLengkap, string username, string password, string umur, Role role)
        {
            string urlAPI = role == Role.Kurir ? urlKurir + "/registerKurir" : urlPengirim + "/registerPengirim";

            try
            {
                List<string> duplicatedUsernames = await GetUsersAsync(role);

                if (duplicatedUsernames.Contains(username))
                {
                    Console.WriteLine("Username already exists");
                    return false;
                }

                Users newUser;
                if (role == Role.Kurir)
                {
                    newUser = new Kurir(namaLengkap, username, password, umur);
                }
                else
                {
                    newUser = new Pengirim(namaLengkap, username, password, umur);
                }

                return await _userRepository.Add(urlAPI, newUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
        }

        private async Task<List<string>> GetUsersAsync(Role role)
        {
            string urlAPI = role == Role.Kurir ? urlKurir : urlPengirim;

            List<Users> users = await _userRepository.GetAll(urlAPI);
            return users.Select(u => u.UserName).ToList();
        }
    }
}
