﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;
using GestiuneApplication.Rapoarte;
using GestiuneBusiness.Poco;

namespace GestiuneApplication.FacturiIesire
{
    public partial class FacturiIesireListControl : UserControl, ITreeNode
    {
        public FacturiIesireListControl()
        {
            InitializeComponent();
        }

        #region [ITreeNode]
        public string NodeName
        {
            get
            {
                return ConstantsAndEnums.Constants.FacturiIesireNode;
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
                return "Lista facturi iesire";
            }
        }
        #endregion [ITreeNode]

        private void FacturiIesireListControl_Load(object sender, EventArgs e)
        {
            RefreshFacturiList();
        }

        private void RefreshFacturiList(string filter = "")
        {
            facturiGrid.Rows.Clear();
            int index = 0;
            foreach (var item in FacturaIesire.GetAll().Where(p => p.Contains(filter)))
            {
                facturiGrid.Rows.Add(item.Serie, item.Numar, item.Data.ToString("dd/MM/yyyy"), item.FirmaObject.Nume);
                facturiGrid.Rows[index++].Tag = item;
            }
        }

        private void facturiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == facturiGrid.Columns["btnColumn"].Index)
            {
                var factura = (FacturaIesire)facturiGrid.Rows[e.RowIndex].Tag;
                new ReportViewerForm
                {
                    FacturaIesire = factura,
                    PozitiiFacturaIesire = PozitieFacturaIesire.GetAll().Where(p=>p.IdFacturaIesire==factura.ID).ToList()
                }.Show();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (new AddEditFacturaIesireForm().ShowDialog() == DialogResult.OK)
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
