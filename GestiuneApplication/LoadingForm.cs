using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GestiuneBusiness.Poco;
using GestiuneBusiness.Poco.Administration;

namespace GestiuneApplication
{
    public partial class LoadingForm : Form
    {
        private const int Operations = 15;
        private const int Maximum = 100;
        private delegate void UpdateDelegate();

        public LoadingForm()
        {
            InitializeComponent();
            progressBar.Maximum = Maximum;
            progressBar.Step = (Maximum / Operations) + 1;
        }

        private void UpdateProgressBar()
        {
            progressBar.PerformStep();
        }

        private void LoadData()
        {
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca bancile...";
            Banca.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca delegatii...";
            Delegat.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca drepturile...";
            Drept.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca facturile...";
            FacturaIntrare.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca facturile...";
            FacturaIesire.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca firmele...";
            Firma.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca platile...";
            Plata.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca platile...";
            PlataFactura.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca platile...";
            PozitieFacturaIesire.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca platile...";
            PozitieFacturaIntrare.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca produsele...";
            Produs.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca rolurile...";
            Rol.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca platile...";
            RolDrept.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca stocurile...";
            Stoc.GetAll();
            progressBar.Invoke(new UpdateDelegate(UpdateProgressBar));
            runningOperationLbl.Text = "Se incarca utilizatorii...";
            Utilizator.GetAll();
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            LoadData();
            this.Close();
        }
    }
}
