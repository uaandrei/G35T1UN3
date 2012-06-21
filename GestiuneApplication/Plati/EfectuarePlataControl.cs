using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;

namespace GestiuneApplication.Plati
{
    public partial class EfectuarePlataControl : UserControl, ITreeNode
    {
        public EfectuarePlataControl()
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
                return ConstantsAndEnums.Constants.PlatiNode;
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
                return "Efectuare plati";
            }
        }
        #endregion [ITreeNode]

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (plataFirmRadioBtn.Checked)
            {
                new PlatiPeFirmaForm().ShowDialog();
            }
            else
            {
                new PlatileMeleForm().ShowDialog();
            }
        }

    }
}
