namespace Kigyo
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        int lepesszam;
        int hossz = 1;

        List<KigyoElem> kígyó = new List<KigyoElem>();
        List<Alma> alma = new List<Alma>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lepesszam++;

            //Fejnövesztés
            fej_x += irány_x * KigyoElem.Méret;
            fej_y += irány_y * KigyoElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is Alma)
                {
                    Alma a = (Alma)item;

                    if (a.Top == fej_y && a.Left == fej_x)
                    {
                        hossz++;
                    }
                }
            }


            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;
            kígyó.Add(ke); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            Controls.Add(ke); //.. és az ûrlap vezérlõinek a listájába is

            if (Controls.Count > hossz)
            {
                KigyoElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Alma a = new Alma();
            Random random = new Random();
            a.Top = random.Next(1, 100) * 20;
            a.Left = random.Next(1, 100) * 20;
            alma.Add(a); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            Controls.Add(a); //.. és az ûrlap vezérlõinek a listájába is
        }
    }
}