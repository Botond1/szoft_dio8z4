using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace GyakorlasZH2
{
    public partial class Form1 : Form
    {
        BindingList<Versenyzo> listVersenyzo = new BindingList<Versenyzo>();

        public Form1()
        {
            InitializeComponent();
            bindingSource1.DataSource = listVersenyzo;
            dataGridView1.DataSource = bindingSource1;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<Versenyzo>();
                foreach (var v in tomb)
                {
                    listVersenyzo.Add(v);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valami hiba történt a fájl beolvasásakor\n" + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog mentes = new SaveFileDialog();
            mentes.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv";
            if (mentes.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(mentes.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(listVersenyzo);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valami hiba a mentés közben\n" + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                MessageBox.Show("Nincs kijelölve semmi.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Biztos törölni akarja?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
            }
        }

        private void newSor_Click(object sender, EventArgs e)
        {
            AddNew addNew = new AddNew();
            if (addNew.ShowDialog() == DialogResult.OK)
            {
                listVersenyzo.Add(addNew.ujsor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usa = 0;
            foreach (var item in listVersenyzo)
            {
                if (item.Nemzetiseg == "USA")
                {
                    usa++;
                }
            }
            var legjobb = listVersenyzo.OrderBy(v => v.EredmenyPerc).First().Nev;
            MessageBox.Show("Eredmenyek: " + usa + " " + legjobb, "Erdekesseg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}