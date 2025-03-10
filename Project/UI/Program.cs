using BL;
using Models;

namespace UI {
    class Program
    {
        static async Task Main() {
            UserService userService = new UserService();

            Console.WriteLine("Fetching Users");
            var users = await userService.GetAllUsersAsync();
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Username: {user.Username}");
            }

            Console.WriteLine("\nAdding a new users");
            var newUser = new User { Id = 12, Name = "John Doe", Username = "JDoe" };
            bool success = await userService.CreateUserAsync(newUser);

            Console.WriteLine(success ? "User added successfully!" : "Failed to add user.");
        }
    }
}