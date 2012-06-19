using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestiuneBusiness.Poco.Administration;
using GestiuneBusiness.Enums;
using GestiuneBusiness.DataHelper.Kernel;

namespace GestiuneApplication.Administrare
{
    public partial class EditDrepturiPeRolForm : Form
    {
        public EditDrepturiPeRolForm()
        {
            InitializeComponent();
        }

        private void CheckRights()
        {
            var rightsForRole = RolDrept.GetAll().Where(p => p.IdRol == this.RolObject.ID && p.AreDrept == true).Select(p => p.DreptObject).ToList();
            foreach (DataGridViewRow row in drepturiGrid.Rows)
            {
                if (rightsForRole.Contains((Drept)row.DataBoundItem)) row.Cells["check"].Value = true;
            }
        }

        private void RefreshDreptList()
        {
            dreptBindingSource.DataSource = null;
            dreptBindingSource.DataSource = Drept.GetAll();
        }

        public Rol RolObject { get; set; }

        private void EditDrepturiPeRolForm_Load(object sender, EventArgs e)
        {
            RefreshDreptList();
            CheckRights();
            this.Text = String.Format("Drepturi pentru rolul: '{0}'", RolObject.Nume);
        }

        private void iesireBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in drepturiGrid.Rows)
            {
                var drept = (Drept)row.DataBoundItem;
                var areDrept = row.Cells["check"].Value;
                var rolDrept = RolDrept.GetAll().Where(p => p.IdDrept == drept.ID && p.IdRol == RolObject.ID).FirstOrDefault();
                if (rolDrept == null)
                {
                    rolDrept = new RolDrept();
                    rolDrept.IdRol = RolObject.ID;
                    rolDrept.IdDrept = drept.ID;
                }
                if (areDrept == null)
                {
                    rolDrept.AreDrept = false;
                }
                else
                {
                    rolDrept.AreDrept = (bool)areDrept;
                }
                var result = rolDrept.Save();
                if (row.Index == drepturiGrid.Rows.Count - 1)
                {
                    MessageBox.Show(result.Message);
                    if (result.Status == StatusEnum.Saved)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
