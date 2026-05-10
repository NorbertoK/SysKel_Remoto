using System;
using System.Drawing;
using System.Windows.Forms;
using Administracion.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    public partial class FormReporteListadoAfiliadosDeBaja : Form1
    {
        private FormPrincipal _fp;

        public FormReporteListadoAfiliadosDeBaja()
        {
            InitializeComponent();
        }

        private void FormReporteListadoAfiliadosDeBaja_Load(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            planesBindingSource.DataSource = _fp.dsPlanes;
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorDesde.Value = ahora.AddMonths(-1).AddDays(-(ahora.Day - 1));
            ultraDateTimeEditorHasta.Value = ahora.AddDays(-ahora.Day);
        }

        private void ultraComboModo_RowSelected(object sender, RowSelectedEventArgs e)
        {
            if (e.Row.Cells["Id"].Value.ToString() == "UnPlan")
            {
                buttonAceptar.Enabled = false;
                ultraLabelPlan.Enabled = true;
                ultraComboPlanes.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = true;
                ultraComboPlanes.Value = DBNull.Value;
                ultraLabelPlan.Enabled = false;
                ultraComboPlanes.Enabled = false;
            }
        }

        private void ultraComboPlanes_RowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonCancelar.Enabled = false;
            buttonAceptar.Enabled = false;
            var desde = ultraDateTimeEditorDesde.Text.Substring(6,4)+ultraDateTimeEditorDesde.Text.Substring(3,2)+ultraDateTimeEditorDesde.Text.Substring(0,2);
            var hasta = ultraDateTimeEditorHasta.Text.Substring(6,4)+ultraDateTimeEditorHasta.Text.Substring(3,2)+ultraDateTimeEditorHasta.Text.Substring(0,2);
            var f = new FormRepListadoAfiliadosDeBaja
            {
                Desde = desde,
                Hasta = hasta,
                Modo = ultraComboModo.Value.ToString(),
                IdPlan = ultraComboPlanes.Value == null ? 0 : (int) ultraComboPlanes.Value,
                Titulo =
                    ultraComboModo.Text == "Un Plan"
                        ? "Afiliados de baja Plan " + ultraComboPlanes.Text + "  " + ultraDateTimeEditorDesde.Text + " - " +
                          ultraDateTimeEditorHasta.Text + "."
                        : "Afiliados de baja " + ultraComboModo.Text + " " + ultraDateTimeEditorDesde.Text + " - " +
                          ultraDateTimeEditorHasta.Text + ".",
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            Close();
        }
    }
}