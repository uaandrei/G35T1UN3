namespace GestiuneApplication.Administrare
{
    partial class SetariControl
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.firmeCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPwdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(3, 4);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(115, 42);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "Setari";
            // 
            // firmeCmb
            // 
            this.firmeCmb.DisplayMember = "Nume";
            this.firmeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmeCmb.FormattingEnabled = true;
            this.firmeCmb.Location = new System.Drawing.Point(3, 72);
            this.firmeCmb.Name = "firmeCmb";
            this.firmeCmb.Size = new System.Drawing.Size(154, 21);
            this.firmeCmb.TabIndex = 16;
            this.firmeCmb.ValueMember = "ID";
            this.firmeCmb.SelectedIndexChanged += new System.EventHandler(this.firmeCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Firma mea";
            // 
            // adminPwdBtn
            // 
            this.adminPwdBtn.Location = new System.Drawing.Point(3, 99);
            this.adminPwdBtn.Name = "adminPwdBtn";
            this.adminPwdBtn.Size = new System.Drawing.Size(154, 23);
            this.adminPwdBtn.TabIndex = 18;
            this.adminPwdBtn.Text = "Schimba parola admin";
            this.adminPwdBtn.UseVisualStyleBackColor = true;
            this.adminPwdBtn.Click += new System.EventHandler(this.adminPwdBtn_Click);
            // 
            // SetariControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminPwdBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firmeCmb);
            this.Controls.Add(this.titleLbl);
            this.Name = "SetariControl";
            this.Size = new System.Drawing.Size(626, 436);
            this.Load += new System.EventHandler(this.MyInfoControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ComboBox firmeCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminPwdBtn;
    }
}
