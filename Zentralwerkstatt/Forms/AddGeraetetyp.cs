﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Zentralwerkstatt.Forms;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form zur hinzufügen eines Neues Gerätetyps
    /// </summary>
    public partial class Geraetetypen : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der Geraetetypen Form
        /// </summary>
        public Geraetetypen()
        {
            InitializeComponent();
        }

        private void Geraetetypen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.fahrzeuge_standorte' table. You can move, or remove it, as needed.
            this.fahrzeuge_standorteTableAdapter.Fill(this.projektZDataSet.fahrzeuge_standorte);
            // TODO: This line of code loads data into the 'projektZDataSet.Hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektZDataSet.hersteller);
            
        }

        private void GeraetetypenHinzufuegenAbbrechenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NeuerHerstellerButton_Click(object sender, EventArgs e)
        {
            HerstellerAdd Form = new HerstellerAdd();
            Form.ShowDialog();
            Aktualisieren();
        }

        private void Aktualisieren()
        {
            herstellerTableAdapter.Fill(projektZDataSet.hersteller);

            fahrzeuge_standorteTableAdapter.Fill(projektZDataSet.fahrzeuge_standorte);
        }

        private void GeraetetypenHinzufuegenButton_Click(object sender, EventArgs e)
        {

            Geraetetyp geraetetyp = new Geraetetyp(Convert.ToInt64(DropDownMenuHersteller.SelectedValue), textBox1.Text, textBox2.Text, textBox3.Text);
            
            AddPruefliste Form = new AddPruefliste(geraetetyp);
            Form.ShowDialog();
            this.Close();
        }
    }
}
