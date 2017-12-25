using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tourcy1.Models;
using Tourcy1.ViewModels;

namespace Tourcy1.Controllers
{
    public class ToursController : Controller
    {
        private ApplicationDbContext _context;
        public ToursController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ViewResult New()
         {
             var continents = _context.Continents.ToList();

            var viewModel = new NewTourViewModel
            {
                Continents = continents
            };

            return View("TourForm", viewModel);
         }

        
        [HttpPost]
        public ActionResult Save(Tour tour)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewTourViewModel
                {
                    Tour = tour,
                    Continents = _context.Continents.ToList()

                };
                return View("TourForm", viewModel);
            }
            if (tour.Id == 0)
                _context.Tours.Add(tour);
            else
            {
                var tourInDb = _context.Tours.Single(t => t.Id == tour.Id);
                tourInDb.Name = tour.Name;
                tourInDb.Description = tour.Description;
                tourInDb.Days = tour.Days;
                tourInDb.Nights = tour.Nights;
                tourInDb.Price = tour.Price;
                tourInDb.Capacity = tour.Capacity;
                tourInDb.ContinentId = tour.ContinentId;
                

            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            
            return RedirectToAction("Index", "Tours");
        }
// GET: Tours/Random
        public ViewResult Index()
        {
            if(User.IsInRole(RoleName.CanManageMovies))
                return View("Index");
            else
                return View("ReadOnlyList");
       
        }

        public ActionResult Details(int id)
        {
            var tours = _context.Tours.Include(t => t.Continent).SingleOrDefault(t => t.Id == id);

            if (tours == null)
                return HttpNotFound();

            return View(tours);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var tour = _context.Tours.SingleOrDefault(t => t.Id == id);

            if (tour == null)
                return HttpNotFound();
            var viewModel = new NewTourViewModel
            {
                Tour = tour,
                Continents = _context.Continents.ToList()
            };
            return View("TourForm", viewModel);
        }
     
    }
}