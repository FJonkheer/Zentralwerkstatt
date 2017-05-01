﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Zentralwerkstatt
{
    public partial class Zentralverwaltung : Form
    {

        public Zentralverwaltung()
        {           
            InitializeComponent();       
        }

        private void Zentralverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Benutzer' table. You can move, or remove it, as needed.
            this.benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            NeuerBenutzer Form2 = new NeuerBenutzer();
            Form2.ShowDialog();
            benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wollen sie den Benutzer löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM benutzer WHERE benutzername = @Benutzername");
                    cmd.Parameters.AddWithValue("@Benutzername", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    this.benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
                }catch(MySqlException ex)
                {
                    MessageBox.Show("Benutzer konnte nicht gelöscht werden da zugehörige Prüfungen existieren: " + ex.Message);
                }
            }
        }

        private void Button_aktualisieren_Click(object sender, EventArgs e)
        {
            this.benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
        }

        private void ChangeUserDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.benutzerBindingSource.EndEdit();
                benutzerTableAdapter.Update(this.projektZDataSet.benutzer);
                MessageBox.Show("Benutzerdaten wurden geändert");
            }
            catch (DBConcurrencyException) { }
        }
    }
}