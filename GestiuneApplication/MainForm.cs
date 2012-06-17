using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using GestiuneApplication.Interfaces;
using WpfLibrary;

namespace GestiuneApplication
{
    public partial class MainForm : Form
    {
        #region [MEMBERS]
        private LoginWindow loginWindow;
        #endregion

        #region [EVENTS]
        private void loginWindow_OnLoginClick(string username, string password)
        {
            if (username == password) // TODO: verificare login
            {
                loginWindow.DialogResult = true;
                // TODO: setare user curent si metoda pt aflare drept
            }
            else
            {
                loginWindow.DialogResult = null;
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node.Tag == null) return;
            try
            {
                IRaportTreeNodeComponent report = (IRaportTreeNodeComponent)e.Node.Tag;
                var tabPage = new TabPage(report.Description);
                tabPage.Controls.Add(report.Control);
                tabControl.TabPages.Add(tabPage);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa inchideti aplicatia?", "Inchidere aplicatie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeLoginWindow();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeLoginWindow();
        }
        #endregion

        #region [METHODS]
        private void InitializeTreeView()
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IRaportTreeNodeComponent))
                            select Activator.CreateInstance(t) as IRaportTreeNodeComponent;
            foreach (var item in instances)
            {
                var node = new TreeNode();
                node.Tag = item;
                node.Text = item.Description;
                node.ImageIndex = treeView.Nodes["rapoarteNode"].ImageIndex;
                node.SelectedImageIndex = treeView.Nodes["rapoarteNode"].SelectedImageIndex;
                treeView.Nodes["rapoarteNode"].Nodes.Add(node);
            }
        }

        private void InitializeLoginWindow()
        {
            this.Hide();
            loginWindow = new LoginWindow();
            loginWindow.OnLoginClick += new ChangedEventHandler(loginWindow_OnLoginClick);
            var dialogResult = loginWindow.ShowDialog();
            if (dialogResult.Value == null) return;
            if (dialogResult.Value == false) Application.Exit();
            // TODO: loadData just once, flag!
            this.Show();
        }
        #endregion

        #region [CTOR]
        public MainForm()
        {
            InitializeComponent();
            this.InitializeTreeView();
        }
        #endregion
    }
}
