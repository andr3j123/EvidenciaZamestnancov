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

namespace EvidenciaZamestnancov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSektorComboBox();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void analizaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analiza analiza = new Analiza();
            analiza.ShowDialog();
            this.Show();
        }
        private void promenaRukovodiocaBtn_Click(object sender, EventArgs e)
        {
            NoviRukovodilac noviRukovodilac = new NoviRukovodilac();

            noviRukovodilac.Show();
        }

        private void sektorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sektorComboBox.SelectedIndex > 0)
            {              
                LoadListView((sektorComboBox.SelectedItem).ToString());
                LoadPodatkeOSektoru((sektorComboBox.SelectedItem).ToString());
            }
        }

        private void LoadListView(string sektorNaziv)
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT r.RadnikId AS id, r.Ime AS ime, r.Prezime AS prezime, " +
                                           "i.DatumPocetka AS dPocetka, i.DatumZavrsetka AS dZavrsetka " +
                                           "FROM radnik r " +
                                           "JOIN istorija_rm_radnika i ON r.RadnikID = i.RadnikID " +
                                           "JOIN sektor s ON r.SektorID = s.SektorID " +
                                           "WHERE s.Naziv = @Naziv", conn);

                cmd.Parameters.AddWithValue("@Naziv", sektorNaziv);

                using (var reader = cmd.ExecuteReader())
                {
                    radnikListView.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id"].ToString());
                        item.SubItems.Add(reader["ime"].ToString());
                        item.SubItems.Add(reader["prezime"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["dPocetka"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(Convert.ToDateTime(reader["dZavrsetka"]).ToString("dd/MM/yyyy"));

                        radnikListView.Items.Add(item);
                    }
                }
            }
        }

        private void LoadPodatkeOSektoru(string sektorNaziv)
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT Opis FROM sektor WHERE Naziv = @naziv", conn);

                cmd.Parameters.AddWithValue("@naziv", sektorNaziv);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        podaciOSektoruTextBox.Text = reader["Opis"].ToString();
                    }
                }
            }
        }

        private void LoadSektorComboBox()
        {
            using (var conn = Database.DbConnection())
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT Naziv, SektorID FROM sektor", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    sektorComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        sektorComboBox.Items.Add(reader["Naziv"].ToString());
                    }
                }
            }
        }

    }
}
