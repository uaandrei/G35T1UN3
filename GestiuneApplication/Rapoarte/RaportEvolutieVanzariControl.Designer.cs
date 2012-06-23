namespace GestiuneApplication.Rapoarte
{
    partial class RaportEvolutieVanzariControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.titleLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.chartVanzari = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalCmb = new System.Windows.Forms.ComboBox();
            this.searchProdusBtn = new System.Windows.Forms.Button();
            this.produsTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartVanzari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(59, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(577, 42);
            this.titleLbl.TabIndex = 28;
            this.titleLbl.Text = "Raport evolutie vanzari pe produs";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::GestiuneApplication.Properties.Resources.Refresh_32;
            this.refreshBtn.Location = new System.Drawing.Point(3, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 27;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // chartVanzari
            // 
            this.chartVanzari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.Title = "Data vanzarii";
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Coral;
            chartArea4.AxisY.Title = "Cantitate";
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.Coral;
            chartArea4.Name = "ChartArea1";
            this.chartVanzari.ChartAreas.Add(chartArea4);
            this.chartVanzari.Location = new System.Drawing.Point(0, 99);
            this.chartVanzari.Name = "chartVanzari";
            this.chartVanzari.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartVanzari.Series.Add(series4);
            this.chartVanzari.Size = new System.Drawing.Size(934, 491);
            this.chartVanzari.TabIndex = 29;
            this.chartVanzari.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Produs";
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Produs);
            // 
            // startDtp
            // 
            this.startDtp.CustomFormat = "dd/MM/yyyy";
            this.startDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDtp.Location = new System.Drawing.Point(215, 71);
            this.startDtp.Name = "startDtp";
            this.startDtp.Size = new System.Drawing.Size(96, 20);
            this.startDtp.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data inceput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Data sfarsit";
            // 
            // endDtp
            // 
            this.endDtp.CustomFormat = "dd/MM/yyyy";
            this.endDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDtp.Location = new System.Drawing.Point(317, 72);
            this.endDtp.Name = "endDtp";
            this.endDtp.Size = new System.Drawing.Size(96, 20);
            this.endDtp.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Interval";
            // 
            // intervalCmb
            // 
            this.intervalCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalCmb.FormattingEnabled = true;
            this.intervalCmb.Location = new System.Drawing.Point(419, 70);
            this.intervalCmb.Name = "intervalCmb";
            this.intervalCmb.Size = new System.Drawing.Size(101, 21);
            this.intervalCmb.TabIndex = 31;
            // 
            // searchProdusBtn
            // 
            this.searchProdusBtn.BackgroundImage = global::GestiuneApplication.Properties.Resources.Search_32;
            this.searchProdusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchProdusBtn.Location = new System.Drawing.Point(175, 57);
            this.searchProdusBtn.Name = "searchProdusBtn";
            this.searchProdusBtn.Size = new System.Drawing.Size(34, 34);
            this.searchProdusBtn.TabIndex = 40;
            this.searchProdusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchProdusBtn.UseVisualStyleBackColor = true;
            this.searchProdusBtn.Click += new System.EventHandler(this.searchProdusBtn_Click);
            // 
            // produsTbox
            // 
            this.produsTbox.Location = new System.Drawing.Point(3, 71);
            this.produsTbox.MaxLength = 15;
            this.produsTbox.Name = "produsTbox";
            this.produsTbox.ReadOnly = true;
            this.produsTbox.Size = new System.Drawing.Size(166, 20);
            this.produsTbox.TabIndex = 41;
            this.produsTbox.Text = "Alegeti un produs...";
            // 
            // RaportEvolutieVanzariControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchProdusBtn);
            this.Controls.Add(this.produsTbox);
            this.Controls.Add(this.endDtp);
            this.Controls.Add(this.startDtp);
            this.Controls.Add(this.intervalCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartVanzari);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.refreshBtn);
            this.Name = "RaportEvolutieVanzariControl";
            this.Size = new System.Drawing.Size(934, 590);
            this.Load += new System.EventHandler(this.RaportEvolutieVanzariControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVanzari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVanzari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DateTimePicker startDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox intervalCmb;
        private System.Windows.Forms.Button searchProdusBtn;
        private System.Windows.Forms.TextBox produsTbox;
    }
}
