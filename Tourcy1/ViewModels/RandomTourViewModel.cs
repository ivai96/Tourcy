using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tourcy1.Models;

namespace Tourcy1.ViewModels
{
    public class RandomTourViewModel
    {
        public Tour Tour { get; set; }
        public List<Customer> Costumers { get; set; }

    }
}