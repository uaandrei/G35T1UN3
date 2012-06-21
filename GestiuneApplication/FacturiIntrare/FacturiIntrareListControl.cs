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

namespace GestiuneApplication.FacturiIntrare
{
    public partial class FacturiIntrareListControl : UserControl, ITreeNode
    {
        public FacturiIntrareListControl()
        {
            InitializeComponent();
        }

        #region [ITreeNode]
        public string NodeName
        {
            get { return ConstantsAndEnums.Constants.FacturiIntrareNode; }
        }

        public string ParentName
        {
            get { return string.Empty; }
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
            get { return "Lista facturi intrare"; }
        }
        #endregion [ITreeNode]

        private void FacturiIntrareListControl_Load(object sender, EventArgs e)
        {
            RefreshFacturiList();
        }

        private void RefreshFacturiList(string filter = "")
        {
            facturiGrid.Rows.Clear();
            int index = 0;
            foreach (var item in FacturaIntrare.GetAll().Where(p => p.Contains(filter)))
            {
                facturiGrid.Rows.Add(item.Serie, item.Numar, item.Data.ToString("dd/MM/yyyy"), item.FirmaObject.Nume);
                facturiGrid.Rows[index++].Tag = item;
            }
        }

        private void facturiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == facturiGrid.Columns["btnColumn"].Index)
            {
                var factura = (FacturaIntrare)facturiGrid.Rows[e.RowIndex].Tag;
                MessageBox.Show(factura.Serie);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditFacturaIntrareForm().ShowDialog() == DialogResult.OK)
            {
                filterTbox.Text = string.Empty;
                RefreshFacturiList();
            }
        }

        #region [SEARCH]
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            filterTbox.Text = string.Empty;
            RefreshFacturiList();
        }

        private void filterTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchItems();
            }
        }

        private void SearchItems()
        {
            RefreshFacturiList(filterTbox.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchItems();
        }
        #endregion [SEARCH]
    }
}
