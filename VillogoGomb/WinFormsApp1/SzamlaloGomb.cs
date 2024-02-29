using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SzamlaloGomb : Button
    {
        int szam = 0;
        public SzamlaloGomb()
        {
            Width = 30;
            Height = 30;
            MouseClick += SzamlaloGomb_MouseClick;
        }

        private void SzamlaloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            Text = szam.ToString();
        }
    }
}
