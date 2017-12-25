using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tourcy1.Models;

namespace Tourcy1.Dtos
{
    public class TourDto
    {
        public int Id { get; set; }
                
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte ContinentId { get; set; }

        public ContinentDto Continent { get; set; }


        public string Description { get; set; }

        [Required]
        public int Days { get; set; }

        [Required]
        public int Nights { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [Range(0, 50)]
        public byte Capacity { get; set; }
    }
}