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

namespace GestiuneApplication.Firme
{
    public partial class AddEditFirmaForm : Form
    {
        public Firma FirmaObject { get; set; }

        public AddEditFirmaForm()
        {
            InitializeComponent();
            bancaCmb.DataSource = Banca.GetAll();
            delegatCmb.DataSource = Delegat.GetAll();
        }

        private void AddEditFirmaForm_Load(object sender, EventArgs e)
        {
            if (FirmaObject == null)
            {
                FirmaObject = new Firma();
                this.Text = "Adauga firma";
            }
            else
            {
                this.Text = "Modifica firma";
                adresaTbox.Text = FirmaObject.Adresa;
                cuiTbox.Text = FirmaObject.Cui;
                ibanTbox.Text = FirmaObject.Iban;
                numeTbox.Text = FirmaObject.Nume;
                rcTbox.Text = FirmaObject.Rc;
                telefonTbox.Text = FirmaObject.Telefon;
                bancaCmb.SelectedValue = FirmaObject.IdBanca;
                delegatCmb.SelectedValue = FirmaObject.IdDelegat;
                dataDtp.Value = FirmaObject.DataInfiintarii;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            FirmaObject.Adresa = adresaTbox.Text;
            FirmaObject.Cui = cuiTbox.Text;
            FirmaObject.DataInfiintarii = dataDtp.Value;
            FirmaObject.Iban = ibanTbox.Text;
            FirmaObject.IdBanca = (int)bancaCmb.SelectedValue;
            FirmaObject.IdDelegat = (int)delegatCmb.SelectedValue;
            FirmaObject.Nume = numeTbox.Text;
            FirmaObject.Rc = rcTbox.Text;
            FirmaObject.Telefon = telefonTbox.Text;
            var errors = FirmaObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = FirmaObject.Save();
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

        private void exiBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
