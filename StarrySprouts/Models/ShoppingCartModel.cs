using Microsoft.EntityFrameworkCore;
using StarrySprouts.Data;

namespace StarrySprouts.Models
{
    public class ShoppingCartModel
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItemsModel> ShoppingCartItems { get; set; }

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

        //Returns integer because it deals with the amount of items in the cart.
        public int RemoveFromCart(ProductModel product)
        {
            //Retrieve item if we had it
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Product.ProductId == product.ProductId && ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;

        }

        public List<ShoppingCartItemsModel> GetAllShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems
                .Where(p => p.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Product).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(p => p.ShoppingCartId == ShoppingCartId)
                .Select(p => p.Product.Price * p.Amount).Sum();

            return total;
        }

        
    }
}
