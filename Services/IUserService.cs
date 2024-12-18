using DogAdoption.Models;

namespace DogAdoption.Services
{
    public interface IUserService
    {
        Task<Users> LoginAsync(string email, string password);

        Task<Users> GetCurrentUserAsync();
    }
}
