using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Range(1,1000)]
        public double Price { get; set; }

        [MaxLength(2000)]
        public string? Description { get; set; }

        [MaxLength(250)]
        public string? CategoryName { get; set; }

        [MaxLength(500)]
        public string? ImageURL { get; set; }


    }
}
