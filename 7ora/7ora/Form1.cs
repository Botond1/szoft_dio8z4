using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7ora
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();

        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class CountryData
        {
            public string Name { get; set; } = string.Empty;
            public long Population { get; set; }
            public double AreaInSquareKm { get; set; }
        }

        private void megnyitasBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Itt megnyithatod és beolvashatod a kiválasztott fájlt
                string filePath = openFileDialog.FileName;
                // Fájl beolvasásának és a data binding frissítésének logikája
                StreamReader sr = new StreamReader(filePath);
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<CountryData>();
                foreach (var item in tomb)
                {
                    countryList.Add(item);
                }
                sr.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to proceed?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Code to execute if user clicks 'Yes'
                countryDataBindingSource.RemoveCurrent();
                MessageBox.Show("Törölve");
            }
        }

        private void szerkesztesBtn_Click(object sender, EventArgs e)
        {
            FormCountyEdit fce = new FormCountyEdit();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Itt mentheted a fájlt a saveFileDialog.FileName által visszaadott helyre
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    // Write records to the CSV file
                    csv.WriteRecords(countryList);
                };
            }
        }
    }
}
