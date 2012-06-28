using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;
using GestiuneApplication.Rapoarte.TelerikReports;
using GestiuneBusiness.Poco;

namespace GestiuneApplication.Rapoarte
{
    public partial class RaportDatoriiControl : UserControl, ITreeNode
    {
        public RaportDatoriiControl()
        {
            InitializeComponent();
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
            get { return "Facturi de intrare neachitate"; }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            var raport = new DatoriiReport();
            raport.FacturiIntrareDataSource.DataSource = FacturaIntrare.GetAll().Where(p => p.SumaRamasaDePlatit > 0).ToList();
            reportViewer.Report = raport;
            reportViewer.RefreshReport();
        }

        private void RaportDatoriiControl_Load(object sender, EventArgs e)
        {

        }
    }
}
