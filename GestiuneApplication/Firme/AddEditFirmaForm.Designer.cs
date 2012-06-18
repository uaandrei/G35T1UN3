namespace GestiuneApplication.Firme
{
    partial class AddEditFirmaForm
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
            this.delegatCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeTbox = new System.Windows.Forms.TextBox();
            this.dataDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rcTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ibanTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adresaTbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bancaCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.exiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(249, 209);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Salvare";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delegatCmb
            // 
            this.delegatCmb.DisplayMember = "Nume";
            this.delegatCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delegatCmb.FormattingEnabled = true;
            this.delegatCmb.Location = new System.Drawing.Point(12, 142);
            this.delegatCmb.Name = "delegatCmb";
            this.delegatCmb.Size = new System.Drawing.Size(206, 21);
            this.delegatCmb.TabIndex = 6;
            this.delegatCmb.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // numeTbox
            // 
            this.numeTbox.Location = new System.Drawing.Point(12, 25);
            this.numeTbox.MaxLength = 30;
            this.numeTbox.Name = "numeTbox";
            this.numeTbox.Size = new System.Drawing.Size(206, 20);
            this.numeTbox.TabIndex = 0;
            // 
            // dataDtp
            // 
            this.dataDtp.CustomFormat = "dd/MM/yyyy";
            this.dataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDtp.Location = new System.Drawing.Point(224, 142);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(100, 20);
            this.dataDtp.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUI";
            // 
            // cuiTbox
            // 
            this.cuiTbox.Location = new System.Drawing.Point(224, 25);
            this.cuiTbox.MaxLength = 15;
            this.cuiTbox.Name = "cuiTbox";
            this.cuiTbox.Size = new System.Drawing.Size(100, 20);
            this.cuiTbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RC";
            // 
            // rcTbox
            // 
            this.rcTbox.Location = new System.Drawing.Point(224, 64);
            this.rcTbox.MaxLength = 15;
            this.rcTbox.Name = "rcTbox";
            this.rcTbox.Size = new System.Drawing.Size(100, 20);
            this.rcTbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IBAN";
            // 
            // ibanTbox
            // 
            this.ibanTbox.Location = new System.Drawing.Point(12, 64);
            this.ibanTbox.MaxLength = 30;
            this.ibanTbox.Name = "ibanTbox";
            this.ibanTbox.Size = new System.Drawing.Size(206, 20);
            this.ibanTbox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // telefonTbox
            // 
            this.telefonTbox.Location = new System.Drawing.Point(224, 103);
            this.telefonTbox.MaxLength = 15;
            this.telefonTbox.Name = "telefonTbox";
            this.telefonTbox.Size = new System.Drawing.Size(100, 20);
            this.telefonTbox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Adresa";
            // 
            // adresaTbox
            // 
            this.adresaTbox.Location = new System.Drawing.Point(12, 103);
            this.adresaTbox.MaxLength = 30;
            this.adresaTbox.Name = "adresaTbox";
            this.adresaTbox.Size = new System.Drawing.Size(206, 20);
            this.adresaTbox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Delegat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Data infiintarii";
            // 
            // bancaCmb
            // 
            this.bancaCmb.DisplayMember = "Nume";
            this.bancaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bancaCmb.FormattingEnabled = true;
            this.bancaCmb.Location = new System.Drawing.Point(12, 182);
            this.bancaCmb.Name = "bancaCmb";
            this.bancaCmb.Size = new System.Drawing.Size(312, 21);
            this.bancaCmb.TabIndex = 8;
            this.bancaCmb.ValueMember = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Banca";
            // 
            // exiBtn
            // 
            this.exiBtn.Location = new System.Drawing.Point(168, 209);
            this.exiBtn.Name = "exiBtn";
            this.exiBtn.Size = new System.Drawing.Size(75, 23);
            this.exiBtn.TabIndex = 10;
            this.exiBtn.Text = "Iesire";
            this.exiBtn.UseVisualStyleBackColor = true;
            this.exiBtn.Click += new System.EventHandler(this.exiBtn_Click);
            // 
            // AddEditFirmaForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 244);
            this.Controls.Add(this.dataDtp);
            this.Controls.Add(this.telefonTbox);
            this.Controls.Add(this.ibanTbox);
            this.Controls.Add(this.rcTbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cuiTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresaTbox);
            this.Controls.Add(this.numeTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bancaCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delegatCmb);
            this.Controls.Add(this.exiBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditFirmaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditFirmaForm";
            this.Load += new System.EventHandler(this.AddEditFirmaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox delegatCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeTbox;
        private System.Windows.Forms.DateTimePicker dataDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuiTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rcTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ibanTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefonTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adresaTbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox bancaCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exiBtn;
    }
}