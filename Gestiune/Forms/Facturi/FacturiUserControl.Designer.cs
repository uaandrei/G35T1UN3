namespace Gestiune.Forms.Facturi
{
    partial class FacturiUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.produseBtn = new System.Windows.Forms.Button();
            this.stocBtn = new System.Windows.Forms.Button();
            this.facturiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(3, 73);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(10, 13);
            this.titleLbl.TabIndex = 9;
            this.titleLbl.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meniu:";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(480, 204);
            this.dataGridView.TabIndex = 8;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modifyBtn.Location = new System.Drawing.Point(81, 299);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(30, 30);
            this.modifyBtn.TabIndex = 7;
            this.modifyBtn.Text = "/";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.ModifyBtnClick);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(45, 299);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(30, 30);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // produseBtn
            // 
            this.produseBtn.Location = new System.Drawing.Point(165, 3);
            this.produseBtn.Name = "produseBtn";
            this.produseBtn.Size = new System.Drawing.Size(75, 45);
            this.produseBtn.TabIndex = 4;
            this.produseBtn.Text = "Produse";
            this.produseBtn.UseVisualStyleBackColor = true;
            this.produseBtn.Click += new System.EventHandler(this.ProduseBtnClick);
            // 
            // stocBtn
            // 
            this.stocBtn.Location = new System.Drawing.Point(84, 3);
            this.stocBtn.Name = "stocBtn";
            this.stocBtn.Size = new System.Drawing.Size(75, 45);
            this.stocBtn.TabIndex = 5;
            this.stocBtn.Text = "Stoc";
            this.stocBtn.UseVisualStyleBackColor = true;
            this.stocBtn.Click += new System.EventHandler(this.StocBtnClick);
            // 
            // facturiBtn
            // 
            this.facturiBtn.Location = new System.Drawing.Point(3, 3);
            this.facturiBtn.Name = "facturiBtn";
            this.facturiBtn.Size = new System.Drawing.Size(75, 45);
            this.facturiBtn.TabIndex = 6;
            this.facturiBtn.Text = "Facturi de intrare";
            this.facturiBtn.UseVisualStyleBackColor = true;
            this.facturiBtn.Click += new System.EventHandler(this.FacturiBtnClick);
            // 
            // FacturiUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.produseBtn);
            this.Controls.Add(this.stocBtn);
            this.Controls.Add(this.facturiBtn);
            this.Name = "FacturiUserControl";
            this.Size = new System.Drawing.Size(480, 332);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button produseBtn;
        private System.Windows.Forms.Button stocBtn;
        private System.Windows.Forms.Button facturiBtn;
    }
}
