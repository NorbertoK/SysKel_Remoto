using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Administracion
{
    public partial class FormRDLC : Form1
    {
        public FormRDLC()
        {
            InitializeComponent();
        }

        private void FormRDLC_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
