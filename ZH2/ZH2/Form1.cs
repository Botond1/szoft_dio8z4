using CsvHelper;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace ZH2
{
    public partial class Form1 : Form
    {
        BindingList<film> filmList = new BindingList<film>();
        public Form1()
        {
            InitializeComponent();
            filmBindingSource1.DataSource = filmList;
            dataGridView1.DataSource = filmBindingSource1;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("filmek.txt");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<film>();
                foreach (var item in tomb)
                {
                    filmList.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Valami baj van a fájl beolvasásával" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(filmList);
                    sw.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Valami baj van a fájl írásával" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (filmBindingSource1.Current == null)
            {
                MessageBox.Show("nincs kijelölt sor", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (filmBindingSource1.Current != null)
            {
                if (MessageBox.Show("Biztos törli?", "Megerõsítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    filmBindingSource1.RemoveCurrent();
                }
            }
        }

        private void newrecordBtn_Click(object sender, EventArgs e)
        {
            AddNew ujhozza = new AddNew();
            if (ujhozza.ShowDialog() == DialogResult.OK)
            {
                filmList.Add(ujhozza.ujfilm);
            }
        }

        private void erdekessegBtn_Click(object sender, EventArgs e)
        {
            int szamlalo = 0;
            var legkorabban = filmList.OrderBy(v => v.KiadasiEv).FirstOrDefault().Cim;
            var bevetele = filmList.OrderBy(v => v.KiadasiEv).FirstOrDefault().BevetelekMillioUSD;
            foreach (var item in filmList)
            {
                if (item.BevetelekMillioUSD > 200)
                {
                    szamlalo++;
                }
            }
            MessageBox.Show("A legkorábban a " + legkorabban + "film volt kiadva, és ennek bevétele: " + bevetele + " millió ft. Összesen " + szamlalo + " film haladta meg a 200 millió ft bevételt.", "Érdekességek", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}