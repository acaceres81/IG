using cookpad.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cookpad
{

    public partial class Form1 : Form
    {
        BotoaForm botoa = new BotoaForm();
        List<BotoaForm> botoak = new List<BotoaForm>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CookpadForm_Load(object sender, EventArgs e)
        {
            using (var db = new BotoaDBContext())
            {
                var botoaData = db.Botoa
                .Include("Errezeta")
                .Where(b => b.Urtea == cbUrteak.Text)
                .GroupBy(b => b.Errezeta.Izena)
                .ToDictionary(g => g.Key, g => g.Count());


                if (botoaData != null)
                {
                    if (botoaData.Count > 0)
                    {
                        //Aqui ponemos el nombre del osagaia
                        var kontrolak = cookpadDll1.Controls.OfType<Chart>();
                        foreach (var kontrola in kontrolak)
                        {
                            kontrola.DataSource = botoaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            List<string> mezuak = new List<string>(); 

            if (tbNan.Text.Length != 9)
            {
                mezuak.Add("Sartu duzun NAN ez da egokia.");
            }

            if (tbIzena.Text.Length == 0)
            {
                mezuak.Add("Izena sartzea derrigorrezkoa da.");
            }

            if (tbEzizena.Text.Length == 0)
            {
                mezuak.Add("Ezizena ezin da utzik laga.");
            }

            if (tbEmaila.Text.Length == 0)
            {
                mezuak.Add("Emaila ezin da utzik egon.");
            }
            else if (!tbEmaila.Text.Contains("@"))
            {
                mezuak.Add("Emailak ez du formatu egokia.");
            }

            if (TbErrezeta.Text.Length == 0)
            {
                mezuak.Add("Errezeta Id-a ezin da utzik gelditu.");
            }
            else if (!int.TryParse(TbErrezeta.Text, out number))
            {
                mezuak.Add("Errezeta Id-a zenbakia izan behar da.");
            }

            // Mostrar todos los mensajes juntos
            if (mezuak.Any())
            {
                string mensajeCompleto = string.Join("\n", mezuak);
                MessageBox.Show(mensajeCompleto);
            }
            else
            {
                botoa.nan = tbNan.Text;
                botoa.izena = tbIzena.Text;
                botoa.ezizena = tbEzizena.Text;
                botoa.email = tbEmaila.Text;
                botoa.errezetaId = TbErrezeta.Text;

                botoa.gorde(tbIzena.Text.ToString());
                botoak.Add(botoa);
            }         
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
