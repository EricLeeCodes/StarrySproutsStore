using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarrySprouts.Models;

namespace StarrySprouts.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCartModel _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCartModel shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(OrderModel order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetAllShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CompletedCheckout");
            }

            return View(order);
        }

        public IActionResult CompletedCheckout()
        {
            ViewBag.CompletedCheckoutMessage = "Thank you for your order. Your stickers are on the way!";
            return View();
        }
    }
}
