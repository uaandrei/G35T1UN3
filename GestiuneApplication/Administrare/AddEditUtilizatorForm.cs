﻿using System;
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
    public partial class AddEditUtilizatorForm : Form
    {
        public AddEditUtilizatorForm()
        {
            InitializeComponent();
            rolCmb.DataSource = Rol.GetAll();
        }

        public Utilizator UtilizatorObject { get; set; }

        private void AddEditUtilizatorForm_Load(object sender, EventArgs e)
        {
            if (UtilizatorObject == null)
            {
                UtilizatorObject = new Utilizator();
                this.Text = "Adauga utilizator";
            }
            else
            {
                this.Text = "Modifica utilizator";
                numeTbox.Text = UtilizatorObject.Nume;
                parolaTbox.Text = UtilizatorObject.Parola;
                rolCmb.SelectedValue = UtilizatorObject.IdRol;
                activeCkbox.Checked = UtilizatorObject.Activ;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (numeTbox.Text.ToLower() == "admin")
            {
                MessageBox.Show("Nu puteti adauga un utilizator cu acest nume!");
                return;
            }
            UtilizatorObject.Activ = activeCkbox.Checked;
            UtilizatorObject.IdRol = rolCmb.SelectedValue == null ? 0 : (int)rolCmb.SelectedValue;
            UtilizatorObject.Nume = numeTbox.Text;
            UtilizatorObject.Parola = parolaTbox.Text;
            var errors = UtilizatorObject.GetErrorString();
            if (errors.Trim() == string.Empty)
            {
                var result = UtilizatorObject.Save();
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
    }
}
