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
using GestiuneBusiness.Poco.Administration;

namespace GestiuneApplication.Administrare
{
    public partial class SetariControl : UserControl, ITreeNode
    {
        private bool returnFromComboFlag = false;
        public SetariControl()
        {
            InitializeComponent();
        }

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
            get { return "Setari"; }
        }

        private void MyInfoControl_Load(object sender, EventArgs e)
        {
            returnFromComboFlag = true;
            firmeCmb.DataSource = Firma.GetAll();
            firmeCmb.SelectedItem = Setare.GetSetare().MyFirma;
            returnFromComboFlag = false;
        }

        private void adminPwdBtn_Click(object sender, EventArgs e)
        {
            new SchimbaParolaAdminForm().ShowDialog();
        }

        private void firmeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (returnFromComboFlag) return;
            if (firmeCmb.SelectedValue == null) return;
            Setare.GetSetare().MyFirmaId = (int)firmeCmb.SelectedValue;
            var result = Setare.GetSetare().Save();
            if (result.Status != GestiuneBusiness.Enums.StatusEnum.Saved)
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
