using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarrySprouts.Data.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Beautiful fantasy-inspired stickers for any occasion!", "Stickers" },
                    { 2, "Cute and snuggly creations to physically be with you!", "Plushy" },
                    { 3, "Fantasy-inspired apparel to represent the StarrySprouts brand!", "Apparel" },
                    { 4, "An assortment of goodies from StarrySprouts!", "Misc" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, 1, "Though many dragons may be fearsome, there are some that also enjoy the soft beauty of flowers. The floral scents calm them so, and the brilliant colours of the petals are the equivalent of treasure for them. When the flowers bloom, there surely will be dragons nearby. A perfect fairy-tale touch to flourish any surface!", "/assets/images/FloralDragon/FloralDragonStickerSheetThumbnail.jpg", "/assets/images/FloralDragon/FloralDragonStickerSheet.jpg", true, false, "Floral Dragon Sticker Sheet", 4.90m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, 1, "Occasionally fluttering by is the sweet fairy penguins. They much prefer to swim and their wings are waterproof, which fortunately helps to catch their favourite snack: fish! Any kind of fish can tame these docile creatures.", "/assets/images/FairyPenguin/FairyPenguinStickerSheetThumbnail.jpg", "/assets/images/FairyPenguin/FairyPenguinStickerSheet.jpg", true, false, "Fairy Penguin Sticker Sheet", 4.90m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, 1, "Out in space, there lives the moon rabbits. Harvesters of stars and growers of space carrots! There's a bustling colony of them that live on the moon, and they love coming down to the lands of Sprout to go on vacation. Many businesses of Sprout hire moon rabbits to go and explore the vastness of space to bring back rare minerals and materials. At the end of the day, a moon rabbit loves to cozy up and watch a good meteor shower.", "/assets/images/MoonBunny/MoonBunnyStickerSheetThumbnail.jpg", "/assets/images/MoonBunny/MoonBunnyStickerSheet.jpg", true, false, "Moon Bunny Sticker Sheet", 4.90m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
