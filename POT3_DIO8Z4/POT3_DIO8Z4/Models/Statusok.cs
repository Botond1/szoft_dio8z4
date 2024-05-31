using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Statusok
    {
        public Statusok()
        {
            Oktatoks = new HashSet<Oktatok>();
        }

        public int Skod { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Oktatok> Oktatoks { get; set; }
    }
}
