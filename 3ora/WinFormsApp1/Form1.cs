namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int meret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Button b = new Button();
                    b.Height = meret;
                    b.Width = meret;
                    b.Left = oszlop*meret;
                    b.Top = sor*meret;
                    b.Text = ((sor+1)*(oszlop+1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}