using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace StarrySprouts.Models
{
    public class OrderModel
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip")]
        [StringLength(5, MinimumLength = 5)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        
        public List<OrderDetailsModel> OrderDetails { get; set; } = new List<OrderDetailsModel>();

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

        
    }
}
