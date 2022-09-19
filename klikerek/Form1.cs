namespace klikerek
{
    public partial class Form1 : Form
    {
        private int licznik1 = 0, licznik2 = 0;
        bool pierwszy = false;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
           
           if (pierwszy)
            {
                licznik1++;
                lbl1.Text = licznik1.ToString();
            }
           else
            {
                licznik2++;
                lbl2.Text = licznik2.ToString();
            }
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            bnt1.Enabled = false;

        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            bnt1.Enabled = true;
            timer3.Start();
            licznik1 = 0;
            licznik2 = 0;
            pierwszy = !pierwszy;

        }

        

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            bnt1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}