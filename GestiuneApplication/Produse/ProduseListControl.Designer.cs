namespace GestiuneApplication.Produse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produseGrid = new System.Windows.Forms.DataGridView();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleLbl = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocMinimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rataTvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.rataTvaDataGridViewTextBoxColumn,
            this.umDataGridViewTextBoxColumn});
            this.produseGrid.DataSource = this.produsBindingSource;
            this.produseGrid.Location = new System.Drawing.Point(0, 59);
            this.produseGrid.Name = "produseGrid";
            this.produseGrid.ReadOnly = true;
            this.produseGrid.Size = new System.Drawing.Size(544, 281);
            this.produseGrid.TabIndex = 0;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Produs);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(115, 11);
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.stocMinimDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.stocMinimDataGridViewTextBoxColumn.HeaderText = "Stoc Minim";
            this.stocMinimDataGridViewTextBoxColumn.Name = "stocMinimDataGridViewTextBoxColumn";
            this.stocMinimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.pretDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rataTvaDataGridViewTextBoxColumn
            // 
            this.rataTvaDataGridViewTextBoxColumn.DataPropertyName = "RataTva";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.rataTvaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.rataTvaDataGridViewTextBoxColumn.HeaderText = "Rata Tva";
            this.rataTvaDataGridViewTextBoxColumn.Name = "rataTvaDataGridViewTextBoxColumn";
            this.rataTvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // umDataGridViewTextBoxColumn
            // 
            this.umDataGridViewTextBoxColumn.DataPropertyName = "Um";
            this.umDataGridViewTextBoxColumn.HeaderText = "UM";
            this.umDataGridViewTextBoxColumn.Name = "umDataGridViewTextBoxColumn";
            this.umDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProduseListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rataTvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umDataGridViewTextBoxColumn;
    }
}
