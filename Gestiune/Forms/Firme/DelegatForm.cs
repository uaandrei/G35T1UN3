using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Firme
{
    public partial class DelegatForm : Form
    {
        public Delegat DelegatObject { get; set; }

        public DelegatForm()
        {
            InitializeComponent();
        }

        private void DelegatForm_Load(object sender, EventArgs e)
        {
            if (DelegatObject == null)
            {
                DelegatObject = new Delegat();
                this.Text = "Adaugare delegat";
            }
            else
            {
                this.Text = "Modificare delegat";
                cnpTbox.Text = DelegatObject.Cnp;
                numeTbox.Text = DelegatObject.Nume;
                serieTbox.Text = DelegatObject.Serie;
            }
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            DelegatObject.Nume = numeTbox.Text;
            DelegatObject.Cnp = cnpTbox.Text;
            DelegatObject.Serie = serieTbox.Text;
            string errors = DelegatObject.GetErrors();
            if (errors == "")
            {
                var result = DelegatObject.Save();
                if (result.Status == GestiuneBusiness.Enums.EnumStatus.Saved)
                {
                    MessageBox.Show("Salvare efectuata cu succes!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Au aparut erori la salvare!" + Environment.NewLine + result.Message);
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
