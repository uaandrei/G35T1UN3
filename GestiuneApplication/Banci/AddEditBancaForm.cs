using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Enums;

namespace GestiuneApplication.Banci
{
    public partial class AddEditBancaForm : Form
    {
        public AddEditBancaForm()
        {
            InitializeComponent();
        }

        public Banca BancaObject { get; set; }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BancaObject.Adresa = adresaTbox.Text;
            decimal value = 0m;
            decimal.TryParse(capitalTbox.Text, out value);
            BancaObject.CapitalSocial = value;
            BancaObject.Cui = cuiTbox.Text;
            BancaObject.Nume = numeTbox.Text;
            BancaObject.RC = rcTbox.Text;
            var errors = BancaObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = BancaObject.Save();
                MessageBox.Show(result.Message);
                if (result.Status == StatusEnum.Saved)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void AddEditBancaForm_Load(object sender, EventArgs e)
        {
            if (BancaObject == null)
            {
                this.Text = "Adauga banca";
                BancaObject = new Banca();
            }
            else
            {
                this.Text = "Modifica banca";
                adresaTbox.Text = BancaObject.Adresa;
                capitalTbox.Text = BancaObject.CapitalSocial.ToString("0.00");
                cuiTbox.Text = BancaObject.Cui;
                numeTbox.Text = BancaObject.Nume;
                rcTbox.Text = BancaObject.RC;
            }
        }
    }
}
