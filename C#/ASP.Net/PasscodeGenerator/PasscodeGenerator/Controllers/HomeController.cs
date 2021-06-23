using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasscodeGenerator.Models;
using Microsoft.AspNetCore.Http;

namespace PasscodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("count") == null)
            {
                HttpContext.Session.SetInt32("count", 1); 
            }
            else
            {
                int count = HttpContext.Session.GetInt32("count").GetValueOrDefault(); 
                HttpContext.Session.SetInt32("count", count + 1);
            }
            ViewBag.Count=HttpContext.Session.GetInt32("count");
            Random rand = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var newstring = new char[14];
            for(int i = 0; i< newstring.Length;i++){
                newstring[i]=characters[rand.Next(0,36)];
            }
            string newString = new String(newstring);
            ViewBag.passcode=newString;
            return View("index");
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
