namespace GestiuneApplication.Stoc
{
    partial class StocListControl
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
            this.stocGrid = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stocGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(59, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(93, 42);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Stoc";
            // 
            // stocGrid
            // 
            this.stocGrid.AllowUserToAddRows = false;
            this.stocGrid.AllowUserToDeleteRows = false;
            this.stocGrid.AllowUserToOrderColumns = true;
            this.stocGrid.AllowUserToResizeRows = false;
            this.stocGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stocGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocGrid.Location = new System.Drawing.Point(0, 59);
            this.stocGrid.Name = "stocGrid";
            this.stocGrid.ReadOnly = true;
            this.stocGrid.Size = new System.Drawing.Size(594, 387);
            this.stocGrid.TabIndex = 3;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::GestiuneApplication.Properties.Resources.Refresh_32;
            this.refreshBtn.Location = new System.Drawing.Point(3, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // StocListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.stocGrid);
            this.Name = "StocListControl";
            this.Size = new System.Drawing.Size(594, 446);
            this.Load += new System.EventHandler(this.StocListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.DataGridView stocGrid;
        private System.Windows.Forms.Button refreshBtn;

    }
}
