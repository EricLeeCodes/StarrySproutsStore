using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(256)]
        public string ImageThumbnailUrl { get; set; }

        [Required]
        [MaxLength(256)]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public bool IsOnSale { get; set; }
        
        [Required]
        public bool IsInStock { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
