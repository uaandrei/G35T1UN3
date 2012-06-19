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

namespace GestiuneApplication.Delegati
{
    public partial class DelegatiListControl : UserControl, ITreeNode
    {
        public DelegatiListControl()
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
                return "Lista delegati";
            }
        }
        #endregion [ITreeNode]

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditDelegatForm().ShowDialog() == DialogResult.OK) RefreshDelegatList();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (delegatiGrid.SelectedCells.Count == 0) return;
            var delegat = (Delegat)delegatiGrid.Rows[delegatiGrid.SelectedCells[0].RowIndex].DataBoundItem;
            var form = new AddEditDelegatForm();
            form.DelegatObject = delegat;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshDelegatList();
            }
        }

        private void DelegatiListControl_Load(object sender, EventArgs e)
        {
            RefreshDelegatList();
        }

        private void RefreshDelegatList()
        {
            this.delegatBindingSource.DataSource = null;
            this.delegatBindingSource.DataSource = Delegat.GetAll();
        }

    }
}
