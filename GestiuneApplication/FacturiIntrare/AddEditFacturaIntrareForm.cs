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
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneApplication.FacturiIntrare
{
    public partial class AddEditFacturaIntrareForm : Form
    {
        public FacturaIntrare FacturaIntrareObject { get; set; }

        private Produs produs;

        public Produs SelectedProdus
        {
            get { return produs; }
            set
            {
                pretUnitarTbox.Text = value == null ? "" : value.Pret.ToString("0.00");
                umTbox.Text = value == null ? "" : value.Um;
                produsTbox.Text = value == null ? "Alegeti un produs..." : value.Nume;
                produs = value;
            }
        }

        private Firma firma;

        public Firma SelectedFirma
        {
            get { return firma; }
            set
            {
                firmaTbox.Text = value == null ? "Alegeti o firma..." : value.Nume;
                firma = value;
            }
        }

        public AddEditFacturaIntrareForm()
        {
            InitializeComponent();
            foreach (var item in new PozitieFacturaIntrare().PropertiesNamesWithValues)
            {
                if (item.FriendlyName.Trim() != string.Empty)
                {
                    pozitieFacturaIntrareGrid.Columns.Add(item.Name, item.FriendlyName);
                }
            }
        }

        private void AddEditFacturaIntrareForm_Load(object sender, EventArgs e)
        {
            if (FacturaIntrareObject == null)
            {
                this.Text = "Adauga factura de intrare";
                FacturaIntrareObject = new FacturaIntrare();
            }
            else
            {
                this.Text = "Modifica factura de intrare";
                // load data
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var pozitieIn = new PozitieFacturaIntrare();
            decimal value = 0m;
            decimal.TryParse(cantitateTbox.Text, out value);
            pozitieIn.Cantitate = value;
            pozitieIn.IdFacturaIntrare = 2; // doar ca sa nu dea mesaj
            decimal.TryParse(pretUnitarTbox.Text, out value);
            pozitieIn.PretUnitar = value;
            pozitieIn.IdProdus = SelectedProdus == null ? 0 : SelectedProdus.ID;
            var errors = pozitieIn.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = pozitieIn;
                row.CreateCells(pozitieFacturaIntrareGrid, pozitieIn.ProdusObject.Nume, pozitieIn.Cantitate, pozitieIn.PretUnitar.ToString("0.00"));
                pozitieFacturaIntrareGrid.Rows.Add(row);
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (pozitieFacturaIntrareGrid.Rows.Count == 0) return;
            if (pozitieFacturaIntrareGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Trebuie sa alegeti un produs!");
            }
            else
            {
                pozitieFacturaIntrareGrid.Rows.RemoveAt(pozitieFacturaIntrareGrid.SelectedCells[0].RowIndex);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var pozitieFacturaIntrareList = new List<PozitieFacturaIntrare>();
            foreach (DataGridViewRow row in pozitieFacturaIntrareGrid.Rows)
            {
                var pozitieFacturaIntrare = (PozitieFacturaIntrare)row.Tag;
                pozitieFacturaIntrareList.Add(pozitieFacturaIntrare);
            }
            decimal value = 0m;
            decimal.TryParse(cotaTvaTbox.Text, out value);
            FacturaIntrareObject.CotaTva = value;
            FacturaIntrareObject.Data = dataDtp.Value;
            FacturaIntrareObject.IdFirma = SelectedFirma == null ? 0 : SelectedFirma.ID;
            FacturaIntrareObject.Numar = numarTbox.Text;
            FacturaIntrareObject.Serie = serieTbox.Text;
            var errors = FacturaIntrareObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = FacturaIntrareObject.Save(pozitieFacturaIntrareList);
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

        private void searchFirmaBtn_Click(object sender, EventArgs e)
        {
            var form = new SelectItemForm
            {
                Datas = Firma.GetAll().Cast<GestiuneObject>().ToList(),
                Text = "Cautare firma"
            };
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SelectedFirma = form.SelectedObject == null ? null : (Firma)form.SelectedObject;
        }

        private void searchProdusBtn_Click(object sender, EventArgs e)
        {
            var form = new SelectItemForm
            {
                Datas = Produs.GetAll().Cast<GestiuneObject>().ToList(),
                Text = "Cautare produs"
            };
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SelectedProdus = form.SelectedObject == null ? null : (Produs)form.SelectedObject;
        }

        private void produsTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
