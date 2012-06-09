using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;

namespace Gestiune.Reports
{
    public partial class ChooseReportForm : Form
    {
        enum ReportsEnum
        {
            Produse,
        }

        private ReportsEnum raportEnum = ReportsEnum.Produse;

        public string ReportPath { get; set; }

        public ReportDataSource ReportDataSourceObject { get; set; }

        public ChooseReportForm()
        {
            InitializeComponent();
        }

        private void ChooseReportForm_Load(object sender, EventArgs e)
        {
            var list = new List<string>();
            foreach (var item in Enum.GetNames(typeof(ReportsEnum)))
            {
                list.Add(item);
            }
            rapoarteListBox.DataSource = list;
        }

        private void RapoarteListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            raportEnum = (ReportsEnum)rapoarteListBox.SelectedIndex;
        }

        private void ChooseBtnClick(object sender, EventArgs e)
        {
            switch (raportEnum)
            {
                case ReportsEnum.Produse:
                    this.ReportPath = @"D:\Faculta\LICENTA\Aplicatie\Gestiune\Gestiune\Reports\ProduseReport.rdlc";
                    this.ReportDataSourceObject = new ReportDataSource("DataSetProdus", GestiuneBusiness.Poco.Produs.GetAll());
                    break;
                //case ReportsEnum.Stoc:
                //    break;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
