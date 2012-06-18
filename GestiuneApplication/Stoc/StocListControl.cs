using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;
using GestiuneBusiness.Poco;

namespace GestiuneApplication.Stoc
{
    public partial class StocListControl : UserControl, ITreeNode
    {
        public StocListControl()
        {
            InitializeComponent();
            foreach (var item in (new GestiuneBusiness.Poco.Stoc().PropertiesNamesWithValues))
            {
                stocGrid.Columns.Add(item.Name, item.FriendlyName);
            }
        }

        #region [ITreeNode]
        public string NodeName
        {
            get
            {
                return ConstantsAndEnums.Constants.StocNode;
            }
        }

        public string ParentName
        {
            get
            {
                return string.Empty;
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
                return "Stoc";
            }
        }
        #endregion [ITreeNode]

        private void StocListControl_Load(object sender, EventArgs e)
        {
            RefreshStocList();
        }

        private void RefreshStocList()
        {
            stocGrid.Rows.Clear();
            foreach (var item in GestiuneBusiness.Poco.Stoc.GetAll())
            {
                if (item.Cantitate == 0m)
                {
                    continue;
                }
                stocGrid.Rows.Add(item.ProdusObject.Nume, item.Pret.ToString("0.00"), item.Cantitate.ToString("0.00"), item.PozitieFacturaIntrareObject.FacturaIntrareObject.Serie);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshStocList();
        }
    }
}
