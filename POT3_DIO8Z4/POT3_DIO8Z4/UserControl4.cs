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
    public partial class UserControl4 : UserControl
    {
        Models.tanulmanyiContext context = new Models.tanulmanyiContext();
        public UserControl4()
        {
            InitializeComponent();
            int max = Convert.ToInt32((from x in context.Tantárgyaks
                                       select x.Kredit).Max());
            int min = Convert.ToInt32((from x in context.Tantárgyaks
                                       select x.Kredit).Min());
            label1.Text = "Legnagyobb kreditérték: " + max.ToString() + "; Legkisebb kreditérték: " + min.ToString();

            int atlag = Convert.ToInt32((from x in context.Tantárgyaks
                                         select x.Kredit).Average());

            var targyak = from x in context.Tantárgyaks
                          where x.Kredit > atlag
                          select x;
            listBox1.DataSource = targyak.ToList();
            listBox1.DisplayMember = "Tantárgynév";

            int tanarcount = (from x in context.Oktatoks
                              select x).Count();
            label2.Text = "Oktatók száma: " + tanarcount.ToString();
        }
    }
}
