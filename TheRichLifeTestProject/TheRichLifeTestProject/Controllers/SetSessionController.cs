using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheRichLifeTestProject.Controllers
{
    public class SetSessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}