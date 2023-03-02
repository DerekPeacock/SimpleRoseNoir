using System.ComponentModel.DataAnnotations;

namespace SimpleRoseNoir.Models
{
    public class Variation
    {
        public int VariationId { get; set; }

        public int ProductId { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = String.Empty;

        [StringLength(400)]
        public string Description { get; set; } = String.Empty;

        // Alternative option price if not the same as the main product
        [DataType(DataType.Currency)]
        public decimal Price { get; set; } = 0;

        public string Colour { get; set; }= String.Empty;

        // Navigation Property

        public virtual Product Product { get; set; }

    }
}
