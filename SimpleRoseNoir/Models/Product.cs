using System.ComponentModel.DataAnnotations;

namespace SimpleRoseNoir.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required, StringLength(60)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; } = 0;

        // Navigation Property

        public virtual ICollection<Variation> Variations { get; set; }
    }
}
