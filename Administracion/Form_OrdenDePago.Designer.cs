namespace Administracion
{
    partial class FormOrdenDePago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("OrdenesDePago", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn223 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOrdenDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn224 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor", -1, "ultraDropDownProveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn225 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn226 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn227 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn228 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado", -1, "ultraDropDownCajas");
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn229 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesOrdenesDePago_OrdenesDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn230 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ValoresRetiros_OrdenesDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn231 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_OrdenesDePago_LibroDiario");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesOrdenesDePago_OrdenesDePago", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn232 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobanteOrdenDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn233 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOrdenDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn234 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn235 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImportePagado");
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn236 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn237 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCompra");
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn238 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ComprobanteCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn239 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn240 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoCompra");
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumCompras", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImportePagado", 3, true, "FK_ComprobantesOrdenesDePago_OrdenesDePago", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("CantComprobantes", Infragistics.Win.UltraWinGrid.SummaryType.Count, null, "idCompra", 2, true, "FK_ComprobantesOrdenesDePago_OrdenesDePago", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "FechaCompra", 5, true);
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ValoresRetiros_OrdenesDePago", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn241 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor", -1, "ultraDropDownTiposDeValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn242 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn243 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn244 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco", -1, "ultraDropDownBancos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn245 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCheque");
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn246 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn247 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRetiro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn248 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRetiro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn249 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOrdenDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn250 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Transferido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn251 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteTransferido");
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn252 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn253 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Efectivo", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn254 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosValores", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn255 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsEfectivo", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn256 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EnCaja", 3);
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumEfectivo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Efectivo", 0, false, "FK_ValoresRetiros_OrdenesDePago", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, "ImporteTransferido", 10, true);
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings4 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumOtrosValores", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "OtrosValores", 1, false, "FK_ValoresRetiros_OrdenesDePago", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, "ImporteTransferido", 10, true);
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings5 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumValores", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteTransferido", 10, true, "FK_ValoresRetiros_OrdenesDePago", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, null, -1, false);
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_OrdenesDePago_LibroDiario", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn257 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLibroDiario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn258 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn259 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Debe");
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn260 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Haber");
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn261 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOrdenDePago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn262 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings6 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalDebe", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Debe", 2, true, "FK_OrdenesDePago_LibroDiario", 3, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Debe", 2, true);
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings7 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalHaber", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Haber", 3, true, "FK_OrdenesDePago_LibroDiario", 3, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Haber", 3, true);
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn204 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn205 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn206 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn207 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn208 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn209 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn210 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Bancos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn211 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn212 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeValores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn213 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn214 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn215 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn216 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsEfectivo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn217 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SePagaCon");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Rubros", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn218 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn219 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn220 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AdmiteValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn221 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn222 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn178 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn179 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn180 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn181 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn182 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn183 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn184 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn185 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn186 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn187 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn188 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn189 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn190 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn191 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn192 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn193 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn194 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn195 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn196 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn197 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn198 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn199 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn200 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn201 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn202 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn203 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.ordenDePagoUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.ordenesDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrdenDePago = new Administracion.WS.DsOrdenDePago();
            this.ultraDropDownCajas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Administracion.WS.DsEmpleadosLista();
            this.ultraDropDownBancos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBancos = new Administracion.WS.DsBancos();
            this.ultraDropDownTiposDeValores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeValoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeValores = new Administracion.WS.DsTiposDeValores();
            this.ultraDropDownRubros = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRubros = new Administracion.WS.DsRubros();
            this.ultraDropDownProveedores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProveedores = new Administracion.WS.DsProveedores();
            this.dsEnCaja1 = new Administracion.WS.DsEnCaja();
            this.dsSistemas = new Administracion.WS.DsSistemas();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDePagoUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnCaja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(857, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(776, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 554);
            this.panel1.Size = new System.Drawing.Size(947, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(695, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ordenDePagoUltraGrid
            // 
            this.ordenDePagoUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenDePagoUltraGrid.CalcManager = this.ultraCalcManager1;
            this.ordenDePagoUltraGrid.DataSource = this.ordenesDePagoBindingSource;
            appearance51.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ordenDePagoUltraGrid.DisplayLayout.Appearance = appearance51;
            ultraGridColumn223.Header.VisiblePosition = 0;
            ultraGridColumn223.Hidden = true;
            ultraGridColumn224.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn224.Header.VisiblePosition = 2;
            ultraGridColumn224.Hidden = true;
            ultraGridColumn224.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn225.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn225.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn225.Header.Caption = "Grabador";
            ultraGridColumn225.Header.VisiblePosition = 3;
            ultraGridColumn225.Hidden = true;
            ultraGridColumn225.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn225.Width = 232;
            ultraGridColumn226.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn226.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance119.TextHAlignAsString = "Center";
            ultraGridColumn226.CellAppearance = appearance119;
            ultraGridColumn226.Header.VisiblePosition = 1;
            ultraGridColumn226.Hidden = true;
            ultraGridColumn226.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn226.MaskInput = "dd/mm/yyyy";
            ultraGridColumn226.Width = 91;
            ultraGridColumn227.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance120.TextHAlignAsString = "Right";
            ultraGridColumn227.CellAppearance = appearance120;
            ultraGridColumn227.Header.VisiblePosition = 4;
            ultraGridColumn227.Hidden = true;
            ultraGridColumn227.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn227.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn227.Width = 87;
            ultraGridColumn228.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance121.FontData.BoldAsString = "True";
            appearance121.FontData.SizeInPoints = 11F;
            appearance121.TextHAlignAsString = "Left";
            ultraGridColumn228.Header.Appearance = appearance121;
            ultraGridColumn228.Header.Caption = "Caja";
            ultraGridColumn228.Header.VisiblePosition = 5;
            ultraGridColumn228.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(156, 0);
            ultraGridColumn228.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn229.Header.VisiblePosition = 7;
            ultraGridColumn230.Header.VisiblePosition = 8;
            ultraGridColumn231.Header.VisiblePosition = 6;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn223,
            ultraGridColumn224,
            ultraGridColumn225,
            ultraGridColumn226,
            ultraGridColumn227,
            ultraGridColumn228,
            ultraGridColumn229,
            ultraGridColumn230,
            ultraGridColumn231});
            ultraGridBand13.MaxRows = 1;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn232.Header.VisiblePosition = 0;
            ultraGridColumn232.Hidden = true;
            ultraGridColumn233.Header.VisiblePosition = 1;
            ultraGridColumn233.Hidden = true;
            ultraGridColumn234.Header.VisiblePosition = 2;
            ultraGridColumn234.Hidden = true;
            appearance122.TextHAlignAsString = "Right";
            ultraGridColumn235.CellAppearance = appearance122;
            ultraGridColumn235.Header.Caption = "Pagado";
            ultraGridColumn235.Header.VisiblePosition = 6;
            ultraGridColumn235.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn235.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn236.Header.VisiblePosition = 7;
            ultraGridColumn236.Width = 252;
            appearance123.TextHAlignAsString = "Center";
            ultraGridColumn237.CellAppearance = appearance123;
            ultraGridColumn237.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn237.Header.Caption = "Fecha";
            ultraGridColumn237.Header.VisiblePosition = 3;
            ultraGridColumn237.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(87, 0);
            ultraGridColumn237.Width = 75;
            ultraGridColumn238.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn238.Header.Caption = "Comprobante";
            ultraGridColumn238.Header.VisiblePosition = 4;
            ultraGridColumn239.Header.VisiblePosition = 8;
            ultraGridColumn239.Hidden = true;
            appearance124.TextHAlignAsString = "Right";
            ultraGridColumn240.CellAppearance = appearance124;
            ultraGridColumn240.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn240.Header.Caption = "Saldo";
            ultraGridColumn240.Header.VisiblePosition = 5;
            ultraGridColumn240.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn240.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn232,
            ultraGridColumn233,
            ultraGridColumn234,
            ultraGridColumn235,
            ultraGridColumn236,
            ultraGridColumn237,
            ultraGridColumn238,
            ultraGridColumn239,
            ultraGridColumn240});
            appearance125.FontData.BoldAsString = "True";
            appearance125.FontData.SizeInPoints = 11F;
            appearance125.TextHAlignAsString = "Left";
            ultraGridBand14.Header.Appearance = appearance125;
            ultraGridBand14.Header.Caption = "Comprobantes";
            ultraGridBand14.HeaderVisible = true;
            ultraGridBand14.Hidden = true;
            ultraGridBand14.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand14.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            appearance126.FontData.BoldAsString = "True";
            appearance126.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance126;
            summarySettings1.DisplayFormat = "{0:c}";
            summarySettings1.GroupBySummaryValueAppearance = appearance127;
            appearance128.FontData.BoldAsString = "True";
            summarySettings2.Appearance = appearance128;
            summarySettings2.DisplayFormat = "{0:#####} comprobantes";
            summarySettings2.GroupBySummaryValueAppearance = appearance129;
            ultraGridBand14.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1,
            summarySettings2});
            ultraGridColumn241.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn241.Header.Caption = "Tipo de Valor";
            ultraGridColumn241.Header.VisiblePosition = 0;
            ultraGridColumn241.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn241.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn241.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn241.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn241.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn241.Width = 75;
            appearance130.TextHAlignAsString = "Right";
            ultraGridColumn242.CellAppearance = appearance130;
            ultraGridColumn242.Header.Caption = "En Caja";
            ultraGridColumn242.Header.VisiblePosition = 1;
            ultraGridColumn242.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn242.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn242.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn242.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn242.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn242.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn243.Header.VisiblePosition = 2;
            ultraGridColumn243.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn243.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn243.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(177, 0);
            ultraGridColumn243.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn243.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn244.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn244.Header.Caption = "Banco";
            ultraGridColumn244.Header.VisiblePosition = 3;
            ultraGridColumn244.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn244.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn244.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn244.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn244.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            appearance131.TextHAlignAsString = "Right";
            ultraGridColumn245.CellAppearance = appearance131;
            ultraGridColumn245.Header.Caption = "Nº de Cheque";
            ultraGridColumn245.Header.VisiblePosition = 4;
            ultraGridColumn245.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn245.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn245.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(92, 0);
            ultraGridColumn245.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn245.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn245.Width = 252;
            appearance132.TextHAlignAsString = "Center";
            ultraGridColumn246.CellAppearance = appearance132;
            ultraGridColumn246.Header.Caption = "Fecha";
            ultraGridColumn246.Header.VisiblePosition = 5;
            ultraGridColumn246.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn246.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn246.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn246.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn247.Header.VisiblePosition = 6;
            ultraGridColumn247.Hidden = true;
            ultraGridColumn247.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn247.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn247.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn247.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn248.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn248.Header.VisiblePosition = 7;
            ultraGridColumn248.Hidden = true;
            ultraGridColumn248.RowLayoutColumnInfo.OriginX = 20;
            ultraGridColumn248.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn248.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn248.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn249.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn249.Header.VisiblePosition = 8;
            ultraGridColumn249.Hidden = true;
            ultraGridColumn249.RowLayoutColumnInfo.OriginX = 22;
            ultraGridColumn249.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn249.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn249.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn250.Header.Caption = "Pagado";
            ultraGridColumn250.Header.VisiblePosition = 9;
            ultraGridColumn250.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn250.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn250.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn250.RowLayoutColumnInfo.SpanY = 2;
            appearance133.TextHAlignAsString = "Right";
            ultraGridColumn251.CellAppearance = appearance133;
            ultraGridColumn251.Header.Caption = "Importe Pagado";
            ultraGridColumn251.Header.VisiblePosition = 10;
            ultraGridColumn251.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn251.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn251.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn251.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn251.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn251.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn252.Header.VisiblePosition = 11;
            ultraGridColumn252.Hidden = true;
            ultraGridColumn253.DataType = typeof(decimal);
            ultraGridColumn253.Formula = "if( [EsEfectivo] , [ImporteTransferido] , 0 )";
            ultraGridColumn253.Header.VisiblePosition = 12;
            ultraGridColumn253.Hidden = true;
            ultraGridColumn253.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn253.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn254.DataType = typeof(decimal);
            ultraGridColumn254.Formula = "if( [EsEfectivo] , 0 , [ImporteTransferido] )";
            ultraGridColumn254.Header.VisiblePosition = 13;
            ultraGridColumn254.Hidden = true;
            ultraGridColumn254.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn254.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn255.DataType = typeof(bool);
            ultraGridColumn255.Header.VisiblePosition = 14;
            ultraGridColumn255.Hidden = true;
            ultraGridColumn256.DataType = typeof(bool);
            ultraGridColumn256.DefaultCellValue = false;
            ultraGridColumn256.Header.VisiblePosition = 15;
            ultraGridColumn256.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn241,
            ultraGridColumn242,
            ultraGridColumn243,
            ultraGridColumn244,
            ultraGridColumn245,
            ultraGridColumn246,
            ultraGridColumn247,
            ultraGridColumn248,
            ultraGridColumn249,
            ultraGridColumn250,
            ultraGridColumn251,
            ultraGridColumn252,
            ultraGridColumn253,
            ultraGridColumn254,
            ultraGridColumn255,
            ultraGridColumn256});
            appearance134.FontData.BoldAsString = "True";
            appearance134.FontData.SizeInPoints = 11F;
            appearance134.TextHAlignAsString = "Left";
            ultraGridBand15.Header.Appearance = appearance134;
            ultraGridBand15.Header.Caption = "Valores";
            ultraGridBand15.HeaderVisible = true;
            ultraGridBand15.Hidden = true;
            ultraGridBand15.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand15.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            appearance135.FontData.BoldAsString = "True";
            appearance135.TextHAlignAsString = "Right";
            summarySettings3.Appearance = appearance135;
            summarySettings3.DisplayFormat = "Efectivo {0:c}";
            summarySettings3.GroupBySummaryValueAppearance = appearance136;
            appearance137.FontData.BoldAsString = "True";
            appearance137.TextHAlignAsString = "Right";
            summarySettings4.Appearance = appearance137;
            summarySettings4.DisplayFormat = "Otros Valores {0:c}";
            summarySettings4.GroupBySummaryValueAppearance = appearance138;
            appearance139.FontData.BoldAsString = "True";
            appearance139.TextHAlignAsString = "Right";
            summarySettings5.Appearance = appearance139;
            summarySettings5.DisplayFormat = "Efectivo + Otros Valores {0:c}";
            summarySettings5.GroupBySummaryValueAppearance = appearance140;
            ultraGridBand15.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings3,
            summarySettings4,
            summarySettings5});
            ultraGridColumn257.Header.VisiblePosition = 0;
            ultraGridColumn257.Hidden = true;
            ultraGridColumn258.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn258.Header.Caption = "Rubro";
            ultraGridColumn258.Header.VisiblePosition = 1;
            ultraGridColumn258.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(203, 0);
            ultraGridColumn258.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn258.Width = 75;
            appearance141.TextHAlignAsString = "Right";
            ultraGridColumn259.CellAppearance = appearance141;
            ultraGridColumn259.Header.VisiblePosition = 2;
            ultraGridColumn259.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn259.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            appearance142.TextHAlignAsString = "Right";
            ultraGridColumn260.CellAppearance = appearance142;
            ultraGridColumn260.Header.VisiblePosition = 3;
            ultraGridColumn260.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn260.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn261.Header.VisiblePosition = 4;
            ultraGridColumn261.Hidden = true;
            ultraGridColumn262.Header.VisiblePosition = 5;
            ultraGridColumn262.Hidden = true;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn257,
            ultraGridColumn258,
            ultraGridColumn259,
            ultraGridColumn260,
            ultraGridColumn261,
            ultraGridColumn262});
            appearance143.FontData.BoldAsString = "True";
            appearance143.FontData.SizeInPoints = 11F;
            appearance143.TextHAlignAsString = "Left";
            ultraGridBand16.Header.Appearance = appearance143;
            ultraGridBand16.Header.Caption = "Libro Diario";
            ultraGridBand16.HeaderVisible = true;
            ultraGridBand16.Hidden = true;
            ultraGridBand16.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            appearance144.FontData.BoldAsString = "True";
            appearance144.TextHAlignAsString = "Right";
            summarySettings6.Appearance = appearance144;
            summarySettings6.DisplayFormat = "{0:c}";
            summarySettings6.GroupBySummaryValueAppearance = appearance145;
            appearance146.FontData.BoldAsString = "True";
            appearance146.TextHAlignAsString = "Right";
            summarySettings7.Appearance = appearance146;
            summarySettings7.DisplayFormat = "{0:c}";
            summarySettings7.GroupBySummaryValueAppearance = appearance147;
            ultraGridBand16.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings6,
            summarySettings7});
            ultraGridBand16.VisiblePosition = 4;
            this.ordenDePagoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ordenDePagoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ordenDePagoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ordenDePagoUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ordenDePagoUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.ordenDePagoUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.ordenDePagoUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance81.BackColor = System.Drawing.SystemColors.Window;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance81;
            appearance82.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance82.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance82.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance82;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance83.BackColor = System.Drawing.Color.Transparent;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance83;
            appearance84.BackColor = System.Drawing.SystemColors.Control;
            appearance84.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.CellAppearance = appearance84;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance85.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance85.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance85.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance85.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance85;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance86.ForeColor = System.Drawing.Color.Red;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance86;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance88.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance88;
            appearance89.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance89.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ordenDePagoUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance89;
            this.ordenDePagoUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ordenDePagoUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ordenDePagoUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.ordenDePagoUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ordenDePagoUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ordenDePagoUltraGrid.Location = new System.Drawing.Point(0, -3);
            this.ordenDePagoUltraGrid.Name = "ordenDePagoUltraGrid";
            this.ordenDePagoUltraGrid.Size = new System.Drawing.Size(947, 567);
            this.ordenDePagoUltraGrid.TabIndex = 2;
            this.ordenDePagoUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ComprasElegidasUltraGridInitializeRow);
            this.ordenDePagoUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ordenDePagoUltraGrid_AfterEnterEditMode);
            this.ordenDePagoUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ComprasElegidasUltraGridCellChange);
            this.ordenDePagoUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ComprasElegidasUltraGridCellListSelect);
            this.ordenDePagoUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.ComprasElegidasUltraGridSummaryValueChanged);
            this.ordenDePagoUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ordenDePagoUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // ordenesDePagoBindingSource
            // 
            this.ordenesDePagoBindingSource.DataMember = "OrdenesDePago";
            this.ordenesDePagoBindingSource.DataSource = this.dsOrdenDePago;
            // 
            // dsOrdenDePago
            // 
            this.dsOrdenDePago.DataSetName = "DsOrdenDePago";
            this.dsOrdenDePago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCajas
            // 
            this.ultraDropDownCajas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCajas.DataSource = this.empleadosListaBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCajas.DisplayLayout.Appearance = appearance11;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn204.Header.VisiblePosition = 0;
            ultraGridColumn204.Hidden = true;
            ultraGridColumn205.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn205.Header.VisiblePosition = 2;
            ultraGridColumn205.Hidden = true;
            ultraGridColumn206.Header.VisiblePosition = 3;
            ultraGridColumn206.Hidden = true;
            ultraGridColumn207.Header.VisiblePosition = 4;
            ultraGridColumn207.Hidden = true;
            ultraGridColumn208.Header.VisiblePosition = 1;
            ultraGridColumn209.Header.VisiblePosition = 5;
            ultraGridColumn209.Hidden = true;
            ultraGridColumn210.Header.VisiblePosition = 6;
            ultraGridColumn210.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn204,
            ultraGridColumn205,
            ultraGridColumn206,
            ultraGridColumn207,
            ultraGridColumn208,
            ultraGridColumn209,
            ultraGridColumn210});
            this.ultraDropDownCajas.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownCajas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCajas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCajas.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCajas.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCajas.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCajas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCajas.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCajas.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownCajas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCajas.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownCajas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCajas.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownCajas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCajas.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCajas.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCajas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownCajas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCajas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCajas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCajas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCajas.DisplayMember = "ApelNomb";
            this.ultraDropDownCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCajas.Location = new System.Drawing.Point(442, 314);
            this.ultraDropDownCajas.Name = "ultraDropDownCajas";
            this.ultraDropDownCajas.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownCajas.TabIndex = 60;
            this.ultraDropDownCajas.ValueMember = "idEmpleado";
            this.ultraDropDownCajas.Visible = false;
            this.ultraDropDownCajas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownCajas_BeforeDropDown);
            this.ultraDropDownCajas.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCajasFilterRow);
            // 
            // empleadosListaBindingSource
            // 
            this.empleadosListaBindingSource.DataMember = "EmpleadosLista";
            this.empleadosListaBindingSource.DataSource = this.dsEmpleadosLista;
            // 
            // dsEmpleadosLista
            // 
            this.dsEmpleadosLista.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownBancos
            // 
            this.ultraDropDownBancos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBancos.DataSource = this.bancosBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBancos.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn211.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn211.Header.VisiblePosition = 0;
            ultraGridColumn211.Hidden = true;
            ultraGridColumn212.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn212.Header.VisiblePosition = 1;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn211,
            ultraGridColumn212});
            ultraGridBand10.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand10.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBancos.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownBancos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBancos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBancos.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBancos.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBancos.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBancos.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBancos.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownBancos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBancos.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownBancos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBancos.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownBancos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBancos.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBancos.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBancos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownBancos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBancos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBancos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBancos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBancos.DisplayMember = "Nombre";
            this.ultraDropDownBancos.DropDownWidth = 250;
            this.ultraDropDownBancos.Location = new System.Drawing.Point(442, 274);
            this.ultraDropDownBancos.Name = "ultraDropDownBancos";
            this.ultraDropDownBancos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownBancos.TabIndex = 64;
            this.ultraDropDownBancos.ValueMember = "idBanco";
            this.ultraDropDownBancos.Visible = false;
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.dsBancos;
            // 
            // dsBancos
            // 
            this.dsBancos.DataSetName = "DsBancos";
            this.dsBancos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeValores
            // 
            this.ultraDropDownTiposDeValores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeValores.DataSource = this.tiposDeValoresBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeValores.DisplayLayout.Appearance = appearance31;
            this.ultraDropDownTiposDeValores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn213.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn213.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn213.Header.VisiblePosition = 0;
            ultraGridColumn213.Hidden = true;
            ultraGridColumn214.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn214.Header.VisiblePosition = 1;
            ultraGridColumn214.Width = 8;
            ultraGridColumn215.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn215.Header.VisiblePosition = 2;
            ultraGridColumn215.Hidden = true;
            ultraGridColumn216.Header.VisiblePosition = 3;
            ultraGridColumn216.Hidden = true;
            ultraGridColumn217.Header.VisiblePosition = 4;
            ultraGridColumn217.Hidden = true;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn213,
            ultraGridColumn214,
            ultraGridColumn215,
            ultraGridColumn216,
            ultraGridColumn217});
            ultraGridBand11.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand11.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeValores.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownTiposDeValores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeValores.DisplayLayout.MaxBandDepth = 5;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance33.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance33.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderAppearance = appearance36;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance37.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSelectorAppearance = appearance37;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedRowAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance40;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeValores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeValores.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeValores.DropDownWidth = 250;
            this.ultraDropDownTiposDeValores.Location = new System.Drawing.Point(442, 234);
            this.ultraDropDownTiposDeValores.Name = "ultraDropDownTiposDeValores";
            this.ultraDropDownTiposDeValores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeValores.TabIndex = 63;
            this.ultraDropDownTiposDeValores.ValueMember = "idTipoDeValor";
            this.ultraDropDownTiposDeValores.Visible = false;
            this.ultraDropDownTiposDeValores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownTiposDeValores_BeforeDropDown);
            this.ultraDropDownTiposDeValores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.ultraDropDownTiposDeValores_FilterRow);
            // 
            // tiposDeValoresBindingSource
            // 
            this.tiposDeValoresBindingSource.DataMember = "TiposDeValores";
            this.tiposDeValoresBindingSource.DataSource = this.dsTiposDeValores;
            // 
            // dsTiposDeValores
            // 
            this.dsTiposDeValores.DataSetName = "DsTiposDeValores";
            this.dsTiposDeValores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownRubros
            // 
            this.ultraDropDownRubros.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownRubros.DataSource = this.rubrosBindingSource;
            appearance41.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRubros.DisplayLayout.Appearance = appearance41;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn218.Header.VisiblePosition = 0;
            ultraGridColumn218.Hidden = true;
            ultraGridColumn219.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn219.Header.VisiblePosition = 1;
            ultraGridColumn219.Hidden = true;
            ultraGridColumn220.Header.VisiblePosition = 2;
            ultraGridColumn220.Hidden = true;
            ultraGridColumn221.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn221.Header.VisiblePosition = 3;
            ultraGridColumn222.Header.VisiblePosition = 4;
            ultraGridColumn222.Hidden = true;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn218,
            ultraGridColumn219,
            ultraGridColumn220,
            ultraGridColumn221,
            ultraGridColumn222});
            ultraGridBand12.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridBand12.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand12.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRubros.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownRubros.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRubros.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRubros.DisplayLayout.MaxBandDepth = 5;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraDropDownRubros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderAppearance = appearance46;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance47.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSelectorAppearance = appearance47;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedRowAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRubros.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRubros.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRubros.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRubros.DisplayMember = "NombreCompleto";
            this.ultraDropDownRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRubros.Location = new System.Drawing.Point(442, 352);
            this.ultraDropDownRubros.Name = "ultraDropDownRubros";
            this.ultraDropDownRubros.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownRubros.TabIndex = 65;
            this.ultraDropDownRubros.ValueMember = "idRubro";
            this.ultraDropDownRubros.Visible = false;
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "Rubros";
            this.rubrosBindingSource.DataSource = this.dsRubros;
            // 
            // dsRubros
            // 
            this.dsRubros.DataSetName = "DsRubros";
            this.dsRubros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownProveedores
            // 
            this.ultraDropDownProveedores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownProveedores.DataSource = this.proveedoresBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownProveedores.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownProveedores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn152.Header.VisiblePosition = 0;
            ultraGridColumn152.Hidden = true;
            ultraGridColumn153.Header.VisiblePosition = 1;
            ultraGridColumn153.Hidden = true;
            ultraGridColumn154.Header.VisiblePosition = 2;
            ultraGridColumn154.Hidden = true;
            ultraGridColumn155.Header.VisiblePosition = 3;
            ultraGridColumn155.Hidden = true;
            ultraGridColumn156.Header.VisiblePosition = 4;
            ultraGridColumn156.Hidden = true;
            ultraGridColumn157.Header.VisiblePosition = 5;
            ultraGridColumn158.Header.VisiblePosition = 6;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn159.Header.VisiblePosition = 7;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn160.Header.VisiblePosition = 8;
            ultraGridColumn160.Hidden = true;
            ultraGridColumn161.Header.VisiblePosition = 9;
            ultraGridColumn161.Hidden = true;
            ultraGridColumn162.Header.VisiblePosition = 10;
            ultraGridColumn163.Header.VisiblePosition = 11;
            ultraGridColumn164.Header.VisiblePosition = 12;
            ultraGridColumn165.Header.VisiblePosition = 13;
            ultraGridColumn166.Header.VisiblePosition = 14;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154,
            ultraGridColumn155,
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160,
            ultraGridColumn161,
            ultraGridColumn162,
            ultraGridColumn163,
            ultraGridColumn164,
            ultraGridColumn165,
            ultraGridColumn166});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn167.Header.VisiblePosition = 0;
            ultraGridColumn168.Header.VisiblePosition = 1;
            ultraGridColumn169.Header.VisiblePosition = 2;
            ultraGridColumn170.Header.VisiblePosition = 3;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169,
            ultraGridColumn170});
            ultraGridColumn171.Header.VisiblePosition = 0;
            ultraGridColumn172.Header.VisiblePosition = 1;
            ultraGridColumn173.Header.VisiblePosition = 2;
            ultraGridColumn174.Header.VisiblePosition = 3;
            ultraGridColumn175.Header.VisiblePosition = 4;
            ultraGridColumn176.Header.VisiblePosition = 5;
            ultraGridColumn177.Header.VisiblePosition = 6;
            ultraGridColumn178.Header.VisiblePosition = 7;
            ultraGridColumn179.Header.VisiblePosition = 8;
            ultraGridColumn180.Header.VisiblePosition = 9;
            ultraGridColumn181.Header.VisiblePosition = 10;
            ultraGridColumn182.Header.VisiblePosition = 11;
            ultraGridColumn183.Header.VisiblePosition = 12;
            ultraGridColumn184.Header.VisiblePosition = 13;
            ultraGridColumn185.Header.VisiblePosition = 14;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn171,
            ultraGridColumn172,
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175,
            ultraGridColumn176,
            ultraGridColumn177,
            ultraGridColumn178,
            ultraGridColumn179,
            ultraGridColumn180,
            ultraGridColumn181,
            ultraGridColumn182,
            ultraGridColumn183,
            ultraGridColumn184,
            ultraGridColumn185});
            ultraGridColumn186.Header.VisiblePosition = 0;
            ultraGridColumn187.Header.VisiblePosition = 1;
            ultraGridColumn188.Header.VisiblePosition = 2;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn186,
            ultraGridColumn187,
            ultraGridColumn188});
            ultraGridColumn189.Header.VisiblePosition = 0;
            ultraGridColumn190.Header.VisiblePosition = 1;
            ultraGridColumn191.Header.VisiblePosition = 2;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn189,
            ultraGridColumn190,
            ultraGridColumn191});
            ultraGridColumn192.Header.VisiblePosition = 0;
            ultraGridColumn193.Header.VisiblePosition = 1;
            ultraGridColumn194.Header.VisiblePosition = 2;
            ultraGridColumn195.Header.VisiblePosition = 3;
            ultraGridColumn196.Header.VisiblePosition = 4;
            ultraGridColumn197.Header.VisiblePosition = 5;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn192,
            ultraGridColumn193,
            ultraGridColumn194,
            ultraGridColumn195,
            ultraGridColumn196,
            ultraGridColumn197});
            ultraGridColumn198.Header.VisiblePosition = 0;
            ultraGridColumn199.Header.VisiblePosition = 1;
            ultraGridColumn200.Header.VisiblePosition = 2;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn198,
            ultraGridColumn199,
            ultraGridColumn200});
            ultraGridColumn201.Header.VisiblePosition = 0;
            ultraGridColumn202.Header.VisiblePosition = 1;
            ultraGridColumn203.Header.VisiblePosition = 2;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn201,
            ultraGridColumn202,
            ultraGridColumn203});
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownProveedores.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownProveedores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownProveedores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownProveedores.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownProveedores.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownProveedores.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownProveedores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownProveedores.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProveedores.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownProveedores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownProveedores.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownProveedores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownProveedores.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownProveedores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownProveedores.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProveedores.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownProveedores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownProveedores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownProveedores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownProveedores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownProveedores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownProveedores.DisplayMember = "NombreCompleto";
            this.ultraDropDownProveedores.DropDownWidth = 250;
            this.ultraDropDownProveedores.Location = new System.Drawing.Point(442, 392);
            this.ultraDropDownProveedores.Name = "ultraDropDownProveedores";
            this.ultraDropDownProveedores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownProveedores.TabIndex = 66;
            this.ultraDropDownProveedores.ValueMember = "idProveedor";
            this.ultraDropDownProveedores.Visible = false;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dsProveedores;
            // 
            // dsProveedores
            // 
            this.dsProveedores.DataSetName = "DsProveedores";
            this.dsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEnCaja1
            // 
            this.dsEnCaja1.DataSetName = "DsEnCaja";
            this.dsEnCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas
            // 
            this.dsSistemas.DataSetName = "DsSistemas";
            this.dsSistemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormOrdenDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(946, 602);
            this.Controls.Add(this.ordenDePagoUltraGrid);
            this.Controls.Add(this.ultraDropDownProveedores);
            this.Controls.Add(this.ultraDropDownCajas);
            this.Controls.Add(this.ultraDropDownBancos);
            this.Controls.Add(this.ultraDropDownTiposDeValores);
            this.Controls.Add(this.ultraDropDownRubros);
            this.Name = "FormOrdenDePago";
            this.Text = "Orden de Pago";
            this.Load += new System.EventHandler(this.Form_OrdenDePago_Load);
            this.Controls.SetChildIndex(this.ultraDropDownRubros, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeValores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBancos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCajas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownProveedores, 0);
            this.Controls.SetChildIndex(this.ordenDePagoUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordenDePagoUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnCaja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ordenDePagoUltraGrid;
        private WS.DsBancos dsBancos;
        private WS.DsTiposDeValores dsTiposDeValores;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private System.Windows.Forms.BindingSource tiposDeValoresBindingSource;
        private WS.DsEnCaja dsEnCaja1;
        private WS.DsEmpleadosLista dsEmpleadosLista;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private WS.DsProveedores dsProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCajas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBancos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeValores;
        private WS.DsRubros dsRubros;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRubros;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownProveedores;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private WS.DsSistemas dsSistemas;
        private System.Windows.Forms.BindingSource ordenesDePagoBindingSource;
        private WS.DsOrdenDePago dsOrdenDePago;
    }
}
