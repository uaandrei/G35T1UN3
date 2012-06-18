using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;

namespace GestiuneApplication.Rapoarte
{
    public partial class RaportEvolutieVanzariControl : UserControl, ITreeNode
    {
        public RaportEvolutieVanzariControl()
        {
            InitializeComponent();
        }

        public string ParentName
        {
            get
            {
                return ConstantsAndEnums.Constants.RapoarteNode;
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
                return "Raport evolutie vanzari";
            }
        }

        public string NodeName
        {
            get { return string.Empty; }
        }
    }
}
