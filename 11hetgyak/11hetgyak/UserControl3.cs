using _11hetgyak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11hetgyak
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();

            var oktatok = from i in context.Instructors
                          select i;
            listBox1.DataSource = oktatok.ToList();

            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var szurt = from i in context.Instructors
                        where i.Name.Contains(textBox1.Text)
                        select i;
            listBox1.DataSource = szurt.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Instructor selectedInstrutor = listBox1.SelectedItem as Instructor;
            if (selectedInstrutor == null) return;

            var adatok = from i in context.Instructors
                         where selectedInstrutor.InstructorSk == i.InstructorSk
                         select new
                         {
                             Munka = i.EmployementFkNavigation.Name,
                             Státusz = i.StatusFkNavigation.Name,
                             Titulus = i.Salutation,
                             Név = i.Name
                         };

            dataGridView1.DataSource = adatok.ToList();

        }
    }
}
