using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    [Route("admin/orders")]
    public class AdminOrderController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Orders/Index.cshtml");
        }
    }
}
