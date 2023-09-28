namespace Ariketa2Zerrenda
{
    public partial class Form1 : Form
    {
        public int i = 1;
        List<Ariketa> zenbakiak = new List<Ariketa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblZenbakiak_Click(object sender, EventArgs e)
        {

        }

        private void tbEmaitza_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            try { 
            switch(i) { 
                case 1:
                lblZenbakiak.Text = "Zenbakia 2";
                zenbakiak.Add(new Ariketa(double.Parse(tbEmaitza.Text)));
                tbEmaitza.Clear();
                i = 2;
                break;
                case 2:
                    lblZenbakiak.Text = "Zenbakia 3";
                    zenbakiak.Add(new Ariketa(double.Parse(tbEmaitza.Text)));
                    tbEmaitza.Clear();
                    i = 3;
                    break;
                case 3:
                    lblZenbakiak.Text = "Zenbakia 4";
                    zenbakiak.Add(new Ariketa(double.Parse(tbEmaitza.Text)));
                    tbEmaitza.Clear();
                    i = 4;
                    break;

                case 4:
                    lblZenbakiak.Text = "Emaitza";
                    zenbakiak.Add(new Ariketa(double.Parse(tbEmaitza.Text)));
                    tbEmaitza.Text = "(" + zenbakiak[0].zenbakia + " + (" + zenbakiak[1].zenbakia + "x2)" + " + (" + zenbakiak[2].zenbakia + "x3)" + " + (" + zenbakiak[3].zenbakia + "x4)/4 = " + Ariketa.eragiketa(zenbakiak);
                    i++;
                    break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Zenbakiak sartu behar dituzu");
                lblZenbakiak.Text = "Zenbakia 1";
                tbEmaitza.Clear();
                i = 1;
            }
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            lblZenbakiak.Text = "Zenbakia 1";
            tbEmaitza.Clear();
            i = 1;
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}