using System;
using System.Linq;
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
            if (PlatesteFactura(facturaIntrareBound, sumaPartiala, false))
            {
                sumaPartialaTbox.Text = string.Empty;
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void platesteAutomatBtn_Click(object sender, EventArgs e)
        {
            sumaPartialaTbox.Text = string.Empty;
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

        private bool PlatesteFactura(FacturaIntrare factura, decimal plataPartiala = 0m, bool plataAutomata = true)
        {
            var sumaDePlatit = sumaDisponibila > factura.SumaRamasaDePlatit ? factura.SumaRamasaDePlatit : sumaDisponibila;
            if (plataPartiala != 0)
            {
                sumaDePlatit = plataPartiala;
            }
            else
            {
                if (!plataAutomata)
                {
                    if (MessageBox.Show("Doriti sa achitati aceasta factua integral?", "Plata factura", MessageBoxButtons.YesNo) != DialogResult.Yes) return false;
                }
            }
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
                MessageBox.Show(String.Format("Plata pentru factura cu seria '{0}' si numarul '{1}' nu a fost efectuata cu succes, suma nu a fost retrasa", factura.Serie, factura.Numar));
            }
            sumaDisponibilaTbox.Enabled = sumaDisponibila == 0m;
            nrTbox.Enabled = sumaDisponibilaTbox.Enabled;
            serieTbox.Enabled = sumaDisponibilaTbox.Enabled;
            return true;
        }

        private decimal sumaPartiala
        {
            get
            {
                decimal value = 0m;
                decimal.TryParse(sumaPartialaTbox.Text, out value);
                return value;
            }
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
