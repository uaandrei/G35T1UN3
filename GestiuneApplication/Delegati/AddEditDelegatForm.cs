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

namespace GestiuneApplication.Delegati
{
    public partial class AddEditDelegatForm : Form
    {
        public AddEditDelegatForm()
        {
            InitializeComponent();
        }

        public Delegat DelegatObject { get; set; }

        private void AddEditDelegatForm_Load(object sender, EventArgs e)
        {
            if (DelegatObject == null)
            {
                DelegatObject = new Delegat();
                this.Text = "Adauga delegat";
            }
            else
            {
                this.Text = "Modifica delegat";
                cnpTbox.Text = DelegatObject.Cnp;
                numeTbox.Text = DelegatObject.Nume;
                serieTbox.Text = DelegatObject.Serie;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DelegatObject.Cnp = cnpTbox.Text;
            DelegatObject.Nume = numeTbox.Text;
            DelegatObject.Serie = serieTbox.Text;
            var errors = DelegatObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = DelegatObject.Save();
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
    }
}
