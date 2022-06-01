namespace StarrySprouts.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<CategoryModel> GetAllCategories => new List<CategoryModel>()
        {
            new CategoryModel
            {
                CategoryId = 1,
                CategoryName = "Stickers",
                CategoryDescription = "Beautiful Fantasy Stickers"
            },
            new CategoryModel
            {
                CategoryId = 2,
                CategoryName = "Plushy",
                CategoryDescription = "Adorable Snuggly Plushies"
            },
            new CategoryModel
            {
                CategoryId = 3,
                CategoryName = "Clothing",
                CategoryDescription = "Stylish and Comfortable Clothing"
            }
        };
    }
}
