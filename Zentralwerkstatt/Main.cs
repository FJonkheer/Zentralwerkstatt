﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Zentralwerkstatt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //Eine manuelle Verbindung mit der Datenbank für eigene SQL-Abfragen einrichten
            int count = 0;
            string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            //Zählen der Datensätze in der Tabelle
            cmd.CommandText = "SELECT * FROM Test";
            MySqlDataReader Reader;
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                count = count + 1;
            }

            //Die gezählten Einträge in die Statusleiste einfügen
            this.StatusStripCount.Text = Convert.ToString(count);
            Reader.Close();
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Öffnen der Benutzerverwaltung
            Zentralverwaltung Form = new Zentralverwaltung();
            Form.Show();
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            //Bei schließen des Main-Programms, alle Fenster schließen
            Application.Exit();
        }
         
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Date = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
                MySqlConnection conn = null;
                conn = new MySqlConnection(cs);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "CREATE OR REPLACE VIEW Prüfausgabe AS SELECT prüfkriterien.Text, prüfergebnisse.Messwert FROM prüfkriterien INNER JOIN prüfergebnisse ON prüfkriterien.IDKriterium = prüfergebnisse.IDKriterium WHERE Prüfergebnisse.IDPrüfung IN (SELECT Prüfungen.IDPrüfung FROM Prüfungen INNER JOIN Geräte ON Prüfungen.Geräte_Barcode = Geräte.Geräte_Barcode INNER JOIN Gerätetypen ON Geräte.IDGerätetyp = Gerätetypen.IDGerätetyp WHERE Gerätetypen.Bezeichnung = @Name AND Prüfungen.Datum = @Date)";
                DateTime Datum = Convert.ToDateTime(Date);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Date", Datum);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                dataGridView2.Visible = true;
                // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.prüfausgabe". Sie können sie bei Bedarf verschieben oder entfernen.
                this.prüfausgabeTableAdapter.Fill(this.projektzDataSet.prüfausgabe);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.test". Sie können sie bei Bedarf verschieben oder entfernen.
            this.testTableAdapter.Fill(this.projektzDataSet.test);
        }

        private void geräteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Geraeteverwaltung Form = new Geraeteverwaltung();
            Form.Show();
        }

        private void MenüLeiste_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
