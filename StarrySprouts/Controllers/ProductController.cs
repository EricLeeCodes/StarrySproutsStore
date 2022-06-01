using Microsoft.AspNetCore.Mvc;
using StarrySprouts.Models;
using StarrySprouts.ViewModels;

namespace StarrySprouts.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        //Injected through constructor
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_productRepository.GetAllProducts);

            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProducts;
            productListViewModel.CurrentCategory = "Bestsellers";
            return View(productListViewModel);
        }

        

    }
}
