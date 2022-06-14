using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class OrderDetailsModel
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public OrderModel Order { get; set; }
    }
}
