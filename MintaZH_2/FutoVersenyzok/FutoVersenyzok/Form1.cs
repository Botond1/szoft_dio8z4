using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace FutoVersenyzok
{
    public partial class Form1 : Form
    {
        BindingList<Versenyzõ> adatok = new BindingList<Versenyzõ>();

        public Form1()
        {
            InitializeComponent();
            versenyzõBindingSource.DataSource = adatok;
            dataGridView1.DataSource = versenyzõBindingSource;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Versenyzõ>();
                foreach (var item in tömb)
                {
                    adatok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(adatok);

                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (versenyzõBindingSource.Current == null)
            {
                MessageBox.Show("Hiba történt, nincs kijelölt sor!", "Hiba", MessageBoxButtons.OK);
            }

            if (MessageBox.Show("Biztos benne?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyzõBindingSource.RemoveCurrent();
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();

            if (formAddNew.ShowDialog() == DialogResult.OK) //addig nem enged vissza és mûködnek a gombok <> .Show()
            {

            }
        }
    }
}