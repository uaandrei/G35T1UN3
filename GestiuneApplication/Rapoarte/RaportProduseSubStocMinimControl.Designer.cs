﻿namespace GestiuneApplication.Rapoarte
{
    partial class RaportProduseSubStocMinimControl
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(59, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(533, 42);
            this.titleLbl.TabIndex = 26;
            this.titleLbl.Text = "Raport produse sub stoc minim";
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Location = new System.Drawing.Point(0, 59);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowExportButton = false;
            this.reportViewer.ShowHistoryButtons = false;
            this.reportViewer.ShowPrintPreviewButton = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.Size = new System.Drawing.Size(698, 509);
            this.reportViewer.TabIndex = 29;
            this.reportViewer.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::GestiuneApplication.Properties.Resources.Refresh_32;
            this.refreshBtn.Location = new System.Drawing.Point(3, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // RaportProduseSubStocMinimControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.refreshBtn);
            this.Name = "RaportProduseSubStocMinimControl";
            this.Size = new System.Drawing.Size(698, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label titleLbl;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer;
    }
}
