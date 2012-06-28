using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Poco;
using GestiuneApplication.Rapoarte.TelerikReports;

namespace GestiuneApplication.Rapoarte
{
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm()
        {
            InitializeComponent();
        }


        public List<PozitieFacturaIesire> PozitiiFacturaIesire { get; set; }
        public FacturaIesire FacturaIesire { get; set; }
        public List<PozitieFacturaIntrare> PozitiiFacturaIntrare { get; set; }
        public FacturaIntrare FacturaIntrare { get; set; }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            if (FacturaIesire != null)
            {
                var raport = new FacturaIntrareReport();
                raport.DataSource = FacturaIesire;
                raport.PozitiiIesireSource.DataSource = PozitiiFacturaIesire;
                reportViewer.Report = raport;
                reportViewer.RefreshReport();
            }
            if (FacturaIntrare != null)
            {
                var raport = new FacturaInReport();
                raport.DataSource = FacturaIntrare;
                raport.PozitiiIntrareSource.DataSource = PozitiiFacturaIntrare;
                reportViewer.Report = raport;
                reportViewer.RefreshReport();
            }
        }
    }
}
