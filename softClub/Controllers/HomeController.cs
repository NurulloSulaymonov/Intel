using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Services.MessageSender;
using softClub.Models;

namespace softClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // field
        private readonly IMessageSender _messageSender;
        private int a;
        public HomeController(ILogger<HomeController> logger,
            IMessageSender messageSender) // constructor
        {
            _logger = logger;
            _messageSender = messageSender;
            
        }

        public IActionResult Index() // acrtion  // method
        {
            _logger.LogInformation("hello");
            var id = _messageSender.GetId();
            return View(id);
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
