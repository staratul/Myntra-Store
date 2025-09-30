using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Faqs()
        {
            return View();
        }
    }
}
