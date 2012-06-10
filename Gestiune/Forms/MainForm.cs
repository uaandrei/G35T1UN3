using System;
using System.Linq;
using System.Windows.Forms;
using Gestiune.Forms.Facturi;
using Gestiune.Forms.Firme;
using Gestiune.Reports;

namespace Gestiune.Forms
{
    // TODO: Wait cursor peste tot
    // TODO: formatare gridView peste tot
    // TODO: Facturi de iesire: fac update pe stoc in ordine lifo sau adauga stoc cu minus?
    // TODO: Daca fac front end mai trbuie sa pun undeva un castig, maresc TVA`ul.
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonFirmeClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.panelCategory.Controls.Clear();
            var uc = new FirmeUserControl();
            uc.Dock = DockStyle.Fill;
            this.panelCategory.Controls.Add(uc);
            Cursor.Current = Cursors.Default;
        }

        private void RapoarteBtnClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.panelCategory.Controls.Clear();
            var uc = new ReportUserControl();
            uc.Dock = DockStyle.Fill;
            this.panelCategory.Controls.Add(uc);
            Cursor.Current = Cursors.Default;
        }

        private void StocBtnClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            panelCategory.Controls.Clear();
            var uc = new FacturiUserControl();
            uc.Dock = DockStyle.Fill;
            panelCategory.Controls.Add(uc);
            Cursor.Current = Cursors.Default;
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
