using System;
using System.ComponentModel;
using System.Windows.Forms;
using Administracion.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administracion.Properties.Resources;

//using Administracion.Properties;

namespace Administracion
{
    public partial class FormFacturaTotalmenteManual : Form1
    {
        private FormPrincipal _fp;

        public FormFacturaTotalmenteManual()
        {
            InitializeComponent();
        }

        private void Form_FacturaTotalmenteManual_Load(object sender, EventArgs e)
        {
            /*Que la fecha del comprobante sea la actual*/
            comprobantesUltraGrid.DisplayLayout.Bands["Comprobantes"].Columns["Fecha"].DefaultCellValue
            //comprobantesUltraGrid.Rows[0].Cells["Fecha"].Value
                =
                new Service().HoraActual(Program.Pin);
            _fp = (FormPrincipal) MdiParent;
            categoriasIVABindingSource.DataSource = _fp.dsCategoriasIVA;
            negociosBindingSource.DataSource = _fp.dsNegocios1;
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            dsParametros1.Merge(new Service().GetParametros(Program.Pin));
            dsTiposDeComprobante.Merge(new Service().GetTiposDeComprobante(Program.Pin));
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            totalesUltraGrid.DisplayLayout.Bands[0].AddNew();
        }

        private bool Verificado()
        {
            if (comprobantesUltraGrid.DisplayLayout.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay ningún dato.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["idCategoriaIVA"].Value == DBNull.Value &&
                comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["idCategoriaIVA"].Column.Hidden == false)
            {
                MessageBox.Show(
                    "Falta la Categoría de IVA.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comprobantesUltraGrid.Rows[0].Cells["Nombre"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta el nombre.",
                    "Imposible Grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (comprobantesUltraGrid.Rows[0].Cells["ObservacionesDireccion"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta la dirección.",
                    "Imposible Grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (comprobantesUltraGrid.Rows[0].ChildBands[0].Rows.Count == 0)
            {
                MessageBox.Show("Falta el Detalle.", "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            var ultimorenglon = comprobantesUltraGrid.Rows[0].ChildBands[0].Rows.Count - 1;
            if (comprobantesUltraGrid.Rows[0].ChildBands[0].Rows[ultimorenglon].Cells["Detalle"].Value ==
                DBNull.Value)
            {
                MessageBox.Show("Falta el campo Detalle.", "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (comprobantesUltraGrid.Rows[0].ChildBands[0].Rows[ultimorenglon].Cells["idPorcentajeIVA"].Value ==
                DBNull.Value)
            {
                MessageBox.Show("Falta el Porcentaje de IVA.", "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (comprobantesUltraGrid.Rows[0].ChildBands[0].Rows[ultimorenglon].Cells["idNegocio"].Value ==
                DBNull.Value && (bool) dsParametros1.Parametros.Rows[0]["UsaNegocios"])
            {
                MessageBox.Show("Falta el Negocio.", "Imposible Grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void comprobantesUltraGrid_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var renglonActivo = comprobantesUltraGrid.ActiveRow;
            if (renglonActivo.Band.Key == "Comprobantes")
            {
                if (renglonActivo.Cells["idCategoriaIVA"].Value == DBNull.Value &&
                    renglonActivo.Cells["idCategoriaIVA"].Hidden == false)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta la Categoría de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if ((renglonActivo.Cells["CUIT"].Value == DBNull.Value ||
                     renglonActivo.Cells["CUIT"].Text == "__-__,___,___-_" || renglonActivo.Cells["CUIT"].Text == "") &&
                    renglonActivo.Cells["CUIT"].Hidden == false)
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el CUIT.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (renglonActivo.Cells["CUIT"].Column.Header.Caption == @"CUIT")
                {
                    // Validación del CUIT, que no esté ingresado.
                    var sCUIT =
                        comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["CUIT"].Text.Replace(",", "")
                            .Replace("-", "");

                    if (sCUIT.Length == 11 &&
                        (int) _fp.dscuitRepetibles.CUITRepetibles.Compute("Count(CUIT)", "CUIT = " + sCUIT) == 0)
                    {
                        var nombClienteAnterior = new Service().NombreCuitIngresado(sCUIT, 0, Program.Pin);
                        if (nombClienteAnterior.Length > 0)
                        {
                            e.Cancel = true;
                            MessageBox.Show(this,
                                "El CUIT " +
                                comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["CUIT"].Text +
                                " ya figura en nuestros registros" +
                                Environment.NewLine + "perteneciendo a " +
                                nombClienteAnterior +
                                "." +
                                Environment.NewLine + Environment.NewLine +
                                "Esta factura es para Clientes NO registrados" +
                                Environment.NewLine +
                                "Por favor haga una factura para Clientes registrados."
                                ,
                                "Falta verificar el CUIT",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        /*Validación del CUIT, que sea válido*/

                        if (sCUIT.Length == 11)
                        {
                            var xa = int.Parse(sCUIT.Substring(0, 1)) * 5;
                            var xb = int.Parse(sCUIT.Substring(1, 1)) * 4;
                            var xc = int.Parse(sCUIT.Substring(2, 1)) * 3;
                            var xd = int.Parse(sCUIT.Substring(3, 1)) * 2;
                            var xe = int.Parse(sCUIT.Substring(4, 1)) * 7;
                            var xf = int.Parse(sCUIT.Substring(5, 1)) * 6;
                            var xg = int.Parse(sCUIT.Substring(6, 1)) * 5;
                            var xh = int.Parse(sCUIT.Substring(7, 1)) * 4;
                            var xi = int.Parse(sCUIT.Substring(8, 1)) * 3;
                            var xj = int.Parse(sCUIT.Substring(9, 1)) * 2;
                            var x = xa + xb + xc + xd + xe + xf + xg + xh + xi + xj;
                            var control = (11 - x % 11) % 11;
                            if (control != int.Parse(sCUIT.Substring(10, 1)))
                            {
                                e.Cancel = true;
                                MessageBox.Show("Inválido",
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                if (renglonActivo.Cells["Prefijo"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el prefijo.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Detalles
            {
                if (renglonActivo.Cells["idNegocio"].Value == DBNull.Value &&
                    (bool) dsParametros1.Parametros.Rows[0]["UsaNegocios"])
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el Negocio.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (renglonActivo.Cells["idPorcentajeIVA"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el porcentaje de IVA.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (renglonActivo.Cells["PrecioUnitarioImpreso"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Falta el Precio Unitario Impreso.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!Verificado()) return;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonAceptar.Refresh();
            buttonCancelar.Refresh();
            if (Grabar())
                Close();
        }

        private bool Grabar()
        {
            const bool ponerCobrador = false;
            Validate();
            comprobantesBindingSource.EndEdit();
            var aux = new Service().UpdateComprobantes(dsComprobantes, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos.",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                buttonCancelar.Enabled = true;
                return false;
            }

            dsComprobantes.Merge(aux);
            ManejoDatos.AplicarUpdate(dsComprobantes);
            var idComprobante = (int) comprobantesUltraGrid.Rows[0].Cells["idComprobante"].Value;
            new Service().HacerComprobanteDeFacturaManual(idComprobante,
                (decimal) totalesUltraGrid.Rows[0].Cells["Total"].Value, ponerCobrador, true, Program.Pin);
            return true;
        }

        private void ultraDropDownCategoriasIVA_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCategoriasIVA.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void comprobantesUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
            if (comprobantesUltraGrid.ActiveCell.Column.Key == "CUIT")
                comprobantesUltraGrid.ActiveCell.SelStart = 0;
        }

        private void ultraDropDownNegocios_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownNegocios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void comprobantesUltraGrid_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            if (e.Cell.Column.Key == "CUIT")
                if (e.Cell.Column.Header.Caption == @"CUIT")
                {
                    e.Cell.Column.Header.Caption = @"DNI";
                    e.Cell.Column.MaskInput = @"{LOC}nnn,nnn,nnn,nnn";
                }
                else
                {
                    e.Cell.Column.Header.Caption = @"CUIT";
                    e.Cell.Column.MaskInput = @"##-##,###,###-#";
                }
        }

        private void comprobantesUltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            var renglonActivo = e.Row;
            if (renglonActivo != null && renglonActivo.Band.Key == "Comprobantes")
                renglonActivo.Cells["CUIT"].ToolTipText = "Doble click para cambiar a DNI.";
        }

        private void comprobantesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comprobantesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void CalcularPrecioUnitarioEtc()
        {
            comprobantesUltraGrid.ActiveRow.Update();
            if (comprobantesUltraGrid.ActiveRow.Cells["PrecioUnitarioImpreso"].Value != DBNull.Value &&
                comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value != DBNull.Value &&
                comprobantesUltraGrid.ActiveRow.Cells["Cantidad"].Value != DBNull.Value)
            {
                comprobantesUltraGrid.ActiveRow.Cells["ImporteImpreso"].Value =
                    (decimal) comprobantesUltraGrid.ActiveRow.Cells["PrecioUnitarioImpreso"].Value *
                    (int) comprobantesUltraGrid.ActiveRow.Cells["Cantidad"].Value;
                if ((int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value > 2)
                    comprobantesUltraGrid.ActiveRow.Cells["Neto"].Value =
                        (decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteImpreso"].Value;
                else
                    comprobantesUltraGrid.ActiveRow.Cells["Neto"].Value = 0;
                comprobantesUltraGrid.ActiveRow.Cells["IVA"].Hidden = false;
                comprobantesUltraGrid.ActiveRow.Cells["IVA"].Value =
                    Math.Round((decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteImpreso"].Value *
                               dsPorcentajeIVA.PorcentajeIVA.FindByidPorcentajeIVA(
                                       (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value)
                                   .Porcentaje /
                               100, 2,
                        MidpointRounding.ToEven);
                comprobantesUltraGrid.ActiveRow.Cells["NoGravado"].Value =
                    (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value == 1
                        ? (decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteImpreso"].Value
                        : 0;
                comprobantesUltraGrid.ActiveRow.Cells["Exento"].Value =
                    (int) comprobantesUltraGrid.ActiveRow.Cells["idPorcentajeIVA"].Value == 2
                        ? (decimal) comprobantesUltraGrid.ActiveRow.Cells["ImporteImpreso"].Value
                        : 0;
                /*Empieza a calcular los totales*/
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Exento"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Neto"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["IVA"].Value = 0;
                totalesUltraGrid.Rows[0].Cells["Total"].Value = 0;
                foreach (
                    var renglon in
                    comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Rows)
                {
                    renglon.Update();
                    totalesUltraGrid.Rows[0].Cells["NoGravado"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["NoGravado"].Value +
                        (decimal) renglon.Cells["NoGravado"].Value;
                    totalesUltraGrid.Rows[0].Cells["Exento"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["Exento"].Value +
                        (decimal) renglon.Cells["Exento"].Value;
                    totalesUltraGrid.Rows[0].Cells["Neto"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["Neto"].Value + (decimal) renglon.Cells["Neto"].Value;
                    totalesUltraGrid.Rows[0].Cells["IVA"].Value =
                        // ReSharper disable once PossibleInvalidCastException
                        (decimal) totalesUltraGrid.Rows[0].Cells["IVA"].Value + (decimal) renglon.Cells["IVA"].Value;
                    if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeComprobante"].Text == "Factura B")
                        totalesUltraGrid.Rows[0].Cells["Total"].Value =
                            // ReSharper disable once PossibleInvalidCastException
                            (decimal) totalesUltraGrid.Rows[0].Cells["Total"].Value +
                            (decimal) renglon.Cells["ImporteImpreso"].Value;
                }

                totalesUltraGrid.Rows[0].Cells["Subtotal"].Value =
                    (totalesUltraGrid.Rows[0].Cells["NoGravado"].Value == DBNull.Value
                        ? 0
                        // ReSharper disable once PossibleInvalidCastException
                        : (decimal) totalesUltraGrid.Rows[0].Cells["NoGravado"].Value) +
                    (totalesUltraGrid.Rows[0].Cells["Exento"].Value == DBNull.Value
                        ? 0
                        // ReSharper disable once PossibleInvalidCastException
                        : (decimal) totalesUltraGrid.Rows[0].Cells["Exento"].Value) +
                    (totalesUltraGrid.Rows[0].Cells["Neto"].Value == DBNull.Value
                        ? 0
                        // ReSharper disable once PossibleInvalidCastException
                        : (decimal) totalesUltraGrid.Rows[0].Cells["Neto"].Value);
                if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeComprobante"].Text == "Factura A" ||
                    comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeComprobante"].Text == "Factura M")
                    totalesUltraGrid.Rows[0].Cells["Total"].Value =
                        (decimal) totalesUltraGrid.Rows[0].Cells["Subtotal"].Value +
                        (totalesUltraGrid.Rows[0].Cells["IVA"].Value == DBNull.Value
                            ? 0
                            // ReSharper disable once PossibleInvalidCastException
                            : (decimal) totalesUltraGrid.Rows[0].Cells["IVA"].Value);
                /*Termina de calcular los totales*/
            }
        }

        private void TipoDeComprobante(CellEventArgs e)
        {
            e.Cell.Row.Update();
            if (e.Cell.Row.Cells["Prefijo"].Text == "0000")
                e.Cell.Row.Cells["idTipoDeComprobante"].Value = 4;
            else if (e.Cell.Row.Cells["idCategoriaIVA"].Value == DBNull.Value)
                e.Cell.Row.Cells["idTipoDeComprobante"].Value = DBNull.Value;
            else
                e.Cell.Row.Cells["idTipoDeComprobante"].Value = dsTiposDeComprobante.TiposDeComprobante
                    .FindByidTipoDeComprobante(
                        _fp.dsCategoriasIVA.CategoriasIVA.FindByidCategoriaIVA(
                                (int) e.Cell.Row.Cells["idCategoriaIVA"].Value)
                            .Factura).idTipoDeComprobante;
            if (e.Cell.Row.Cells["idTipoDeComprobante"].Text == "Factura B")
            {
                comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                    "IVA"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["Exento"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["Neto"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["Subtotal"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["IVA"].Hidden = true;
            }
            else
            {
                comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                    "IVA"].Hidden = false;
                if ((bool) dsParametros1.Parametros.Rows[0]["UsaNegocios"] == false)
                    comprobantesUltraGrid.Rows[0].ChildBands["FK__DetallesC__idCom__07AC1A97"].Band.Columns[
                        "idNegocio"].Hidden = true;
                totalesUltraGrid.Rows[0].Cells["NoGravado"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["Exento"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["Neto"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["Subtotal"].Hidden = false;
                totalesUltraGrid.Rows[0].Cells["IVA"].Hidden = false;
            }
        }

        private void comprobantesUltraGrid_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (comprobantesUltraGrid.ActiveCell.Column.Key == "PrecioUnitario" ||
                comprobantesUltraGrid.ActiveCell.Column.Key == "Cantidad")
                CalcularPrecioUnitarioEtc();
        }

        private void comprobantesUltraGrid_CellChange(object sender, CellEventArgs e)
        {
            comprobantesUltraGrid.Update();
            totalesUltraGrid.Update();
            if (e.Cell.Column.Key == "idPorcentajeIVA")
            {
                e.Cell.Row.Update();
                CalcularPrecioUnitarioEtc();
            }
            //if (e.Cell.Column.Key == "Prefijo")
            //{
            //    TipoDeComprobante(e);
            //    if (e.Cell.Text == "0000")
            //    {
            //        //e.Cell.Row.Cells["idCategoriaIVA"].Value = DBNull.Value;
            //        comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["idCategoriaIVA"].Hidden = true;
            //        e.Cell.Row.Cells["CUIT"].Value = DBNull.Value;
            //        comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["CUIT"].Hidden = true;
            //    }
            //    else
            //    {
            //        comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["idCategoriaIVA"].Hidden = false;
            //        e.Cell.Row.Band.Columns["CUIT"].Hidden = false;
            //    }
            //    if ((int) ultraDropDownPrefijo.SelectedRow.Cells["SolicitaCAE"].Value > 0)
            //    {
            //        comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["NumeroDeComprobante"].Hidden = true;
            //        comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["NumeroDeComprobante"].Value = "99990000";
            //    }
            //    else
            //    {
            //        comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["NumeroDeComprobante"].Hidden = false;
            //        if (comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["NumeroDeComprobante"].Value.ToString() ==
            //            "99990000")
            //            comprobantesUltraGrid.DisplayLayout.Rows[0].Cells["NumeroDeComprobante"].Value = DBNull.Value;
            //    }
            //}
            if (e.Cell.Column.Key == "Prefijo")
                if (ultraDropDownPrefijo.SelectedRow.Cells["SolicitaCAE"].Value != DBNull.Value &&
                    (int)ultraDropDownPrefijo.SelectedRow.Cells["SolicitaCAE"].Value > 0 ||
                    ultraDropDownPrefijo.SelectedRow.Cells["SolicitaCAE"].Value == DBNull.Value ||
                    (string)ultraDropDownPrefijo.SelectedRow.Cells["Prefijo"].Value == "0000")
                {
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["NumeroDeComprobante"].Hidden = true;
                    comprobantesUltraGrid.Rows[0].Cells["NumeroDeComprobante"].Value =
                        "99990000";
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["Fecha"].Hidden = true;
                    comprobantesUltraGrid.Rows[0].Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["idTipoDeComprobante"].CellActivation =
                        Activation.ActivateOnly;
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["idTipoDeComprobante"].CellAppearance
                        .ImageBackground = Resources.Verde;
                    //CalcularPrecioUnitarioEtc();
                }
                else
                {
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["NumeroDeComprobante"].Hidden = false;
                    if (comprobantesUltraGrid.Rows[0].Cells["NumeroDeComprobante"].Value
                            .ToString() == "99990000")
                        comprobantesUltraGrid.Rows[0].Cells["NumeroDeComprobante"].Value =
                            DBNull.Value;
                    comprobantesUltraGrid.Rows[0].Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["Fecha"].Hidden = false;
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["idTipoDeComprobante"].CellActivation =
                        Activation.AllowEdit;
                    comprobantesUltraGrid.DisplayLayout.Bands[0].Columns["idTipoDeComprobante"].CellAppearance
                        .ImageBackground = null;
                }
            if (e.Cell.Column.Key == "idCategoriaIVA")
                TipoDeComprobante(e);
        }

        private void comprobantesUltraGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
        }
    }
}