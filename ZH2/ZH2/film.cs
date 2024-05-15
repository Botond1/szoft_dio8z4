using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2
{
    public class film
    {
        public int FilmID { get; set; }
        public string Cim { get; set; } = string.Empty;
        public int KiadasiEv { get; set; }
        public int BevetelekMillioUSD { get; set; }
        public bool Sikeres { get; set; }
    }
}
