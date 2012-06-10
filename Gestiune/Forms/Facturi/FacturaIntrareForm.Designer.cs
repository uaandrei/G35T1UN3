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
            this.addProductBtn = new System.Windows.Forms.Button();
            this.stocGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stocGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // serieTbox
            // 
            this.serieTbox.Location = new System.Drawing.Point(12, 65);
            this.serieTbox.MaxLength = 20;
            this.serieTbox.Name = "serieTbox";
            this.serieTbox.Size = new System.Drawing.Size(138, 20);
            this.serieTbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Data factura";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Inapoi";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(316, 472);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Salveaza";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Numar factura";
            // 
            // numarTbox
            // 
            this.numarTbox.Location = new System.Drawing.Point(156, 65);
            this.numarTbox.MaxLength = 20;
            this.numarTbox.Name = "numarTbox";
            this.numarTbox.Size = new System.Drawing.Size(138, 20);
            this.numarTbox.TabIndex = 2;
            // 
            // dataDtp
            // 
            this.dataDtp.CustomFormat = "dddd - MMM - yyyy";
            this.dataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDtp.Location = new System.Drawing.Point(300, 65);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(172, 20);
            this.dataDtp.TabIndex = 3;
            this.dataDtp.Value = new System.DateTime(2012, 6, 10, 11, 37, 23, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Serie factura";
            // 
            // firmeCmb
            // 
            this.firmeCmb.DisplayMember = "Nume";
            this.firmeCmb.FormattingEnabled = true;
            this.firmeCmb.Location = new System.Drawing.Point(12, 25);
            this.firmeCmb.Name = "firmeCmb";
            this.firmeCmb.Size = new System.Drawing.Size(460, 21);
            this.firmeCmb.TabIndex = 0;
            this.firmeCmb.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Furnizor";
            // 
            // produseCmb
            // 
            this.produseCmb.DisplayMember = "Nume";
            this.produseCmb.FormattingEnabled = true;
            this.produseCmb.Location = new System.Drawing.Point(12, 104);
            this.produseCmb.Name = "produseCmb";
            this.produseCmb.Size = new System.Drawing.Size(282, 21);
            this.produseCmb.TabIndex = 4;
            this.produseCmb.ValueMember = "ID";
            // 
            // cantitateTbox
            // 
            this.cantitateTbox.Location = new System.Drawing.Point(300, 105);
            this.cantitateTbox.MaxLength = 10;
            this.cantitateTbox.Name = "cantitateTbox";
            this.cantitateTbox.Size = new System.Drawing.Size(73, 20);
            this.cantitateTbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Produs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cantitatea";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(379, 103);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(93, 21);
            this.addProductBtn.TabIndex = 6;
            this.addProductBtn.Text = "Adauga in stoc";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.AddProductBtnClick);
            // 
            // stocGrid
            // 
            this.stocGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stocGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocGrid.Location = new System.Drawing.Point(12, 131);
            this.stocGrid.Name = "stocGrid";
            this.stocGrid.Size = new System.Drawing.Size(460, 335);
            this.stocGrid.TabIndex = 51;
            // 
            // FacturaIntrareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 507);
            this.Controls.Add(this.stocGrid);
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
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturaIntrareForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura de intrare pentru produse";
            this.Load += new System.EventHandler(this.FacturaIntrareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocGrid)).EndInit();
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
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.DataGridView stocGrid;
    }
}