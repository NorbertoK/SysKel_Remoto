using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormReporteArqueo : Form1
    {
        public FormReporteArqueo()
        {
            InitializeComponent();
        }

        public int IdArqueo { get; set; }

        private void FormReporteArqueoLoad(object sender, EventArgs e)
        {
            dsReportArqueo1.Merge(new Service().ObtenerDatosArqueo(IdArqueo, Program.Pin));
            crArqueo1.SetDataSource(dsReportArqueo1);
        }
    }
}