namespace DogAdoption.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool isAdmin { get; set; } = false;

    }
}
