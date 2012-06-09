namespace Gestiune.Forms.Facturi
{
    partial class FacturaIntrareForm
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
            this.serieTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numarTbox = new System.Windows.Forms.TextBox();
            this.dataDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.firmeCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.produseCmb = new System.Windows.Forms.ComboBox();
            this.cantitateTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serieTbox
            // 
            this.serieTbox.Location = new System.Drawing.Point(12, 31);
            this.serieTbox.MaxLength = 20;
            this.serieTbox.Name = "serieTbox";
            this.serieTbox.Size = new System.Drawing.Size(150, 20);
            this.serieTbox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Data factura";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(293, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Inapoi";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "Salveaza";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Numar factura";
            // 
            // numarTbox
            // 
            this.numarTbox.Location = new System.Drawing.Point(12, 70);
            this.numarTbox.MaxLength = 20;
            this.numarTbox.Name = "numarTbox";
            this.numarTbox.Size = new System.Drawing.Size(150, 20);
            this.numarTbox.TabIndex = 44;
            // 
            // dataDtp
            // 
            this.dataDtp.Location = new System.Drawing.Point(168, 30);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(200, 20);
            this.dataDtp.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Serie factura";
            // 
            // firmeCmb
            // 
            this.firmeCmb.DisplayMember = "Nume";
            this.firmeCmb.FormattingEnabled = true;
            this.firmeCmb.Location = new System.Drawing.Point(168, 70);
            this.firmeCmb.Name = "firmeCmb";
            this.firmeCmb.Size = new System.Drawing.Size(200, 21);
            this.firmeCmb.TabIndex = 46;
            this.firmeCmb.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Firma";
            // 
            // produseCmb
            // 
            this.produseCmb.DisplayMember = "Nume";
            this.produseCmb.FormattingEnabled = true;
            this.produseCmb.Location = new System.Drawing.Point(12, 109);
            this.produseCmb.Name = "produseCmb";
            this.produseCmb.Size = new System.Drawing.Size(150, 21);
            this.produseCmb.TabIndex = 50;
            this.produseCmb.ValueMember = "ID";
            // 
            // cantitateTbox
            // 
            this.cantitateTbox.Location = new System.Drawing.Point(168, 109);
            this.cantitateTbox.MaxLength = 10;
            this.cantitateTbox.Name = "cantitateTbox";
            this.cantitateTbox.Size = new System.Drawing.Size(200, 20);
            this.cantitateTbox.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Alegeti produsul";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cantitatea";
            // 
            // FacturaIntrareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 166);
            this.Controls.Add(this.produseCmb);
            this.Controls.Add(this.cantitateTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firmeCmb);
            this.Controls.Add(this.dataDtp);
            this.Controls.Add(this.numarTbox);
            this.Controls.Add(this.serieTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturaIntrareForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaIntrareForm";
            this.Load += new System.EventHandler(this.FacturaIntrareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serieTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numarTbox;
        private System.Windows.Forms.DateTimePicker dataDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox firmeCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox produseCmb;
        private System.Windows.Forms.TextBox cantitateTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}