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

namespace GestiuneApplication.Firme
{
    public partial class FirmeListControl : UserControl, ITreeNode
    {
        #region [CTOR]
        public FirmeListControl()
        {
            InitializeComponent();
            foreach (var item in (new Firma()).PropertiesNamesWithValues)
            {
                firmeGrid.Columns.Add(item.Name, item.FriendlyName);
            }
        }
        #endregion

        #region [ITreeNodeParentComponent]
        public string ParentName
        {
            get
            {
                return string.Empty;
            }
        }

        public string NodeName
        {
            get { return ConstantsAndEnums.Constants.FirmeNode; }
        }

        public System.Windows.Forms.UserControl Control
        {
            get
            {
                this.Dock = DockStyle.Fill;
                return this;
            }
        }

        public string Description
        {
            get { return "Lista firme"; }
        }
        #endregion

        private void FirmeListControl_Load(object sender, EventArgs e)
        {
            RefreshFirmeList();
        }

        private void RefreshFirmeList()
        {
            firmeGrid.Rows.Clear();
            int index = 0;
            foreach (var item in Firma.GetAll())
            {
                firmeGrid.Rows.Add(item.Nume, item.Cui, item.Rc, item.Iban, item.Adresa, item.Telefon, item.DataInfiintarii.ToString("dd/MM/yyyy"), item.BancaObject.Nume, item.DelegatObject.Nume);
                firmeGrid.Rows[index++].Tag = item;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((new AddEditFirmaForm()).ShowDialog() == DialogResult.OK) RefreshFirmeList();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (firmeGrid.SelectedCells.Count == 0) return;
            var firma = (Firma)firmeGrid.Rows[firmeGrid.SelectedCells[0].RowIndex].Tag;
            var form = new AddEditFirmaForm();
            form.FirmaObject = firma;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshFirmeList();
            }
        }

    }
}
