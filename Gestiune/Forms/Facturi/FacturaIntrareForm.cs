using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Facturi
{
    public partial class FacturaIntrareForm : Form
    {
        public FacturaProdusStoc FacturaProdusStocObject { get; set; }

        public FacturaIntrareForm()
        {
            InitializeComponent();
        }

        private void FacturaIntrareForm_Load(object sender, EventArgs e)
        {
            produseCmb.DataSource = Produs.GetAll();
            firmeCmb.DataSource = Firma.GetAll();
            if (FacturaProdusStocObject == null)
            {
                FacturaProdusStocObject = new FacturaProdusStoc();
                FacturaProdusStocObject.FacturaObject = new Factura();
                FacturaProdusStocObject.ProdusObject = new Produs();
                FacturaProdusStocObject.StocObject = new Stoc();
                this.Text = "Adaugare factura";
            }
            else
            {
                //this.Text = "Modificare factura";
                //produseCmb.SelectedValue = StocObject.IdProdus;
                //numarTbox.Text = FacturaObject.Numar;
                //serieTbox.Text = FacturaObject.Serie;
                //dataDtp.Value = FacturaObject.Data.Value;
                //firmeCmb.SelectedValue = FacturaObject.IdFirma;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            FacturaProdusStocObject.FacturaObject.Numar = numarTbox.Text;
            FacturaProdusStocObject.FacturaObject.Serie = serieTbox.Text;
            FacturaProdusStocObject.FacturaObject.Data = dataDtp.Value;
            FacturaProdusStocObject.FacturaObject.IdFirma = (int)firmeCmb.SelectedValue;
            FacturaProdusStocObject.FacturaObject.Tip = "Intrare";
            decimal cantitate = 0m;
            decimal.TryParse(cantitateTbox.Text, out cantitate);
            FacturaProdusStocObject.StocObject.Cantitate = cantitate;
            FacturaProdusStocObject.StocObject.IdProdus = (int)produseCmb.SelectedValue;
            FacturaProdusStocObject.StocObject.IdFacturaIntrare = -1;
            FacturaProdusStocObject.ProdusObject = FacturaProdusStocObject.StocObject.ProdusObject;
            // TODO: try catch si verificari pt pret
            FacturaProdusStocObject.Pret = cantitate * FacturaProdusStocObject.ProdusObject.Pret;
            FacturaProdusStocObject.Cantitate = cantitate;
            string errors = FacturaProdusStocObject.GetErrors();
            if (errors == "")
            {
                var result = FacturaProdusStocObject.Save();
                if (result.Status == GestiuneBusiness.Enums.EnumStatus.Saved)
                {
                    MessageBox.Show("Salvare efectuata cu succes!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Au aparut erori la salvare!" + Environment.NewLine + result.Message);
                }
            }
            else
            {
                MessageBox.Show(errors);
            }
        }
    }
}
