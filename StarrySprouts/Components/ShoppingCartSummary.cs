using Microsoft.AspNetCore.Mvc;
using StarrySprouts.Models;
using StarrySprouts.ViewModels;

namespace StarrySprouts.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCartModel _shoppingCart;

        public ShoppingCartSummary(ShoppingCartModel shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        //This needs to be in ViewComponent
        public IViewComponentResult Invoke()
        {
            //First, get all of the shopping cart items
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetAllShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };

            return View(shoppingCartViewModel);
        }


    }
}
