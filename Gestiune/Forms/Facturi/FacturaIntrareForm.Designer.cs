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
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Data";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(293, 97);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Inapoi";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 97);
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
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Numar";
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
            this.dataDtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Serie";
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
            // FacturaIntrareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 127);
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
    }
}