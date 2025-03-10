using System.Text;
using Models;
using Newtonsoft.Json;

namespace DAL 
{
    public class DataService
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly string _baseUrl = "http://localhost:3000/api/v1";

        public async Task<string> GetUsersAsync()
        {
            HttpResponseMessage response = await _client.GetAsync($"{_baseUrl}/users");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<bool> AddUserAsync(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync($"{_baseUrl}/users", content);
            return response.IsSuccessStatusCode;
        }
    }
}


