﻿namespace GestiuneApplication.Rapoarte
{
    partial class ReportViewerForm
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
            this.reportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowExportButton = false;
            this.reportViewer.ShowPageSetupButton = false;
            this.reportViewer.ShowPrintPreviewButton = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.Size = new System.Drawing.Size(605, 404);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // ReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 404);
            this.Controls.Add(this.reportViewer);
            this.Name = "ReportViewerForm";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.ReportViewerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer;
    }
}