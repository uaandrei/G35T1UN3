namespace GestiuneApplication.Delegati
{
    partial class DelegatiListControl
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
            this.delegatiGrid = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delegatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.delegatiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(115, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(155, 42);
            this.titleLbl.TabIndex = 14;
            this.titleLbl.Text = "Delegati";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Image = global::GestiuneApplication.Properties.Resources.Edit_32;
            this.modifyBtn.Location = new System.Drawing.Point(59, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(50, 50);
            this.modifyBtn.TabIndex = 13;
            this.modifyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.modifyBtn, "Modifica delegat");
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 12;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.addBtn, "Adauga delegat");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delegatiGrid
            // 
            this.delegatiGrid.AllowUserToAddRows = false;
            this.delegatiGrid.AllowUserToDeleteRows = false;
            this.delegatiGrid.AllowUserToOrderColumns = true;
            this.delegatiGrid.AllowUserToResizeRows = false;
            this.delegatiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.delegatiGrid.AutoGenerateColumns = false;
            this.delegatiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.delegatiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delegatiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.cnpDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn});
            this.delegatiGrid.DataSource = this.delegatBindingSource;
            this.delegatiGrid.Location = new System.Drawing.Point(0, 59);
            this.delegatiGrid.Name = "delegatiGrid";
            this.delegatiGrid.ReadOnly = true;
            this.delegatiGrid.Size = new System.Drawing.Size(580, 301);
            this.delegatiGrid.TabIndex = 11;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "Cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "Cnp";
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            this.cnpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delegatBindingSource
            // 
            this.delegatBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Delegat);
            // 
            // DelegatiListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delegatiGrid);
            this.Name = "DelegatiListControl";
            this.Size = new System.Drawing.Size(580, 360);
            this.Load += new System.EventHandler(this.DelegatiListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delegatiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delegatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView delegatiGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource delegatBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
