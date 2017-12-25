using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tourcy1.Dtos;
using Tourcy1.Models;
using System.Data.Entity;

namespace Tourcy1.Controllers.Api
{
    public class ToursController : ApiController
    {
        private ApplicationDbContext _context;

        public ToursController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/tours
        public IEnumerable<TourDto> GetTours()
        {
            return _context.Tours
                 .Include(t => t.Continent)
                 .ToList()
                 .Select(Mapper.Map<Tour, TourDto>);
        }

        // GET /api/tours/1
        public IHttpActionResult GetTour(int id)
        {
            var tour = _context.Tours.SingleOrDefault(c => c.Id == id);

            if (tour == null)

                return NotFound();

            return Ok(Mapper.Map<Tour, TourDto>(tour));
        }

        // POST /api/tours
        [HttpPost]
        public IHttpActionResult CreateTour(TourDto tourDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            //throw new HttpResponseException(HttpStatusCode.BadRequest);

            var tour = Mapper.Map<TourDto, Tour>(tourDto);
            _context.Tours.Add(tour);
            _context.SaveChanges();

            tourDto.Id = tour.Id;
            return Created(new Uri(Request.RequestUri + "/" + tour.Id), tour);

        }

        // PUT /api/tour/1
        [HttpPut]
        public IHttpActionResult UpdateTour(int id, TourDto tourDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var tourInDb = _context.Tours.SingleOrDefault(c => c.Id == id);

            if (tourInDb == null)
                return NotFound();

            Mapper.Map(tourDto, tourInDb);

            _context.SaveChanges();

            return Ok();
        }


        // DELETE /api/tour/1
        [HttpDelete]
        public IHttpActionResult DeleteTour(int id)
        {
            var tourInDb = _context.Tours.SingleOrDefault(c => c.Id == id);

            if (tourInDb == null)
                return NotFound();

            _context.Tours.Remove(tourInDb);
            _context.SaveChanges();

            return Ok();

        }

    }
}
    

