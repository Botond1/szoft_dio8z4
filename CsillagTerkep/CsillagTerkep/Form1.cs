namespace CsillagTerkep
{
    public partial class Form1 : Form
    {
        Models.hajosContext hajosContext = new Models.hajosContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stars = hajosContext.StarData.Select(s => new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();

            Graphics g = this.CreateGraphics();

            g.Clear(Color.Black);

            Color c = Color.White;

            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;

            Pen toll = new Pen(Color.Magenta, 1);
            Brush brush = new SolidBrush(c);

            int nagyitas = 500;

            foreach (var s in stars)
            {
                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 1) continue;
                if ((float)s.Magnitude <= 10)
                {
                    double size = (40 * Math.Pow(10, (s.Magnitude) / -2.5));
                    if (size < 1)
                    {
                        size = 1;
                    }
                    // a code that create an shade between white and orange where 1 white and 10 orange
                    c = Color.FromArgb(255, (int)(255-(s.Magnitude * 25.5)), 0);
                    brush = new SolidBrush(c);
                    g.FillEllipse(brush, ((float)s.X * nagyitas)+cx, ((float)s.Y * nagyitas)+cy, (float)size, (float)size);
                }
            }

            var lines = hajosContext.ConstellationLines.Select(l => new { l.Star1, l.Star2 }).ToList();

            foreach (var l in lines)
            {
                var s1 = stars.Where(s => s.Hip == l.Star1).FirstOrDefault();
                var s2 = stars.Where(s => s.Hip == l.Star2).FirstOrDefault();

                if (s1 != null && s2 != null)
                {
                    if (Math.Sqrt(Math.Pow(s1.X, 2) + Math.Pow(s1.Y, 2)) > 1) continue;
                    if (Math.Sqrt(Math.Pow(s2.X, 2) + Math.Pow(s2.Y, 2)) > 1) continue;
                    double size1 = (40 * Math.Pow(10, (s1.Magnitude) / -2.5))/2;
                    double size2 = (40 * Math.Pow(10, (s2.Magnitude) / -2.5))/2;
                    g.DrawLine(toll, ((float)s1.X * nagyitas) + cx + (float)size1, ((float)s1.Y * nagyitas) + cy + (float)size1, ((float)s2.X * nagyitas) + cx + (float)size2, ((float)s2.Y * nagyitas) + cy + +(float)size2);
                }
            }
        }
    }
}