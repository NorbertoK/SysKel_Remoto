using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormRepDatosPrestaciones : FormCR
    {
        public FormRepDatosPrestaciones()
        {
            InitializeComponent();
        }

        public DateTime Desde { private get; set; }
        public DateTime Hasta { private get; set; }

        private void FomRepDatosPrestacionesLoad(object sender, EventArgs e)
        {
            var aux = new Service {Timeout = 60 * 60 * 1000};
            dsDatosPrestaciones1.Merge(aux.GetDatosPrestaciones(Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"),
                Program.Pin));
            crDatosPrestaciones1.SetDataSource(dsDatosPrestaciones1);
        }
    }
}