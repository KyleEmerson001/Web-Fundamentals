﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
          private ChefsNDishesContext db;
        public HomeController(ChefsNDishesContext context)
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

         [HttpGet("/Index")]
        public IActionResult ChefsIndex()
        {
            List<Chef> cook = db.Chefs.ToList();
            ViewBag.All = cook;
            return View("IndexChef");
        }

        [HttpGet("NewDish")]
        public IActionResult NewDish()
        {
            List<Chef> chef = db.Chefs.ToList();
            ViewBag.All = chef;
            return View("Add");
        }

                [HttpGet("NewChef")]
        public IActionResult NewChef()
        {
            return View("AddChef");
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

        [HttpPost("createchef")]
        public IActionResult CreateChef(Chef c)
        {
            if(ModelState.IsValid)
            {
                db.Chefs.Add(c);
                db.SaveChanges();
                Console.WriteLine("Model is Valid");
                return Redirect("/");
            }
            else
            {
                Console.WriteLine("Model is Invalid");
                return View("Add", "Chefs");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
