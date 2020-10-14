using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Welcome(string Name, int numTimes)
        {

            ViewData["Message"]= "hello"+ Name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
