using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class ShoppingCartItemsModel
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        [Required]
        [MaxLength(3000)]
        public string ShoppingCartId { get; set; }
        [Required]
        public ProductModel Product { get; set; }
        [Required]
        public int Amount { get; set; }


    }
}
