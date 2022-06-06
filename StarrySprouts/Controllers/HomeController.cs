using Microsoft.AspNetCore.Mvc;
using StarrySprouts.Models;
using StarrySprouts.ViewModels;
using System.Diagnostics;

namespace StarrySprouts.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOnSale = _productRepository.GetProductsOnSale
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}