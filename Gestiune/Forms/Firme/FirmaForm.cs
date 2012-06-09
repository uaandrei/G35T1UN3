using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Firme
{
    public partial class FirmaForm : Form
    {
        public Firma FirmaObject { get; set; }

        public FirmaForm()
        {
            InitializeComponent();
        }

        private void FirmaForm_Load(object sender, EventArgs e)
        {
            banciCmb.DataSource = Banca.GetAll();
            delegatiCmb.DataSource = Delegat.GetAll();
            if (FirmaObject == null)
            {
                FirmaObject = new Firma();
                this.Text = "Adaugare firma";
            }
            else
            {
                this.Text = "Modificare firma";
                numeTbox.Text = FirmaObject.Nume;
                adresaTbox.Text = FirmaObject.Adresa;
                cuiTbox.Text = FirmaObject.Cui;
                ibanTbox.Text = FirmaObject.Iban;
                judetTbox.Text = FirmaObject.Judet;
                localitateTbox.Text = FirmaObject.Localitate;
                nrInmatriculareTbox.Text = FirmaObject.NrInmatriculare;
                persContactTbox.Text = FirmaObject.PersoanaContact;
                telefonTbox.Text = FirmaObject.Telefon;
                banciCmb.SelectedValue = FirmaObject.IdBanca;
                delegatiCmb.SelectedValue = FirmaObject.IdDelegat;
                dataInfiintariiDtp.Value = FirmaObject.DataInfiintarii.Value;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            FirmaObject.Nume = numeTbox.Text;
            FirmaObject.Adresa = adresaTbox.Text;
            FirmaObject.Cui = cuiTbox.Text;
            FirmaObject.Iban = ibanTbox.Text;
            FirmaObject.Judet = judetTbox.Text;
            FirmaObject.Localitate = localitateTbox.Text;
            FirmaObject.NrInmatriculare = nrInmatriculareTbox.Text;
            FirmaObject.PersoanaContact = persContactTbox.Text;
            FirmaObject.Telefon = telefonTbox.Text;
            FirmaObject.IdBanca = (int)banciCmb.SelectedValue;
            FirmaObject.IdDelegat = (int)delegatiCmb.SelectedValue;
            FirmaObject.DataInfiintarii = dataInfiintariiDtp.Value;
            string errors = FirmaObject.GetErrors();
            if (errors == "")
            {
                var result = FirmaObject.Save();
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
