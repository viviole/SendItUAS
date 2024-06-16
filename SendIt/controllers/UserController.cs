using Newtonsoft.Json;
using SendIt.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SendIt.controllers
{
    internal class UserController
    {
        private static readonly HttpClient client = new HttpClient();
        private static string urlAPI = "http://localhost:5069/api/users";

        public static async Task<List<string>> GetUsersAsync()
        {
            List<string> userName = new List<string>();
            try
            {
                HttpResponseMessage response = await client.GetAsync(urlAPI);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Users[] userData = JsonConvert.DeserializeObject<Users[]>(data);
                    foreach (Users user in userData)
                    {
                        userName.Add(user.UserName);
                    }                        
                    return userName;
                }
                else
                {
                    Console.WriteLine("Gagal memanggil API: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
