using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Facturi
{
    public partial class FacturaIntrareForm : Form
    {
        public Factura FacturaObject { get; set; }

        public FacturaIntrareForm()
        {
            InitializeComponent();
        }

        private void FacturaIntrareForm_Load(object sender, EventArgs e)
        {
            firmeCmb.DataSource = Firma.GetAll();
            if (FacturaObject == null)
            {
                FacturaObject = new Factura();
                this.Text = "Adaugare factura";
            }
            else
            {
                this.Text = "Modificare factura";
                numarTbox.Text = FacturaObject.Numar;
                serieTbox.Text = FacturaObject.Serie;
                dataDtp.Value = FacturaObject.Data.Value;
                firmeCmb.SelectedValue = FacturaObject.IdFirma;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            FacturaObject.Numar = numarTbox.Text;
            FacturaObject.Serie = serieTbox.Text;
            FacturaObject.Data = dataDtp.Value;
            FacturaObject.Numar = numarTbox.Text;
            FacturaObject.IdFirma = (int)firmeCmb.SelectedValue;
            FacturaObject.Tip = "Intrare";
            string errors = FacturaObject.GetErrors();
            if (errors == "")
            {
                var result = FacturaObject.Save();
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
