﻿namespace GestiuneApplication.Produse
{
    partial class ProduseListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.produseGrid = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocMinimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleLbl = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.filterTbox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produseGrid
            // 
            this.produseGrid.AllowUserToAddRows = false;
            this.produseGrid.AllowUserToDeleteRows = false;
            this.produseGrid.AllowUserToOrderColumns = true;
            this.produseGrid.AllowUserToResizeRows = false;
            this.produseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.produseGrid.AutoGenerateColumns = false;
            this.produseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.stocMinimDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.umDataGridViewTextBoxColumn});
            this.produseGrid.DataSource = this.produsBindingSource;
            this.produseGrid.Location = new System.Drawing.Point(0, 85);
            this.produseGrid.MultiSelect = false;
            this.produseGrid.Name = "produseGrid";
            this.produseGrid.ReadOnly = true;
            this.produseGrid.Size = new System.Drawing.Size(544, 255);
            this.produseGrid.TabIndex = 0;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocMinimDataGridViewTextBoxColumn
            // 
            this.stocMinimDataGridViewTextBoxColumn.DataPropertyName = "StocMinim";
            this.stocMinimDataGridViewTextBoxColumn.HeaderText = "StocMinim";
            this.stocMinimDataGridViewTextBoxColumn.Name = "stocMinimDataGridViewTextBoxColumn";
            this.stocMinimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // umDataGridViewTextBoxColumn
            // 
            this.umDataGridViewTextBoxColumn.DataPropertyName = "Um";
            this.umDataGridViewTextBoxColumn.HeaderText = "Um";
            this.umDataGridViewTextBoxColumn.Name = "umDataGridViewTextBoxColumn";
            this.umDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Produs);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(171, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(158, 42);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Produse";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Image = global::GestiuneApplication.Properties.Resources.Edit_32;
            this.modifyBtn.Location = new System.Drawing.Point(59, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(50, 50);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.modifyBtn, "Modifica produs");
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 1;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.addBtn, "Adauga produs");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::GestiuneApplication.Properties.Resources.Refresh_32;
            this.refreshBtn.Location = new System.Drawing.Point(115, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 24;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // filterTbox
            // 
            this.filterTbox.Location = new System.Drawing.Point(3, 59);
            this.filterTbox.Name = "filterTbox";
            this.filterTbox.Size = new System.Drawing.Size(106, 20);
            this.filterTbox.TabIndex = 28;
            this.filterTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterTbox_KeyPress);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(115, 59);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 20);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.Text = "Cauta";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // ProduseListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterTbox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.produseGrid);
            this.Name = "ProduseListControl";
            this.Size = new System.Drawing.Size(544, 340);
            this.Load += new System.EventHandler(this.ProduseListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView produseGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocMinimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox filterTbox;
        private System.Windows.Forms.Button searchBtn;
    }
}
