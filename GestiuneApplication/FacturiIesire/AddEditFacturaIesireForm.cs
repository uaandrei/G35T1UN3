﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Enums;

namespace GestiuneApplication.FacturiIesire
{
    public partial class AddEditFacturaIesireForm : Form
    {
        public FacturaIesire FacturaIesireObject { get; set; }
        private List<PozitieFacturaIesire> pozitiiOut { get; set; }

        public AddEditFacturaIesireForm()
        {
            InitializeComponent();
            dataGrid.Columns.Add("c1", "Produs");
            dataGrid.Columns.Add("c2", "Cantitate");
            dataGrid.Columns.Add("c3", "Pret unitar");
            produsCmb.DataSource = Produs.GetAll();
            firmeCmb.DataSource = Firma.GetAll();
            pozitiiOut = new List<PozitieFacturaIesire>();
        }

        private void AddEditFacturaIesireForm_Load(object sender, EventArgs e)
        {
            if (FacturaIesireObject == null)
            {
                FacturaIesireObject = new FacturaIesire();
                this.Text = "Adauga factura de iesire";
            }
        }

        private void produsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCantitateDisponibila();
        }

        private void RefreshCantitateDisponibila()
        {
            if (produsCmb.SelectedItem == null) return;
            var produs = (Produs)produsCmb.SelectedItem;
            cantitateDisponibilaTbox.Text = produs.CantitateDisponibila().ToString("0.00");
            pretUnitarTbox.Text = produs.Pret.ToString("0.00");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // TODO: poate optimizez cu o proprietata Produs
            if (produsCmb.SelectedItem == null) return;
            var produs = (Produs)produsCmb.SelectedItem;
            if (produs.CantitateDisponibila() == 0)
            {
                MessageBox.Show("Produsul '" + produs.Nume + "' nu este disponibil!");
                return;
            }
            decimal cantitate = 0m;
            decimal.TryParse(cantitateTbox.Text, out cantitate);
            if (cantitate == 0)
            {
                MessageBox.Show("Introduceti o cantitate!");
                return;
            }
            if (cantitate > produs.CantitateDisponibila())
            {
                MessageBox.Show("Ati ales o cantitate mai mare decat cantitatea disponibila!");
                return;
            }
            decimal pretUnitar = 0;
            decimal.TryParse(pretUnitarTbox.Text, out pretUnitar);
            bool verifiedErrorsFlag = false;
            string cantitateString = cantitate.ToString("0.00");
            List<PozitieFacturaIesire> pozitiiNoiList = new List<PozitieFacturaIesire>();
            while (cantitate > 0)
            {
                var pozitieIesireNoua = new PozitieFacturaIesire();
                pozitieIesireNoua.IdFacturaIesire = 2;// pt a evita avertismentele
                pozitieIesireNoua.PretUnitar = pretUnitar;
                var stocDisponibil = Stoc.GetAll().Where(p => p.Cantitate > 0 && p.IdProdus == produs.ID).First();
                pozitieIesireNoua.IdStoc = stocDisponibil.ID;
                pozitieIesireNoua.Cantitate = stocDisponibil.Cantitate;
                if (!verifiedErrorsFlag)
                {
                    verifiedErrorsFlag = true;
                    var errors = pozitieIesireNoua.GetErrorString();
                    if (errors.Trim() != string.Empty)
                    {
                        MessageBox.Show(errors);
                        return;
                    }
                }
                if (stocDisponibil.Cantitate >= cantitate)
                {
                    stocDisponibil.Cantitate -= cantitate;
                    pozitieIesireNoua.Cantitate = cantitate;
                    cantitate = 0;
                }
                else
                {
                    cantitate -= stocDisponibil.Cantitate;
                    stocDisponibil.Cantitate = 0;
                }
                pozitiiNoiList.Add(pozitieIesireNoua);
                pozitiiOut.Add(pozitieIesireNoua);
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGrid, produs.Nume, cantitateString, pretUnitar.ToString("0.00"));
            row.Tag = pozitiiNoiList;
            dataGrid.Rows.Add(row);
            RefreshCantitateDisponibila();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count == 0) return;
            var rowIndex = dataGrid.SelectedCells[0].RowIndex;
            var pozitiiList = (List<PozitieFacturaIesire>)dataGrid.Rows[rowIndex].Tag;
            foreach (var item in pozitiiList)
            {
                pozitiiOut.Remove(item);
                item.StocObject.Cantitate += item.Cantitate;
            }
            dataGrid.Rows.RemoveAt(rowIndex);
            RefreshCantitateDisponibila();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            decimal value = 0m;
            decimal.TryParse(cotaTvaTbox.Text, out value);
            FacturaIesireObject.CotaTva = value;
            FacturaIesireObject.Data = dataDtp.Value;
            FacturaIesireObject.IdFirma = firmeCmb.SelectedValue == null ? 0 : (int)firmeCmb.SelectedValue;
            FacturaIesireObject.Numar = numarTbox.Text;
            FacturaIesireObject.Serie = serieTbox.Text;
            var errors = FacturaIesireObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = FacturaIesireObject.Save(pozitiiOut);
                MessageBox.Show(result.Message);
                if (result.Status == StatusEnum.Saved)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        //TODO: test de neuitat, goleste baza de date si testeaza aplicatia asa
    }
}
