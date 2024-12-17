using System.Security.Cryptography.X509Certificates;

namespace DogAdoption.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string? RecipientName { get; set; }  
        public string? SenderName { get; set; }
        public string? Content {  get; set; }

    }
}
