using System;
using System.Linq;
using System.Windows.Forms;
using Gestiune.Forms.Facturi;
using Gestiune.Forms.Firme;
using Microsoft.Reporting.WinForms;
using Gestiune.Reports;

namespace Gestiune.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonFirmeClick(object sender, EventArgs e)
        {
            this.panelCategory.Controls.Clear();
            var uc = new FirmeUserControl();
            uc.Dock = DockStyle.Fill;
            this.panelCategory.Controls.Add(uc);
        }

        private void RapoarteBtnClick(object sender, EventArgs e)
        {
            this.panelCategory.Controls.Clear();
            var form = new ChooseReportForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReportViewer reportViewer = new ReportViewer();
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.Dock = DockStyle.Fill;
                panelCategory.Controls.Add(reportViewer);
                reportViewer.Show();
                var localReport = new LocalReport();
                localReport = reportViewer.LocalReport;
                localReport.ReportPath = form.ReportPath;
                localReport.DataSources.Add(form.ReportDataSourceObject);
                reportViewer.RefreshReport();
            }
        }

        private void StocBtnClick(object sender, EventArgs e)
        {
            panelCategory.Controls.Clear();
            var uc = new FacturiUserControl();
            uc.Dock = DockStyle.Fill;
            panelCategory.Controls.Add(uc);
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
