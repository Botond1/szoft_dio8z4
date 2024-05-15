namespace Kigyo
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int lepesszam;
        int hossz = 1;

        List<KigyoElem> k�gy� = new List<KigyoElem>();
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

            //Fejn�veszt�s
            fej_x += ir�ny_x * KigyoElem.M�ret;
            fej_y += ir�ny_y * KigyoElem.M�ret;

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
            k�gy�.Add(ke); //Amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is ..
            Controls.Add(ke); //.. �s az �rlap vez�rl�inek a list�j�ba is

            if (Controls.Count > hossz)
            {
                KigyoElem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Alma a = new Alma();
            Random random = new Random();
            a.Top = random.Next(1, 100) * 20;
            a.Left = random.Next(1, 100) * 20;
            alma.Add(a); //Amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is ..
            Controls.Add(a); //.. �s az �rlap vez�rl�inek a list�j�ba is
        }
    }
}