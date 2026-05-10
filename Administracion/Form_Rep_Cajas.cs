using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormRepCajas : FormCR
    {
        public FormRepCajas()
        {
            InitializeComponent();
        }

        private void FormRepCajasLoad(object sender, EventArgs e)
        {
            dsCajas1.Merge(new Service().GetCajas(Program.Pin));
            crCajas1.SetDataSource(dsCajas1);
        }
    }
}