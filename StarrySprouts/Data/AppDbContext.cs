using Microsoft.EntityFrameworkCore;
using StarrySprouts.Models;

namespace StarrySprouts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        //Which DbSet to manage
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ShoppingCartItemsModel> ShoppingCartItems { get; set; }

        //Seeding the data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Categories to seed
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel
            {
                CategoryId = 1,
                CategoryName = "Stickers",
                CategoryDescription = "Beautiful fantasy-inspired stickers for any occasion!"
                
            });
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel
            {
                CategoryId = 2,
                CategoryName = "Plushy",
                CategoryDescription = "Cute and snuggly creations to physically be with you!"
            });
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel
            {
                CategoryId = 3,
                CategoryName = "Apparel",
                CategoryDescription = "Fantasy-inspired apparel to represent the StarrySprouts brand!"
            });
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel
            {
                CategoryId = 4,
                CategoryName = "Misc",
                CategoryDescription = "An assortment of goodies from StarrySprouts!"
            });


            //Products to seed

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 1,
                ImageThumbnailUrl = "/assets/images/FloralDragon/FloralDragonStickerSheetThumbnail.jpg",
                ImageUrl = "/assets/images/FloralDragon/FloralDragonStickerSheet.jpg",
                Name = "Floral Dragon Sticker Sheet",
                Price = 4.90M,
                Description = "Though many dragons may be fearsome, there are some that also enjoy the soft beauty of flowers. " +
                "The floral scents calm them so, and the brilliant colours of the petals are the equivalent of treasure for them. " +
                "When the flowers bloom, there surely will be dragons nearby. A perfect fairy-tale touch to flourish any surface!",
                CategoryId = 1,
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 2,
                ImageThumbnailUrl = "/assets/images/FairyPenguin/FairyPenguinStickerSheetThumbnail.jpg",
                ImageUrl = "/assets/images/FairyPenguin/FairyPenguinStickerSheet.jpg",
                Name = "Fairy Penguin Sticker Sheet",
                Price = 4.90M,
                Description = "Occasionally fluttering by is the sweet fairy penguins. " +
                "They much prefer to swim and their wings are waterproof, which fortunately helps to catch their favourite snack: fish! Any kind of fish can tame these docile creatures.",
                CategoryId = 1,
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 3,
                ImageThumbnailUrl = "/assets/images/MoonBunny/MoonBunnyStickerSheetThumbnail.jpg",
                ImageUrl = "/assets/images/MoonBunny/MoonBunnyStickerSheet.jpg",
                Name = "Moon Bunny Sticker Sheet",
                Price = 4.90M,
                Description = "Out in space, there lives the moon rabbits. Harvesters of stars and growers of space carrots! " +
                "There's a bustling colony of them that live on the moon, and they love coming down to the lands of Sprout to go on vacation. " +
                "Many businesses of Sprout hire moon rabbits to go and explore the vastness of space to bring back rare minerals and materials. " +
                "At the end of the day, a moon rabbit loves to cozy up and watch a good meteor shower.",
                CategoryId = 1,
                IsInStock = true,
                IsOnSale = false
            });

           


        }
    }
}
