namespace GestiuneApplication.Firme
{
    partial class FirmeListControl
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
            this.firmeGrid = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmeGrid)).BeginInit();
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
            this.titleLbl.TabIndex = 6;
            this.titleLbl.Text = "Firme";
            // 
            // firmeGrid
            // 
            this.firmeGrid.AllowUserToAddRows = false;
            this.firmeGrid.AllowUserToDeleteRows = false;
            this.firmeGrid.AllowUserToOrderColumns = true;
            this.firmeGrid.AllowUserToResizeRows = false;
            this.firmeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.firmeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmeGrid.Location = new System.Drawing.Point(0, 59);
            this.firmeGrid.Name = "firmeGrid";
            this.firmeGrid.ReadOnly = true;
            this.firmeGrid.Size = new System.Drawing.Size(510, 357);
            this.firmeGrid.TabIndex = 3;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Image = global::GestiuneApplication.Properties.Resources.Edit_32;
            this.modifyBtn.Location = new System.Drawing.Point(59, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(50, 50);
            this.modifyBtn.TabIndex = 5;
            this.modifyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.modifyBtn, "Modifica firma");
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(50, 50);
            this.addBtn.TabIndex = 4;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.addBtn, "Adauga firma");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // FirmeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.firmeGrid);
            this.Name = "FirmeListControl";
            this.Size = new System.Drawing.Size(510, 416);
            this.Load += new System.EventHandler(this.FirmeListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView firmeGrid;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
