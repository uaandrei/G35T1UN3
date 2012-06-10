namespace Gestiune.Reports
{
    partial class ReportUserControl
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
            this.reportsListBox = new System.Windows.Forms.ListBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportsListBox
            // 
            this.reportsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.reportsListBox.FormattingEnabled = true;
            this.reportsListBox.Location = new System.Drawing.Point(3, 3);
            this.reportsListBox.Name = "reportsListBox";
            this.reportsListBox.Size = new System.Drawing.Size(180, 420);
            this.reportsListBox.TabIndex = 0;
            this.reportsListBox.DoubleClick += new System.EventHandler(this.ReportsListBoxDoubleClick);
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Location = new System.Drawing.Point(189, 3);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(582, 420);
            this.reportViewer.TabIndex = 1;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.reportsListBox);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(774, 428);
            this.Load += new System.EventHandler(this.ReportUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox reportsListBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}
