using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormRepPuestosAutorizados : FormCR
    {
        public FormRepPuestosAutorizados()
        {
            InitializeComponent();
        }

        private void FormRepPuestosAutorizadosLoad(object sender, EventArgs e)
        {
            dsRepPuestosAutorizados1.Merge(new Service().GetPuestosAutorizados(Program.Pin));
            crPuestosAutorizados1.SetDataSource(dsRepPuestosAutorizados1);
        }
    }
}