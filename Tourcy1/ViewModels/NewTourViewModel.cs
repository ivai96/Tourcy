using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tourcy1.Models;

namespace Tourcy1.ViewModels
{
    public class NewTourViewModel
    {
        public IEnumerable<Continent> Continents { get; set; }
        public Tour Tour { get; set; }
        public string Title
        {
            get
            {
                if (Tour != null && Tour.Id != 0)
                    return "Edit Tour";

                return "New Tour";
            }
        }
    }
}