using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace TheRichLifeTestProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            if (username == "Jon" && password == "Test")
            {
                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, username, ClaimValueTypes.String)
                };
                var userIdentity = new ClaimsIdentity(claims, "SecureLogin");
                var userPrincipal = new ClaimsPrincipal(userIdentity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    userPrincipal,
                    new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                        IsPersistent = false,
                        AllowRefresh = false
                    });

                return View();
            }
            return View();
        }
        public string denied()
        {
            return "No";
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}