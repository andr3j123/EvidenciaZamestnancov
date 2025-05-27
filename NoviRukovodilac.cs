using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenciaZamestnancov
{
    public partial class NoviRukovodilac : Form
    {
        private List<string> radnikIDList = new List<string>(); 

        public NoviRukovodilac()
        {
            InitializeComponent();
        }

        private void NoviRukovodilac_Load(object sender, EventArgs e)
        {
            LoadRukovodilacComboBox();
        }

        private void LoadRukovodilacComboBox()
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT CONCAT(r.Ime, ' ', r.Prezime) AS punoIme, r.RadnikID AS id " +
                    "FROM radnik r " +
                    "JOIN sektor s ON r.SektorID = s.SektorID " +
                    "WHERE r.SektorID = @sektorID", conn);

                cmd.Parameters.AddWithValue("@sektorID", Form1.selectedSektorID);

                using (var reader = cmd.ExecuteReader())
                {
                    rukovodilacComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        rukovodilacComboBox.Items.Add(reader["id"].ToString() + " " + reader["punoIme"].ToString());

                        radnikIDList.Add(reader["id"].ToString());
                    }
                }
            }
        }

        private void unesiIzmenuBtn_Click(object sender, EventArgs e)
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                var query = "UPDATE rukovodi_sektorom rs " +
                                           "SET RadnikID = @noviRadnikID, " +
                                               "DatumPostavljanja = @datumPostavljanja " +
                                           "WHERE SektorID = @sektorID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@noviRadnikID", radnikIDList[rukovodilacComboBox.SelectedIndex]);
                    cmd.Parameters.AddWithValue("@datumPostavljanja", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@SektorID", Form1.selectedSektorID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspesne znemeneni rukovodilac!");

                    this.Close();
                }

            }
        }
    }
}
