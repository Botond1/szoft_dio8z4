using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POT3_DIO8Z4
{
    public partial class UserControl2 : UserControl
    {
        Models.tanulmanyiContext context = new Models.tanulmanyiContext();

        public UserControl2()
        {
            InitializeComponent();

            listBox1.DataSource = context.Oktatoks.ToList();
            listBox1.DisplayMember = "Nev";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var adatok = from x in context.Oktatoks
                         where x.Nev.Contains(textBox1.Text)
                         select x;
            listBox1.DataSource = adatok.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var adat = from x in context.Oraks
                           where x.Tanar == (listBox1.SelectedItem as Models.Oktatok).OktatoId
                           select new
                           {
                               x.TanarNavigation.Nev,
                               x.NapNavigation.Nap,
                               x.SavNavigation.Sav,
                               x.SavNavigation.Időpont,
                               x.TargyNavigation.Tantárgynév,
                               x.TeremNavigation.Terem
                           };
                dataGridView1.DataSource = adat.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
            }
        }
    }
}
