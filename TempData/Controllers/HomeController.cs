using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] str = { "saifullah", "mahar", "Faqeer" };
            TempData["var1"] =str;
            

            TempData["var2"] = new List<string>()
            {
                "saif",
                 "mahar",
                  "faqeer",
            };
            return View();
        }

        public IActionResult about()
        {
            TempData.Keep();
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
