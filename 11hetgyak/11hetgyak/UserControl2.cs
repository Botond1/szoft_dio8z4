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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();

        public UserControl2()
        {
            InitializeComponent();

            var courses = from i in context.Courses
                          select i;
            listBox1.DataSource = courses.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fcourse = from i in context.Courses
                          where i.Name.Contains(textBox1.Text)
                          select i;
            listBox1.DataSource = fcourse.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course selectedCourse = listBox1.SelectedItem as Course;
            if (selectedCourse == null) return;
            
            var adatok = from i in context.Lessons
                         where i.CourseFk == selectedCourse.CourseSk
                         select new
                         {
                             Tanár = i.InstructorFkNavigation.Name,
                             Nap = i.DayFkNavigation.Name,
                             Sáv = i.TimeFkNavigation.Name
                         };

            dataGridView1.DataSource = adatok.ToList();
        }
    }
}
