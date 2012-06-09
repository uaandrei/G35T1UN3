namespace Gestiune.Forms
{
    partial class MainForm
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
            this.stocBtn = new System.Windows.Forms.Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.firmeBtn = new System.Windows.Forms.Button();
            this.rapoarteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stocBtn
            // 
            this.stocBtn.Location = new System.Drawing.Point(12, 12);
            this.stocBtn.Name = "stocBtn";
            this.stocBtn.Size = new System.Drawing.Size(256, 77);
            this.stocBtn.TabIndex = 0;
            this.stocBtn.Text = "STOC";
            this.stocBtn.UseVisualStyleBackColor = true;
            this.stocBtn.Click += new System.EventHandler(this.StocBtnClick);
            // 
            // panelCategory
            // 
            this.panelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCategory.Location = new System.Drawing.Point(274, 12);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(513, 428);
            this.panelCategory.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 77);
            this.button2.TabIndex = 0;
            this.button2.Text = "FACTURI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // firmeBtn
            // 
            this.firmeBtn.Location = new System.Drawing.Point(12, 178);
            this.firmeBtn.Name = "firmeBtn";
            this.firmeBtn.Size = new System.Drawing.Size(256, 77);
            this.firmeBtn.TabIndex = 0;
            this.firmeBtn.Text = "FIRME";
            this.firmeBtn.UseVisualStyleBackColor = true;
            this.firmeBtn.Click += new System.EventHandler(this.ButtonFirmeClick);
            // 
            // rapoarteBtn
            // 
            this.rapoarteBtn.Location = new System.Drawing.Point(12, 261);
            this.rapoarteBtn.Name = "rapoarteBtn";
            this.rapoarteBtn.Size = new System.Drawing.Size(256, 77);
            this.rapoarteBtn.TabIndex = 0;
            this.rapoarteBtn.Text = "RAPOARTE";
            this.rapoarteBtn.UseVisualStyleBackColor = true;
            this.rapoarteBtn.Click += new System.EventHandler(this.RapoarteBtnClick);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 344);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(256, 77);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "IESIRE";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rapoarteBtn);
            this.Controls.Add(this.firmeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stocBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiune - Back End";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stocBtn;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button firmeBtn;
        private System.Windows.Forms.Button rapoarteBtn;
        private System.Windows.Forms.Button exitBtn;

    }
}