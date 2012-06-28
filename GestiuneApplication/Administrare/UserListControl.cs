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
    public partial class UserListControl : UserControl, ITreeNode
    {
        public UserListControl()
        {
            InitializeComponent();
            foreach (var item in (new Utilizator()).PropertiesNamesWithValues)
            {
                utilizatoriGrid.Columns.Add(item.Name, item.FriendlyName);
            }
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
            get { return "Utilizatori"; }
        }
        #endregion [ITreeNode]

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditUtilizatorForm().ShowDialog() == DialogResult.OK) RefreshUtilizatorList();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (utilizatoriGrid.SelectedCells.Count == 0) return;
            var utilizator = (Utilizator)utilizatoriGrid.Rows[utilizatoriGrid.SelectedCells[0].RowIndex].Tag;
            var form = new AddEditUtilizatorForm();
            form.UtilizatorObject = utilizator;
            form.ShowDialog();
            RefreshUtilizatorList();
        }

        private void UserListControl_Load(object sender, EventArgs e)
        {
            RefreshUtilizatorList();
        }

        private void RefreshUtilizatorList()
        {
            utilizatoriGrid.Rows.Clear();
            int index = 0;
            foreach (var item in Utilizator.GetAll())
            {
                utilizatoriGrid.Rows.Add(item.Nume, "*******", item.Activ, item.RolObject.Nume);
                utilizatoriGrid.Rows[index++].Tag = item;
            }
        }
    }
}
