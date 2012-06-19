namespace GestiuneApplication.Administrare
{
    partial class EditDrepturiPeRolForm
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
            this.drepturiGrid = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dreptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.iesireBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drepturiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // drepturiGrid
            // 
            this.drepturiGrid.AllowUserToAddRows = false;
            this.drepturiGrid.AllowUserToDeleteRows = false;
            this.drepturiGrid.AllowUserToOrderColumns = true;
            this.drepturiGrid.AllowUserToResizeRows = false;
            this.drepturiGrid.AutoGenerateColumns = false;
            this.drepturiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drepturiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drepturiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.check});
            this.drepturiGrid.DataSource = this.dreptBindingSource;
            this.drepturiGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.drepturiGrid.Location = new System.Drawing.Point(0, 0);
            this.drepturiGrid.Name = "drepturiGrid";
            this.drepturiGrid.Size = new System.Drawing.Size(500, 221);
            this.drepturiGrid.TabIndex = 0;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.FillWeight = 130.9645F;
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.FillWeight = 130.9645F;
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // check
            // 
            this.check.FillWeight = 38.07107F;
            this.check.HeaderText = "Are drept";
            this.check.Name = "check";
            // 
            // dreptBindingSource
            // 
            this.dreptBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Administration.Drept);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(413, 227);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Salvare";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // iesireBtn
            // 
            this.iesireBtn.Location = new System.Drawing.Point(332, 227);
            this.iesireBtn.Name = "iesireBtn";
            this.iesireBtn.Size = new System.Drawing.Size(75, 23);
            this.iesireBtn.TabIndex = 2;
            this.iesireBtn.Text = "Iesire";
            this.iesireBtn.UseVisualStyleBackColor = true;
            this.iesireBtn.Click += new System.EventHandler(this.iesireBtn_Click);
            // 
            // EditDrepturiPeRolForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 262);
            this.Controls.Add(this.iesireBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.drepturiGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDrepturiPeRolForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditDrepturiPeRolForm";
            this.Load += new System.EventHandler(this.EditDrepturiPeRolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drepturiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drepturiGrid;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button iesireBtn;
        private System.Windows.Forms.BindingSource dreptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}