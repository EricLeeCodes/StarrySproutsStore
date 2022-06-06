using StarrySprouts.Data;

namespace StarrySprouts.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CategoryModel> GetAllCategories => _appDbContext.Categories;
    }
}
