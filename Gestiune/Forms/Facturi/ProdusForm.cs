using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Facturi
{
    public partial class ProdusForm : Form
    {
        public Produs ProdusObject { get; set; }

        public ProdusForm()
        {
            InitializeComponent();
        }

        private void ProdusForm_Load(object sender, EventArgs e)
        {
            if (ProdusObject == null)
            {
                ProdusObject = new Produs();
                this.Text = "Adaugare produs";
            }
            else
            {
                this.Text = "Modificare produs";
                numeTbox.Text = ProdusObject.Nume;
                pretTbox.Text = ProdusObject.Pret.ToString("0.00");
                tvaTbox.Text = ProdusObject.RataTva.ToString("0.00");
                umTbox.Text = ProdusObject.Um;
            }
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            ProdusObject.Nume = numeTbox.Text;
            decimal pret = 0m;
            decimal tva = 0m;
            decimal.TryParse(tvaTbox.Text, out tva);
            decimal.TryParse(pretTbox.Text, out pret);
            ProdusObject.Pret = pret;
            ProdusObject.RataTva = tva;
            ProdusObject.Um = umTbox.Text;
            string errors = ProdusObject.GetErrors();
            if (errors == "")
            {
                var result = ProdusObject.Save();
                MessageBox.Show(result.Message);
                if (result.Status == GestiuneBusiness.Enums.EnumStatus.Saved)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
