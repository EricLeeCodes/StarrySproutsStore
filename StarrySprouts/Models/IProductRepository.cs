namespace StarrySprouts.Models
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAllProducts { get; }
        IEnumerable<ProductModel> GetProductsOnSale { get; }
        ProductModel GetProductById(int productId);
    }
}
