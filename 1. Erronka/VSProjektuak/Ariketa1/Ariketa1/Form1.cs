namespace Ariketa1
{
    public partial class Form1 : Form
    {
        
        private Esaldi esaldiaKlasea = new Esaldi();
        String esaldia1 = "";
        String esaldiaBatua = "";
        public Form1()
        {
            InitializeComponent();
            btnEsaldi2.Enabled = false; // dejar los btones inabilitados
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
  
        }

        private void esaldi1_Click(object sender, EventArgs e)
        {
            
            esaldia1 = tbIdatzi.Text;
            btnEsaldi2.Enabled = true;
            btnEsaldi1.Enabled = false;
            esaldiaKlasea.Lotu();
        }

        private void btnEsaldi2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbIdatzi.Text);

            
        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbIdatzi.Text);
            
        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbIdatzi.Text);
            
        }

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbIdatzi.Text);
        
        
        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            
        }

        private void tbIdatzi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {

        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}