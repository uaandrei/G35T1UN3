using System;
using System.Linq;
using System.Windows.Forms;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Firme
{
    public partial class FirmeUserControl : UserControl
    {
        enum FirmaEnum
        {
            Nimic,
            Firma,
            Delegat,
            Banca
        }

        private FirmaEnum firmaEnum = FirmaEnum.Nimic;

        public FirmeUserControl()
        {
            InitializeComponent();
        }

        private void AddBtnClick(object sender, EventArgs e)
        {
            switch (firmaEnum)
            {
                case FirmaEnum.Nimic:
                    break;
                case FirmaEnum.Firma:
                    var addFirmaForm = new FirmaForm();
                    addFirmaForm.FirmaObject = null;
                    if (addFirmaForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = Firma.GetAll();
                    }
                    break;
                case FirmaEnum.Delegat:
                    var addDelegatForm = new DelegatForm();
                    addDelegatForm.DelegatObject = null;
                    if (addDelegatForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = Delegat.GetAll();
                    }
                    break;
                case FirmaEnum.Banca:
                    var addBancaForm = new BancaForm();
                    addBancaForm.BancaObject = null;
                    if (addBancaForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = Banca.GetAll();
                    }
                    break;
            }
        }

        private void ModifyBtnClick(object sender, EventArgs e)
        {
            try
            {
                switch (firmaEnum)
                {
                    case FirmaEnum.Nimic:
                        break;
                    case FirmaEnum.Firma:
                        var addFirmaForm = new FirmaForm();
                        addFirmaForm.FirmaObject = (Firma)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
                        if (addFirmaForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = Firma.GetAll();
                        }
                        break;
                    case FirmaEnum.Delegat:
                        var addDelegatForm = new DelegatForm();
                        addDelegatForm.DelegatObject = (Delegat)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
                        if (addDelegatForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = Delegat.GetAll();
                        }
                        break;
                    case FirmaEnum.Banca:
                        var addBancaForm = new BancaForm();
                        addBancaForm.BancaObject = (Banca)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
                        if (addBancaForm.ShowDialog() == DialogResult.OK)
                        {
                            // TODO: refactor aici ca sa pot folosi wait cursor
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = Banca.GetAll();
                        }
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void DelegatiBtnClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            titleLbl.Text = delegatiBtn.Text;
            dataGridView.DataSource = Delegat.GetAll();
            firmaEnum = FirmaEnum.Delegat;
            Cursor.Current = Cursors.Default;
        }

        private void FirmeBtnClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            titleLbl.Text = firmeBtn.Text;
            dataGridView.DataSource = Firma.GetAll();
            firmaEnum = FirmaEnum.Firma;
            Cursor.Current = Cursors.Default;
        }

        private void BanciBtnClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            titleLbl.Text = banciBtn.Text;
            dataGridView.DataSource = Banca.GetAll();
            firmaEnum = FirmaEnum.Banca;
            Cursor.Current = Cursors.Default;
        }
    }
}
