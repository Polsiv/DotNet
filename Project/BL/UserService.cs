using DAL;
using Models;
using Newtonsoft.Json;

namespace BL {
    public class UserService
    {
        private readonly DataService _dataService = new DataService();
        
        public async Task<List<User>> GetAllUsersAsync()
        {
            string jsonData = await _dataService.GetUsersAsync();
            return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();;
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            return await _dataService.AddUserAsync(user);
        }
    }

}

