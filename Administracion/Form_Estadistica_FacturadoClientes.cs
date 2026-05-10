using System;
using System.Drawing;
using System.Windows.Forms;
using Administracion.WS;

namespace Administracion
{
    public partial class FormEstadisticaFacturadoClientes : Form1
    {
        public FormEstadisticaFacturadoClientes()
        {
            InitializeComponent();
        }

        private void FormEstadisticaFacturadoClientesLoad(object sender, EventArgs e)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorPeriodoDesde.Value = ahora.AddMonths(-12);
            ultraDateTimeEditorPeriodoHasta.Value = ahora.AddMonths(-1);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var f = new FormRepFacturadoClientes
            {
                DesdePeriodo = ultraDateTimeEditorPeriodoDesde.Text,
                HastaPeriodo = ultraDateTimeEditorPeriodoHasta.Text,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            Close();
        }
    }
}