namespace Practica_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sue, Nsue, aum;

            sue = double.Parse(sueldo.Text);

            if (sue < 400000.00)
            {
                aum = sue * 0.15;
                Nsue = sue + aum;
                Nsueldo.Text = Nsue.ToString();
            }

            else
            {
                Nsueldo.Text = sue.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sueldo.Text = " ";
            Nsueldo.Text = " ";
        }
    }
}