using Microsoft.AspNetCore.Mvc;
using StarrySprouts.Models;
using StarrySprouts.ViewModels;

namespace StarrySprouts.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCartModel _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCartModel shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetAllShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            //Finding the product's ID
            var selectedProduct = _productRepository.GetAllProducts.FirstOrDefault(p => p.ProductId == productId);

            //If the product is not null then we can add it to the cart.
            if (selectedProduct != null && selectedProduct.IsInStock == true)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            //Finding the product's ID
            var selectedProduct = _productRepository.GetAllProducts.FirstOrDefault(p => p.ProductId == productId);

            //If the product is not null and is in stock then we can add it to the cart.
            if (selectedProduct != null && selectedProduct.IsInStock == true)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }

            return RedirectToAction("Index");
        }

    }
}
