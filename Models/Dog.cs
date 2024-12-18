using System.ComponentModel.DataAnnotations;

namespace DogAdoption.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string? Name {  get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Breed { get; set; }

        [Required]
        public string? Size { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string? Description { get; set; }

        public bool Hypoallergenic { get; set; }

        [Required]
        public string? ImageFileName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Status { get; set; }

        [DataType(DataType.Currency)]
        public decimal AdoptionFee { get; set; }
    }
}
