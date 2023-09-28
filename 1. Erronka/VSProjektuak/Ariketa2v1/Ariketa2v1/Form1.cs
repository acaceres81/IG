namespace Ariketa2v1
{
    public partial class Form1 : Form
    {
        Eragiketa eragiketa = new Eragiketa();
        int b = 1;
        int a = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbZenbakia_Click(object sender, EventArgs e)
        {
            Balidazioa();
        }

        private void tbZenbakia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            if (b < 4) 
            {
                a++;
                lbZenbakia.Text = a + ". Zenbakia";
                b++;
            } else
            {

                a = 1;
                b= 1;
                lbZenbakia.Text = a + ". Zenbakia";
                eragiketa.eragiketa();
                tbZenbakia.Show(eragiketa.eragiketa());
                
            }
            

            
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {

        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Balidazioa()
        {
            
        }
    }
}