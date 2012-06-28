namespace GestiuneApplication.Rapoarte.TelerikReports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for DatoriiPeFirmeReport.
    /// </summary>
    public partial class DatoriiPeFirmeReport : Telerik.Reporting.Report
    {
        public DatoriiPeFirmeReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            infoTbox.Value = String.Format("Eliberat de '{0}', in data de {1}", MainForm.LoggedUser.Nume, DateTime.Now.ToString("dd/MM/yyyy"));

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }

    public class DatorieFirma
    {
        public string NumeFirma { get; set; }
        public string SumaPlatita { get; set; }
        public string SumaRamasa { get; set; }
    }
}