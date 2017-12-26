using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tourcy1.Dtos
{
    public class ReservationDto
    {
        public int CustomerId { get; set; }
        public List<int> TourIds { get; set; }
    }
}