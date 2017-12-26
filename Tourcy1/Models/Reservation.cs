using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tourcy1.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Tour Tour { get; set; }

        public DateTime DateReserved { get; set; }
    }
}