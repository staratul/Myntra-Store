using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    [Route("admin/brands")]
    public class AdminBrandController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Brands/Index.cshtml");
        }
    }
}
