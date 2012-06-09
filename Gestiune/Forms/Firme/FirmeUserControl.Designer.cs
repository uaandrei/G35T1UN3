namespace Gestiune.Forms.Firme
{
    partial class FirmeUserControl
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
            this.firmeBtn = new System.Windows.Forms.Button();
            this.delegatiBtn = new System.Windows.Forms.Button();
            this.banciBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.modifyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firmeBtn
            // 
            this.firmeBtn.Location = new System.Drawing.Point(3, 3);
            this.firmeBtn.Name = "firmeBtn";
            this.firmeBtn.Size = new System.Drawing.Size(75, 45);
            this.firmeBtn.TabIndex = 0;
            this.firmeBtn.Text = "Firme";
            this.firmeBtn.UseVisualStyleBackColor = true;
            this.firmeBtn.Click += new System.EventHandler(this.FirmeBtnClick);
            // 
            // delegatiBtn
            // 
            this.delegatiBtn.Location = new System.Drawing.Point(84, 3);
            this.delegatiBtn.Name = "delegatiBtn";
            this.delegatiBtn.Size = new System.Drawing.Size(75, 45);
            this.delegatiBtn.TabIndex = 0;
            this.delegatiBtn.Text = "Delegati";
            this.delegatiBtn.UseVisualStyleBackColor = true;
            this.delegatiBtn.Click += new System.EventHandler(this.DelegatiBtnClick);
            // 
            // banciBtn
            // 
            this.banciBtn.Location = new System.Drawing.Point(165, 3);
            this.banciBtn.Name = "banciBtn";
            this.banciBtn.Size = new System.Drawing.Size(75, 45);
            this.banciBtn.TabIndex = 0;
            this.banciBtn.Text = "Banci";
            this.banciBtn.UseVisualStyleBackColor = true;
            this.banciBtn.Click += new System.EventHandler(this.BanciBtnClick);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 87);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(444, 136);
            this.dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meniu:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(48, 229);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(30, 30);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(3, 71);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(10, 13);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "-";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modifyBtn.Location = new System.Drawing.Point(84, 229);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(30, 30);
            this.modifyBtn.TabIndex = 0;
            this.modifyBtn.Text = "/";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.ModifyBtnClick);
            // 
            // FirmeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.banciBtn);
            this.Controls.Add(this.delegatiBtn);
            this.Controls.Add(this.firmeBtn);
            this.Name = "FirmeUserControl";
            this.Size = new System.Drawing.Size(444, 262);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firmeBtn;
        private System.Windows.Forms.Button delegatiBtn;
        private System.Windows.Forms.Button banciBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button modifyBtn;
    }
}
