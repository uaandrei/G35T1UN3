namespace GestiuneApplication.FacturiIesire
{
    partial class FacturiIesireListControl
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.facturiGrid = new System.Windows.Forms.DataGridView();
            this.serieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facturiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(59, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(231, 42);
            this.titleLbl.TabIndex = 21;
            this.titleLbl.Text = "Facturi iesire";
            // 
            // addBtn
            // 
            this.addBtn.Image = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 20;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // facturiGrid
            // 
            this.facturiGrid.AllowUserToAddRows = false;
            this.facturiGrid.AllowUserToDeleteRows = false;
            this.facturiGrid.AllowUserToOrderColumns = true;
            this.facturiGrid.AllowUserToResizeRows = false;
            this.facturiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.facturiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieColumn,
            this.numarColumn,
            this.dataColumn,
            this.furnizorColumn,
            this.btnColumn});
            this.facturiGrid.Location = new System.Drawing.Point(0, 59);
            this.facturiGrid.Name = "facturiGrid";
            this.facturiGrid.ReadOnly = true;
            this.facturiGrid.Size = new System.Drawing.Size(474, 261);
            this.facturiGrid.TabIndex = 19;
            this.facturiGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturiGrid_CellContentClick);
            // 
            // serieColumn
            // 
            this.serieColumn.FillWeight = 112.3096F;
            this.serieColumn.HeaderText = "Serie";
            this.serieColumn.Name = "serieColumn";
            this.serieColumn.ReadOnly = true;
            // 
            // numarColumn
            // 
            this.numarColumn.FillWeight = 112.3096F;
            this.numarColumn.HeaderText = "Numar";
            this.numarColumn.Name = "numarColumn";
            this.numarColumn.ReadOnly = true;
            // 
            // dataColumn
            // 
            this.dataColumn.FillWeight = 112.3096F;
            this.dataColumn.HeaderText = "Data facturarii";
            this.dataColumn.Name = "dataColumn";
            this.dataColumn.ReadOnly = true;
            // 
            // furnizorColumn
            // 
            this.furnizorColumn.FillWeight = 112.3096F;
            this.furnizorColumn.HeaderText = "Cumparator";
            this.furnizorColumn.Name = "furnizorColumn";
            this.furnizorColumn.ReadOnly = true;
            // 
            // btnColumn
            // 
            this.btnColumn.FillWeight = 50.76142F;
            this.btnColumn.HeaderText = "-";
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.ReadOnly = true;
            this.btnColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnColumn.Text = "Raport";
            this.btnColumn.ToolTipText = "Vizualizati aceasta factura de intrare";
            this.btnColumn.UseColumnTextForButtonValue = true;
            // 
            // FacturiIesireListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.facturiGrid);
            this.Name = "FacturiIesireListControl";
            this.Size = new System.Drawing.Size(474, 320);
            this.Load += new System.EventHandler(this.FacturiIesireListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView facturiGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnColumn;
    }
}
