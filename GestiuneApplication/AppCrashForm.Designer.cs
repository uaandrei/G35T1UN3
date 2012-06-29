namespace GestiuneApplication
{
    partial class AppCrashForm
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
            this.noBtn = new System.Windows.Forms.Button();
            this.messageTbox = new System.Windows.Forms.TextBox();
            this.crashDetailsTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noBtn
            // 
            this.noBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.noBtn.Location = new System.Drawing.Point(239, 38);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 23);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "Nu";
            this.noBtn.UseVisualStyleBackColor = true;
            // 
            // messageTbox
            // 
            this.messageTbox.Location = new System.Drawing.Point(12, 12);
            this.messageTbox.Name = "messageTbox";
            this.messageTbox.ReadOnly = true;
            this.messageTbox.Size = new System.Drawing.Size(448, 20);
            this.messageTbox.TabIndex = 3;
            // 
            // crashDetailsTbox
            // 
            this.crashDetailsTbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crashDetailsTbox.Location = new System.Drawing.Point(0, 89);
            this.crashDetailsTbox.Multiline = true;
            this.crashDetailsTbox.Name = "crashDetailsTbox";
            this.crashDetailsTbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.crashDetailsTbox.Size = new System.Drawing.Size(472, 278);
            this.crashDetailsTbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalii";
            // 
            // yesBtn
            // 
            this.yesBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesBtn.Location = new System.Drawing.Point(158, 38);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 0;
            this.yesBtn.Text = "Da";
            this.yesBtn.UseVisualStyleBackColor = true;
            // 
            // AppCrashForm
            // 
            this.AcceptButton = this.yesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noBtn;
            this.ClientSize = new System.Drawing.Size(472, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crashDetailsTbox);
            this.Controls.Add(this.messageTbox);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.noBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppCrashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppCrashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.TextBox messageTbox;
        private System.Windows.Forms.TextBox crashDetailsTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesBtn;
    }
}