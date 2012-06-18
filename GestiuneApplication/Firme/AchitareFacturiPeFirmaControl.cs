using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;

namespace GestiuneApplication.Firme
{
    public partial class AchitareFacturiPeFirmaControl : UserControl, ITreeNode
    {
        #region [CTOR]
        public AchitareFacturiPeFirmaControl()
        {
            InitializeComponent();
        }
        #endregion

        #region [ITreeNodeComponent]
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
                return "Achitare facturi";
            }
        }
        #endregion
    }
}
