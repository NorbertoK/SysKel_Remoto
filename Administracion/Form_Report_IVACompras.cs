using System;
using System.Drawing;
using System.Windows.Forms;
using Administracion.WS;

namespace Administracion
{
    public partial class FormReportIVACompras : Form1
    {
        public FormReportIVACompras()
        {
            InitializeComponent();
        }

        private void FormReportIVACompras_Load(object sender, EventArgs e)
        {
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            ultraCalendarComboDesde.Value =
                new Service().HoraActual(Program.Pin).AddMonths(-1).AddDays(
                    -(new Service().HoraActual(Program.Pin).Day - 1));
            ultraCalendarComboHasta.Value =
                new Service().HoraActual(Program.Pin).AddDays(-new Service().HoraActual(Program.Pin).Day);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var f = new FormRepIVACompras
            {
                Desde = (DateTime) ultraCalendarComboDesde.Value,
                Hasta = (DateTime) ultraCalendarComboHasta.Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}