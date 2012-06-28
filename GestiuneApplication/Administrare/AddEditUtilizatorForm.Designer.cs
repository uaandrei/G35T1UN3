namespace GestiuneApplication.Administrare
{
    partial class AddEditUtilizatorForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.rolCmb = new System.Windows.Forms.ComboBox();
            this.activeCkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parolaTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.curentPwdTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(162, 193);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Salvare";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // rolCmb
            // 
            this.rolCmb.DisplayMember = "Nume";
            this.rolCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolCmb.FormattingEnabled = true;
            this.rolCmb.Location = new System.Drawing.Point(12, 142);
            this.rolCmb.Name = "rolCmb";
            this.rolCmb.Size = new System.Drawing.Size(225, 21);
            this.rolCmb.TabIndex = 2;
            this.rolCmb.ValueMember = "ID";
            // 
            // activeCkbox
            // 
            this.activeCkbox.AutoSize = true;
            this.activeCkbox.Location = new System.Drawing.Point(12, 169);
            this.activeCkbox.Name = "activeCkbox";
            this.activeCkbox.Size = new System.Drawing.Size(50, 17);
            this.activeCkbox.TabIndex = 3;
            this.activeCkbox.Text = "Activ";
            this.activeCkbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // numeTbox
            // 
            this.numeTbox.Location = new System.Drawing.Point(12, 25);
            this.numeTbox.MaxLength = 30;
            this.numeTbox.Name = "numeTbox";
            this.numeTbox.Size = new System.Drawing.Size(225, 20);
            this.numeTbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // parolaTbox
            // 
            this.parolaTbox.Location = new System.Drawing.Point(12, 103);
            this.parolaTbox.MaxLength = 30;
            this.parolaTbox.Name = "parolaTbox";
            this.parolaTbox.PasswordChar = '*';
            this.parolaTbox.Size = new System.Drawing.Size(225, 20);
            this.parolaTbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rol";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(81, 193);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola curenta";
            // 
            // curentPwdTbox
            // 
            this.curentPwdTbox.Location = new System.Drawing.Point(12, 64);
            this.curentPwdTbox.MaxLength = 30;
            this.curentPwdTbox.Name = "curentPwdTbox";
            this.curentPwdTbox.PasswordChar = '*';
            this.curentPwdTbox.Size = new System.Drawing.Size(225, 20);
            this.curentPwdTbox.TabIndex = 1;
            // 
            // AddEditUtilizatorForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 226);
            this.Controls.Add(this.curentPwdTbox);
            this.Controls.Add(this.parolaTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activeCkbox);
            this.Controls.Add(this.rolCmb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditUtilizatorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditUtilizatorForm";
            this.Load += new System.EventHandler(this.AddEditUtilizatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox rolCmb;
        private System.Windows.Forms.CheckBox activeCkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parolaTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox curentPwdTbox;
    }
}