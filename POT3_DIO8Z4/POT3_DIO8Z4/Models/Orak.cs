using System;
using System.Collections.Generic;

namespace POT3_DIO8Z4.Models
{
    public partial class Orak
    {
        public int OraId { get; set; }
        public int? Tanar { get; set; }
        public int? Nap { get; set; }
        public int? Sav { get; set; }
        public int? Targy { get; set; }
        public int? Terem { get; set; }

        public virtual Napok? NapNavigation { get; set; }
        public virtual Savok? SavNavigation { get; set; }
        public virtual Oktatok? TanarNavigation { get; set; }
        public virtual Tantárgyak? TargyNavigation { get; set; }
        public virtual Termek? TeremNavigation { get; set; }
    }
}
