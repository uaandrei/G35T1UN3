using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Firme
{
    public partial class BancaForm : Form
    {
        public Banca BancaObject { get; set; }

        public BancaForm()
        {
            InitializeComponent();
        }

        private void BancaForm_Load(object sender, EventArgs e)
        {
            if (BancaObject == null)
            {
                BancaObject = new Banca();
                this.Text = "Adaugare banca";
            }
            else
            {
                this.Text = "Modificare banca";
                numeTbox.Text = BancaObject.Nume;
                nrOrcTbox.Text = BancaObject.NrOrc;
                adresaTbox.Text = BancaObject.Adresa;
                cifTbox.Text = BancaObject.CodIdentificareFiscala;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            BancaObject.Nume = numeTbox.Text;
            BancaObject.Adresa = adresaTbox.Text;
            BancaObject.NrOrc = nrOrcTbox.Text;
            BancaObject.CodIdentificareFiscala = cifTbox.Text;
            string errors = BancaObject.GetErrors();
            if (errors == "")
            {
                var result = BancaObject.Save();
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
    }
}
