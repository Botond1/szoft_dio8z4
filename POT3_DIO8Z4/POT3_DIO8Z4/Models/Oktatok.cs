using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Oktatok
    {
        public Oktatok()
        {
            Oraks = new HashSet<Orak>();
        }

        public int OktatoId { get; set; }
        public string? Nev { get; set; }
        public string? Titulus { get; set; }
        public int? Beosztás { get; set; }
        public int? Status { get; set; }

        public virtual Beosztasok? BeosztásNavigation { get; set; }
        public virtual Statusok? StatusNavigation { get; set; }
        public virtual ICollection<Orak> Oraks { get; set; }
    }
}
