using System.Security.Policy;

namespace Akasztofa
{
    public partial class Form1 : Form
    {
        List<string> szavak = new List<string>();
        public string szo;
        public int hibaszamlalo = 0;

        public Form1()
        {
            InitializeComponent();
            GombRajzolas();

            //open file dialog to select a txt file with words
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";

        }

        public void GombRajzolas()
        {
            //generate buttons with each letter of the hungarian abc to the form1. Position it to the left bottom section.
            string abc = "aábcdeéfghiíjklmnoóöõpqrstuúüûvwxyz";
            int x = 10;
            int y = ClientRectangle.Height - 250;
            for (int i = 0; i < abc.Length; i++)
            {
                Button btn = new Button();
                btn.Text = abc[i].ToString();
                btn.Size = new Size(50, 50);
                btn.Location = new Point(x, y);
                btn.Click += Btn_Click;
                Controls.Add(btn);
                x += 50;
                if (i == 8 || i == 17 || i == 26)
                {
                    x = 10;
                    y += 50;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (szo.Contains(btn.Text))
            {
                TalaltBetu(btn);
            }
            else
            {
                hibaszamlalo++;
                hibaszamLabel.Text = "Hibaszám: " + hibaszamlalo;
                AkasztofaRajz();
            }
        }

        private void AkasztofaRajz()
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            //rajzold meg az akasztófát a form1-re ha a számláló nõ egyel. Ha a számláló 6, akkor vesztettél. A rajzolás kiindulópontja legyen az ablak szélessége és magassága/2 +100
            int x = (ClientRectangle.Width / 2)+200;
            int y = ClientRectangle.Height / 2 ;
            if (hibaszamlalo == 1)
            {
                g.DrawLine(p, x, y, x, y - 100);
            }
            else if (hibaszamlalo == 2)
            {
                g.DrawLine(p, x, y - 100, x + 50, y - 100);
            }
            else if (hibaszamlalo == 3)
            {
                g.DrawLine(p, x + 50, y - 100, x + 50, y - 80);
            }
            else if (hibaszamlalo == 4)
            {
                g.DrawEllipse(p, x + 40, y - 80, 20, 20);
            }
            else if (hibaszamlalo == 5)
            {
                g.DrawLine(p, x + 50, y - 60, x + 50, y - 40);
            }
            else if (hibaszamlalo == 6)
            {
                g.DrawLine(p, x + 50, y - 60, x + 40, y - 50);
                g.DrawLine(p, x + 50, y - 60, x + 60, y - 50);
                MessageBox.Show("Vesztettél! A helyes szó: " + szo);
                hibaszamlalo = 0;
                SzoKiiras();
                g.Clear(BackColor);
            }
            
        }

        private void TalaltBetu(Button btn)
        {
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i].ToString() == btn.Text)
                {
                    szoLabel.Text = szoLabel.Text.Remove(i, 1).Insert(i, btn.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open file dialog to select a word list in txt format
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    szavak.Add(line);
                }
                sr.Close();
                SzoKiiras();
            }
        }

        private void SzoKiiras()
        {
            Random rnd = new Random();
            int index = rnd.Next(szavak.Count);
            szo = szavak[index];
            string csillagos = "";
            for (int i = 0; i < szo.Length; i++)
            {
                csillagos += "*";
            }
            szoLabel.Text = csillagos;
           hibaszamLabel.Text = "Hibaszám: " + hibaszamlalo;
        }
    }
}