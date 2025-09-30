using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    [Route("admin")]
    public class DashboardController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Dashboard/Index.cshtml");
        }
    }
}
