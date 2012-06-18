using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Enums;
using GestiuneBusiness.Poco;

namespace GestiuneApplication.Produse
{
    public partial class AddEditProdusForm : Form
    {
        public Produs ProdusObject { get; set; }
        public AddEditProdusForm()
        {
            InitializeComponent();
        }

        private void AddEditProdusForm_Load(object sender, EventArgs e)
        {
            if (ProdusObject == null)
            {
                ProdusObject = new Produs();
                this.Text = "Adauga produs";
            }
            else
            {
                this.Text = "Modifica produs";
                numeTbox.Text = ProdusObject.Nume;
                stocMinimTbox.Text = ProdusObject.StocMinim.ToString("0.00");
                pretTbox.Text = ProdusObject.Pret.ToString("0.00");
                rataTvaTbox.Text = ProdusObject.RataTva.ToString("0.00");
                umTbox.Text = ProdusObject.Um;
            }
        }

        private void exitTbox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveTbox_Click(object sender, EventArgs e)
        {
            ProdusObject.Nume = numeTbox.Text;
            decimal value = 0m;
            decimal.TryParse(stocMinimTbox.Text, out value);
            ProdusObject.StocMinim = value;
            decimal.TryParse(pretTbox.Text, out value);
            ProdusObject.Pret = value;
            decimal.TryParse(rataTvaTbox.Text, out value);
            ProdusObject.RataTva = value;
            ProdusObject.Um = umTbox.Text;
            var errors = ProdusObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = ProdusObject.Save();
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
    }
}
