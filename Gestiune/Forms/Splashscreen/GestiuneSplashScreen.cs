using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using GestiuneBusiness.Poco;

namespace Gestiune.Forms.Splashscreen
{
    public partial class GestiuneSplashScreen : Form
    {
        public GestiuneSplashScreen()
        {
            InitializeComponent();
        }

        private const int TotalCostOfLoadingOperations = 100; // 100 percent => loaded everything
        private const int OperationsCount = 7;

        private void LoadData()
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new MethodInvoker(LoadData));
                return;
            }
            progressBar.PerformStep();
            Banca.GetAll();
            progressBar.PerformStep();
            Delegat.GetAll();
            progressBar.PerformStep();
            Factura.GetAll();
            progressBar.PerformStep();
            Firma.GetAll();
            progressBar.PerformStep();
            Produs.GetAll();
            progressBar.PerformStep();
            // TODO: Plata.GetAll();
            Stoc.GetAll();
            FacturaProdusStoc.GetAll();
            progressBar.PerformStep();
            this.Close();
        }

        private void GestiuneSplashScreen_Shown(object sender, EventArgs e)
        {
            progressBar.Step = (TotalCostOfLoadingOperations / OperationsCount) + 1;
            Thread loadData = new Thread(LoadData);
            loadData.Start();
        }
    }
}
