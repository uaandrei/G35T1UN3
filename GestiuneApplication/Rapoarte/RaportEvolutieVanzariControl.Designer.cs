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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.titleLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.chartVanzari = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.produseCmb = new System.Windows.Forms.ComboBox();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalCmb = new System.Windows.Forms.ComboBox();
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
            this.titleLbl.Size = new System.Drawing.Size(400, 42);
            this.titleLbl.TabIndex = 28;
            this.titleLbl.Text = "Raport evolutie vanzari";
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
            chartArea2.AxisX.Title = "Data vanzarii";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Coral;
            chartArea2.AxisY.Title = "Cantitate";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Coral;
            chartArea2.Name = "ChartArea1";
            this.chartVanzari.ChartAreas.Add(chartArea2);
            this.chartVanzari.Location = new System.Drawing.Point(0, 99);
            this.chartVanzari.Name = "chartVanzari";
            this.chartVanzari.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartVanzari.Series.Add(series2);
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
            // produseCmb
            // 
            this.produseCmb.DataSource = this.produsBindingSource;
            this.produseCmb.DisplayMember = "Nume";
            this.produseCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produseCmb.FormattingEnabled = true;
            this.produseCmb.Location = new System.Drawing.Point(3, 72);
            this.produseCmb.Name = "produseCmb";
            this.produseCmb.Size = new System.Drawing.Size(201, 21);
            this.produseCmb.TabIndex = 31;
            this.produseCmb.ValueMember = "ID";
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(GestiuneBusiness.Poco.Produs);
            // 
            // startDtp
            // 
            this.startDtp.CustomFormat = "dd/MM/yyyy";
            this.startDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDtp.Location = new System.Drawing.Point(210, 72);
            this.startDtp.Name = "startDtp";
            this.startDtp.Size = new System.Drawing.Size(96, 20);
            this.startDtp.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data inceput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Data sfarsit";
            // 
            // endDtp
            // 
            this.endDtp.CustomFormat = "dd/MM/yyyy";
            this.endDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDtp.Location = new System.Drawing.Point(312, 73);
            this.endDtp.Name = "endDtp";
            this.endDtp.Size = new System.Drawing.Size(96, 20);
            this.endDtp.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Interval";
            // 
            // intervalCmb
            // 
            this.intervalCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalCmb.FormattingEnabled = true;
            this.intervalCmb.Location = new System.Drawing.Point(414, 71);
            this.intervalCmb.Name = "intervalCmb";
            this.intervalCmb.Size = new System.Drawing.Size(101, 21);
            this.intervalCmb.TabIndex = 31;
            // 
            // RaportEvolutieVanzariControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDtp);
            this.Controls.Add(this.startDtp);
            this.Controls.Add(this.intervalCmb);
            this.Controls.Add(this.produseCmb);
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
        private System.Windows.Forms.ComboBox produseCmb;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private System.Windows.Forms.DateTimePicker startDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox intervalCmb;
    }
}
