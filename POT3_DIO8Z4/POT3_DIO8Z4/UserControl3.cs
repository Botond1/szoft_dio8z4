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
    public partial class UserControl3 : UserControl
    {
        Models.tanulmanyiContext context = new Models.tanulmanyiContext();

        public UserControl3()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Termeks.ToList();
            dataGridView1.Columns[2].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                try
                {
                    Models.Termek termek2 = new Models.Termek();
                    termek2.Tkód = Convert.ToInt32(form2.textBox1.Text);
                    termek2.Terem = form2.textBox2.Text;
                    context.Termeks.Add(termek2);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
