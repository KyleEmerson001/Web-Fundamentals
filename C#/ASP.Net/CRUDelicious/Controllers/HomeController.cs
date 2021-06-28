using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
          private CRUDeliciousContext db;
        public HomeController(CRUDeliciousContext context)
            {
            db = context;
            }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> food = db.Dishes.ToList();
            ViewBag.All = food;
            return View();
        }

        [HttpGet("NewDish")]
        public IActionResult NewDish()
        {
            return View("Add");
        }

         [HttpPost("create")]
        public IActionResult Create(Dish d)
        {
            if(ModelState.IsValid)
            {
                db.Dishes.Add(d);
                db.SaveChanges();
                Console.WriteLine("Model is Valid");
                return Redirect("/");
            }
            else
            {
                Console.WriteLine("Model is Invalid");
                return View("Add");
            }
        }
        [HttpGet("View/{DishId}")]
        public IActionResult ViewDish(int DishId)
        {
            Dish RetrievedDish = db.Dishes.FirstOrDefault(selectedDish => selectedDish.DishId == DishId);      
            ViewBag.selectedDish = RetrievedDish;
            return View("View");
        }


        [HttpGet("Edit/{DishId}")]
        public IActionResult EditDish(int DishId)
        {
            Dish RetrievedDish = db.Dishes.FirstOrDefault(selectedDish => selectedDish.DishId == DishId);      
            ViewBag.selectedDish = RetrievedDish;
            return View("Edit");
        }

        [HttpPost("updateDish/{DishId}")]
        public IActionResult updateDish(int DishId, Dish updatedDish)
        {
            if(ModelState.IsValid)
            {
                Dish RetrievedDish = db.Dishes.FirstOrDefault(selectedDish => selectedDish.DishId == DishId);
                RetrievedDish.DishName = updatedDish.DishName;
                RetrievedDish.ChefName = updatedDish.ChefName;
                RetrievedDish.Tastiness = updatedDish.Tastiness;
                RetrievedDish.Calories = updatedDish.Calories;
                RetrievedDish.Description = updatedDish.Description;
                db.SaveChanges();
                RetrievedDish.UpdatedAt = DateTime.Now;
                Console.WriteLine("Model is Valid");
                return Redirect($"/DishId/{DishId}");
            }
            else
            {
                Console.WriteLine("Model is Invalid");
                return View("Edit", updatedDish);
            }
        }

                [HttpGet("delete/{DishId}")]
        public IActionResult DeleteDish(int DishId)
        {
            Dish RetrievedDish = db.Dishes.SingleOrDefault(selectedDish => selectedDish.DishId == DishId);
            db.Dishes.Remove(RetrievedDish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
