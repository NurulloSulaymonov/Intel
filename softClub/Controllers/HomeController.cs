using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using softClub.Models;

namespace softClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // field

        public HomeController(ILogger<HomeController> logger) // constructor
        {
            _logger = logger;
        }

        public IActionResult Index() // acrtion  // method
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        // public IActionResult Add([FromQuery] int a, int b)
        // {

        //     return Json(a + b);

        //     // Ok
        //     //Json
        //     //View
        //     //Erro
        // }


        // public IActionResult Subtract([FromQuery] int a, int b)
        // {
        //     return Json(a - b);
        // }
        // public IActionResult Multiply([FromQuery] int a, int b)
        // {
        //     return Json(a - b);
        // }

        // public IActionResult Divide([FromQuery] int a, int b)
        // {
        //     return Json(a - b);
        // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
