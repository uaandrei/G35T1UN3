using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Facturi
{
    public partial class FacturaIntrareForm : Form
    {
        private List<FacturaProdusStoc> facturaProdusStocObjectList = null;

        public FacturaIntrareForm()
        {
            InitializeComponent();
        }

        private void FacturaIntrareForm_Load(object sender, EventArgs e)
        {
            produseCmb.DataSource = Produs.GetAll();
            firmeCmb.DataSource = Firma.GetAll();
            if (facturaProdusStocObjectList == null)
            {
                facturaProdusStocObjectList = new List<FacturaProdusStoc>();
                stocList = new List<Stoc>();
                this.Text = "Adaugare factura";
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            var result = FacturaProdusStoc.SaveManyFacturaProdusStoc(facturaProdusStocObjectList);
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

        private Factura facturaIn;

        private List<Stoc> stocList = null;

        private void AddProductBtnClick(object sender, EventArgs e)
        {
            string errors = "";
            // facem factura, daca nu a fost facuta deja
            if (facturaIn == null)
            {
                var furnizorId = (int)firmeCmb.SelectedValue;
                var serieFactura = serieTbox.Text;
                var numarFactura = numarTbox.Text;
                var dataFactura = dataDtp.Value;
                facturaIn = new Factura
                {
                    Data = dataFactura,
                    IdFirma = furnizorId,
                    Serie = serieFactura,
                    Numar = numarFactura,
                    Tip = "Intrare"
                };
                errors = facturaIn.GetErrors();
                if (errors.Trim() != string.Empty)
                {
                    MessageBox.Show(errors);
                    facturaIn = null;
                    return;
                }
                // daca s-a ajuns aici inseamna ca datele pentru factura nu se mai pot modifica, se mai pot adauga doar produse
                // deci blocam modificarea datelor facturii
                if (firmeCmb.Enabled == true)
                {
                    firmeCmb.Enabled = false;
                    numarTbox.Enabled = false;
                    serieTbox.Enabled = false;
                    dataDtp.Enabled = false;
                }
            }

            var produsId = (int)produseCmb.SelectedValue;
            var cantitate = 0m; decimal.TryParse(cantitateTbox.Text, out cantitate);

            // facem stocul
            var stoc = new Stoc
            {
                Cantitate = cantitate,
                IdProdus = produsId,
                IdFacturaIntrare = -1 // urmeaza sa se actualizeze in tranzactie
            };
            errors = stoc.GetErrors();
            if (errors.Trim() != string.Empty) { MessageBox.Show(errors); return; }
            stocList.Add(stoc);

            // adaugam in lista de FacturiProduseStoc
            facturaProdusStocObjectList.Add(new FacturaProdusStoc
            {
                Cantitate = cantitate,
                FacturaObject = facturaIn,
                Pret = stoc.ProdusObject.Pret * cantitate,
                ProdusObject = stoc.ProdusObject,
                StocObject = stoc
            });

            // incarcam gridul cu stocul adaugat
            stocGrid.DataSource = null;
            stocGrid.DataSource = stocList;
        }
    }
}
