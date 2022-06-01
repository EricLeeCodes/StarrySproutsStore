using StarrySprouts.Models;

namespace StarrySprouts.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
        public string CurrentCategory { get; set; }

    }
}
