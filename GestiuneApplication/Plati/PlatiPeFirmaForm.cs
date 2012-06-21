using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace GestiuneApplication.Plati
{
    public partial class PlatiPeFirmaForm : Form
    {
        public PlatiPeFirmaForm()
        {
            InitializeComponent();
        }

        private void platesteAutomatBtn_Click(object sender, EventArgs e)
        {
            if (facturaIesireBound == null) return;
            while (sumaDisponibila > 0) // ies daca nu mai am cu ce plati
            {
                var factura = FacturaIesire.GetAll().OrderBy(p => p.Data).Where(p => p.IdFirma == facturaIesireBound.ID && p.SumaRamasaDePlatit > 0).FirstOrDefault();
                if (factura == null) return; // ies daca nu mai gasesc facturi de platit
                if (!PlatesteFactura(factura)) return;
            }
        }

        private void platesteFacturaBtn_Click(object sender, EventArgs e)
        {
            if (firmaBound == null) return;
            if (facturaIesireBound == null) return;
            PlatesteFactura(facturaIesireBound);
        }

        private bool PlatesteFactura(FacturaIesire factura)
        {
            var sumaDePlatit = sumaDisponibila > factura.SumaRamasaDePlatit ? factura.SumaRamasaDePlatit : sumaDisponibila;
            var plata = new Plata
            {
                Data = dataDtp.Value,
                Numar = nrTbox.Text,
                Serie = serieTbox.Text,
                Suma = sumaDePlatit,
                TipPlata = TipPlata
            };
            var errors = plata.GetErrorString();
            if (errors.Trim() != string.Empty)
            {
                MessageBox.Show(errors);
                return false;
            }
            factura.AdaugaPlata(plata);
            var result = factura.AchitareFactura();
            MessageBox.Show(String.Format("Plata inregistrata pentru factura cu seria '{0}' si 'numarul'", factura.Serie, factura.Numar));
            if (result.Status == GestiuneBusiness.Enums.StatusEnum.Saved)
            {
                sumaDisponibila = sumaDisponibila - sumaDePlatit;
                if (sumaDisponibila == 0)
                {
                    nrTbox.Text = string.Empty;
                    serieTbox.Text = string.Empty;
                    sumaDisponibilaTbox.Text = string.Empty;
                }
                RefreshFacturiIesireGrid();
            }
            else
            {
            }
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFacturiIesireGrid();
        }

        private void RefreshFacturiIesireGrid()
        {
            facturaIesireBindingSource.DataSource = null;
            if (firmaBound == null) return;
            var facturi = FacturaIesire.GetAll().Where(p => p.IdFirma == firmaBound.ID && p.SumaRamasaDePlatit > 0).ToList();
            facturaIesireBindingSource.DataSource = facturi;
        }

        private decimal sumaDisponibila
        {
            get
            {
                var value = 0m;
                decimal.TryParse(sumaDisponibilaTbox.Text, out value);
                return value;
            }
            set
            {
                sumaDisponibilaTbox.Text = value.ToString("0.00");
            }
        }

        private Firma firmaBound
        {
            get
            {
                if (firmeCmb.SelectedItem == null) return null;
                return (Firma)firmeCmb.SelectedItem;
            }
        }

        private FacturaIesire facturaIesireBound
        {
            get
            {
                if (facturiGrid.SelectedCells.Count == 0) return null;
                else return (FacturaIesire)facturiGrid.Rows[facturiGrid.SelectedCells[0].RowIndex].DataBoundItem;
            }
        }

        private string TipPlata
        {
            get
            {
                if (boRbtn.Checked) return boRbtn.Text;
                if (cecRbtn.Checked) return cecRbtn.Text;
                if (chitantaRbtn.Checked) return chitantaRbtn.Text;
                else return opRbtn.Text;
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PlatiPeFirmaForm_Load(object sender, EventArgs e)
        {
            firmeCmb.DataSource = Firma.GetAll();
        }
    }
}
