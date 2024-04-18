using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyakorlasZH2
{
    public partial class AddNew : Form
    {
        public Versenyzo ujsor = new Versenyzo();
        public AddNew()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ujsor;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
