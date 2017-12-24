using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tourcy1.Models
{
    public class MembershipType
    {
        public byte Id { get; set; } //postojat samo nekolku tipovi na clenstvo
        public short SignUpFee { get; set; } //nema da ni trebaat vrednosti pogolemi od 32000->short
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; } //byte oti ke bidi od 0 do 100 procenti
        [Display(Name = "Membership Type")]
        public string Name { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
      

    }
}