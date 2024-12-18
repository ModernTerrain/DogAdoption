using DogAdoption.Models;

namespace DogAdoption.Services
{
    public class AdminService
    {
        private List<Users> _users = new List<Users>
    {
        new Users { Id = 1, Email = "admin@dogadoption.com", Password = "adminpassword", isAdmin = true },
        new Users { Id = 2, Email = "user@dogadoption.com", Password = "userpassword", isAdmin = false }
    };

        private Users _currentUser;

        public Task<Users> LoginAsync(string email, string password)
        {
            // Simulate login check
            _currentUser = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return Task.FromResult(_currentUser);
        }

        public Task<Users> GetCurrentUserAsync()
        {
            // Return the currently logged-in user
            return Task.FromResult(_currentUser);
        }
    }
}

