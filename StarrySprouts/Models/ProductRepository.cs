using Microsoft.EntityFrameworkCore;
using StarrySprouts.Data;

namespace StarrySprouts.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ProductModel> GetAllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }   
        }

        public IEnumerable<ProductModel> GetProductsOnSale
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public ProductModel GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
