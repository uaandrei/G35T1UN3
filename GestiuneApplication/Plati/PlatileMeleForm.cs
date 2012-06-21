using System;
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
    public partial class PlatileMeleForm : Form
    {
        public PlatileMeleForm()
        {
            InitializeComponent();
        }

        private void platesteFacturaBtn_Click(object sender, EventArgs e)
        {
            if (facturaIntrareBound == null) return;
            PlatesteFactura(facturaIntrareBound);
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void platesteAutomatBtn_Click(object sender, EventArgs e)
        {
            if (facturaIntrareBound == null) return;
            while (sumaDisponibila > 0) // ies daca nu mai am cu ce plati
            {
                var factura = FacturaIntrare.GetAll().OrderBy(p => p.Data).Where(p => p.SumaRamasaDePlatit > 0).FirstOrDefault();
                if (factura == null) return; // ies daca nu mai gasesc facturi de platit
                if (!PlatesteFactura(factura)) return;
            }
        }

        private void PlatileMeleForm_Load(object sender, EventArgs e)
        {
            RefreshFacturileMele();
        }

        private void RefreshFacturileMele()
        {
            facturaIntrareBindingSource.DataSource = null;
            var facturi = FacturaIntrare.GetAll().Where(p => p.SumaRamasaDePlatit > 0).ToList();
            facturaIntrareBindingSource.DataSource = facturi;
        }

        private bool PlatesteFactura(FacturaIntrare factura)
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
                RefreshFacturileMele();
            }
            else
            {
            }
            return true;
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

        private FacturaIntrare facturaIntrareBound
        {
            get
            {
                if (facturiGrid.SelectedCells.Count == 0) return null;
                else return (FacturaIntrare)facturiGrid.Rows[facturiGrid.SelectedCells[0].RowIndex].DataBoundItem;
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
    }
}
