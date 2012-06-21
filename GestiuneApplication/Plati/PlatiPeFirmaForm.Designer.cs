namespace GestiuneApplication.Plati
{
    partial class PlatiPeFirmaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.facturiGrid = new System.Windows.Forms.DataGridView();
            this.facturaIesireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nrTbox = new System.Windows.Forms.TextBox();
            this.cecRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boRbtn = new System.Windows.Forms.RadioButton();
            this.chitantaRbtn = new System.Windows.Forms.RadioButton();
            this.opRbtn = new System.Windows.Forms.RadioButton();
            this.firmeCmb = new System.Windows.Forms.ComboBox();
            this.endBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serieTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sumaDisponibilaTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.platesteFacturaBtn = new System.Windows.Forms.Button();
            this.platesteAutomatBtn = new System.Windows.Forms.Button();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaPlatitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facturiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaIesireBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // facturiGrid
            // 
            this.facturiGrid.AllowUserToAddRows = false;
            this.facturiGrid.AllowUserToDeleteRows = false;
            this.facturiGrid.AllowUserToOrderColumns = true;
            this.facturiGrid.AllowUserToResizeRows = false;
            this.facturiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.facturiGrid.AutoGenerateColumns = false;
            this.facturiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieDataGridViewTextBoxColumn,
            this.numarDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.sumaPlatitaDataGridViewTextBoxColumn,
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn});
            this.facturiGrid.DataSource = this.facturaIesireBindingSource;
            this.facturiGrid.Location = new System.Drawing.Point(12, 127);
            this.facturiGrid.Name = "facturiGrid";
            this.facturiGrid.ReadOnly = true;
            this.facturiGrid.Size = new System.Drawing.Size(551, 250);
            this.facturiGrid.TabIndex = 27;
            // 
            // facturaIesireBindingSource
            // 
            this.facturaIesireBindingSource.DataSource = typeof(GestiuneBusiness.Poco.FacturaIesire);
            // 
            // nrTbox
            // 
            this.nrTbox.Location = new System.Drawing.Point(307, 25);
            this.nrTbox.MaxLength = 15;
            this.nrTbox.Name = "nrTbox";
            this.nrTbox.Size = new System.Drawing.Size(125, 20);
            this.nrTbox.TabIndex = 1;
            // 
            // cecRbtn
            // 
            this.cecRbtn.AutoSize = true;
            this.cecRbtn.Checked = true;
            this.cecRbtn.Location = new System.Drawing.Point(9, 19);
            this.cecRbtn.Name = "cecRbtn";
            this.cecRbtn.Size = new System.Drawing.Size(46, 17);
            this.cecRbtn.TabIndex = 25;
            this.cecRbtn.TabStop = true;
            this.cecRbtn.Text = "CEC";
            this.cecRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boRbtn);
            this.groupBox1.Controls.Add(this.chitantaRbtn);
            this.groupBox1.Controls.Add(this.opRbtn);
            this.groupBox1.Controls.Add(this.cecRbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipul de plata";
            // 
            // boRbtn
            // 
            this.boRbtn.AutoSize = true;
            this.boRbtn.Location = new System.Drawing.Point(148, 19);
            this.boRbtn.Name = "boRbtn";
            this.boRbtn.Size = new System.Drawing.Size(86, 17);
            this.boRbtn.TabIndex = 25;
            this.boRbtn.Text = "Bilet de ordin";
            this.boRbtn.UseVisualStyleBackColor = true;
            // 
            // chitantaRbtn
            // 
            this.chitantaRbtn.AutoSize = true;
            this.chitantaRbtn.Location = new System.Drawing.Point(148, 42);
            this.chitantaRbtn.Name = "chitantaRbtn";
            this.chitantaRbtn.Size = new System.Drawing.Size(64, 17);
            this.chitantaRbtn.TabIndex = 25;
            this.chitantaRbtn.Text = "Chitanta";
            this.chitantaRbtn.UseVisualStyleBackColor = true;
            // 
            // opRbtn
            // 
            this.opRbtn.AutoSize = true;
            this.opRbtn.Location = new System.Drawing.Point(9, 42);
            this.opRbtn.Name = "opRbtn";
            this.opRbtn.Size = new System.Drawing.Size(91, 17);
            this.opRbtn.TabIndex = 25;
            this.opRbtn.Text = "Ordin de plata";
            this.opRbtn.UseVisualStyleBackColor = true;
            // 
            // firmeCmb
            // 
            this.firmeCmb.DisplayMember = "Nume";
            this.firmeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmeCmb.FormattingEnabled = true;
            this.firmeCmb.Location = new System.Drawing.Point(12, 25);
            this.firmeCmb.Name = "firmeCmb";
            this.firmeCmb.Size = new System.Drawing.Size(289, 21);
            this.firmeCmb.TabIndex = 0;
            this.firmeCmb.ValueMember = "ID";
            this.firmeCmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // endBtn
            // 
            this.endBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.endBtn.Location = new System.Drawing.Point(456, 383);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(107, 23);
            this.endBtn.TabIndex = 8;
            this.endBtn.Text = "Terminare";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numar chitanta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Firma";
            // 
            // serieTbox
            // 
            this.serieTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serieTbox.Location = new System.Drawing.Point(438, 26);
            this.serieTbox.MaxLength = 15;
            this.serieTbox.Name = "serieTbox";
            this.serieTbox.Size = new System.Drawing.Size(125, 20);
            this.serieTbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Serie";
            // 
            // dataDtp
            // 
            this.dataDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDtp.CustomFormat = "dd/MM/yyyy";
            this.dataDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDtp.Location = new System.Drawing.Point(438, 64);
            this.dataDtp.Name = "dataDtp";
            this.dataDtp.Size = new System.Drawing.Size(125, 20);
            this.dataDtp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Suma disponibila";
            // 
            // sumaDisponibilaTbox
            // 
            this.sumaDisponibilaTbox.Location = new System.Drawing.Point(307, 64);
            this.sumaDisponibilaTbox.MaxLength = 15;
            this.sumaDisponibilaTbox.Name = "sumaDisponibilaTbox";
            this.sumaDisponibilaTbox.Size = new System.Drawing.Size(125, 20);
            this.sumaDisponibilaTbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data platii";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Facturi";
            // 
            // platesteFacturaBtn
            // 
            this.platesteFacturaBtn.Location = new System.Drawing.Point(307, 98);
            this.platesteFacturaBtn.Name = "platesteFacturaBtn";
            this.platesteFacturaBtn.Size = new System.Drawing.Size(125, 23);
            this.platesteFacturaBtn.TabIndex = 6;
            this.platesteFacturaBtn.Text = "Plateste factura";
            this.platesteFacturaBtn.UseVisualStyleBackColor = true;
            this.platesteFacturaBtn.Click += new System.EventHandler(this.platesteFacturaBtn_Click);
            // 
            // platesteAutomatBtn
            // 
            this.platesteAutomatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.platesteAutomatBtn.Location = new System.Drawing.Point(438, 98);
            this.platesteAutomatBtn.Name = "platesteAutomatBtn";
            this.platesteAutomatBtn.Size = new System.Drawing.Size(125, 23);
            this.platesteAutomatBtn.TabIndex = 7;
            this.platesteAutomatBtn.Text = "Plateste automat";
            this.platesteAutomatBtn.UseVisualStyleBackColor = true;
            this.platesteAutomatBtn.Click += new System.EventHandler(this.platesteAutomatBtn_Click);
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarDataGridViewTextBoxColumn
            // 
            this.numarDataGridViewTextBoxColumn.DataPropertyName = "Numar";
            this.numarDataGridViewTextBoxColumn.HeaderText = "Numar";
            this.numarDataGridViewTextBoxColumn.Name = "numarDataGridViewTextBoxColumn";
            this.numarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumaPlatitaDataGridViewTextBoxColumn
            // 
            this.sumaPlatitaDataGridViewTextBoxColumn.DataPropertyName = "SumaPlatita";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.sumaPlatitaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sumaPlatitaDataGridViewTextBoxColumn.HeaderText = "Suma platita";
            this.sumaPlatitaDataGridViewTextBoxColumn.Name = "sumaPlatitaDataGridViewTextBoxColumn";
            this.sumaPlatitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumaRamasaDePlatitDataGridViewTextBoxColumn
            // 
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn.DataPropertyName = "SumaRamasaDePlatit";
            dataGridViewCellStyle3.Format = "N2";
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn.HeaderText = "Suma ramasa";
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn.Name = "sumaRamasaDePlatitDataGridViewTextBoxColumn";
            this.sumaRamasaDePlatitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PlatiPeFirmaForm
            // 
            this.AcceptButton = this.endBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 418);
            this.Controls.Add(this.dataDtp);
            this.Controls.Add(this.facturiGrid);
            this.Controls.Add(this.serieTbox);
            this.Controls.Add(this.sumaDisponibilaTbox);
            this.Controls.Add(this.nrTbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.firmeCmb);
            this.Controls.Add(this.platesteAutomatBtn);
            this.Controls.Add(this.platesteFacturaBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlatiPeFirmaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Achitare facturi pe firma";
            this.Load += new System.EventHandler(this.PlatiPeFirmaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaIesireBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView facturiGrid;
        private System.Windows.Forms.TextBox nrTbox;
        private System.Windows.Forms.RadioButton cecRbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox firmeCmb;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serieTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sumaDisponibilaTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton boRbtn;
        private System.Windows.Forms.RadioButton opRbtn;
        private System.Windows.Forms.RadioButton chitantaRbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button platesteFacturaBtn;
        private System.Windows.Forms.Button platesteAutomatBtn;
        private System.Windows.Forms.BindingSource facturaIesireBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaPlatitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaRamasaDePlatitDataGridViewTextBoxColumn;
    }
}