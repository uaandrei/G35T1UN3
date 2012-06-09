using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Facturi
{
    public partial class FacturiUserControl : UserControl
    {
        enum FacturiEnum
        {
            Nimic,
            Produs,
            FacturaIntrare,
            Stoc
        }

        private FacturiEnum facturiEnum = FacturiEnum.Nimic;

        public FacturiUserControl()
        {
            InitializeComponent();
        }

        private void FacturiBtnClick(object sender, EventArgs e)
        {
            titleLbl.Text = facturiBtn.Text;
            facturiEnum = FacturiEnum.FacturaIntrare;
            dataGridView.DataSource = Factura.GetAll().Where(p => p.Tip == "Intrare").ToList();
        }

        private void StocBtnClick(object sender, EventArgs e)
        {
            titleLbl.Text = stocBtn.Text;
            facturiEnum = FacturiEnum.Stoc;
            dataGridView.DataSource = Stoc.GetAll();
        }

        private void ProduseBtnClick(object sender, EventArgs e)
        {
            titleLbl.Text = produseBtn.Text;
            facturiEnum = FacturiEnum.Produs;
            dataGridView.DataSource = Produs.GetAll();
        }

        private void AddBtnClick(object sender, EventArgs e)
        {
            switch (facturiEnum)
            {
                case FacturiEnum.Nimic:
                    break;
                case FacturiEnum.Produs:
                    var produsForm = new ProdusForm();
                    produsForm.ProdusObject = null;
                    if (produsForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = Produs.GetAll();
                    }
                    break;
                case FacturiEnum.FacturaIntrare:
                    var facturaIntrareForm = new FacturaIntrareForm();
                    facturaIntrareForm.FacturaObject = null;
                    if (facturaIntrareForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = Factura.GetAll().Where(p => p.Tip == "Intrare");
                    }
                    break;
                case FacturiEnum.Stoc:
                    var stocForm = new StocForm();
                    stocForm.StocObject = null;
                    if (stocForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = Stoc.GetAll();
                    }
                    break;
            }
        }

        private void ModifyBtnClick(object sender, EventArgs e)
        {
            try
            {
                switch (facturiEnum)
                {
                    case FacturiEnum.Nimic:
                        break;
                    case FacturiEnum.Produs:
                        var produsForm = new ProdusForm();
                        produsForm.ProdusObject = (Produs)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
                        if (produsForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = Produs.GetAll();
                        }
                        break;
                    case FacturiEnum.FacturaIntrare:
                        var facturaIntrareForm = new FacturaIntrareForm();
                        facturaIntrareForm.FacturaObject = (Factura)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
                        if (facturaIntrareForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = Factura.GetAll().Where(p => p.Tip == "Intrare");
                        }
                        break;
                    case FacturiEnum.Stoc:
                        var stocForm = new StocForm();
                        stocForm.StocObject = (Stoc)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
                        if (stocForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = Stoc.GetAll();
                        }
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
