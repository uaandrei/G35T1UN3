namespace Gestiune.Reports
{
    partial class ChooseReportForm
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
            this.chooseBtn = new System.Windows.Forms.Button();
            this.rapoarteListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chooseBtn
            // 
            this.chooseBtn.Location = new System.Drawing.Point(175, 113);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(75, 25);
            this.chooseBtn.TabIndex = 0;
            this.chooseBtn.Text = "Alege";
            this.chooseBtn.UseVisualStyleBackColor = true;
            this.chooseBtn.Click += new System.EventHandler(this.ChooseBtnClick);
            // 
            // rapoarteListBox
            // 
            this.rapoarteListBox.FormattingEnabled = true;
            this.rapoarteListBox.Location = new System.Drawing.Point(12, 12);
            this.rapoarteListBox.Name = "rapoarteListBox";
            this.rapoarteListBox.Size = new System.Drawing.Size(238, 95);
            this.rapoarteListBox.TabIndex = 1;
            this.rapoarteListBox.SelectedIndexChanged += new System.EventHandler(this.RapoarteListBoxSelectedIndexChanged);
            // 
            // ChooseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 150);
            this.Controls.Add(this.rapoarteListBox);
            this.Controls.Add(this.chooseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista rapoarte";
            this.Load += new System.EventHandler(this.ChooseReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.ListBox rapoarteListBox;
    }
}