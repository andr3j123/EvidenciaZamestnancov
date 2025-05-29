using MySql.Data.MySqlClient;
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

namespace EvidenciaZamestnancov
{
    public partial class Analiza : Form
    {
        public Analiza()
        {
            InitializeComponent();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                var query = "SELECT r.Ime AS ime, " +
                                   "rs.DatumPostavljanja AS datumPostavljanja, " +
                                   "rs.DatumRazresenja AS datumRazresenja " +
                            "FROM radnik r " +
                            "JOIN rukovodi_sektorom rs ON rs.RadnikID = r.RadnikID ";

                using (var cmd =  new MySqlCommand(query, conn))
                {
                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();

                    adapter.Fill(dt);

                    statistikaChart.Series.Clear();
                    statistikaChart.ChartAreas.Clear();
                    statistikaChart.Legends.Clear();

                    ChartArea oblast = new ChartArea();

                    oblast.AxisY.Title = "Dni";
                    oblast.AxisX.Title = "Rukovodilac";

                    oblast.AxisX.MajorGrid.LineColor = Color.Black;
                    oblast.AxisY.MajorGrid.LineColor = Color.Black;

                    statistikaChart.ChartAreas.Add(oblast);

                    Series seria = new Series()
                    {
                        ChartType = SeriesChartType.Column,
                        XValueType = ChartValueType.String,
                        YValueType = ChartValueType.Int64,
                        BorderWidth = 2,
                        Color = Color.Blue,
                        IsValueShownAsLabel = false
                    };

                    foreach (DataRow riadok in dt.Rows)
                    {
                        string rukovodilac = riadok["ime"].ToString();
                        DateTime datumRazresenja = Convert.ToDateTime(riadok["datumRazresenja"]);
                        DateTime datumPostavljanja = Convert.ToDateTime(riadok["datumPostavljanja"]);

                        int zostaloDni = (datumRazresenja - datumPostavljanja).Days;

                        seria.Points.AddXY(rukovodilac, zostaloDni);
                    }

                    statistikaChart.Series.Add(seria);
                }
            }
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
