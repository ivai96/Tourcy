using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tourcy1.Dtos;
using Tourcy1.Models;

namespace Tourcy1.Controllers.Api
{
    public class ReservationController : ApiController
    {
            private ApplicationDbContext _context;

            public ReservationController()
            {
                _context = new ApplicationDbContext();
            }

        [HttpPost]
        public IHttpActionResult CreateNewReservations (ReservationDto newReservation)
        {
            
            var customer = _context.Customers.Single(
                c => c.Id == newReservation.CustomerId);
                  
            var tours = _context.Tours.Where(
                t => newReservation.TourIds.Contains(t.Id)).ToList();                      

            foreach (var tour in tours)
            {
                if (tour.AvailableCapacity == 0)
                    return BadRequest("Site mesta se popolneti.");

                tour.AvailableCapacity--;

                var reservation = new Reservation
                {
                    Customer = customer,
                    Tour = tour,
                    DateReserved = DateTime.Now
                };

                _context.Reservations.Add(reservation);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
