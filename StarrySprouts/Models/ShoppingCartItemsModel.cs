using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class ShoppingCartItemsModel
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        [Required]
        public string ShoppingCartId { get; set; }
        [Required]
        public ProductModel Product { get; set; }
        [Required]
        public int Amount { get; set; }


    }
}
