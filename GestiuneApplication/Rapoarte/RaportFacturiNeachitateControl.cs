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
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneApplication.Rapoarte
{
    public partial class RaportFacturiNeachitateControl : UserControl, ITreeNode
    {
        #region [CTOR]
        public RaportFacturiNeachitateControl()
        {
            InitializeComponent();
        }
        #endregion

        #region [ITreeNodeComponent]
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
            get { return "Facturi de iesire neachitate pe firma"; }
        }
        #endregion

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (SelectedFirma == null) return;
            var facturi = FacturaIesire.GetAll().Where(p => p.SumaRamasaDePlatit > 0 && p.IdFirma == SelectedFirma.ID);
            var report = new FacturiNeachitateReport();
            report.TitleTBox.Value = string.Format("Facturi neachitate pentru firma '{0}'", SelectedFirma.Nume);
            report.ObjectDataSource.DataSource = facturi;
            reportViewer.Report = report;
            reportViewer.RefreshReport();
        }

        private Firma firma;

        public Firma SelectedFirma
        {
            get { return firma; }
            set
            {
                firmaTbox.Text = value == null ? "Alegeti o firma..." : value.Nume;
                firma = value;
            }
        }

        private void searchFirmaBtn_Click(object sender, EventArgs e)
        {
            var form = new SelectItemForm
            {
                Datas = Firma.GetAll().Cast<GestiuneObject>().ToList(),
                Text = "Cautare firma"
            };
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SelectedFirma = form.SelectedObject == null ? null : (Firma)form.SelectedObject;
        }

        private void RaportFacturiNeachitateControl_Load(object sender, EventArgs e)
        {

        }
    }
}
