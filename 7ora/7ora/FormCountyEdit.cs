using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _7ora.Form1;

namespace _7ora
{
    public partial class FormCountyEdit : Form
    {
        public CountryData CountryData;

        public FormCountyEdit()
        {
            InitializeComponent();
        }

        private void FormCountyEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void okeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
