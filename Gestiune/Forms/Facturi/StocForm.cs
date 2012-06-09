using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Facturi
{
    public partial class StocForm : Form
    {
        public Stoc StocObject { get; set; }

        public StocForm()
        {
            InitializeComponent();
        }

        private void StocForm_Load(object sender, EventArgs e)
        {
            produseCmb.DataSource = Produs.GetAll();
            facturiGrid.DataSource = Factura.GetAll().Where(p => p.Tip == "Intrare").ToList();
            if (StocObject == null)
            {
                StocObject = new Stoc();
                this.Text = "Adaugare in stoc";
            }
            else
            {
                this.Text = "Modificare in stoc";
                produseCmb.SelectedValue = StocObject.IdProdus;
                cantitateTbox.Text = StocObject.Cantitate.ToString("0.00");
                if (facturiGrid.Rows.Count == 0) return;
                int indexOfFactura = 0;
                foreach (DataGridViewRow item in facturiGrid.Rows)
                {
                    if (item.DataBoundItem == StocObject.FacturaObject)
                    {
                        indexOfFactura = item.Index;
                        break;
                    }
                }
                facturiGrid.Rows[indexOfFactura].Cells[0].Value = true;
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            decimal cantitate = 0m;
            decimal.TryParse(cantitateTbox.Text, out cantitate);
            StocObject.Cantitate = cantitate;
            StocObject.IdProdus = (int)produseCmb.SelectedValue;
            if (facturiGrid.Rows.Count == 0)
            {
                MessageBox.Show("Nu aveti facturi de intrare!");
                return;
            }
            foreach (DataGridViewRow item in facturiGrid.Rows)
            {
                if (item.Cells["ColumnCheckBox"].Value == null) continue;
                if ((bool)item.Cells["ColumnCheckBox"].Value == true)
                {
                    var factura = (Factura)item.DataBoundItem;
                    StocObject.IdFacturaIntrare = factura.ID;
                }
            }
            string errors = StocObject.GetErrors();
            if (errors == "")
            {
                var result = StocObject.Save();
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
