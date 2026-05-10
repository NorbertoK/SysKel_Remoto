using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormProviDireccionesSinZona : Form1
    {
        public FormProviDireccionesSinZona()
        {
            InitializeComponent();
        }

        private void FormProviDireccionesSinZonaLoad(object sender, EventArgs e)
        {
            dsProviDireccionesSinZona1.Merge(new Service().GetDireciconesSinZona(Program.Pin));
            crProviDireccionesSinZona1.SetDataSource(dsProviDireccionesSinZona1);
        }
    }
}