using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //
        //GET: /HelloWorld1/

        public IActionResult Index()
        {
            return View();
        }
      
        //
        //GET: /HelloWorld/Welcome
        //refer to add a controller, page bottom
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }
        //public IActionResult Index()
        //{
          //  return View();,
        //}
    }
}
