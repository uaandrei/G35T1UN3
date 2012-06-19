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

namespace GestiuneApplication.StocF
{
    public partial class StocListControl : UserControl, ITreeNode
    {
        public StocListControl()
        {
            InitializeComponent();
            stocGrid.Columns.Add("c1", "Produs");
            stocGrid.Columns.Add("c2", "Cantitate");
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
            foreach (var item in GestiuneBusiness.Poco.Stoc.GetAllGroupedByProdus())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = item;
                row.CreateCells(stocGrid, item.ProdusObject.Nume, item.Cantitate.ToString("0.00"));
                stocGrid.Rows.Add(row);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshStocList();
        }

        private void stocGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 1) return;
            if (e.Value != null)
            {
                var stocGrupat = (Stoc)stocGrid.Rows[e.RowIndex].Tag;
                if (stocGrupat.ProdusObject.StocMinim > stocGrupat.Cantitate)
                {
                    if (stocGrupat.Cantitate == 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.SelectionBackColor = Color.DarkRed;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.SelectionBackColor = Color.DarkOrange;
                    }

                }
            }
        }
    }
}
