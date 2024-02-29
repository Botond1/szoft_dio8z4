using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SzinezodoGomb : Button
    {
        public SzinezodoGomb() {
            Width = 20;
            Height = 20;
            MouseClick += SzinezodoGomb_MouseClick;
        }

        private void SzinezodoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (BackColor == Color.Fuchsia)
            {
                BackColor = SystemColors.ButtonFace;
            } 
            else
            {
                BackColor = Color.Fuchsia;
            }
            
        }
    }
}
