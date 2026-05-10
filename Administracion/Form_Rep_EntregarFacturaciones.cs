using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormRepEntregarFacturaciones : FormCR
    {
        public FormRepEntregarFacturaciones()
        {
            InitializeComponent();
        }

        public string Proceso { private get; set; }

        private void FormRepEntregarFacturacionesLoad(object sender, EventArgs e)
        {
            dsFacturaciones1.Merge(new Service().GetFacturacionesPorProceso(Proceso, Program.Pin));
            crEntregarFacturaciones1.SetDataSource(dsFacturaciones1);
            new Service().EliminarProceso(Proceso, Program.Pin);
        }
    }
}