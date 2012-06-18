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
        #endregion [MEMBERS]

        #region [EVENTS]
        private void loginWindow_OnLoginClick(string username, string password)
        {
            if (VerifyLogin(username, password))
            {
                loginWindow.DialogResult = true;
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
                ITreeNode node = (ITreeNode)e.Node.Tag;
                ShowTab(node);
            }
            catch (Exception)
            {
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
        #endregion [EVENTS]

        #region [METHODS]
        private bool VerifyLogin(string username, string password)
        {
            // TODO: setare user curent si metoda pt aflare drept ;
            // TODO: verificare login
            return username == password;
        }

        private void ShowTab(ITreeNode node)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab.Text == node.Description)
                {
                    tabControl.SelectedTab = tab;
                    return;
                }
            }
            var tabPage = new TabPage(node.Description);
            tabPage.Controls.Add(node.Control);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;
        }

        private void InitializeTreeView()
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(ITreeNode))
                            select Activator.CreateInstance(t) as ITreeNode;
            foreach (var item in instances)
            {
                // verifica daca este nod parinte sau nod copil
                if (item.NodeName != string.Empty) // => este nod parinte
                {
                    treeView.Nodes[item.NodeName].Tag = item;
                }
                else
                {
                    if (item.ParentName == string.Empty) throw new Exception("Daca nu este nod parinte atunci trebuie sa aibe un nod parinte!");
                    var node = new TreeNode();
                    node.Tag = item;
                    node.Text = item.Description;
                    node.ImageIndex = treeView.Nodes[item.ParentName].ImageIndex;
                    node.SelectedImageIndex = treeView.Nodes[item.ParentName].SelectedImageIndex;
                    treeView.Nodes[item.ParentName].Nodes.Add(node);
                }
            }
        }

        private void InitializeLoginWindow()
        {
            this.Hide();
            loginWindow = new LoginWindow();
            loginWindow.OnLoginClick += new ChangedEventHandler(loginWindow_OnLoginClick);
            var dialogResult = loginWindow.ShowDialog();
            if (dialogResult.Value == false) Application.Exit();
            // TODO: loadData just once, flag!
            this.Show();
        }
        #endregion [METHODS]

        #region [CTOR]
        public MainForm()
        {
            InitializeComponent();
            this.InitializeTreeView();
        }
        #endregion [CTOR]
    }
}
