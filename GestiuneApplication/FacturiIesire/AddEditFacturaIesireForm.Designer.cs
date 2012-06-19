namespace GestiuneApplication.FacturiIesire
{
    partial class AddEditFacturaIesireForm
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
            this.dataDtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numarTbox = new System.Windows.Forms.TextBox();
            this.cotaTvaTbox = new System.Windows.Forms.TextBox();
            this.produsCmb = new System.Windows.Forms.ComboBox();
            this.serieTbox = new System.Windows.Forms.TextBox();
            this.firmeCmb = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pretUnitarTbox = new System.Windows.Forms.TextBox();
            this.cantitateDisponibilaTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantitateTbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDtp
            // 
            this.dataDtp.CustomFormat = "dd/MM/yyyy";
            this.dataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDtp.Location = new System.Drawing.Point(224, 25);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(100, 20);
            this.dataDtp.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Lista produse";
            // 
            // numarTbox
            // 
            this.numarTbox.Location = new System.Drawing.Point(118, 25);
            this.numarTbox.MaxLength = 15;
            this.numarTbox.Name = "numarTbox";
            this.numarTbox.Size = new System.Drawing.Size(100, 20);
            this.numarTbox.TabIndex = 14;
            // 
            // cotaTvaTbox
            // 
            this.cotaTvaTbox.Location = new System.Drawing.Point(330, 25);
            this.cotaTvaTbox.MaxLength = 15;
            this.cotaTvaTbox.Name = "cotaTvaTbox";
            this.cotaTvaTbox.Size = new System.Drawing.Size(100, 20);
            this.cotaTvaTbox.TabIndex = 16;
            // 
            // produsCmb
            // 
            this.produsCmb.DisplayMember = "Nume";
            this.produsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produsCmb.FormattingEnabled = true;
            this.produsCmb.Location = new System.Drawing.Point(224, 64);
            this.produsCmb.Name = "produsCmb";
            this.produsCmb.Size = new System.Drawing.Size(206, 21);
            this.produsCmb.TabIndex = 27;
            this.produsCmb.ValueMember = "ID";
            this.produsCmb.SelectedIndexChanged += new System.EventHandler(this.produsCmb_SelectedIndexChanged);
            // 
            // serieTbox
            // 
            this.serieTbox.Location = new System.Drawing.Point(12, 25);
            this.serieTbox.MaxLength = 15;
            this.serieTbox.Name = "serieTbox";
            this.serieTbox.Size = new System.Drawing.Size(100, 20);
            this.serieTbox.TabIndex = 13;
            // 
            // firmeCmb
            // 
            this.firmeCmb.DisplayMember = "Nume";
            this.firmeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmeCmb.FormattingEnabled = true;
            this.firmeCmb.Location = new System.Drawing.Point(12, 64);
            this.firmeCmb.Name = "firmeCmb";
            this.firmeCmb.Size = new System.Drawing.Size(206, 21);
            this.firmeCmb.TabIndex = 24;
            this.firmeCmb.ValueMember = "ID";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 143);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(418, 202);
            this.dataGrid.TabIndex = 31;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(256, 351);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(84, 23);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(346, 351);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(84, 23);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Salveaza";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Remove_32;
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.Location = new System.Drawing.Point(398, 92);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(32, 32);
            this.removeBtn.TabIndex = 34;
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.removeBtn, "Sterge produs din lista");
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Add_32;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.Location = new System.Drawing.Point(360, 92);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(32, 32);
            this.addBtn.TabIndex = 30;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addBtn, "Adauga produs in lista");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Produs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cumparator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pret unitar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data facturarii";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantitate disponibila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Numar";
            // 
            // pretUnitarTbox
            // 
            this.pretUnitarTbox.Location = new System.Drawing.Point(224, 104);
            this.pretUnitarTbox.MaxLength = 10;
            this.pretUnitarTbox.Name = "pretUnitarTbox";
            this.pretUnitarTbox.Size = new System.Drawing.Size(130, 20);
            this.pretUnitarTbox.TabIndex = 29;
            // 
            // cantitateDisponibilaTbox
            // 
            this.cantitateDisponibilaTbox.Location = new System.Drawing.Point(12, 104);
            this.cantitateDisponibilaTbox.MaxLength = 10;
            this.cantitateDisponibilaTbox.Name = "cantitateDisponibilaTbox";
            this.cantitateDisponibilaTbox.ReadOnly = true;
            this.cantitateDisponibilaTbox.Size = new System.Drawing.Size(100, 20);
            this.cantitateDisponibilaTbox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cota TVA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Serie";
            // 
            // cantitateTbox
            // 
            this.cantitateTbox.Location = new System.Drawing.Point(118, 104);
            this.cantitateTbox.MaxLength = 10;
            this.cantitateTbox.Name = "cantitateTbox";
            this.cantitateTbox.Size = new System.Drawing.Size(100, 20);
            this.cantitateTbox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cantitate";
            // 
            // AddEditFacturaIesireForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 386);
            this.Controls.Add(this.dataDtp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numarTbox);
            this.Controls.Add(this.cotaTvaTbox);
            this.Controls.Add(this.produsCmb);
            this.Controls.Add(this.serieTbox);
            this.Controls.Add(this.firmeCmb);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantitateTbox);
            this.Controls.Add(this.pretUnitarTbox);
            this.Controls.Add(this.cantitateDisponibilaTbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditFacturaIesireForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditFacturaIesireForm";
            this.Load += new System.EventHandler(this.AddEditFacturaIesireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataDtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numarTbox;
        private System.Windows.Forms.TextBox cotaTvaTbox;
        private System.Windows.Forms.ComboBox produsCmb;
        private System.Windows.Forms.TextBox serieTbox;
        private System.Windows.Forms.ComboBox firmeCmb;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pretUnitarTbox;
        private System.Windows.Forms.TextBox cantitateDisponibilaTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantitateTbox;
        private System.Windows.Forms.Label label10;
    }
}