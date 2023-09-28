namespace Ariketa2Array
{
    public partial class Form1 : Form
    {
        public int i = 1;
        Ariketa ariketa = new Ariketa();
        float[] zenbakiak = new float[4];
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
            switch (i)
            {
                case 1:
                    lblZenbakiak.Text = "Zenbakia 2";
                    ariketa.zenbakiak[0] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 2;
                    break;
                case 2:
                    lblZenbakiak.Text = "Zenbakia 3";
                    ariketa.zenbakiak[1] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 3;
                    break;
                case 3:
                    lblZenbakiak.Text = "Zenbakia 4";
                    ariketa.zenbakiak[2] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    i = 4;
                    break;
                case 4:
                    lblZenbakiak.Text = "Emaitza";
                    ariketa.zenbakiak[3] = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Text = "(" + ariketa.zenbakiak[0] + " + (" + ariketa.zenbakiak[1] + "x2)" + " + (" + zenbakiak[2] + "x3)" + " + (" + zenbakiak[3] + "x4)/4 = " + ariketa.eragiketaluzea().ToString();
                    i++;
                    break;
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