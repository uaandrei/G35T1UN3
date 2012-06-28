namespace GestiuneApplication.Rapoarte.TelerikReports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using GestiuneBusiness.Poco.Administration;

    /// <summary>
    /// Summary description for FacturaReport.
    /// </summary>
    public partial class FacturaIntrareReport : Telerik.Reporting.Report
    {
        public FacturaIntrareReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            FurnizorTbox.Value = Setare.GetSetare().MyFirma.InfoString;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}