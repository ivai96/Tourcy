using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tourcy1.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        /*navigatin property -ni dava pristap i na korisnikot i negoviot membership type
        se koristi koga sakame da prikazime objekt zedno so drugite objekti so koj e povrzan
        od bazata. nacin da gi prikazime dve povrzani tabeli*/

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }//nadvoresen kluc

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
    }
}