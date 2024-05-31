using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Termek
    {
        public Termek()
        {
            Oraks = new HashSet<Orak>();
        }

        public int Tkód { get; set; }
        public string? Terem { get; set; }

        public virtual ICollection<Orak> Oraks { get; set; }
    }
}
