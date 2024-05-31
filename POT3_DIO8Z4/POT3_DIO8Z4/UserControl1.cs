using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POT3_DIO8Z4
{
    public partial class UserControl1 : UserControl
    {
        Models.tanulmanyiContext context = new Models.tanulmanyiContext();
        List<String> kiiras = new List<string>();
        public UserControl1()
        {
            InitializeComponent();
            var adat = from x in context.Oktatoks
                       select new
                       {
                           x.Nev,
                           x.Titulus,
                           x.BeosztásNavigation.Beosztasnev,
                           x.StatusNavigation.Status
                       };

            dataGridView1.DataSource = adat.ToList();
            foreach (var item in adat)
            {
                kiiras.Add(Convert.ToString(item));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "CSV fájl|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(ofd.FileName);
                    foreach (var item in kiiras)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
