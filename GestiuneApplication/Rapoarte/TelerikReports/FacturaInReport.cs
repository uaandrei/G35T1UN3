namespace GestiuneApplication.Rapoarte.TelerikReports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using GestiuneBusiness.Poco.Administration;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for FacturaInReport.
    /// </summary>
    public partial class FacturaInReport : Telerik.Reporting.Report
    {
        public FacturaInReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            CumparatorTbox.Value = Setare.GetSetare().MyFirma.InfoString;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}