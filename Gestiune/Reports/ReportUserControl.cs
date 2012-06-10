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
            Produse
        }

        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportsListBoxDoubleClick(object sender, EventArgs e)
        {
            var raportEnum = (ReportsEnum)reportsListBox.SelectedIndex;
            switch (raportEnum)
            {
                case ReportsEnum.Produse:
                    LocalReport localReport = new LocalReport();
                    localReport = reportViewer.LocalReport;
                    localReport.ReportPath = @"..\..\Reports\ProduseReport.rdlc";
                    localReport.DataSources.Add(new ReportDataSource("DataSetProdus", GestiuneBusiness.Poco.Produs.GetAll()));
                    reportViewer.RefreshReport();
                    break;
            }
        }

        private void ReportUserControl_Load(object sender, EventArgs e)
        {
            var list = new List<string>();
            foreach (var item in Enum.GetNames(typeof(ReportsEnum)))
            {
                list.Add(item);
            }
            reportsListBox.DataSource = list;
        }
    }
}
