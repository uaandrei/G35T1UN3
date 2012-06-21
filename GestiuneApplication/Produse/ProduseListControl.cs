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

namespace GestiuneApplication.Produse
{
    public partial class ProduseListControl : UserControl, ITreeNode
    {
        public ProduseListControl()
        {
            InitializeComponent();
        }

        #region [ITreeNode]
        public string NodeName
        {
            get
            {
                return ConstantsAndEnums.Constants.ProduseNode;
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
                return "Lista produse";
            }
        }
        #endregion [ITreeNode]

        #region [EVENTS]
        private void ProduseListControl_Load(object sender, EventArgs e)
        {
            RefreshProduseList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((new AddEditProdusForm()).ShowDialog() == DialogResult.OK)
            {
                filterTbox.Text = string.Empty;
                RefreshProduseList();
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (produseGrid.SelectedCells.Count == 0) return;
            var form = new AddEditProdusForm();
            form.ProdusObject = (Produs)produseGrid.Rows[produseGrid.SelectedCells[0].RowIndex].DataBoundItem;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshProduseList();
            }
        }
        #endregion [EVENTS]

        #region [METHODS]
        private void RefreshProduseList(string filter = "")
        {
            produsBindingSource.DataSource = null;
            produsBindingSource.DataSource = Produs.GetAll().Where(p => p.Contains(filter));
        }
        #endregion [METHODS]

        #region [SEARCH]
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            filterTbox.Text = string.Empty;
            RefreshProduseList();
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
            RefreshProduseList(filterTbox.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchItems();
        }
        #endregion [SEARCH]

    }
}
