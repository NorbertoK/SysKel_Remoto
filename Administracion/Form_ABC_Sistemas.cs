using System;
using System.ComponentModel;
using Administracion.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    public partial class FormABCSistemas : Form1
    {
        private FormPrincipal _fp;

        public FormABCSistemas()
        {
            InitializeComponent();
        }

        private void FormABCSistemasLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            dsSistemas.Merge(new Service().GetSistemas(Program.Pin));
            dsTiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
            dsTiposDeDocumento.Merge(new Service().GetTiposDeDocumento(Program.Pin));
            dsMotivosDevolucionCobranza.Merge(new Service().GetMotivosDevolucionCobranza(Program.Pin));
            dsCoberturas.Merge(new Service().GetCoberturas(Program.Pin));
            dsCodigos.Merge(new Service().GetCodigos(Program.Pin));
            dsTiposDeDestino.Merge(new Service().GetTiposDeDestino(Program.Pin));
            dsMotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            dsTandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            dsMedicamentos.Merge(new Service().GetMedicamentos(Program.Pin));
            dsPlanes.Merge(new Service().GetPlanes(Program.Pin));
            clientesListaBindingSource.DataSource = _fp.dsClientesLista;
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            dsRubros.Merge(new Service().GetRubrosQueAdmitenValores(Program.Pin));
        }

        private void Grabar()
        {
            Validate();
            sistemasBindingSource.EndEdit();
            dsSistemas.Merge(new Service().UpdateSistemas(dsSistemas, Program.Pin));
            ManejoDatos.AplicarUpdate(dsSistemas);
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
                Grabar();
            Close();
        }

        private void ParametrosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void UltraDropDownMotiDevCobCobroBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotiDevCobCobro.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMotiDevCobCambioPeriodoCobranzaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotiDevCobCambioPeriodoCobranza.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMotiDevCobBajaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotiDevCobBaja.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCoberturasBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCoberturas.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTiposDeDestinoBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTiposDeDestino.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownNdeCBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownNdeC.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownEmpleadosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownEmpleados.DisplayLayout.Bands[0].PerformAutoResizeColumns(false,
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownDNIBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownDNI.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMotiDevCobSaldoCeroBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotiDevCobSaldoCero.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownFacturaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownFactura.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCodigosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCodigos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownReciboBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownRecibo.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownMotivosDeBajaBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownMotivosDeBaja.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownTandasDeFacturacionBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownTandasDeFacturacion.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownRubros_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownRubros.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }
    }
}