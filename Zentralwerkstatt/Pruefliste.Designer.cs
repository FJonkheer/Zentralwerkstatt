﻿namespace Zentralwerkstatt
{
    partial class Pruefliste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Prüfliste = new System.Windows.Forms.DataGridView();
            this.Prueftext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzeigeart = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gerätetypen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projektZDataSet = new Zentralwerkstatt.ProjektZDataSet();
            this.gerätetypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerätetypenTableAdapter = new Zentralwerkstatt.ProjektZDataSetTableAdapters.geraetetypenTableAdapter();
            this.iDGerätetypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerätetypenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Prüfliste
            // 
            this.Prüfliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prüfliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prüfliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueftext,
            this.Anzeigeart});
            this.Prüfliste.Location = new System.Drawing.Point(191, 12);
            this.Prüfliste.Name = "Prüfliste";
            this.Prüfliste.RowHeadersVisible = false;
            this.Prüfliste.Size = new System.Drawing.Size(847, 563);
            this.Prüfliste.TabIndex = 0;
            // 
            // Prueftext
            // 
            this.Prueftext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prueftext.FillWeight = 10000F;
            this.Prueftext.HeaderText = "Prüftext";
            this.Prueftext.Name = "Prueftext";
            // 
            // Anzeigeart
            // 
            this.Anzeigeart.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Anzeigeart.HeaderText = "Anzeigeart";
            this.Anzeigeart.Items.AddRange(new object[] {
            "h",
            "b",
            "mm"});
            this.Anzeigeart.Name = "Anzeigeart";
            // 
            // Gerätetypen
            // 
            this.Gerätetypen.AllowUserToAddRows = false;
            this.Gerätetypen.AllowUserToDeleteRows = false;
            this.Gerätetypen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Gerätetypen.AutoGenerateColumns = false;
            this.Gerätetypen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gerätetypen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGerätetypDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.Gerätetypen.DataSource = this.gerätetypenBindingSource;
            this.Gerätetypen.Location = new System.Drawing.Point(12, 12);
            this.Gerätetypen.Name = "Gerätetypen";
            this.Gerätetypen.ReadOnly = true;
            this.Gerätetypen.RowHeadersVisible = false;
            this.Gerätetypen.Size = new System.Drawing.Size(173, 563);
            this.Gerätetypen.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(866, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Abbrechen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1044, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "h = Überschrift";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1044, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "b = o.K./nicht o.K.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1044, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "mm = Messwert";
            // 
            // projektZDataSet
            // 
            this.projektZDataSet.DataSetName = "ProjektZDataSet";
            this.projektZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gerätetypenBindingSource
            // 
            this.gerätetypenBindingSource.DataMember = "Gerätetypen";
            this.gerätetypenBindingSource.DataSource = this.projektZDataSet;
            // 
            // gerätetypenTableAdapter
            // 
            this.gerätetypenTableAdapter.ClearBeforeFill = true;
            // 
            // iDGerätetypDataGridViewTextBoxColumn
            // 
            this.iDGerätetypDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDGerätetypDataGridViewTextBoxColumn.DataPropertyName = "IDGerätetyp";
            this.iDGerätetypDataGridViewTextBoxColumn.FillWeight = 1000F;
            this.iDGerätetypDataGridViewTextBoxColumn.HeaderText = "IDGerätetyp";
            this.iDGerätetypDataGridViewTextBoxColumn.Name = "iDGerätetypDataGridViewTextBoxColumn";
            this.iDGerätetypDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDGerätetypDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Bezeichnung";
            this.dataGridViewTextBoxColumn1.FillWeight = 1000F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Bezeichnung";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Pruefliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gerätetypen);
            this.Controls.Add(this.Prüfliste);
            this.Name = "Pruefliste";
            this.Text = "Prüfliste erstellen";
            this.Load += new System.EventHandler(this.Pruefliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prüfliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gerätetypen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerätetypenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Prüfliste;
        private System.Windows.Forms.DataGridView Gerätetypen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGeraetetypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueftext;
        private System.Windows.Forms.DataGridViewComboBoxColumn Anzeigeart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ProjektZDataSet projektZDataSet;
        private System.Windows.Forms.BindingSource gerätetypenBindingSource;
        private ProjektZDataSetTableAdapters.geraetetypenTableAdapter gerätetypenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGerätetypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}