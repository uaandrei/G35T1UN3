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
using GestiuneBusiness.Poco.Administration;
using WpfLibrary;

namespace GestiuneApplication
{
    public partial class MainForm : Form
    {
        #region [MEMBERS]
        public static Utilizator LoggedUser { get; set; }
        private LoginWindow loginWindow;
        private bool loginWindowFlag = false;
        private bool dataLoadedFlag = false;
        #endregion [MEMBERS]

        #region [EVENTS]

        private void inchiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close all tabs but this
            if (tabControl.TabPages.Count == 0) return;
            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab.Text != tabControl.SelectedTab.Text) tabControl.TabPages.Remove(tab);
            }
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginWindowFlag)
            {
                if (MessageBox.Show("Doriti sa inchideti aplicatia?", "Inchidere aplicatie", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

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
            if (LoggedUser.Nume != "admin")
            {
                if (e.Node.Parent == null)
                {
                    if (!HasRight(e.Node)) return;
                }
                else
                {
                    if (!HasRight(e.Node.Parent)) return;
                }
            }
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
            this.Close();
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
        private bool HasRight(TreeNode node)
        {
            var rightName = node.Text;
            var rolDrept = RolDrept.GetAll().Where(p => p.DreptObject.Nume == rightName && p.IdRol == LoggedUser.IdRol).FirstOrDefault();
            if (rolDrept == null)
            {
                node.Collapse();
                MessageBox.Show("Nu aveti acest drept!");
                return false;
            }
            else
            {
                if (rolDrept.AreDrept == false)
                {
                    node.Collapse();
                    MessageBox.Show("Nu aveti dreptul asupra: " + rolDrept.DreptObject.Nume);
                    return false;
                }
            }
            return true;
        }

        private bool VerifyLogin(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                LoggedUser = new Utilizator { Nume = "admin" };
            }
            else
            {
                var utilizator = Utilizator.GetAll().Where(p => p.Nume == username && p.Parola == password).FirstOrDefault();
                if (utilizator == null)
                {
                    MessageBox.Show("Utilizator sau parola incorecta!");
                    return false;
                }
                if (utilizator.Activ == false)
                {
                    MessageBox.Show("Utilizatorul nu este activat!");
                    return false;
                }
                LoggedUser = utilizator;
            }
            roleTssl.Text = LoggedUser.RolObject == null ? "admin" : LoggedUser.RolObject.Nume;
            usernameTssl.Text = LoggedUser.Nume;
            return true;
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
            if (tabControl.TabCount > 0)
            {
                tabControl.TabPages.Clear();
            }
            treeView.CollapseAll();
            loginWindow = new LoginWindow();
            loginWindow.OnLoginClick += new ChangedEventHandler(loginWindow_OnLoginClick);
            var dialogResult = loginWindow.ShowDialog();
            if (dialogResult.Value == false)
            {
                loginWindowFlag = true;
                Application.Exit();
            }
            if (dataLoadedFlag == false)
            {
                new LoadingForm().ShowDialog();
                dataLoadedFlag = true;
            }
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
