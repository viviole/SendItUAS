using Newtonsoft.Json;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace SendIt.controllers
{
    internal class Authentication
    {
        string urlPengirim = "http://localhost:5069/api/Pengirim";
        string urlKurir = "http://localhost:5069/api/Kurir";

        HttpClient client = new HttpClient();

        private string HashPassword(string password, string salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            return Convert.ToBase64String(hash);
        }

        public async Task<Users> AunthenticateUser(string username, string password, Role role)
        {

            string urlAPI;

            if (role == Role.Kurir)
            {
                urlAPI = urlKurir;
            }
            else
            {
                urlAPI = urlPengirim;
            }

            try
            {
                HttpResponseMessage response = await client.GetAsync(urlAPI);
                Console.Write(response);
                if (response != null && response.IsSuccessStatusCode)
                {
                    Users loggedInUser = null;
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Users[] result = JsonConvert.DeserializeObject<Users[]>(jsonResponse);

                    foreach (Users users in result)
                    {
                        string inputPasswordHash = HashPassword(password, users.Salt);
                        if (users.UserName == username && users.PasswordHash == inputPasswordHash)
                        {
                            if (loggedInUser != null)
                            {
                                return null;
                            }
                            loggedInUser = users;
                        }
                    }
                    return loggedInUser;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }



        public async Task<bool> RegisterUser(string namaLengkap, string username, string password, string umur, Role role)
        {
            string urlAPI = role == Role.Kurir ? urlKurir + "/registerKurir" : urlPengirim + "/registerPengirim";

            try
            {
                List<string> duplicatedUsername = await UserController.GetUsersAsync();

                if (duplicatedUsername.Contains(username))
                {
                    return false;
                }

                // Create user object
                Users newUser;
                if (role == Role.Kurir)
                {
                    newUser = new Kurir(namaLengkap, username, password, umur);
                }
                else
                {
                    newUser = new Pengirim(namaLengkap, username, password, umur);
                }

                // Serialize object to JSON
                string jsonContent = JsonConvert.SerializeObject(newUser);
                Console.WriteLine("JSON Content: " + jsonContent);

                // Send POST request
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(urlAPI, content);

                string responseContent = await response.Content.ReadAsStringAsync();

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
        }
    }
}