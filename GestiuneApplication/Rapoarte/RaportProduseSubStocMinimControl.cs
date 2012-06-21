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
    public partial class RaportProduseSubStocMinimControl : UserControl, ITreeNode
    {
        public RaportProduseSubStocMinimControl()
        {
            InitializeComponent();
        }

        public string NodeName
        {
            get
            {
                return string.Empty;
            }
        }

        public string ParentName
        {
            get
            {
                return ConstantsAndEnums.Constants.RapoarteNode;
            }
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
            get
            {
                return "Produse sub stoc minim";
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            var stocList = Stoc.GetAllGroupedByProdus().Where(p => p.Cantitate < p.ProdusObject.StocMinim);
            var report = new StocReport();
            report.objectDataSource.DataSource = stocList;
            reportViewer.Report = report;
            reportViewer.RefreshReport();
        }
    }
}
