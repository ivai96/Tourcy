using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tourcy1.Models
{
    public class Tour
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public Continent Continent { get; set; }

        
        [Display(Name="Continent")]
        public byte ContinentId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        
        public string Description { get; set; }

        [Required]
        public int Days { get; set; }

        [Required]
        public int Nights { get; set; }

        [Required]
        [Display(Name="Price ($)")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Remaining capacity")]
        [Range(0, 50)]
        public byte Capacity { get; set; }
    }
}