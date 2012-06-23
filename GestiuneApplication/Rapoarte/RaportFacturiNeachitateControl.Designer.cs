namespace GestiuneApplication.Rapoarte
{
    partial class RaportFacturiNeachitateControl
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
            this.reportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.firmaTbox = new System.Windows.Forms.TextBox();
            this.searchFirmaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(59, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(424, 42);
            this.titleLbl.TabIndex = 30;
            this.titleLbl.Text = "Raport facturi neachitate";
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Location = new System.Drawing.Point(0, 99);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowExportButton = false;
            this.reportViewer.ShowHistoryButtons = false;
            this.reportViewer.ShowPrintPreviewButton = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.Size = new System.Drawing.Size(900, 455);
            this.reportViewer.TabIndex = 31;
            this.reportViewer.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Firme";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::GestiuneApplication.Properties.Resources.Refresh_32;
            this.refreshBtn.Location = new System.Drawing.Point(3, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 29;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // firmaTbox
            // 
            this.firmaTbox.Location = new System.Drawing.Point(3, 72);
            this.firmaTbox.MaxLength = 15;
            this.firmaTbox.Name = "firmaTbox";
            this.firmaTbox.ReadOnly = true;
            this.firmaTbox.Size = new System.Drawing.Size(166, 20);
            this.firmaTbox.TabIndex = 41;
            this.firmaTbox.Text = "Alegeti o firma...";
            // 
            // searchFirmaBtn
            // 
            this.searchFirmaBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Search_32;
            this.searchFirmaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchFirmaBtn.Location = new System.Drawing.Point(175, 58);
            this.searchFirmaBtn.Name = "searchFirmaBtn";
            this.searchFirmaBtn.Size = new System.Drawing.Size(34, 34);
            this.searchFirmaBtn.TabIndex = 42;
            this.searchFirmaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchFirmaBtn.UseVisualStyleBackColor = true;
            this.searchFirmaBtn.Click += new System.EventHandler(this.searchFirmaBtn_Click);
            // 
            // RaportFacturiNeachitateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchFirmaBtn);
            this.Controls.Add(this.firmaTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.refreshBtn);
            this.Name = "RaportFacturiNeachitateControl";
            this.Size = new System.Drawing.Size(900, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button refreshBtn;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firmaTbox;
        private System.Windows.Forms.Button searchFirmaBtn;
    }
}
