using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerRelationsDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationsDatabase.Controllers
{
    public class CustomersController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        private int? cid
        {
            get
            {
                return HttpContext.Session.GetInt32("CustomerId");
            }
        }

        private CustomerRelationsDatabaseContext db;

        public CustomersController(CustomerRelationsDatabaseContext context)
        {
            db = context;
        }

        [HttpGet("Customer/Success")]
        public IActionResult Success()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Customer> allCustomers = db.Customers
                .Include(Customer => Customer.Author)
                .Include(Customer => Customer.Calls)
                .ToList();

            return View("Success", allCustomers);
        }

        [HttpGet("New")]
        public IActionResult New()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }

        [HttpGet("NewCall/{CustomerId}")]
        public IActionResult NewCall(int CustomerId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

             Customer Customer = db.Customers
            .Include(Customer => Customer.Author)
            .Include(Customer => Customer.Calls)
            .ThenInclude(Call => Call.User)
            .FirstOrDefault(p => p.CustomerId == CustomerId);

            if (Customer == null)
            {
                return RedirectToAction("Success");
            }

            return View("NewCall");
        }

        [HttpPost("/Customers/create")]
        public IActionResult Create(Customer newCustomer)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid == false)
            {
                // Send back to the page with the form to show errors.
                return View("New");
            }
            // ModelState IS valid...
            newCustomer.UserId = (int)uid;
            db.Customers.Add(newCustomer);
            db.SaveChanges();

            HttpContext.Session.SetInt32("CustomerId", newCustomer.CustomerId);
            return RedirectToAction("Success");
        }

[HttpPost("/Customers/Callcreate")]
        public IActionResult CallCreate(int CustomerId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid == false)
            {
                // Send back to the page with the form to show errors.
                return View("New");
            }
            // ModelState IS valid...
            CustomerCall newCall = new CustomerCall(){
                UserId = (int)uid,
                CustomerId = CustomerId
            };
            
            db.CustomerCalls.Add(newCall);
            db.SaveChanges();
            return RedirectToAction("Success");
        }

        [HttpGet("/View/{CustomerId}")]
        public IActionResult ViewCustomer(int CustomerId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Customer Customer = db.Customers
            .Include(Customer => Customer.Author)
            .Include(Customer => Customer.Calls)
            .ThenInclude(Call => Call.User)
            .FirstOrDefault(p => p.CustomerId == CustomerId);

            if (Customer == null)
            {
                return RedirectToAction("Success");
            }

            return View("View", Customer);
        }

        [HttpPost("/Customers/{CustomerId}")]
        public IActionResult Delete(int CustomerId)
        {
            Customer Customer = db.Customers.FirstOrDefault(p => p.CustomerId == CustomerId);

            // If post doesn't exist or not author, redirect away.
            if (Customer == null || Customer.UserId != uid)
            {
                return RedirectToAction("Success");
            }

            db.Customers.Remove(Customer);
            db.SaveChanges();

            return RedirectToAction("Success");
        }

        
        [HttpPost("/Customers/{CustomerId}/Call")]
        public IActionResult Call(int CustomerId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            CustomerCall existingCall = db.CustomerCalls
                .FirstOrDefault(Call => Call.CustomerId == CustomerId && (int)uid == Call.UserId);

            if (existingCall == null)
            {
                CustomerCall Call = new CustomerCall()
                {
                    CustomerId = CustomerId,
                    UserId = (int)uid
                };

                db.CustomerCalls.Add(Call);
            }
            else
            {
                db.CustomerCalls.Remove(existingCall);
            }

            db.SaveChanges();
            return RedirectToAction("Success");
        }
    }
}