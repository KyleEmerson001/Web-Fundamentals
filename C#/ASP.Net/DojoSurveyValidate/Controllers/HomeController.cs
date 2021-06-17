using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyValidate.Models;

namespace DojoSurveyValidate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("/survey")]
        public IActionResult SubmitSurvey(Survey survey)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Model State is valid");
                return View("show", survey);
            }

            Console.WriteLine("Model State INVALID");
            return View("Index");
        }
        [HttpGet("/show")]
        public IActionResult ValidateSurvey()
        {
            return View("show");
        }
    }

}


