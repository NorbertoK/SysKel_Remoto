using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormReporteRemesa : Form1
    {
        public FormReporteRemesa()
        {
            InitializeComponent();
        }

        public int IdRemesa { get; set; }

        private void FormReporteRemesaLoad(object sender, EventArgs e)
        {
            dsReportRemesa1.Merge(new Service().GetReporteRemesa(IdRemesa, Program.Pin));
            crRemesa1.SetDataSource(dsReportRemesa1);
        }
    }
}