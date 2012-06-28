using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Rapoarte.TelerikReports;
using GestiuneBusiness.Poco;
using GestiuneApplication.Interfaces;

namespace GestiuneApplication.Rapoarte
{
    public partial class RaportDatoriiFirmeControl : UserControl, ITreeNode
    {
        public RaportDatoriiFirmeControl()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            var raport = new DatoriiPeFirmeReport();
            var listaDatorii = new List<DatorieFirma>();
            foreach (var firma in Firma.GetAll())
            {
                var facturi = FacturaIesire.GetAll().Where(p => p.IdFirma == firma.ID && p.SumaRamasaDePlatit > 0).ToList();
                var sumaPlatita = facturi.Sum(p => p.SumaPlatita);
                var sumaRamasa = facturi.Sum(p => p.SumaRamasaDePlatit);
                listaDatorii.Add(new DatorieFirma
                {
                    NumeFirma = firma.Nume,
                    SumaPlatita = sumaPlatita.ToString("0.00"),
                    SumaRamasa = sumaRamasa.ToString("0.00")
                });
            }
            raport.DatoriiSource.DataSource = listaDatorii;
            reportViewer.Report = raport;
            reportViewer.RefreshReport();
        }

        public string NodeName
        {
            get { return string.Empty; }
        }

        public string ParentName
        {
            get { return ConstantsAndEnums.Constants.RapoarteNode; }
        }

        public UserControl Control
        {
            get
            {
                this.Dock = DockStyle.Fill;
                return this;
            }
        }

        public string Description
        {
            get { return "Situatie plati pe firme"; }
        }
    }
}
