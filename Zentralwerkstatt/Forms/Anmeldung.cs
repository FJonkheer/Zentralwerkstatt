﻿using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Anmeldung Form
    /// </summary>
    public partial class Anmeldung : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der Anmeldung Form
        /// </summary>
        public Anmeldung()
        {
            InitializeComponent();
            try
            {
                //Verbindung mit der Datenbank herstellen, um eine mögliche fehlende Verbindung zu erkennen
                DBUtils.CONNECTION.Open();

                //Letzte Benutzername in die Benutzer-Textbox schreiben
                txtBenutzer.Text = ConfigurationManager.AppSettings["user"];
            }
            //Falls die Verbindung zur Datenbank nicht hergestellt werden konnte
            catch (MySqlException ex)
            {
                //Fehlertext ausgeben
                MessageBox.Show(String.Format("Die Verbindung zur Datenbank konnte nicht hergestellt werden: {0}", ex.Message));

                //Dialog zur ändern der Verbindungsdaten anzeigen
                new EditConnection().ShowDialog();
            }            
        }

        private void BtnAnmelden_Click(object sender, EventArgs e)
        {
            try
            {
                //Manuelle Datenanbindung zum erstellen von eigenen MySQL Abfragen
                int count = 0;
                MySqlCommand cmd = DBUtils.GetCommand("SELECT * FROM benutzer WHERE benutzername = @Benutzername AND passwort = @Passwort");
                cmd.Parameters.AddWithValue("@Benutzername", this.txtBenutzer.Text);
                cmd.Parameters.AddWithValue("@Passwort", DBUtils.EncodeMD5(this.txtPasswort.Text));
                MySqlDataReader Reader;
                Reader = cmd.ExecuteReader();
                while (Reader.Read() && count < 2)
                {
                    count = count + 1;
                }
                //Wenn ein Benutzer gefunden wurde, findet die Administratorabfrage statt
                if (count == 1)
                {
                    //Administrator-Abfrage
                    if (Reader.GetBoolean(3))
                    {
                        Reader.Close();

                        //App-Config laden
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        //Name des erfolgreich angemeldeten Benutzers in die Config speichern
                        config.AppSettings.Settings.Remove("user");
                        config.AppSettings.Settings.Add("user", txtBenutzer.Text);
                        config.Save();

                        //Neuladen der Configdatei erzwingen
                        ConfigurationManager.RefreshSection("appSettings");

                        //Hauptfenster des Programms starten
                        Main mainForm = new Main();
                        this.Hide();
                        mainForm.Show();
                        mainForm.BringToFront();
                    }
                    //Falls der Benutzer keine Administratorrechte hat, gib einen Fehlertext aus
                    else
                    {
                        txtPasswort.Text = "";
                        lblAdminErrorText.Visible = true;
                        txtBenutzer.Focus();
                    }
                }
                //Falls der Benutzer nicht gefunden wurde oder ein falsches Passwort eingegeben wurde, gib einen Fehlertext aus
                else
                {
                    txtPasswort.Text = "";
                    lblWrongPasswordText.Visible = true;
                    txtBenutzer.Focus();
                }
                Reader.Close();
            }
            catch (MySqlException ex)
            {
                //Erneute Fehlermeldung, falls die Verbindung zur Datenbank immer noch nicht hergestellt wurde
                MessageBox.Show(String.Format("Die Verbindung zur Datenbank konnte nicht hergestellt werden: {0}", ex.Message));
            }
        }

        private void TxtPasswort_TextChanged(object sender, EventArgs e)
        {
            //Bei Verändern des Felds für das Passwort oder des Benutzernamens werden die Fehlermeldungen entfernt
            lblWrongPasswordText.Visible = false;
            lblAdminErrorText.Visible = false;
        }

        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            //Bei drücken des Abbrechen Buttons, werden alle Fenster geschlossen
            Application.Exit();
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            //Öffnen des Dialogs zur verändern der Verbindung
            EditConnection editConnectionForm = new EditConnection();
            editConnectionForm.ShowDialog(this);
        }
        
        private void Anmeldung_Shown(object sender, EventArgs e)
        {
            //Wenn ein Benutzer in der Configdatei gefunden wurde, Focus auf die Passworteingabe verschieben
            if (!string.IsNullOrEmpty(txtBenutzer.Text)) txtPasswort.Focus();
        }
    }
}
