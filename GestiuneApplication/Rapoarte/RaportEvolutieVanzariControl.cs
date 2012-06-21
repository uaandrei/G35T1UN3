using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GestiuneApplication.Interfaces;
using GestiuneBusiness.Poco;

namespace GestiuneApplication.Rapoarte
{
    public partial class RaportEvolutieVanzariControl : UserControl, ITreeNode
    {
        public RaportEvolutieVanzariControl()
        {
            InitializeComponent();
        }

        #region [ITreeNode]
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
                return "Evolutie vanzari";
            }
        }

        public string NodeName
        {
            get { return string.Empty; }
        }
        #endregion [ITreeNode]

        #region [EVENTS]
        private void RaportEvolutieVanzariControl_Load(object sender, EventArgs e)
        {
            chartVanzari.Series.Clear();
            produsBindingSource.DataSource = Produs.GetAll();
            intervalCmb.DataSource = Enum.GetValues(typeof(IntervalType));
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (produseCmb.SelectedItem == null) return;
            if (endDtp.Value.Date < startDtp.Value.Date)
            {
                MessageBox.Show("Data sfarsit nu poate fi mai mica decat data de inceput!");
                return;
            }
            var produs = (Produs)produseCmb.SelectedItem;
            var interval = (IntervalType)intervalCmb.SelectedItem;
            MakeChartWithProdus(produs, startDtp.Value.Date, endDtp.Value.Date,interval);
        }
        #endregion [EVENTS]

        private void MakeChartWithProdus(Produs produs, DateTime beginDate, DateTime endDate, IntervalType interval = IntervalType.Zilnic)
        {
            string comparer = "";
            switch (interval)
            {
                case IntervalType.Zilnic:
                    comparer = "dd/MM/yyyy";
                    break;
                case IntervalType.Lunar:
                    comparer = "MM/yyyy";
                    break;
            }
            chartVanzari.Series.Clear();
            var vanzariPeProdus = new List<VanzareProdus>();
            while (beginDate.Date <= endDate.Date)
            {
                var result = from poz in PozitieFacturaIesire.GetAll()
                             where poz.FacturaIesireObject.Data.ToString(comparer) == beginDate.Date.ToString(comparer) && poz.StocObject.IdProdus == produs.ID
                             group poz by poz.FacturaIesireObject.Data.ToString(comparer) into poz_nou
                             select new VanzareProdus
                             {
                                 Cantitate = poz_nou.Sum(p => p.Cantitate).ToString("0.00"),
                                 DataVanzarii = beginDate.Date.ToString(comparer)
                             };
                VanzareProdus vanzare = null;
                vanzare = result.FirstOrDefault() == null ? new VanzareProdus { Cantitate = "0", DataVanzarii = beginDate.Date.ToString(comparer) } : result.FirstOrDefault();
                vanzariPeProdus.Add(vanzare);
                switch (interval)
                {
                    case IntervalType.Zilnic:
                        beginDate = beginDate.AddDays(1);
                        break;
                    case IntervalType.Lunar:
                        beginDate = beginDate.AddMonths(1);
                        break;
                }
            }
            var series = new Series(produs.Nume);
            series.XValueMember = "DataVanzarii";
            series.XValueType = ChartValueType.Date;
            series.YValueMembers = "Cantitate";
            series.YValueType = ChartValueType.String;
            chartVanzari.DataSource = vanzariPeProdus.ToList();
            chartVanzari.Series.Add(series);
        }

        enum IntervalType
        {
            Zilnic,
            Lunar
        }

        private class VanzareProdus
        {
            public string DataVanzarii { get; set; }
            public string Cantitate { get; set; }
        }
    }
}
