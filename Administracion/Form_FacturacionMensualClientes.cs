using System;
using Administracion.WS;

namespace Administracion
{
    public partial class FormFacturacionMensualClientes : Form1
    {
        public FormFacturacionMensualClientes()
        {
            InitializeComponent();
        }

        private void FormFacturacionMensualAfiliadosLoad(object sender, EventArgs e)
        {
            var hoy = new Service().HoraActual(Program.Pin);
            var periodo = hoy.Day < 16 ? hoy : hoy.AddMonths(1);
            ultraDateTimeEditorPeriodo.Value = periodo;
            ultraDateTimeEditorPeriodo.Enabled = true;
            dsTandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            var fecha1 = ultraDateTimeEditorPeriodo.Value.ToString().Substring(6, 4) +
                         ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 2) +
                         "01";
            var periodo1 = ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 7);
            var idTandaDeFacturacion1 =
                (int) ultraComboTandasDeFacturacion.SelectedRow.Cells["idTandaDeFacturacion"].Value;
            ultraLabelMensaje.Text = "Espere, por favor...";
            ultraLabelMensaje.Update();
            var aux = new Service {Timeout = 60 * 60 * 1000};
            var cantidadComprobantes = aux.CantidadDeComprobantesDeFacturasRealizados(idTandaDeFacturacion1, fecha1,
                periodo1, Program.Pin);
            switch (cantidadComprobantes)
            {
                case 0:
                    ultraLabelMensaje.Text = "No se hicieron comprobantes.";
                    break;
                case 1:
                    ultraLabelMensaje.Text = "Se hizo 1 comprobante.";
                    break;
                default:
                    ultraLabelMensaje.Text = "Se hicieron " + cantidadComprobantes + " comprobantes.";
                    break;
            }
            //if (Settings.Default.Empresa == "SAE" && !File.Exists("c:\\MiCasa\\Estoy.txt"))
            //    new Service().EsMiPyme(Program.Pin);
            buttonAplicar.Visible = true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            // Es el botón Salir.
            Close();
        }

        private void UltraComboTandasDeFacturacionValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = ultraComboTandasDeFacturacion.Value != null;
        }
    }
}