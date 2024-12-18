using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AdoptionFee { get; set; }
    }
}
