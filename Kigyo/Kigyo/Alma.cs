using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // Szükséges az Image osztály használatához
using System.Windows.Forms; // Szükséges a PictureBox osztály használatához

namespace Kigyo
{
    internal class Alma : PictureBox
    {
        public static int Méret = 20;

        public Alma()
        {
            Width = Alma.Méret;
            Height = Alma.Méret;
            this.Image = Image.FromFile("alma.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
