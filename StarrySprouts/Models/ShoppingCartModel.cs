using StarrySprouts.Data;

namespace StarrySprouts.Models
{
    public class ShoppingCartModel
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItemsModel> MyProperty { get; set; }

        public ShoppingCartModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCartModel GetCart(IServiceProvider services)
        {
            //Conditional operator acts as a null check
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //This is to see if a cart session exists. If it doesn't exist, we assign it to a new Guid.
            //Double conditional operator acts as a null check with an if statement. If it is there it will be assigned to CartId. If it isn't a new Guid is assigned.
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCartModel(context) { ShoppingCartId = cartId };

        }

        public void AddToCart(ProductModel product, int amount)
        {
            //Retrieve item if we had it
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Product.ProductId == product.ProductId && ShoppingCartId == ShoppingCartId);

            //Creating new item if it was null
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItemsModel
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Amount = amount
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            //If we already had the item, we add the amount
            else
            {
                shoppingCartItem.Amount++;
            }

            _appDbContext.SaveChanges();

        }



        
    }
}
