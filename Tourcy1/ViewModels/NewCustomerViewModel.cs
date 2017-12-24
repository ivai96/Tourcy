using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tourcy1.Models;

namespace Tourcy1.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}