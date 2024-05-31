using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Savok
    {
        public Savok()
        {
            Oraks = new HashSet<Orak>();
        }

        public int SavId { get; set; }
        public string? Sav { get; set; }
        public string? Időpont { get; set; }

        public virtual ICollection<Orak> Oraks { get; set; }
    }
}
