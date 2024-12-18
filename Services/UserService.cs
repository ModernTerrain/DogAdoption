using DogAdoption.Data;
using DogAdoption.Models;
using Microsoft.EntityFrameworkCore;

namespace DogAdoption.Services
{
    public class UserService : IUserService
    {
        private readonly DogAdoptionContext? _context;
        private Users? _currentUser;

        public UserService(DogAdoptionContext context)
        {
            _context = context;
        }

        public Task<Users> GetCurrentUserAsync()
        {
            // Return the currently logged-in user
            return Task.FromResult(_currentUser);
        }

        public async Task<Users> LoginAsync(string email, string password)
        {
            // Find user by email and password
            var user = await _context.Users
                                      .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user; // Returns null if no user found
        }
    }
}


