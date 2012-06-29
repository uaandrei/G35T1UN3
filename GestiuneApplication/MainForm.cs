using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        #region [LOGIN REGION]
        // UNCOMMENT THIS TO ENABLE LOGIN FEATURE
        private LoginWindow loginWindow;

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

        private void InitializeLoginWindow()
        {
            //VerifyLogin("admin", "admin");//COMMENT THIS FOR LOGIN FEATURE
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
                closeWithoutAskingFlag = true;
                Application.Exit();
                return;
            }
            if (dataLoadedFlag == false)
            {
                new LoadingForm().ShowDialog();
                dataLoadedFlag = true;
            }
            this.Show();
        }
        #endregion [LOGIN REGION]

        #region [MEMBERS]
        public static Utilizator LoggedUser { get; set; }
        private bool closeWithoutAskingFlag = false;
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
            if (!closeWithoutAskingFlag)
            {
                if (MessageBox.Show("Doriti sa inchideti aplicatia?", "Inchidere aplicatie", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
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
        public static string Md5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder s_builder = new StringBuilder();
            foreach (byte b in data)
            {
                s_builder.Append(b.ToString("x2"));
            }// Return the hexadecimal string.      
            return s_builder.ToString();
        }

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
            password = Md5Hash(password);
            if (username.ToLower() == "admin")
            {
                if (password == Setare.GetSetare().AdminPassword)
                {
                    LoggedUser = new Utilizator { Nume = "admin" };
                }
                else
                {
                    MessageBox.Show("Parola incorecta!");
                    return false;
                }
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
            roleTssl.Text = "Rol: ";
            roleTssl.Text += LoggedUser.RolObject == null ? "admin" : LoggedUser.RolObject.Nume;
            usernameTssl.Text = "Utilizator logat: " + LoggedUser.Nume;
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
        #endregion [METHODS]

        #region [CTOR]
        public MainForm()
        {
            InitializeComponent();
            timerDbCon.Start();
            this.InitializeTreeView();
        }
        #endregion [CTOR]

        private void timerDbCon_Tick(object sender, EventArgs e)
        {
            try
            {
                new Utilizator().IsConnectionAvailable();
            }
            catch (Exception ex)
            {
                timerDbCon.Stop();
                loginWindow.Close();
                closeWithoutAskingFlag = true;
                var form = new AppCrashForm();
                form.SetDetails(ex, "Aplicatia s-a inchis din cauza lipsei de conexiune cu baza de date, doriti sa o reporniti?");
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
