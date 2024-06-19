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
    internal class Authentication
    {
        string urlPengirim = "http://localhost:5069/api/Pengirim";
        string urlKurir = "http://localhost:5069/api/Kurir";

        HttpClient client = new HttpClient();

        public async Task<Users> AuthenticateUser(string username, string password, Role role)
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
                    Console.WriteLine(jsonResponse);
                    Users[] result = JsonConvert.DeserializeObject<Users[]>(jsonResponse);
                    Console.WriteLine(result);
                    foreach (Users users in result)
                    {
                        if (users.UserName == username && users.Password == password)
                        {
                            if (loggedInUser != null)
                            {
                                Console.WriteLine("Apakah tidak ada serius?");
                                return null;
                            }
                            loggedInUser = users;
                        }
                    }
                    return loggedInUser;
                }
                return null;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }

        

        public async Task<bool> RegisterUser(string namaLengkap, string username, string password, string umur, Role role)
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
                List<string> duplicatedUsername = await UserController.GetUsersAsync();

                foreach (string name in duplicatedUsername) 
                {
                    if (name == username) 
                    {
                        Console.WriteLine("Username already exists");
                        return false;
                    }
                }

                Users newUser = new Users(namaLengkap, username, password, umur)
                {
                    Role = role
                };
                string jsonContent = JsonConvert.SerializeObject(newUser);
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(urlAPI, content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}
