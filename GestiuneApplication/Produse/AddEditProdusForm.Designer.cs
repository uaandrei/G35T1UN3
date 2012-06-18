namespace GestiuneApplication.Produse
{
    partial class AddEditProdusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.saveTbox = new System.Windows.Forms.Button();
            this.numeTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rataTvaTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.umTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stocMinimTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pretTbox = new System.Windows.Forms.TextBox();
            this.exitTbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // saveTbox
            // 
            this.saveTbox.Location = new System.Drawing.Point(143, 129);
            this.saveTbox.Name = "saveTbox";
            this.saveTbox.Size = new System.Drawing.Size(75, 23);
            this.saveTbox.TabIndex = 5;
            this.saveTbox.Text = "Salvare";
            this.saveTbox.UseVisualStyleBackColor = true;
            this.saveTbox.Click += new System.EventHandler(this.saveTbox_Click);
            // 
            // numeTbox
            // 
            this.numeTbox.Location = new System.Drawing.Point(12, 25);
            this.numeTbox.MaxLength = 20;
            this.numeTbox.Name = "numeTbox";
            this.numeTbox.Size = new System.Drawing.Size(206, 20);
            this.numeTbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rata T.V.A.";
            // 
            // rataTvaTbox
            // 
            this.rataTvaTbox.Location = new System.Drawing.Point(12, 103);
            this.rataTvaTbox.MaxLength = 10;
            this.rataTvaTbox.Name = "rataTvaTbox";
            this.rataTvaTbox.Size = new System.Drawing.Size(100, 20);
            this.rataTvaTbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unitate de masura";
            // 
            // umTbox
            // 
            this.umTbox.Location = new System.Drawing.Point(118, 103);
            this.umTbox.MaxLength = 10;
            this.umTbox.Name = "umTbox";
            this.umTbox.Size = new System.Drawing.Size(100, 20);
            this.umTbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stoc minim";
            // 
            // stocMinimTbox
            // 
            this.stocMinimTbox.Location = new System.Drawing.Point(12, 64);
            this.stocMinimTbox.MaxLength = 10;
            this.stocMinimTbox.Name = "stocMinimTbox";
            this.stocMinimTbox.Size = new System.Drawing.Size(100, 20);
            this.stocMinimTbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pret";
            // 
            // pretTbox
            // 
            this.pretTbox.Location = new System.Drawing.Point(118, 64);
            this.pretTbox.MaxLength = 10;
            this.pretTbox.Name = "pretTbox";
            this.pretTbox.Size = new System.Drawing.Size(100, 20);
            this.pretTbox.TabIndex = 2;
            // 
            // exitTbox
            // 
            this.exitTbox.Location = new System.Drawing.Point(62, 129);
            this.exitTbox.Name = "exitTbox";
            this.exitTbox.Size = new System.Drawing.Size(75, 23);
            this.exitTbox.TabIndex = 6;
            this.exitTbox.Text = "Iesire";
            this.exitTbox.UseVisualStyleBackColor = true;
            this.exitTbox.Click += new System.EventHandler(this.exitTbox_Click);
            // 
            // AddEditProdusForm
            // 
            this.AcceptButton = this.saveTbox;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 160);
            this.Controls.Add(this.pretTbox);
            this.Controls.Add(this.stocMinimTbox);
            this.Controls.Add(this.umTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rataTvaTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitTbox);
            this.Controls.Add(this.saveTbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditProdusForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditProdusForm";
            this.Load += new System.EventHandler(this.AddEditProdusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveTbox;
        private System.Windows.Forms.TextBox numeTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rataTvaTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox umTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stocMinimTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pretTbox;
        private System.Windows.Forms.Button exitTbox;
    }
}