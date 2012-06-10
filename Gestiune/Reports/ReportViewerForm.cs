using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestiune.Reports
{
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm()
        {
            InitializeComponent();
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {

            this.ReportViewer.RefreshReport();
        }
    }
}
