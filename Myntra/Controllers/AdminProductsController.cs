using Microsoft.AspNetCore.Mvc;

namespace Myntra.Controllers
{
    [Route("admin/products")]
    public class AdminProductsController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/Products/Index.cshtml");
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("~/Views/Admin/Products/Add.cshtml");
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View("~/Views/Admin/Products/Edit.cshtml");
        }
    }
}
