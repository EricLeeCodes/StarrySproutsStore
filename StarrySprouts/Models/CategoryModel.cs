using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(128)]
        public string CategoryName { get; set; }
        [Required]
        [MaxLength(1024)]
        public string CategoryDescription { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
