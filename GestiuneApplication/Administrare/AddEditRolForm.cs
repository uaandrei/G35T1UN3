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

namespace GestiuneApplication.Administrare
{
    public partial class AddEditRolForm : Form
    {
        public AddEditRolForm()
        {
            InitializeComponent();
        }

        public Rol RolObject { get; set; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            RolObject.Descriere = descriereTbox.Text;
            RolObject.Nume = numeTbox.Text;
            var errors = RolObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = RolObject.Save();
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddEditRolForm_Load(object sender, EventArgs e)
        {
            if (RolObject == null)
            {
                this.Text = "Adauga rol";
                RolObject = new Rol();
            }
            else
            {
                this.Text = "Modifica rol";
                descriereTbox.Text = RolObject.Descriere;
                numeTbox.Text = RolObject.Nume;
            }
        }
    }
}
