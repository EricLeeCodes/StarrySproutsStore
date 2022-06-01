namespace StarrySprouts.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
