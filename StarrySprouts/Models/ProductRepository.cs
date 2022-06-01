namespace StarrySprouts.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<ProductModel> GetAllProducts => new List<ProductModel>
        {
            new ProductModel
            {
                ProductId = 1,
                ImageThumbnailUrl = "/assets/images/FloralDragon/FloralDragonStickerSheet.jpg",
                ImageUrl = "/assets/images/FloralDragon/FloralDragonStickerSheet.jpg",
                Name = "Floral Dragons Sticker Sheet",
                Description = "Though many dragons may be fearsome, there are some that also enjoy the soft beauty of flowers. " +
                "The floral scents calm them so, and the brilliant colours of the petals are the equivalent of treasure for them. " +
                "When the flowers bloom, there surely will be dragons nearby. A perfect fairy-tale touch to flourish any surface!",
                Price = 4.90M,
                IsInStock = true,
                IsOnSale = false,
                Category = _categoryRepository.GetAllCategories.ToList()[0]

            },
             
            new ProductModel
            {
                ProductId = 2,
                ImageThumbnailUrl = "/assets/images/FairyPenguin/FairyPenguinStickerSheetThumbnail.jpg",
                ImageUrl = "/assets/images/FairyPenguin/FairyPenguinStickerSheet.jpg",
                Name = "Fairy Penguin Sticker Sheet",
                Description = "Occasionally fluttering by is the sweet fairy penguins. " +
                "They much prefer to swim and their wings are waterproof, which fortunately helps to catch their favourite snack: fish! " +
                "Any kind of fish can tame these docile creatures.",
                Price = 4.90M,
                IsInStock = true,
                IsOnSale = false,
                Category = _categoryRepository.GetAllCategories.ToList()[0]

            },

            new ProductModel
            {
                ProductId = 3,
                ImageThumbnailUrl = "/assets/images/MoonBunny/MoonBunnyStickerSheetThumbnail.jpg",
                ImageUrl = "/assets/images/MoonBunny/MoonBunnyStickerSheet.jpg",
                Name = "Moon Bunny Sticker Sheet",
                Description = "Out in space, there lives the moon rabbits. Harvesters of stars and growers of space carrots! " +
                "There's a bustling colony of them that live on the moon, and they love coming down to the lands of Sprout to go on vacation. " +
                "Many businesses of Sprout hire moon rabbits to go and explore the vastness of space to bring back rare minerals and materials. " +
                "At the end of the day, a moon rabbit loves to cozy up and watch a good meteor shower.",
                Price = 4.90M,
                IsInStock = true,
                IsOnSale = false,
                Category = _categoryRepository.GetAllCategories.ToList()[0]


            }
        };

        public IEnumerable<ProductModel> GetProductsOnSale => throw new NotImplementedException();

        public ProductModel GetProductById(int productId)
        {
            return GetAllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
