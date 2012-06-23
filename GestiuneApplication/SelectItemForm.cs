using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using GestiuneBusiness.Poco.Kernel;

namespace GestiuneApplication
{
    public partial class SelectItemForm : Form
    {
        public List<GestiuneObject> Datas { get; set; }

        public GestiuneObject SelectedObject
        {
            get
            {
                try
                {
                    if (gestiuneObjGrid.SelectedCells.Count == 0) return null;
                    return (GestiuneObject)gestiuneObjGrid.Rows[gestiuneObjGrid.SelectedCells[0].RowIndex].DataBoundItem;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public SelectItemForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDataGrid(filterTbox.Text);
        }

        private void SelectItemForm_Load(object sender, EventArgs e)
        {
            SearchDataGrid();
        }

        private void SearchDataGrid(string filter = "")
        {
            gestiuneObjectBindingSource.DataSource = null;
            gestiuneObjectBindingSource.DataSource = Datas.Where(p => p.Contains(filter));
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gestiuneObjGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
