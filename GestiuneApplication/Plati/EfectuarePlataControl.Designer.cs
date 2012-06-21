namespace GestiuneApplication.Plati
{
    partial class EfectuarePlataControl
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.plataFirmRadioBtn = new System.Windows.Forms.RadioButton();
            this.openBtn = new System.Windows.Forms.Button();
            this.plataMeaRadioBtn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLbl.Location = new System.Drawing.Point(3, 4);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(256, 42);
            this.titleLbl.TabIndex = 20;
            this.titleLbl.Text = "Efectuare plati";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.plataMeaRadioBtn);
            this.groupBox.Controls.Add(this.plataFirmRadioBtn);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(10, 49);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(249, 105);
            this.groupBox.TabIndex = 21;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tip plata";
            // 
            // plataFirmRadioBtn
            // 
            this.plataFirmRadioBtn.AutoSize = true;
            this.plataFirmRadioBtn.Checked = true;
            this.plataFirmRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plataFirmRadioBtn.Location = new System.Drawing.Point(6, 30);
            this.plataFirmRadioBtn.Name = "plataFirmRadioBtn";
            this.plataFirmRadioBtn.Size = new System.Drawing.Size(133, 28);
            this.plataFirmRadioBtn.TabIndex = 0;
            this.plataFirmRadioBtn.TabStop = true;
            this.plataFirmRadioBtn.Text = "plati pe firma";
            this.plataFirmRadioBtn.UseVisualStyleBackColor = true;
            // 
            // openBtn
            // 
            this.openBtn.Image = global::GestiuneApplication.Properties.Resources.Check_32;
            this.openBtn.Location = new System.Drawing.Point(265, 104);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(50, 50);
            this.openBtn.TabIndex = 22;
            this.openBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.openBtn, "Efectueaza plata");
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // plataMeaRadioBtn
            // 
            this.plataMeaRadioBtn.AutoSize = true;
            this.plataMeaRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plataMeaRadioBtn.Location = new System.Drawing.Point(6, 64);
            this.plataMeaRadioBtn.Name = "plataMeaRadioBtn";
            this.plataMeaRadioBtn.Size = new System.Drawing.Size(123, 28);
            this.plataMeaRadioBtn.TabIndex = 0;
            this.plataMeaRadioBtn.Text = "platile mele";
            this.plataMeaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // EfectuarePlataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.titleLbl);
            this.Name = "EfectuarePlataControl";
            this.Size = new System.Drawing.Size(398, 246);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton plataFirmRadioBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.RadioButton plataMeaRadioBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
