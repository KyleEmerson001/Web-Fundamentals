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

        [HttpGet("Wedding/Success")]
        public IActionResult Success()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Wedding> allWeddings = db.Weddings
                .Include(Wedding => Wedding.Author)
                .Include(Wedding => Wedding.RSVPs)
                .ToList();

            return View("Success", allWeddings);
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

        [HttpPost("/Weddings/create")]
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
            return RedirectToAction("Success");
        }

        [HttpGet("/View/{WeddingId}")]
        public IActionResult ViewWedding(int WeddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding Wedding = db.Weddings
            .Include(Wedding => Wedding.Author)
            .Include(Wedding => Wedding.RSVPs)
            .ThenInclude(RSVP => RSVP.User)
            .FirstOrDefault(p => p.WeddingId == WeddingId);

            if (Wedding == null)
            {
                return RedirectToAction("Success");
            }

            return View("View", Wedding);
        }

        [HttpPost("/Weddings/{WeddingId}")]
        public IActionResult Delete(int WeddingId)
        {
            Wedding Wedding = db.Weddings.FirstOrDefault(p => p.WeddingId == WeddingId);

            // If post doesn't exist or not author, redirect away.
            if (Wedding == null || Wedding.UserId != uid)
            {
                return RedirectToAction("Success");
            }

            db.Weddings.Remove(Wedding);
            db.SaveChanges();

            return RedirectToAction("Success");
        }

        
        [HttpPost("/Weddings/{WeddingId}/RSVP")]
        public IActionResult RSVP(int WeddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            WeddingRSVP existingRSVP = db.WeddingRSVPs
                .FirstOrDefault(RSVP => RSVP.WeddingId == WeddingId && (int)uid == RSVP.UserId);

            if (existingRSVP == null)
            {
                WeddingRSVP RSVP = new WeddingRSVP()
                {
                    WeddingId = WeddingId,
                    UserId = (int)uid
                };

                db.WeddingRSVPs.Add(RSVP);
            }
            else
            {
                db.WeddingRSVPs.Remove(existingRSVP);
            }

            db.SaveChanges();
            return RedirectToAction("Success");
        }
    }
}