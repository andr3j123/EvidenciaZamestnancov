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

                var cmd = new MySqlCommand("SELECT CONCAT(r.Ime, ' ', r.Prezime) AS punoIme " +
                    "FROM radnik r " +
                    "JOIN rukovodi_sektorom rs ON r.RadnikID = rs.RadnikID", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    rukovodilacComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        rukovodilacComboBox.Items.Add(reader["punoIme"].ToString());
                    }
                }
            }
        }

        private void unesiIzmenuBtn_Click(object sender, EventArgs e)
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                string sektorID;

                var cmd = new MySqlCommand("SELECT RadnikID FROM radnik " +
                    "WHERE CONCAT(Ime, ' ', Prezime) = @imePrezime", conn);

                cmd.Parameters.AddWithValue("@imePrezime", rukovodilacComboBox.SelectedItem);

                using (var reader = cmd.ExecuteReader())
                { 

                    if (reader.Read())
                    {
                        sektorID = reader["SektorID"].ToString();

                        MessageBox.Show(sektorID);
                    }
                }

                
            }
        }
    }
}
