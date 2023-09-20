namespace Ariketa1
{
    public partial class Form1 : Form
    {
        String text1 = "";
        String text2 = "";
        String text3 = "";
        String text4 = "";
        String text5 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void esaldi1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbIdatzi.Text);

        }     

            private void btnEsaldi2_Click(object sender, EventArgs e)
            {
                MessageBox.Show(tbIdatzi.Text);
                text1 = tbIdatzi.Text;
            }

            private void btnEsaldi3_Click(object sender, EventArgs e)
            {
                MessageBox.Show(tbIdatzi.Text);
                text2 = tbIdatzi.Text;
            }

            private void btnEsaldi4_Click(object sender, EventArgs e)
            {
                MessageBox.Show(tbIdatzi.Text);
                text3 = tbIdatzi.Text;
            }

            private void btnEsaldi5_Click(object sender, EventArgs e)
            {
                MessageBox.Show(tbIdatzi.Text);
                text4 = tbIdatzi.Text;
            }

            private void btnLotu_Click(object sender, EventArgs e)
            {
            String message = text1 + text2 + text3 + text4 +text5;
            MessageBox.Show(message);
            }

            private void tbIdatzi_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }