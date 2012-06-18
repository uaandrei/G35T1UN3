using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneApplication.Interfaces;

namespace GestiuneApplication.Administrare
{
    public partial class UserListControl : UserControl, ITreeNode
    {
        public UserListControl()
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
            get { return "Utilizatori"; }
        }
        #endregion [ITreeNode]
    }
}
