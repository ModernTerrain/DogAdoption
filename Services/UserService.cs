using DogAdoption.Data;
using DogAdoption.Models;
using Microsoft.EntityFrameworkCore;

namespace DogAdoption.Services
{
    public static class UserService
    {
        public static DogAdoptionContext? _context { get; set; }
        private static Users? _currentUser;

        public static Users GetCurrentUserAsync()
        {
            // Return the currently logged-in user
            return _currentUser;
        }

        public static async Task<Users> LoginAsync(string email, string password)
        {
            // Find user by email and password
            _currentUser = await _context.Users
                                      .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return _currentUser; // Returns null if no user found
        }

        public static void LogoutAsync()
        {
            _currentUser = null;
        }
    }
}


