using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAdoption.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HouseholdIncome { get; set; }

        [Required]
        public int NumberOfPets { get; set; }

        [Required]
        public string? DogOfInterest { get; set; }

        [Required]
        public string? DateOfInterest { get; set; }
    }
}
