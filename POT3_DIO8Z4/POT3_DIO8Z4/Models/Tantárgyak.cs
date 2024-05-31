using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Tantárgyak
    {
        public Tantárgyak()
        {
            Oraks = new HashSet<Orak>();
        }

        public int Tkód { get; set; }
        public string? Tantárgynév { get; set; }
        public int? Tantárgyfelelős { get; set; }
        public string? Tantargykod { get; set; }
        public int? Kredit { get; set; }

        public virtual ICollection<Orak> Oraks { get; set; }
    }
}
