using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}
