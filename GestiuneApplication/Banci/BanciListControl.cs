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

        private void RefreshBanciList()
        {
            bancaBindingSource.DataSource = null;
            bancaBindingSource.DataSource = Banca.GetAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditBancaForm().ShowDialog() == DialogResult.OK) RefreshBanciList();
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
    }
}
