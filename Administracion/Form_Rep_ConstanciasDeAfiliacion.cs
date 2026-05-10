using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormRepConstanciasDeAfiliacion : FormCR
    {
        private string _periodo = "";

        public FormRepConstanciasDeAfiliacion()
        {
            InitializeComponent();
        }

        public string Periodo
        {
            private get { return _periodo; }
            set { _periodo = value; }
        }

        public int IdCliente { private get; set; }

        public int IdContrato { private get; set; }

        public int IdPlan { private get; set; }

        private void FormRepConstanciasDeAfiliacionLoad(object sender, EventArgs e)
        {
            var aux = new Service {Timeout = 60 * 60 * 1000};
            dsRepConstanciasAfiliacion1.Merge(aux.GetConstanciasAfiliacion(Periodo, IdCliente, IdContrato, IdPlan,
                Program.Pin));
            crConstanciasAfiliacion1.SetDataSource(dsRepConstanciasAfiliacion1);
        }
    }
}