using Microsoft.AspNetCore.Mvc;
using Myntra.Data;
using Myntra.Models;
using System.Linq;

namespace Myntra.Controllers
{
    [Route("admin/categories")]
    public class AdminCategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public AdminCategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // LIST CATEGORIES
        [HttpGet("")]
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View("~/Views/Admin/Categories/Index.cshtml", categories);
        }

        // ADD / EDIT FORM
        [HttpGet("form/{id?}")]
        public IActionResult Form(int? id)
        {
            Category category = new Category();

            if (id.HasValue)
            {
                category = _context.Categories.FirstOrDefault(c => c.Id == id.Value);
                if (category == null) return NotFound();
            }

            ViewBag.ParentCategories = _context.Categories
                .Where(c => c.ParentId == null && c.Id != id) // exclude self from parent list
                .ToList();

            return View("~/Views/Admin/Categories/Form.cshtml", category);
        }

        // SAVE CATEGORY
        [HttpPost("form/{id?}")]
        public IActionResult Form(int? id, Category model)
        {
            //if (!ModelState.IsValid)
            //{
            //    ViewBag.ParentCategories = _context.Categories
            //        .Where(c => c.ParentId == null && c.Id != id)
            //        .ToList();
            //    return View("~/Views/Admin/Categories/Form.cshtml", model);
            //}

            if (id.HasValue)
            {
                // EDIT
                var existing = _context.Categories.FirstOrDefault(c => c.Id == id.Value);
                if (existing == null) return NotFound();

                existing.Name = model.Name;
                existing.Slug = model.Slug;
                existing.ParentId = model.ParentId;
                existing.SortOrder = model.SortOrder;
                existing.ImageUrl = model.ImageUrl;
                existing.IsActive = model.IsActive;
            }
            else
            {
                // ADD
                _context.Categories.Add(model);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
