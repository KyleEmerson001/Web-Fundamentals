using Microsoft.AspNetCore.Mvc;
using DojoSurveys.Models;

namespace DojoSurveys.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("/users/register")]
        public ViewResult Register()
        {
            return View("Register");
        }

        [HttpPost("/users/process-registration")]
        public ViewResult ProcessRegistration(User newUser)
        {
            return View("show", newUser);
        }

    }
}