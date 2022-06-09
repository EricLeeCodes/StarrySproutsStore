using Microsoft.AspNetCore.Mvc;

namespace StarrySprouts.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
