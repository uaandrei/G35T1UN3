namespace GestiuneApplication.Banci
{
    partial class BanciListControl
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.banciGrid = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.banciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(115, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(112, 42);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "Banci";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Image = global::GestiuneApplication.Properties.Resources.Edit_32;
            this.modifyBtn.Location = new System.Drawing.Point(59, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(50, 50);
            this.modifyBtn.TabIndex = 9;
            this.modifyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.modifyBtn, "Modifica banca");
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 8;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.addBtn, "Adauga banca");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // banciGrid
            // 
            this.banciGrid.AllowUserToAddRows = false;
            this.banciGrid.AllowUserToDeleteRows = false;
            this.banciGrid.AllowUserToOrderColumns = true;
            this.banciGrid.AllowUserToResizeRows = false;
            this.banciGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.banciGrid.AutoGenerateColumns = false;
            this.banciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.banciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.cuiDataGridViewTextBoxColumn,
            this.rCDataGridViewTextBoxColumn,
            this.capitalSocialDataGridViewTextBoxColumn});
            this.banciGrid.DataSource = this.bancaBindingSource;
            this.banciGrid.Location = new System.Drawing.Point(0, 59);
            this.banciGrid.Name = "banciGrid";
            this.banciGrid.ReadOnly = true;
            this.banciGrid.Size = new System.Drawing.Size(506, 319);
            this.banciGrid.TabIndex = 7;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuiDataGridViewTextBoxColumn
            // 
            this.cuiDataGridViewTextBoxColumn.DataPropertyName = "Cui";
            this.cuiDataGridViewTextBoxColumn.HeaderText = "CUI";
            this.cuiDataGridViewTextBoxColumn.Name = "cuiDataGridViewTextBoxColumn";
            this.cuiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rCDataGridViewTextBoxColumn
            // 
            this.rCDataGridViewTextBoxColumn.DataPropertyName = "RC";
            this.rCDataGridViewTextBoxColumn.HeaderText = "RC";
            this.rCDataGridViewTextBoxColumn.Name = "rCDataGridViewTextBoxColumn";
            this.rCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capitalSocialDataGridViewTextBoxColumn
            // 
            this.capitalSocialDataGridViewTextBoxColumn.DataPropertyName = "CapitalSocial";
            this.capitalSocialDataGridViewTextBoxColumn.HeaderText = "CapitalSocial";
            this.capitalSocialDataGridViewTextBoxColumn.Name = "capitalSocialDataGridViewTextBoxColumn";
            this.capitalSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bancaBindingSource
            // 
            this.bancaBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Banca);
            // 
            // BanciListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.banciGrid);
            this.Name = "BanciListControl";
            this.Size = new System.Drawing.Size(506, 378);
            this.Load += new System.EventHandler(this.BanciListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView banciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bancaBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
