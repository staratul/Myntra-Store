using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blogs()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
