namespace Ariketa3
{
    public partial class Form1 : Form
    {
        Kontaktua kontaktua = new Kontaktua();
        List<Kontaktua> kontaktulist = new List<Kontaktua>();
        List<Bezeroa> bezeroaList = new List<Bezeroa>();
        List<Langilea> langileaList = new List<Langilea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void lblNAN_Click(object sender, EventArgs e)
        {

        }

        private void tbNAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIzena_Click(object sender, EventArgs e)
        {

        }

        private void tbIzena_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAbizena_Click(object sender, EventArgs e)
        {

        }

        private void tbAbizena_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmaila_Click(object sender, EventArgs e)
        {

        }

        private void tbEmaila_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbMota_Enter(object sender, EventArgs e)
        {

        }

        private void rbKotaktua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBezeroa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLangilea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblKategoria_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGorde_Click(object sender, EventArgs e)
        {

            kontaktua.nan = tbNAN.Text;
            kontaktua.izena = tbIzena.Text;
            kontaktua.abizena = tbAbizena.Text;
            kontaktua.email = tbEmaila.Text;
         

            if (rbKotaktua.Checked)
            {
                MessageBox.Show(kontaktua.ToString());
                kontaktua.gorde();
                kontaktulist.Add(kontaktua);
            }
            else if (rbBezeroa.Checked)
            {
                Bezeroa bezeroa = new Bezeroa();
                bezeroa.nan = kontaktua.nan;
                bezeroa.izena = kontaktua.izena;
                bezeroa.abizena = kontaktua.abizena;
                bezeroa.email = kontaktua.email;
                bezeroa.kategoria = comboBox1.Text;
                //comboBox1.SelectedIndex = 0;
                bezeroa.gorde();
                MessageBox.Show(bezeroa.ToString());
                bezeroaList.Add(bezeroa);
            }
            else if (rbLangilea.Checked)
            {
                Langilea langilea = new Langilea();
                langilea.nan = kontaktua.nan;
                langilea.izena = kontaktua.izena;
                langilea.abizena = kontaktua.abizena;
                langilea.email = kontaktua.email;
                langilea.segurtasuSoziala = tbSoldata.Text;
                langilea.soldata = float.Parse(tbSoldata.Text);
                langilea.segurtasuSoziala = tbSS.Text;
                langilea.gorde();
                MessageBox.Show(langilea.ToString());
                langileaList.Add(langilea);
            } else
            {
                MessageBox.Show("kontaktu mota aukeratzea falta zaizu");
            }
            
            tbAbizena.Clear();
            tbSoldata.Clear();
            tbSS.Clear();
            tbAbizena.Clear();
            tbIzena.Clear();
            tbEmaila.Clear();
            tbNAN.Clear();
            comboBox1.Text ="";
            rbBezeroa.Checked = false;
            rbKotaktua.Checked = false;
            rbLangilea.Checked = false;

        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}