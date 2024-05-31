using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Napok
    {
        public Napok()
        {
            Oraks = new HashSet<Orak>();
        }

        public int NapId { get; set; }
        public string? Nap { get; set; }

        public virtual ICollection<Orak> Oraks { get; set; }
    }
}
