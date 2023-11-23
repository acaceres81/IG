using NutrinfoForm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NutrinfoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NutrinfoForma_Load(object sender, EventArgs e)
        {
            using (var db = new NutrinfoDbContext())
            {

                var elikagaiData = db.Elikagaia.ToList();

                if (elikagaiData != null)
                {
                    if (elikagaiData.Count > 0)
                    {
                        dataGridView.DataSource = elikagaiData;
                        dataGridView.Columns["Key"].DataPropertyName = "Key";
                        dataGridView.Columns["Value"].DataPropertyName = "Value";
                    }
                }  
                
            }
        }

        private void btnBistaratu_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 0 || dataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Mesedez, aukeratu elikagai bat bakarrik.");
            } else 
            {
                //Aukeratutako lerroa
                DataGridViewRow row = dataGridView.SelectedRows[0];
                // lortu idearen balioa lehen kolumnatik
                int id = (int)row.Cells[0].Value;


               using (var db = new NutrinfoDbContext())
                {
                    var infirmazioaData = db.Infomazioa
                        .Include("Osagaia")
                        .Where(b => b.ElikagaiaId == id)
                        .GroupBy(c => c.Osagaia.Izena)
                        .ToDictionary(g => g.Key, g => g.Sum(i => i.Kantitaea));

                    var kontrolak = charInformazioa.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                    foreach (var kontrola in kontrolak)
                    {
                        kontrola.DataSource = infirmazioaData;
                        kontrola.Series[0].YValueMembers = "Value";
                        kontrola.Series[0].XValueMember = "Key";
                        kontrola.DataBind();
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
