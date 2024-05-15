namespace _10ora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Fuchsia);
            Brush brush = new SolidBrush(Color.Fuchsia);

            g.FillEllipse(brush, 0, 0, 100, 100);
        }
    }
}