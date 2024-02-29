using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class VillogoGomb : Button //származtatjuk a button osztályból, hogy a tul.okat átvegye
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public VillogoGomb() //ctor tabtab
        {
            BackColor = Color.Yellow;
            MouseEnter += VillogoGomb_MouseEnter; //+= tabtab
                                                  //MouseLeave += VillogoGomb_MouseLeave;

            t.Tick += T_Tick;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
            t.Stop();
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
            t.Interval = 1000;
            t.Start();
        }
    }
}