using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestiuneApplication
{
    public partial class AppCrashForm : Form
    {
        public AppCrashForm()
        {
            InitializeComponent();
        }

        public void SetDetails(Exception ex, string message)
        {
            var stackTrace = ex.StackTrace;
            var errorMsg = "Exceptii aparute" + Environment.NewLine;
            errorMsg += "----------------------------" + Environment.NewLine;
            while (ex != null)
            {
                errorMsg += ex.Message + Environment.NewLine;
                ex = ex.InnerException;
            }
            errorMsg += "----------------------------" + Environment.NewLine;
            errorMsg += Environment.NewLine;
            errorMsg += "Stiva de executie" + Environment.NewLine;
            errorMsg += "----------------------------" + Environment.NewLine;
            errorMsg += stackTrace;
            messageTbox.Text = message;
            crashDetailsTbox.Text = errorMsg;
        }
    }
}
