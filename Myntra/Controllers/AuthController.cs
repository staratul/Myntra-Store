using Myntra.Models;
using Myntra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Myntra.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(string email,string password)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Email and Password is required";
                return View();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.PasswordHash == password);

            if(user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.UserId);
                HttpContext.Session.SetString("Email", user.Email);
                HttpContext.Session.SetString("Password", user.PasswordHash);
                HttpContext.Session.SetString("ConfirmPassword", user.ConfirmPassword);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Email and Password ";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register (User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if(existingUser != null)
            {
                ViewBag.Error = "Email Already Register";
                return View(user);
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            HttpContext.Session.SetString("Email", user.Email);
            HttpContext.Session.SetString("PasswordHash", user.PasswordHash);

            TempData["SuccessMessage"] = "Registration Successful ! Please login.";
            return RedirectToAction("Login", "Auth");
        }
    }
}
