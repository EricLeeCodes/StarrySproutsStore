using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class OrderDetailsModel
    {
        [Key]
        public int OrderDetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public ProductModel Products { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public decimal Price { get; set; }

        public OrderModel Order { get; set; }

    }
}
