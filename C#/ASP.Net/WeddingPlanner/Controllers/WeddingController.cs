using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class WeddingsController : Controller
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

        private WeddingPlannerContext db;

        public WeddingsController(WeddingPlannerContext context)
        {
            db = context;
        }

        [HttpGet("/weddings")]
        public IActionResult All()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Wedding> allWeddings = db.Weddings
                .Include(wedding => wedding.Author)
                .Include(wedding => wedding.Guests)
                .ToList();

            return View("All", allWeddings);
        }

        [HttpGet("/weddings/new")]
        public IActionResult New()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }

        [HttpPost("/weddings/create")]
        public IActionResult Create(Wedding newWedding)
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
            newWedding.UserId = (int)uid;
            db.Weddings.Add(newWedding);
            db.SaveChanges();
            return RedirectToAction("All");
        }

        [HttpGet("/weddings/{weddingId}")]
        public IActionResult Details(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding wedding = db.Weddings
            .Include(wedding => wedding.Author)
            .Include(wedding => wedding.Guests)
            .ThenInclude(guest => guest.User)
            .FirstOrDefault(p => p.WeddingId == weddingId);

            if (wedding == null)
            {
                return RedirectToAction("All");
            }

            return View("Details", wedding);
        }

        [HttpPost("/weddings/{weddingId}")]
        public IActionResult Delete(int weddingId)
        {
            Wedding wedding = db.Weddings.FirstOrDefault(p => p.WeddingId == weddingId);

            // If post doesn't exist or not author, redirect away.
            if (wedding == null || wedding.UserId != uid)
            {
                return RedirectToAction("All");
            }

            db.Weddings.Remove(wedding);
            db.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpGet("/weddings/{weddingId}/edit")]
        public IActionResult Edit(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding wedding = db.Weddings.FirstOrDefault(p => p.WeddingId == weddingId);

            // If post doesn't exist or not author, redirect away.
            if (wedding == null || wedding.UserId != uid)
            {
                return RedirectToAction("All");
            }

            return View("Edit", wedding);
        }

        [HttpPost("/weddings/{weddingId}/update")]
        public IActionResult Update(int weddingId, Wedding editedWedding)
        {
            if (ModelState.IsValid == false)
            {
                editedWedding.WeddingId = weddingId;
                return View("Edit", editedWedding);
            }

            Wedding dbWedding = db.Weddings.FirstOrDefault(p => p.WeddingId == weddingId);

            if (dbWedding == null)
            {
                return RedirectToAction("All");
            }

            dbWedding.WedderOne = editedWedding.WedderOne;
            dbWedding.WedderTwo = editedWedding.WedderTwo;
            dbWedding.Date = editedWedding.Date;
            dbWedding.Address = editedWedding.Address;

            db.Weddings.Update(dbWedding);
            db.SaveChanges();

            // Dict matches Details params     new { paramName = paramValue }
            return RedirectToAction("Details", new { weddingId = dbWedding.WeddingId });
        }

        [HttpPost("/weddings/{weddingId}/guest")]
        public IActionResult RSVP(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            WeddingGuest existingGuest = db.WeddingGuests
                .FirstOrDefault(guest => guest.WeddingId == weddingId && (int)uid == guest.UserId);

            if (existingGuest == null)
            {
                WeddingGuest guest = new WeddingGuest()
                {
                    WeddingId = weddingId,
                    UserId = (int)uid
                };

                db.WeddingGuests.Add(guest);
            }
            else
            {
                db.WeddingGuests.Remove(existingGuest);
            }

            db.SaveChanges();
            return RedirectToAction("All");
        }
    }
}