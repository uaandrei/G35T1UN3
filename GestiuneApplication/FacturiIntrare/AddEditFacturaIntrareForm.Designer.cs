namespace GestiuneApplication.FacturiIntrare
{
    partial class AddEditFacturaIntrareForm
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
            this.components = new System.ComponentModel.Container();
            this.addBtn = new System.Windows.Forms.Button();
            this.pozitieFacturaIntrareGrid = new System.Windows.Forms.DataGridView();
            this.serieTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDtp = new System.Windows.Forms.DateTimePicker();
            this.numarTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cantitateTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pretUnitarTbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.searchProdusBtn = new System.Windows.Forms.Button();
            this.cotaTvaTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.umTbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchFirmaBtn = new System.Windows.Forms.Button();
            this.firmaTbox = new System.Windows.Forms.TextBox();
            this.produsTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pozitieFacturaIntrareGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.Location = new System.Drawing.Point(360, 92);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(32, 32);
            this.addBtn.TabIndex = 8;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addBtn, "Adauga produs in lista");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pozitieFacturaIntrareGrid
            // 
            this.pozitieFacturaIntrareGrid.AllowUserToAddRows = false;
            this.pozitieFacturaIntrareGrid.AllowUserToDeleteRows = false;
            this.pozitieFacturaIntrareGrid.AllowUserToOrderColumns = true;
            this.pozitieFacturaIntrareGrid.AllowUserToResizeRows = false;
            this.pozitieFacturaIntrareGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pozitieFacturaIntrareGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pozitieFacturaIntrareGrid.Location = new System.Drawing.Point(12, 143);
            this.pozitieFacturaIntrareGrid.Name = "pozitieFacturaIntrareGrid";
            this.pozitieFacturaIntrareGrid.ReadOnly = true;
            this.pozitieFacturaIntrareGrid.Size = new System.Drawing.Size(418, 202);
            this.pozitieFacturaIntrareGrid.TabIndex = 9;
            // 
            // serieTbox
            // 
            this.serieTbox.Location = new System.Drawing.Point(12, 25);
            this.serieTbox.MaxLength = 15;
            this.serieTbox.Name = "serieTbox";
            this.serieTbox.Size = new System.Drawing.Size(100, 20);
            this.serieTbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serie";
            // 
            // dataDtp
            // 
            this.dataDtp.CustomFormat = "dd/MM/yyyy";
            this.dataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDtp.Location = new System.Drawing.Point(224, 25);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(100, 20);
            this.dataDtp.TabIndex = 2;
            // 
            // numarTbox
            // 
            this.numarTbox.Location = new System.Drawing.Point(118, 25);
            this.numarTbox.MaxLength = 15;
            this.numarTbox.Name = "numarTbox";
            this.numarTbox.Size = new System.Drawing.Size(100, 20);
            this.numarTbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data facturarii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Furnizor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Produs";
            // 
            // cantitateTbox
            // 
            this.cantitateTbox.Location = new System.Drawing.Point(12, 104);
            this.cantitateTbox.MaxLength = 10;
            this.cantitateTbox.Name = "cantitateTbox";
            this.cantitateTbox.Size = new System.Drawing.Size(100, 20);
            this.cantitateTbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantitate";
            // 
            // pretUnitarTbox
            // 
            this.pretUnitarTbox.Location = new System.Drawing.Point(224, 104);
            this.pretUnitarTbox.MaxLength = 10;
            this.pretUnitarTbox.Name = "pretUnitarTbox";
            this.pretUnitarTbox.Size = new System.Drawing.Size(130, 20);
            this.pretUnitarTbox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pret unitar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lista produse";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(346, 351);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(84, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Salveaza";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(256, 351);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(84, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Remove_32;
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.Location = new System.Drawing.Point(398, 92);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(32, 32);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.removeBtn, "Sterge produs din lista");
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // searchProdusBtn
            // 
            this.searchProdusBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Search_32;
            this.searchProdusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchProdusBtn.Location = new System.Drawing.Point(396, 50);
            this.searchProdusBtn.Name = "searchProdusBtn";
            this.searchProdusBtn.Size = new System.Drawing.Size(34, 34);
            this.searchProdusBtn.TabIndex = 37;
            this.searchProdusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.searchProdusBtn, "Cauta firma");
            this.searchProdusBtn.UseVisualStyleBackColor = true;
            this.searchProdusBtn.Click += new System.EventHandler(this.searchProdusBtn_Click);
            // 
            // cotaTvaTbox
            // 
            this.cotaTvaTbox.Location = new System.Drawing.Point(330, 25);
            this.cotaTvaTbox.MaxLength = 15;
            this.cotaTvaTbox.Name = "cotaTvaTbox";
            this.cotaTvaTbox.Size = new System.Drawing.Size(100, 20);
            this.cotaTvaTbox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cota TVA";
            // 
            // umTbox
            // 
            this.umTbox.Location = new System.Drawing.Point(118, 104);
            this.umTbox.MaxLength = 10;
            this.umTbox.Name = "umTbox";
            this.umTbox.ReadOnly = true;
            this.umTbox.Size = new System.Drawing.Size(100, 20);
            this.umTbox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Unitate de masura";
            // 
            // searchFirmaBtn
            // 
            this.searchFirmaBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Search_32;
            this.searchFirmaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchFirmaBtn.Location = new System.Drawing.Point(184, 50);
            this.searchFirmaBtn.Name = "searchFirmaBtn";
            this.searchFirmaBtn.Size = new System.Drawing.Size(34, 34);
            this.searchFirmaBtn.TabIndex = 38;
            this.searchFirmaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.searchFirmaBtn, "Cauta produs");
            this.searchFirmaBtn.UseVisualStyleBackColor = true;
            this.searchFirmaBtn.Click += new System.EventHandler(this.searchFirmaBtn_Click);
            // 
            // firmaTbox
            // 
            this.firmaTbox.Location = new System.Drawing.Point(12, 64);
            this.firmaTbox.MaxLength = 15;
            this.firmaTbox.Name = "firmaTbox";
            this.firmaTbox.ReadOnly = true;
            this.firmaTbox.Size = new System.Drawing.Size(166, 20);
            this.firmaTbox.TabIndex = 40;
            this.firmaTbox.Text = "Alegeti o firma...";
            // 
            // produsTbox
            // 
            this.produsTbox.Location = new System.Drawing.Point(224, 64);
            this.produsTbox.MaxLength = 15;
            this.produsTbox.Name = "produsTbox";
            this.produsTbox.ReadOnly = true;
            this.produsTbox.Size = new System.Drawing.Size(166, 20);
            this.produsTbox.TabIndex = 39;
            this.produsTbox.Text = "Alegeti un produs...";
            this.produsTbox.TextChanged += new System.EventHandler(this.produsTbox_TextChanged);
            // 
            // AddEditFacturaIntrareForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 386);
            this.Controls.Add(this.searchFirmaBtn);
            this.Controls.Add(this.firmaTbox);
            this.Controls.Add(this.searchProdusBtn);
            this.Controls.Add(this.produsTbox);
            this.Controls.Add(this.dataDtp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pretUnitarTbox);
            this.Controls.Add(this.umTbox);
            this.Controls.Add(this.cantitateTbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numarTbox);
            this.Controls.Add(this.cotaTvaTbox);
            this.Controls.Add(this.serieTbox);
            this.Controls.Add(this.pozitieFacturaIntrareGrid);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditFacturaIntrareForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditFacturaIntrareForm";
            this.Load += new System.EventHandler(this.AddEditFacturaIntrareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pozitieFacturaIntrareGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView pozitieFacturaIntrareGrid;
        private System.Windows.Forms.TextBox serieTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataDtp;
        private System.Windows.Forms.TextBox numarTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantitateTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pretUnitarTbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox cotaTvaTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox umTbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchFirmaBtn;
        private System.Windows.Forms.TextBox firmaTbox;
        private System.Windows.Forms.Button searchProdusBtn;
        private System.Windows.Forms.TextBox produsTbox;
    }
}