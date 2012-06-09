namespace Gestiune.Forms.Firme
{
    partial class FirmaForm
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
            this.nrInmatriculareTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cuiTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ibanTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.localitateTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.judetTbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adresaTbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telefonTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.persContactTbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataInfiintariiDtp = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.banciCmb = new System.Windows.Forms.ComboBox();
            this.delegatiCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nrInmatriculareTbox
            // 
            this.nrInmatriculareTbox.Location = new System.Drawing.Point(12, 109);
            this.nrInmatriculareTbox.MaxLength = 30;
            this.nrInmatriculareTbox.Name = "nrInmatriculareTbox";
            this.nrInmatriculareTbox.Size = new System.Drawing.Size(227, 20);
            this.nrInmatriculareTbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nr. de inmatriculare";
            // 
            // cuiTbox
            // 
            this.cuiTbox.Location = new System.Drawing.Point(12, 70);
            this.cuiTbox.MaxLength = 30;
            this.cuiTbox.Name = "cuiTbox";
            this.cuiTbox.Size = new System.Drawing.Size(227, 20);
            this.cuiTbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CUI";
            // 
            // numeTbox
            // 
            this.numeTbox.Location = new System.Drawing.Point(12, 31);
            this.numeTbox.MaxLength = 30;
            this.numeTbox.Name = "numeTbox";
            this.numeTbox.Size = new System.Drawing.Size(227, 20);
            this.numeTbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nume";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Inapoi";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(316, 253);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Salveaza";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IBAN";
            // 
            // ibanTbox
            // 
            this.ibanTbox.Location = new System.Drawing.Point(12, 148);
            this.ibanTbox.MaxLength = 30;
            this.ibanTbox.Name = "ibanTbox";
            this.ibanTbox.Size = new System.Drawing.Size(227, 20);
            this.ibanTbox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Localitate";
            // 
            // localitateTbox
            // 
            this.localitateTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localitateTbox.Location = new System.Drawing.Point(245, 31);
            this.localitateTbox.MaxLength = 30;
            this.localitateTbox.Name = "localitateTbox";
            this.localitateTbox.Size = new System.Drawing.Size(227, 20);
            this.localitateTbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Judet";
            // 
            // judetTbox
            // 
            this.judetTbox.Location = new System.Drawing.Point(245, 70);
            this.judetTbox.MaxLength = 30;
            this.judetTbox.Name = "judetTbox";
            this.judetTbox.Size = new System.Drawing.Size(227, 20);
            this.judetTbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adresa";
            // 
            // adresaTbox
            // 
            this.adresaTbox.Location = new System.Drawing.Point(245, 109);
            this.adresaTbox.MaxLength = 30;
            this.adresaTbox.Name = "adresaTbox";
            this.adresaTbox.Size = new System.Drawing.Size(227, 20);
            this.adresaTbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telefon";
            // 
            // telefonTbox
            // 
            this.telefonTbox.Location = new System.Drawing.Point(245, 148);
            this.telefonTbox.MaxLength = 30;
            this.telefonTbox.Name = "telefonTbox";
            this.telefonTbox.Size = new System.Drawing.Size(227, 20);
            this.telefonTbox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Persoana de contact";
            // 
            // persContactTbox
            // 
            this.persContactTbox.Location = new System.Drawing.Point(12, 187);
            this.persContactTbox.MaxLength = 30;
            this.persContactTbox.Name = "persContactTbox";
            this.persContactTbox.Size = new System.Drawing.Size(227, 20);
            this.persContactTbox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Data infiintarii";
            // 
            // dataInfiintariiDtp
            // 
            this.dataInfiintariiDtp.Location = new System.Drawing.Point(245, 187);
            this.dataInfiintariiDtp.Name = "dataInfiintariiDtp";
            this.dataInfiintariiDtp.Size = new System.Drawing.Size(227, 20);
            this.dataInfiintariiDtp.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Banca";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Delegat";
            // 
            // banciCmb
            // 
            this.banciCmb.DisplayMember = "Nume";
            this.banciCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banciCmb.FormattingEnabled = true;
            this.banciCmb.Location = new System.Drawing.Point(12, 226);
            this.banciCmb.Name = "banciCmb";
            this.banciCmb.Size = new System.Drawing.Size(227, 21);
            this.banciCmb.TabIndex = 17;
            this.banciCmb.ValueMember = "Id";
            // 
            // delegatiCmb
            // 
            this.delegatiCmb.DisplayMember = "Nume";
            this.delegatiCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delegatiCmb.FormattingEnabled = true;
            this.delegatiCmb.Location = new System.Drawing.Point(245, 226);
            this.delegatiCmb.Name = "delegatiCmb";
            this.delegatiCmb.Size = new System.Drawing.Size(227, 21);
            this.delegatiCmb.TabIndex = 17;
            this.delegatiCmb.ValueMember = "Id";
            // 
            // FirmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.delegatiCmb);
            this.Controls.Add(this.banciCmb);
            this.Controls.Add(this.dataInfiintariiDtp);
            this.Controls.Add(this.nrInmatriculareTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.persContactTbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.telefonTbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adresaTbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.localitateTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.judetTbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ibanTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cuiTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmaForm";
            this.Load += new System.EventHandler(this.FirmaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nrInmatriculareTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cuiTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ibanTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox localitateTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox judetTbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adresaTbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telefonTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox persContactTbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dataInfiintariiDtp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox banciCmb;
        private System.Windows.Forms.ComboBox delegatiCmb;
    }
}