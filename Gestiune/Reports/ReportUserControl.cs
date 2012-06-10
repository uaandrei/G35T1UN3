using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Gestiune.Reports
{
    public partial class ReportUserControl : UserControl
    {
        enum ReportsEnum
        {
            Produse,
            Delegati,
            Banci,
            Facturi
        }

        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportsListBoxDoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var raportEnum = (ReportsEnum)reportsListBox.SelectedIndex;
            LocalReport localReport;
            switch (raportEnum)
            {
                case ReportsEnum.Produse:
                    localReport = new LocalReport();
                    localReport = reportViewer.LocalReport;
                    localReport.ReportPath = @"..\..\Reports\ProduseReport.rdlc";
                    localReport.DataSources.Add(new ReportDataSource("DataSetProdus", GestiuneBusiness.Poco.Produs.GetAll()));
                    break;
                case ReportsEnum.Facturi:
                    localReport = new LocalReport();
                    localReport = reportViewer.LocalReport;
                    localReport.ReportPath = @"..\..\Reports\FacturiReport.rdlc";
                    localReport.DataSources.Add(new ReportDataSource("DataSetFacturi", GestiuneBusiness.Poco.Factura.GetAll()));
                    break;
            }
            reportViewer.RefreshReport();
            Cursor.Current = Cursors.Default;
        }

        private void ReportUserControl_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var list = new List<string>();
            foreach (var item in Enum.GetNames(typeof(ReportsEnum)))
            {
                list.Add(item);
            }
            reportsListBox.DataSource = list;
            Cursor.Current = Cursors.Default;
        }
    }
}
