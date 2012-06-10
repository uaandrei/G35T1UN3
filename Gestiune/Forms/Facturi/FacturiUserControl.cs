using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using Gestiune.Reports;
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
            // TODO: Adaugi facturile de intrare si la dublu click pe oricare faci raport din legaturi. Jos faci suma cu Total.
            // TODO: poti sa te folosesti si de delagat ca sa-l pui jos
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
                    //facturaIntrareForm.FacturaObject = null;
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

        //TODO: la dublu click pe grid sa apara raport cu factura si anulare! Pot pune la Tip = "Anulata"

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
                        //TODO: nu prea pot modifica facturi, eventual sa le anulez || facturaIntrareForm.FacturaObject = (Factura)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
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

        private void DataGridViewCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (facturiEnum == FacturiEnum.FacturaIntrare)
            {
                Factura factura = null;
                try
                {
                    factura = (Factura)dataGridView.Rows[e.RowIndex].DataBoundItem;
                }
                catch (Exception)
                {
                    return;
                }
                List<FacturaProdusStoc> facturaProdusStocObjectList = FacturaProdusStoc.GetAll().Where(p => p.FacturaObject.ID == factura.ID).ToList();
                ReportViewerForm form = new ReportViewerForm();
                form.ReportViewer.ProcessingMode = ProcessingMode.Local;
                var localReport = new LocalReport();
                localReport = form.ReportViewer.LocalReport;
                localReport.ReportPath = @"..\..\Reports\FacturaIntrareReport.rdlc";
                var furnizorList = new List<Firma>();
                var facturaList = new List<Factura>();
                var stocList = new List<Stoc>();

                foreach (var item in facturaProdusStocObjectList)
                {
                    stocList.Add(item.StocObject);
                }
                furnizorList.Add(facturaProdusStocObjectList[0].FacturaObject.Firma);
                facturaList.Add(facturaProdusStocObjectList[0].FacturaObject);
                localReport.DataSources.Add(new ReportDataSource("DataSetFurnizor", furnizorList));
                localReport.DataSources.Add(new ReportDataSource("DataSetFactura", facturaList));
                localReport.DataSources.Add(new ReportDataSource("DataSetStoc", stocList));
                form.ReportViewer.RefreshReport();
                form.Show();
            }
        }
    }
}
