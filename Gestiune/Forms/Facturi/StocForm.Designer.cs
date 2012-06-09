namespace Gestiune.Forms.Facturi
{
    partial class StocForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.facturiGrid = new System.Windows.Forms.DataGridView();
            this.ColumnCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(341, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Inapoi";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(260, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Salveaza";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // facturiGrid
            // 
            this.facturiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.facturiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheckBox});
            this.facturiGrid.Location = new System.Drawing.Point(12, 65);
            this.facturiGrid.Name = "facturiGrid";
            this.facturiGrid.Size = new System.Drawing.Size(404, 155);
            this.facturiGrid.TabIndex = 36;
            // 
            // ColumnCheckBox
            // 
            this.ColumnCheckBox.HeaderText = "";
            this.ColumnCheckBox.Name = "ColumnCheckBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Alegeti factura";
            // 
            // StocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 256);
            this.Controls.Add(this.facturiGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StocForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StocForm";
            this.Load += new System.EventHandler(this.StocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView facturiGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheckBox;
    }
}