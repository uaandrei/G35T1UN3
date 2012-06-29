using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Poco.Administration;

namespace GestiuneApplication.Administrare
{
    public partial class SchimbaParolaAdminForm : Form
    {
        public SchimbaParolaAdminForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var parolaCurenta = MainForm.Md5Hash(currentTbox.Text);
            if (Setare.GetSetare().AdminPassword != parolaCurenta)
            {
                MessageBox.Show("Parola curenta nu este corecta!");
                return;
            }
            if (newTbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nu ati introdus o parola noua!");
                return;
            }
            var parolaNoua = newTbox.Text;
            Setare.GetSetare().AdminPassword = MainForm.Md5Hash(parolaNoua);
            var pr = Setare.GetSetare().Save();
            MessageBox.Show(pr.Message);
            if (pr.Status == GestiuneBusiness.Enums.StatusEnum.Saved)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
