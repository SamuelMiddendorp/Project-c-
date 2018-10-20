using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheRichLifeTestProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace TheRichLifeTestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Status") == null)
            {
                HttpContext.Session.SetString("Status", "Session is now set");
            }
            else
            {
                HttpContext.Session.SetString("Status", "Session is already set");
            }
            _context.SaveChanges();
            ViewBag.Session = HttpContext.Session.GetString("Status");
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        [Authorize]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Products(string searchString)
        {
            //var products = from m in _context.Animals select m;
            //if (!String.IsNullOrEmpty(searchString))
           // {
                //products = products.Where(s => s.Name.Contains(searchString) || s.Species.Contains(searchString));
           // }


            return View();
        }
        public IActionResult Detail(int Id, string category)
        {
            //ViewModel mymodel = new ViewModel();
            //if (category == "Animal")
            //{
                //try
                //{
                   // var product = _context.Animals.Single(x => x.Id == Id);
                    //var reviews = from row in _context.Reviews where row.AnimalId == Id select row;
                    //List<Review> reviews2 = reviews.ToList<Review>();
                    //mymodel.Animal = product;
                    //mymodel.Reviews = reviews2;
                    //return View(mymodel);
               // }
            //}
            //else
            //{
                return View();
            //}

        }
        public IActionResult All()
        {
            
            return View(_context.Products);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
