using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;
using GestiuneBusiness.Poco.Administration;

namespace GestiuneApplication.Administrare
{
    public partial class RoleListControl : UserControl, ITreeNode
    {
        public RoleListControl()
        {
            InitializeComponent();
        }

        #region [ITreeNode]
        public string NodeName
        {
            get { return string.Empty; }
        }

        public string ParentName
        {
            get { return ConstantsAndEnums.Constants.AdministrareNode; }
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
            get { return "Roluri"; }
        }

        #endregion [ITreeNode]

        private void RoleListControl_Load(object sender, EventArgs e)
        {
            RefreshRolList();
        }

        private void RefreshRolList()
        {
            rolBindingSource.DataSource = null;
            rolBindingSource.DataSource = Rol.GetAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditRolForm().ShowDialog() == DialogResult.OK) RefreshRolList();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (roluriGrid.SelectedCells.Count == 0) return;
            var rol = (Rol)roluriGrid.Rows[roluriGrid.SelectedCells[0].RowIndex].DataBoundItem;
            var form = new AddEditRolForm();
            form.RolObject = rol;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshRolList();
            }
        }

        private void drepturiPeRolBtn_Click(object sender, EventArgs e)
        {
            if (roluriGrid.SelectedCells.Count == 0) return;
            var rol = (Rol)roluriGrid.Rows[roluriGrid.SelectedCells[0].RowIndex].DataBoundItem;
            if (MainForm.LoggedUser.IdRol == rol.ID)
            {
                MessageBox.Show("Nu puteti modifica un rol care este folosit!");
                return;
            }
            var form = new EditDrepturiPeRolForm();
            form.RolObject = rol;
            form.ShowDialog();
        }
    }
}
