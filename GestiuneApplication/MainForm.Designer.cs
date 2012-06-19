namespace GestiuneApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Firme");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Produse", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Facturi Intrare", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Facturi Iesire", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Stoc", 3, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Rapoarte", 4, 4);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Administrare", -2, -2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabControlContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inchideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameTssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.roleTssl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tabControlContextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 27);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.treeView);
            this.mainSplitContainer.Panel1MinSize = 100;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainSplitContainer.Panel2.Controls.Add(this.tabControl);
            this.mainSplitContainer.Panel2MinSize = 100;
            this.mainSplitContainer.Size = new System.Drawing.Size(869, 424);
            this.mainSplitContainer.SplitterDistance = 212;
            this.mainSplitContainer.SplitterWidth = 10;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageListIcons;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "firmeNode";
            treeNode1.Tag = "Firme";
            treeNode1.Text = "Firme";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "produseNode";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Tag = "Produse";
            treeNode2.Text = "Produse";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "FacturiIntrareNode";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Tag = "FacturiIntrare";
            treeNode3.Text = "Facturi Intrare";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "FacturiIesireNode";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Tag = "FacturiIesire";
            treeNode4.Text = "Facturi Iesire";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "stocNode";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Tag = "Stoc";
            treeNode5.Text = "Stoc";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "rapoarteNode";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Tag = "Rapoarte";
            treeNode6.Text = "Rapoarte";
            treeNode7.ImageIndex = -2;
            treeNode7.Name = "administrareNode";
            treeNode7.SelectedImageIndex = -2;
            treeNode7.Tag = "Administrare";
            treeNode7.Text = "Administrare";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(212, 424);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "Boss-32x32.png");
            this.imageListIcons.Images.SetKeyName(1, "apple-32x32.png");
            this.imageListIcons.Images.SetKeyName(2, "Invoice-32.png");
            this.imageListIcons.Images.SetKeyName(3, "Crate-32.png");
            this.imageListIcons.Images.SetKeyName(4, "Report-32.png");
            // 
            // tabControl
            // 
            this.tabControl.ContextMenuStrip = this.tabControlContextMenuStrip;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(647, 424);
            this.tabControl.TabIndex = 0;
            // 
            // tabControlContextMenuStrip
            // 
            this.tabControlContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchideToolStripMenuItem,
            this.inchiToolStripMenuItem,
            this.deToolStripMenuItem});
            this.tabControlContextMenuStrip.Name = "tabControlContextMenuStrip";
            this.tabControlContextMenuStrip.Size = new System.Drawing.Size(269, 92);
            // 
            // inchideToolStripMenuItem
            // 
            this.inchideToolStripMenuItem.Name = "inchideToolStripMenuItem";
            this.inchideToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.inchideToolStripMenuItem.Text = "Inchide tab curent";
            this.inchideToolStripMenuItem.Click += new System.EventHandler(this.inchideToolStripMenuItem_Click);
            // 
            // inchiToolStripMenuItem
            // 
            this.inchiToolStripMenuItem.Name = "inchiToolStripMenuItem";
            this.inchiToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.inchiToolStripMenuItem.Text = "Inchide toate in afara de tabul curent";
            this.inchiToolStripMenuItem.Click += new System.EventHandler(this.inchiToolStripMenuItem_Click);
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.deToolStripMenuItem.Text = "Inchide toate taburile";
            this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameTssl,
            this.toolStripStatusLabel1,
            this.roleTssl});
            this.statusStrip.Location = new System.Drawing.Point(0, 454);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(869, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(869, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Image = global::GestiuneApplication.Properties.Resources.exit_32;
            this.iesireToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::GestiuneApplication.Properties.Resources.Logout_32;
            this.logoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // usernameTssl
            // 
            this.usernameTssl.Name = "usernameTssl";
            this.usernameTssl.Size = new System.Drawing.Size(118, 17);
            this.usernameTssl.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // roleTssl
            // 
            this.roleTssl.Name = "roleTssl";
            this.roleTssl.Size = new System.Drawing.Size(118, 17);
            this.roleTssl.Text = "toolStripStatusLabel2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 476);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainSplitContainer);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tabControlContextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.ContextMenuStrip tabControlContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem inchideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel usernameTssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel roleTssl;
    }
}

