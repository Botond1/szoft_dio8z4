using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Beosztasok
    {
        public Beosztasok()
        {
            Oktatoks = new HashSet<Oktatok>();
        }

        public int BeosztasId { get; set; }
        public string? Beosztasnev { get; set; }
        public int? Elvart { get; set; }

        public virtual ICollection<Oktatok> Oktatoks { get; set; }
    }
}
