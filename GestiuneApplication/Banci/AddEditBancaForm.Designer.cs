namespace GestiuneApplication.Banci
{
    partial class AddEditBancaForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cuiTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rcTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adresaTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.capitalTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(143, 168);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Salvare";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cuiTbox
            // 
            this.cuiTbox.Location = new System.Drawing.Point(12, 103);
            this.cuiTbox.MaxLength = 15;
            this.cuiTbox.Name = "cuiTbox";
            this.cuiTbox.Size = new System.Drawing.Size(100, 20);
            this.cuiTbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUI";
            // 
            // rcTbox
            // 
            this.rcTbox.Location = new System.Drawing.Point(118, 103);
            this.rcTbox.MaxLength = 15;
            this.rcTbox.Name = "rcTbox";
            this.rcTbox.Size = new System.Drawing.Size(100, 20);
            this.rcTbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RC";
            // 
            // numeTbox
            // 
            this.numeTbox.Location = new System.Drawing.Point(12, 25);
            this.numeTbox.MaxLength = 30;
            this.numeTbox.Name = "numeTbox";
            this.numeTbox.Size = new System.Drawing.Size(206, 20);
            this.numeTbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // adresaTbox
            // 
            this.adresaTbox.Location = new System.Drawing.Point(12, 64);
            this.adresaTbox.MaxLength = 30;
            this.adresaTbox.Name = "adresaTbox";
            this.adresaTbox.Size = new System.Drawing.Size(206, 20);
            this.adresaTbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresa";
            // 
            // capitalTbox
            // 
            this.capitalTbox.Location = new System.Drawing.Point(12, 143);
            this.capitalTbox.MaxLength = 20;
            this.capitalTbox.Name = "capitalTbox";
            this.capitalTbox.Size = new System.Drawing.Size(206, 20);
            this.capitalTbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Capital social";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(62, 168);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddEditBancaForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 201);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capitalTbox);
            this.Controls.Add(this.adresaTbox);
            this.Controls.Add(this.rcTbox);
            this.Controls.Add(this.numeTbox);
            this.Controls.Add(this.cuiTbox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditBancaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditBancaForm";
            this.Load += new System.EventHandler(this.AddEditBancaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox cuiTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rcTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresaTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capitalTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitBtn;
    }
}