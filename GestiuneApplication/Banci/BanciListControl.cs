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

namespace GestiuneApplication.Banci
{
    public partial class BanciListControl : UserControl, ITreeNode
    {
        public BanciListControl()
        {
            InitializeComponent();
        }

        #region [ITreeNode]
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
                return ConstantsAndEnums.Constants.FirmeNode;
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
                return "Lista banci";
            }
        }
        #endregion [ITreeNode]

        private void BanciListControl_Load(object sender, EventArgs e)
        {
            RefreshBanciList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditBancaForm().ShowDialog() == DialogResult.OK)
            {
                filterTbox.Text = string.Empty;
                RefreshBanciList();
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (banciGrid.SelectedCells.Count == 0) return;
            var banca = (Banca)banciGrid.Rows[banciGrid.SelectedCells[0].RowIndex].DataBoundItem;
            var form = new AddEditBancaForm();
            form.BancaObject = banca;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshBanciList();
            }
        }

        private void RefreshBanciList()
        {
            filterTbox.Text = string.Empty;
            bancaBindingSource.DataSource = null;
            bancaBindingSource.DataSource = Banca.GetAll();
        }

        #region [SEARCH]
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshBanciList();
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
            if (filterTbox.Text.Trim() == string.Empty)
            {
                RefreshBanciList();
            }
            bancaBindingSource.DataSource = null;
            bancaBindingSource.DataSource = Banca.GetAll().Where(p => p.Contains(filterTbox.Text) == true).ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchItems();
        }
        #endregion [SEARCH]
    }
}
