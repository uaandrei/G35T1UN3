namespace GestiuneApplication
{
    partial class SelectItemForm
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
            this.gestiuneObjGrid = new System.Windows.Forms.DataGridView();
            this.gestiuneObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchBtn = new System.Windows.Forms.Button();
            this.filterTbox = new System.Windows.Forms.TextBox();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.numeCompactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneObjGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneObjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestiuneObjGrid
            // 
            this.gestiuneObjGrid.AllowUserToAddRows = false;
            this.gestiuneObjGrid.AllowUserToDeleteRows = false;
            this.gestiuneObjGrid.AllowUserToResizeRows = false;
            this.gestiuneObjGrid.AutoGenerateColumns = false;
            this.gestiuneObjGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gestiuneObjGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeCompactDataGridViewTextBoxColumn});
            this.gestiuneObjGrid.DataSource = this.gestiuneObjectBindingSource;
            this.gestiuneObjGrid.Location = new System.Drawing.Point(12, 38);
            this.gestiuneObjGrid.Name = "gestiuneObjGrid";
            this.gestiuneObjGrid.Size = new System.Drawing.Size(218, 179);
            this.gestiuneObjGrid.TabIndex = 0;
            this.gestiuneObjGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gestiuneObjGrid_CellDoubleClick);
            // 
            // gestiuneObjectBindingSource
            // 
            this.gestiuneObjectBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Kernel.GestiuneObject);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(155, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 20);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Cauta";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // filterTbox
            // 
            this.filterTbox.Location = new System.Drawing.Point(12, 12);
            this.filterTbox.Name = "filterTbox";
            this.filterTbox.Size = new System.Drawing.Size(137, 20);
            this.filterTbox.TabIndex = 2;
            // 
            // chooseBtn
            // 
            this.chooseBtn.Location = new System.Drawing.Point(147, 223);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(83, 25);
            this.chooseBtn.TabIndex = 1;
            this.chooseBtn.Text = "Alegeti";
            this.chooseBtn.UseVisualStyleBackColor = true;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Location = new System.Drawing.Point(58, 223);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(83, 25);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Inapoi";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // numeCompactDataGridViewTextBoxColumn
            // 
            this.numeCompactDataGridViewTextBoxColumn.DataPropertyName = "NumeCompact";
            this.numeCompactDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeCompactDataGridViewTextBoxColumn.Name = "numeCompactDataGridViewTextBoxColumn";
            this.numeCompactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SelectItemForm
            // 
            this.AcceptButton = this.chooseBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(242, 260);
            this.Controls.Add(this.filterTbox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.gestiuneObjGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectItemForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectItemForm";
            this.Load += new System.EventHandler(this.SelectItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneObjGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneObjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox filterTbox;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView gestiuneObjGrid;
        private System.Windows.Forms.BindingSource gestiuneObjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeCompactDataGridViewTextBoxColumn;
    }
}