namespace Administracion
{
    partial class FormFacturaTotalmenteManual
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
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Comprobantes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn181 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn182 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn183 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeComprobante");
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn184 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn185 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn186 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn187 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn188 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Anulado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn189 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vinculados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn190 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo", -1, "ultraDropDownPrefijo");
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn191 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn192 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apellido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn193 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn194 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Entre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn195 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Barrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn196 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn197 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionesDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn198 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn199 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn200 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn201 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn202 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ServicioDesde");
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn203 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ServicioHasta", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn204 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__DetallesC__idCom__07AC1A97");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn205 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravado", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn206 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Exento", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn207 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto", 2);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__DetallesC__idCom__07AC1A97", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn208 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDetalleComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn209 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn210 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn211 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn212 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn213 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn214 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn215 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn216 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioImpreso");
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn217 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteImpreso");
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn218 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IVA", 0);
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn219 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravado", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn220 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Exento", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn221 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto", 3);
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PuntosDeVenta", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Verdadero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDB");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SolicitaCAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignadoM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeCM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoNumeroAsignacoNdeDM");
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturaE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeCE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeDE");
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn178 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn179 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn180 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NoGravado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Exento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subtotal");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("IVA");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravado");
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Exento");
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto");
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal");
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturaTotalmenteManual));
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IVA");
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Total");
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            this.dsComprobantes = new Administracion.WS.DsComprobantes();
            this.comprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprobantesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.dsPuntosDeVenta = new Administracion.WS.DsPuntosDeVenta();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPrefijo = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsCategoriasIVA = new Administracion.WS.DsCategoriasIVA();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsNegocios = new Administracion.WS.DsNegocios();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsPorcentajeIVA = new Administracion.WS.DsPorcentajeIVA();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraDropDownTiposDeComprobante = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeComprobante = new Administracion.WS.DsTiposDeComprobante();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.dsParametros1 = new Administracion.WS.DsParametros();
            this.totalesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrefijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesUltraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(613, 16);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(151, 16);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(703, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(532, 16);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // dsComprobantes
            // 
            this.dsComprobantes.DataSetName = "DsComprobantes";
            this.dsComprobantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprobantesBindingSource
            // 
            this.comprobantesBindingSource.DataMember = "Comprobantes";
            this.comprobantesBindingSource.DataSource = this.dsComprobantes;
            // 
            // comprobantesUltraGrid
            // 
            this.comprobantesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprobantesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.comprobantesUltraGrid.DataSource = this.comprobantesBindingSource;
            appearance60.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance60.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprobantesUltraGrid.DisplayLayout.Appearance = appearance60;
            ultraGridColumn181.Header.VisiblePosition = 0;
            ultraGridColumn181.Hidden = true;
            ultraGridColumn182.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance106.ImageBackground = global::Administracion.Properties.Resources.Verde;
            appearance106.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance106.TextHAlignAsString = "Center";
            ultraGridColumn182.CellAppearance = appearance106;
            ultraGridColumn182.Header.Caption = "Tipo de Comprobante";
            ultraGridColumn182.Header.VisiblePosition = 1;
            ultraGridColumn182.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn182.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn182.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn182.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn182.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn182.Width = 91;
            appearance107.TextHAlignAsString = "Center";
            ultraGridColumn183.CellAppearance = appearance107;
            ultraGridColumn183.Header.Caption = "N°  de Comprobante";
            ultraGridColumn183.Header.VisiblePosition = 2;
            ultraGridColumn183.Hidden = true;
            ultraGridColumn183.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth;
            ultraGridColumn183.MaskInput = "########";
            ultraGridColumn183.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn183.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn183.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(115, 0);
            ultraGridColumn183.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn183.RowLayoutColumnInfo.SpanY = 2;
            appearance108.TextHAlignAsString = "Center";
            ultraGridColumn184.CellAppearance = appearance108;
            ultraGridColumn184.Header.VisiblePosition = 3;
            ultraGridColumn184.Hidden = true;
            ultraGridColumn184.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn184.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn184.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 0);
            ultraGridColumn184.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(76, 0);
            ultraGridColumn184.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn184.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn184.Width = 70;
            ultraGridColumn185.Header.VisiblePosition = 4;
            ultraGridColumn185.Hidden = true;
            ultraGridColumn186.Header.VisiblePosition = 5;
            ultraGridColumn186.Hidden = true;
            ultraGridColumn187.Header.VisiblePosition = 6;
            ultraGridColumn187.Hidden = true;
            ultraGridColumn188.Header.VisiblePosition = 7;
            ultraGridColumn188.Hidden = true;
            ultraGridColumn189.Header.VisiblePosition = 8;
            ultraGridColumn189.Hidden = true;
            appearance109.TextHAlignAsString = "Center";
            ultraGridColumn190.CellAppearance = appearance109;
            ultraGridColumn190.Header.VisiblePosition = 9;
            ultraGridColumn190.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn190.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn190.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 0);
            ultraGridColumn190.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(76, 0);
            ultraGridColumn190.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn190.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn191.Header.VisiblePosition = 10;
            ultraGridColumn191.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn191.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn191.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(311, 0);
            ultraGridColumn191.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn191.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn191.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn192.Header.VisiblePosition = 11;
            ultraGridColumn192.Hidden = true;
            ultraGridColumn192.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn192.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn192.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn192.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn193.Header.VisiblePosition = 12;
            ultraGridColumn193.Hidden = true;
            ultraGridColumn193.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn193.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn193.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(328, 0);
            ultraGridColumn193.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(278, 0);
            ultraGridColumn193.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn193.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn194.Header.VisiblePosition = 13;
            ultraGridColumn194.Hidden = true;
            ultraGridColumn195.Header.VisiblePosition = 14;
            ultraGridColumn195.Hidden = true;
            ultraGridColumn196.Header.VisiblePosition = 15;
            ultraGridColumn196.Hidden = true;
            ultraGridColumn197.Header.Caption = "Dirección";
            ultraGridColumn197.Header.VisiblePosition = 16;
            ultraGridColumn197.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn197.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn197.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(311, 0);
            ultraGridColumn197.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(60, 0);
            ultraGridColumn197.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn197.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn198.Header.VisiblePosition = 17;
            ultraGridColumn198.Hidden = true;
            ultraGridColumn198.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn198.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn198.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(105, 0);
            ultraGridColumn198.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn198.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn199.Header.Caption = "Categoría IVA";
            ultraGridColumn199.Header.VisiblePosition = 18;
            ultraGridColumn199.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn199.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn199.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(113, 0);
            ultraGridColumn199.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(113, 0);
            ultraGridColumn199.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn199.RowLayoutColumnInfo.SpanY = 2;
            appearance110.TextHAlignAsString = "Center";
            ultraGridColumn200.CellAppearance = appearance110;
            ultraGridColumn200.Header.VisiblePosition = 19;
            ultraGridColumn200.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn200.MaskInput = "##-##,###,###-#";
            ultraGridColumn200.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn200.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn200.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(105, 0);
            ultraGridColumn200.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(105, 0);
            ultraGridColumn200.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn200.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn201.Header.VisiblePosition = 20;
            ultraGridColumn201.Hidden = true;
            appearance111.TextHAlignAsString = "Center";
            ultraGridColumn202.CellAppearance = appearance111;
            ultraGridColumn202.Header.Caption = "Servicio Desde";
            ultraGridColumn202.Header.VisiblePosition = 21;
            ultraGridColumn202.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn202.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn202.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn202.RowLayoutColumnInfo.SpanY = 2;
            appearance112.TextHAlignAsString = "Center";
            ultraGridColumn203.CellAppearance = appearance112;
            ultraGridColumn203.Header.Caption = "Servicio Hasta";
            ultraGridColumn203.Header.VisiblePosition = 22;
            ultraGridColumn203.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn203.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn203.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn203.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn204.Header.VisiblePosition = 26;
            ultraGridColumn205.DataType = typeof(decimal);
            ultraGridColumn205.Header.VisiblePosition = 23;
            ultraGridColumn205.Hidden = true;
            ultraGridColumn206.DataType = typeof(decimal);
            ultraGridColumn206.Header.VisiblePosition = 24;
            ultraGridColumn206.Hidden = true;
            ultraGridColumn207.DataType = typeof(decimal);
            ultraGridColumn207.Header.VisiblePosition = 25;
            ultraGridColumn207.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn181,
            ultraGridColumn182,
            ultraGridColumn183,
            ultraGridColumn184,
            ultraGridColumn185,
            ultraGridColumn186,
            ultraGridColumn187,
            ultraGridColumn188,
            ultraGridColumn189,
            ultraGridColumn190,
            ultraGridColumn191,
            ultraGridColumn192,
            ultraGridColumn193,
            ultraGridColumn194,
            ultraGridColumn195,
            ultraGridColumn196,
            ultraGridColumn197,
            ultraGridColumn198,
            ultraGridColumn199,
            ultraGridColumn200,
            ultraGridColumn201,
            ultraGridColumn202,
            ultraGridColumn203,
            ultraGridColumn204,
            ultraGridColumn205,
            ultraGridColumn206,
            ultraGridColumn207});
            ultraGridBand7.MaxRows = 1;
            ultraGridBand7.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand8.ColHeaderLines = 2;
            ultraGridColumn208.Header.VisiblePosition = 0;
            ultraGridColumn208.Hidden = true;
            ultraGridColumn209.Header.VisiblePosition = 1;
            ultraGridColumn209.Hidden = true;
            ultraGridColumn210.Header.VisiblePosition = 2;
            ultraGridColumn210.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn210.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn210.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(38, 0);
            ultraGridColumn210.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn210.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn210.Width = 60;
            ultraGridColumn211.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn211.Header.VisiblePosition = 3;
            ultraGridColumn211.MaxLength = 4000;
            ultraGridColumn211.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn211.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn211.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(229, 56);
            ultraGridColumn211.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(229, 0);
            ultraGridColumn211.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn211.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn211.VertScrollBar = true;
            ultraGridColumn211.Width = 60;
            appearance113.TextHAlignAsString = "Right";
            ultraGridColumn212.CellAppearance = appearance113;
            ultraGridColumn212.Header.Caption = "Precio Unitario con IVA";
            ultraGridColumn212.Header.VisiblePosition = 4;
            ultraGridColumn212.Hidden = true;
            ultraGridColumn212.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth;
            ultraGridColumn212.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn212.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn212.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn212.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(88, 0);
            ultraGridColumn212.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn212.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn213.Formula = "[Cantidad] *  [PrecioUnitario]";
            ultraGridColumn213.Header.VisiblePosition = 5;
            ultraGridColumn213.Hidden = true;
            ultraGridColumn214.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn214.Header.Caption = "Negocio";
            ultraGridColumn214.Header.VisiblePosition = 6;
            ultraGridColumn214.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn214.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn214.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn214.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(54, 0);
            ultraGridColumn214.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn214.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn214.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn215.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn215.Header.Caption = "IVA";
            ultraGridColumn215.Header.VisiblePosition = 7;
            ultraGridColumn215.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn215.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn215.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn215.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn215.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            appearance114.TextHAlignAsString = "Right";
            ultraGridColumn216.CellAppearance = appearance114;
            ultraGridColumn216.Header.Caption = "Precio Unitario Impreso";
            ultraGridColumn216.Header.VisiblePosition = 8;
            ultraGridColumn216.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn216.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn216.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn216.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(81, 0);
            ultraGridColumn216.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(109, 0);
            ultraGridColumn216.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn216.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn217.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance115.ImageBackground = global::Administracion.Properties.Resources.Verde;
            appearance115.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance115.TextHAlignAsString = "Right";
            ultraGridColumn217.CellAppearance = appearance115;
            ultraGridColumn217.Header.Caption = "Importe Impreso";
            ultraGridColumn217.Header.VisiblePosition = 9;
            ultraGridColumn217.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn217.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn217.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn217.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn217.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn217.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn218.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance116.ImageBackground = global::Administracion.Properties.Resources.Verde;
            appearance116.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance116.TextHAlignAsString = "Right";
            ultraGridColumn218.CellAppearance = appearance116;
            ultraGridColumn218.DataType = typeof(decimal);
            ultraGridColumn218.Header.VisiblePosition = 10;
            ultraGridColumn218.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn218.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn218.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn218.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn218.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn219.DataType = typeof(decimal);
            ultraGridColumn219.Header.VisiblePosition = 11;
            ultraGridColumn219.Hidden = true;
            ultraGridColumn220.DataType = typeof(decimal);
            ultraGridColumn220.Header.VisiblePosition = 12;
            ultraGridColumn220.Hidden = true;
            ultraGridColumn221.DataType = typeof(decimal);
            ultraGridColumn221.Header.VisiblePosition = 13;
            ultraGridColumn221.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn208,
            ultraGridColumn209,
            ultraGridColumn210,
            ultraGridColumn211,
            ultraGridColumn212,
            ultraGridColumn213,
            ultraGridColumn214,
            ultraGridColumn215,
            ultraGridColumn216,
            ultraGridColumn217,
            ultraGridColumn218,
            ultraGridColumn219,
            ultraGridColumn220,
            ultraGridColumn221});
            ultraGridBand8.MaxRows = 100;
            ultraGridBand8.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand8.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.comprobantesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.comprobantesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            appearance71.BackColor = System.Drawing.SystemColors.Window;
            appearance71.FontData.BoldAsString = "True";
            appearance71.FontData.SizeInPoints = 11F;
            appearance71.ForeColor = System.Drawing.Color.Green;
            appearance71.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance71.ImageBackground")));
            appearance71.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.comprobantesUltraGrid.DisplayLayout.CaptionAppearance = appearance71;
            this.comprobantesUltraGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.comprobantesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprobantesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprobantesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance72.BackColor = System.Drawing.SystemColors.Window;
            this.comprobantesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance72;
            appearance73.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance73.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance73.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprobantesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance73;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprobantesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance74.BackColor = System.Drawing.Color.Transparent;
            this.comprobantesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.Control;
            appearance75.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprobantesUltraGrid.DisplayLayout.Override.CellAppearance = appearance75;
            this.comprobantesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance76.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance76.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance76.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance76.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprobantesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance76;
            this.comprobantesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance77.ForeColor = System.Drawing.Color.Red;
            this.comprobantesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance77;
            this.comprobantesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprobantesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance78;
            appearance79.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance79.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprobantesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance79;
            appearance80.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance80.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprobantesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance80;
            this.comprobantesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprobantesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprobantesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprobantesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprobantesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comprobantesUltraGrid.Location = new System.Drawing.Point(3, 0);
            this.comprobantesUltraGrid.Name = "comprobantesUltraGrid";
            this.comprobantesUltraGrid.Size = new System.Drawing.Size(697, 464);
            this.comprobantesUltraGrid.TabIndex = 1;
            this.comprobantesUltraGrid.Text = "***  Esta factura irá al cliente \"Varios\"  ***";
            this.comprobantesUltraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.comprobantesUltraGrid_InitializeLayout);
            this.comprobantesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.comprobantesUltraGrid_InitializeRow);
            this.comprobantesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.comprobantesUltraGrid_AfterEnterEditMode);
            this.comprobantesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprobantesUltraGrid_CellChange);
            this.comprobantesUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.comprobantesUltraGrid_BeforeCellDeactivate);
            this.comprobantesUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.comprobantesUltraGrid_BeforeRowDeactivate);
            this.comprobantesUltraGrid.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.comprobantesUltraGrid_DoubleClickCell);
            this.comprobantesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprobantesUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // dsPuntosDeVenta
            // 
            this.dsPuntosDeVenta.DataSetName = "DsPuntosDeVenta";
            this.dsPuntosDeVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntosDeVentaBindingSource
            // 
            this.puntosDeVentaBindingSource.DataMember = "PuntosDeVenta";
            this.puntosDeVentaBindingSource.DataSource = this.dsPuntosDeVenta;
            // 
            // ultraDropDownPrefijo
            // 
            this.ultraDropDownPrefijo.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrefijo.DataSource = this.puntosDeVentaBindingSource;
            appearance37.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrefijo.DisplayLayout.Appearance = appearance37;
            this.ultraDropDownPrefijo.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn161.Header.VisiblePosition = 0;
            ultraGridColumn161.Hidden = true;
            ultraGridColumn162.Header.VisiblePosition = 1;
            ultraGridColumn163.Header.VisiblePosition = 2;
            ultraGridColumn163.Hidden = true;
            ultraGridColumn164.Header.VisiblePosition = 3;
            ultraGridColumn164.Hidden = true;
            ultraGridColumn165.Header.VisiblePosition = 4;
            ultraGridColumn165.Hidden = true;
            ultraGridColumn166.Header.VisiblePosition = 5;
            ultraGridColumn166.Hidden = true;
            ultraGridColumn167.Header.VisiblePosition = 6;
            ultraGridColumn167.Hidden = true;
            ultraGridColumn168.Header.VisiblePosition = 7;
            ultraGridColumn168.Hidden = true;
            ultraGridColumn169.Header.VisiblePosition = 8;
            ultraGridColumn169.Hidden = true;
            ultraGridColumn170.Header.VisiblePosition = 9;
            ultraGridColumn170.Hidden = true;
            ultraGridColumn171.Header.VisiblePosition = 10;
            ultraGridColumn171.Hidden = true;
            ultraGridColumn172.Header.VisiblePosition = 11;
            ultraGridColumn172.Hidden = true;
            ultraGridColumn173.Header.VisiblePosition = 12;
            ultraGridColumn173.Hidden = true;
            ultraGridColumn174.Header.VisiblePosition = 13;
            ultraGridColumn174.Hidden = true;
            ultraGridColumn175.Header.VisiblePosition = 14;
            ultraGridColumn175.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn161,
            ultraGridColumn162,
            ultraGridColumn163,
            ultraGridColumn164,
            ultraGridColumn165,
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169,
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172,
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175});
            ultraGridBand5.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPrefijo.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownPrefijo.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrefijo.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrefijo.DisplayLayout.MaxBandDepth = 5;
            appearance38.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrefijo.DisplayLayout.Override.ActiveCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance39.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrefijo.DisplayLayout.Override.ActiveRowAppearance = appearance39;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrefijo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance40.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrefijo.DisplayLayout.Override.CardAreaAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.Control;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrefijo.DisplayLayout.Override.CellAppearance = appearance41;
            this.ultraDropDownPrefijo.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance42.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance42.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance42.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrefijo.DisplayLayout.Override.HeaderAppearance = appearance42;
            this.ultraDropDownPrefijo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance43.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrefijo.DisplayLayout.Override.RowSelectorAppearance = appearance43;
            this.ultraDropDownPrefijo.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrefijo.DisplayLayout.Override.SelectedCellAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance45.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrefijo.DisplayLayout.Override.SelectedRowAppearance = appearance45;
            appearance46.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrefijo.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance46;
            this.ultraDropDownPrefijo.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrefijo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrefijo.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrefijo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrefijo.DisplayMember = "Prefijo";
            this.ultraDropDownPrefijo.DropDownWidth = 0;
            this.ultraDropDownPrefijo.Location = new System.Drawing.Point(127, 158);
            this.ultraDropDownPrefijo.Name = "ultraDropDownPrefijo";
            this.ultraDropDownPrefijo.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPrefijo.TabIndex = 13;
            this.ultraDropDownPrefijo.ValueMember = "Prefijo";
            this.ultraDropDownPrefijo.Visible = false;
            // 
            // dsCategoriasIVA
            // 
            this.dsCategoriasIVA.DataSetName = "DsCategoriasIVA";
            this.dsCategoriasIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasIVABindingSource
            // 
            this.categoriasIVABindingSource.DataMember = "CategoriasIVA";
            this.categoriasIVABindingSource.DataSource = this.dsCategoriasIVA;
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance103.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance103;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn151.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn151.Header.VisiblePosition = 0;
            ultraGridColumn151.Hidden = true;
            ultraGridColumn152.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn152.Header.VisiblePosition = 1;
            ultraGridColumn153.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn153.Header.VisiblePosition = 2;
            ultraGridColumn153.Hidden = true;
            ultraGridColumn154.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn154.Header.VisiblePosition = 3;
            ultraGridColumn154.Hidden = true;
            ultraGridColumn155.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn155.Header.VisiblePosition = 4;
            ultraGridColumn155.Hidden = true;
            ultraGridColumn156.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn156.Header.VisiblePosition = 5;
            ultraGridColumn156.Hidden = true;
            ultraGridColumn157.Header.VisiblePosition = 6;
            ultraGridColumn157.Hidden = true;
            ultraGridColumn158.Header.VisiblePosition = 7;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn159.Header.VisiblePosition = 8;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn160.Header.VisiblePosition = 9;
            ultraGridColumn160.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154,
            ultraGridColumn155,
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance104.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance104;
            appearance105.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance105.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance105.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance105.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance105;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance30.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.Control;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance31;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance32.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance32.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance32.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance32;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance33.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance33;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance35.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance36;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(127, 109);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCategoriasIVA.TabIndex = 27;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            this.ultraDropDownCategoriasIVA.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownCategoriasIVA_BeforeDropDown);
            // 
            // dsNegocios
            // 
            this.dsNegocios.DataSetName = "DsNegocios";
            this.dsNegocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // negociosBindingSource
            // 
            this.negociosBindingSource.DataMember = "Negocios";
            this.negociosBindingSource.DataSource = this.dsNegocios;
            // 
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance17;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn147.Header.VisiblePosition = 0;
            ultraGridColumn147.Hidden = true;
            ultraGridColumn148.Header.VisiblePosition = 1;
            ultraGridColumn148.Hidden = true;
            ultraGridColumn149.Header.VisiblePosition = 2;
            ultraGridColumn150.Header.VisiblePosition = 3;
            ultraGridColumn150.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn147,
            ultraGridColumn148,
            ultraGridColumn149,
            ultraGridColumn150});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance18.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance19;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance96.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance96;
            appearance97.BackColor = System.Drawing.SystemColors.Control;
            appearance97.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance97;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance98.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance98.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance98.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance98;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance99.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance99;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance100;
            appearance101.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance101.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance101;
            appearance102.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance102.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance102;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(127, 199);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownNegocios.TabIndex = 28;
            this.ultraDropDownNegocios.ValueMember = "idNegocio";
            this.ultraDropDownNegocios.Visible = false;
            this.ultraDropDownNegocios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownNegocios_BeforeDropDown);
            // 
            // dsPorcentajeIVA
            // 
            this.dsPorcentajeIVA.DataSetName = "DsPorcentajeIVA";
            this.dsPorcentajeIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porcentajeIVABindingSource
            // 
            this.porcentajeIVABindingSource.DataMember = "PorcentajeIVA";
            this.porcentajeIVABindingSource.DataSource = this.dsPorcentajeIVA;
            // 
            // ultraDropDownPorcentajeIVA
            // 
            this.ultraDropDownPorcentajeIVA.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPorcentajeIVA.DataSource = this.porcentajeIVABindingSource;
            appearance47.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance47.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance47;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn176.Header.VisiblePosition = 0;
            ultraGridColumn176.Hidden = true;
            ultraGridColumn176.Width = 54;
            ultraGridColumn177.Header.VisiblePosition = 1;
            ultraGridColumn177.Hidden = true;
            ultraGridColumn177.Width = 45;
            ultraGridColumn178.Header.VisiblePosition = 2;
            ultraGridColumn178.Width = 231;
            ultraGridColumn179.Header.VisiblePosition = 3;
            ultraGridColumn179.Hidden = true;
            ultraGridColumn179.Width = 27;
            ultraGridColumn180.Header.VisiblePosition = 4;
            ultraGridColumn180.Hidden = true;
            ultraGridColumn180.Width = 47;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn176,
            ultraGridColumn177,
            ultraGridColumn178,
            ultraGridColumn179,
            ultraGridColumn180});
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance48.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance49.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance49;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance50.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.Control;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance51;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance52.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance52.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance52.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance52;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance53.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance53;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance55.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance55;
            appearance56.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance56;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.DropDownWidth = 250;
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(127, 240);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPorcentajeIVA.TabIndex = 62;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // ultraPanel1
            // 
            this.ultraPanel1.AutoScroll = true;
            this.ultraPanel1.AutoSize = true;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.comprobantesUltraGrid);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraDropDownTiposDeComprobante);
            this.ultraPanel1.Location = new System.Drawing.Point(0, 1);
            this.ultraPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(703, 482);
            this.ultraPanel1.TabIndex = 63;
            // 
            // ultraDropDownTiposDeComprobante
            // 
            this.ultraDropDownTiposDeComprobante.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeComprobante.DataSource = this.tiposDeComprobanteBindingSource;
            appearance20.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Appearance = appearance20;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn138.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn138.Header.VisiblePosition = 0;
            ultraGridColumn138.Hidden = true;
            ultraGridColumn139.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn139.Header.VisiblePosition = 1;
            ultraGridColumn140.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn140.Header.VisiblePosition = 2;
            ultraGridColumn140.Hidden = true;
            ultraGridColumn141.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn141.Header.VisiblePosition = 3;
            ultraGridColumn141.Hidden = true;
            ultraGridColumn142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn142.Header.VisiblePosition = 4;
            ultraGridColumn142.Hidden = true;
            ultraGridColumn143.Header.VisiblePosition = 5;
            ultraGridColumn143.Hidden = true;
            ultraGridColumn144.Header.VisiblePosition = 6;
            ultraGridColumn144.Hidden = true;
            ultraGridColumn145.Header.VisiblePosition = 7;
            ultraGridColumn145.Hidden = true;
            ultraGridColumn146.Header.VisiblePosition = 8;
            ultraGridColumn146.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142,
            ultraGridColumn143,
            ultraGridColumn144,
            ultraGridColumn145,
            ultraGridColumn146});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownTiposDeComprobante.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.MaxBandDepth = 5;
            appearance21.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveCellAppearance = appearance21;
            appearance22.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance22.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance22.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveRowAppearance = appearance22;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance23.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CardAreaAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.Control;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CellAppearance = appearance24;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance25.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderAppearance = appearance25;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance26.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSelectorAppearance = appearance26;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedCellAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance28.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedRowAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance29;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeComprobante.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeComprobante.DropDownWidth = 0;
            this.ultraDropDownTiposDeComprobante.Location = new System.Drawing.Point(207, 231);
            this.ultraDropDownTiposDeComprobante.Name = "ultraDropDownTiposDeComprobante";
            this.ultraDropDownTiposDeComprobante.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeComprobante.TabIndex = 74;
            this.ultraDropDownTiposDeComprobante.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownTiposDeComprobante.Visible = false;
            // 
            // tiposDeComprobanteBindingSource
            // 
            this.tiposDeComprobanteBindingSource.DataMember = "TiposDeComprobante";
            this.tiposDeComprobanteBindingSource.DataSource = this.dsTiposDeComprobante;
            // 
            // dsTiposDeComprobante
            // 
            this.dsTiposDeComprobante.DataSetName = "DsTiposDeComprobante";
            this.dsTiposDeComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDataSource1
            // 
            ultraDataColumn1.DataType = typeof(decimal);
            ultraDataColumn2.DataType = typeof(decimal);
            ultraDataColumn3.DataType = typeof(decimal);
            ultraDataColumn4.DataType = typeof(decimal);
            ultraDataColumn5.DataType = typeof(decimal);
            ultraDataColumn6.DataType = typeof(decimal);
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3,
            ultraDataColumn4,
            ultraDataColumn5,
            ultraDataColumn6});
            // 
            // dsParametros1
            // 
            this.dsParametros1.DataSetName = "DsParametros";
            this.dsParametros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalesUltraGrid
            // 
            this.totalesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.totalesUltraGrid.DataSource = this.ultraDataSource1;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.totalesUltraGrid.DisplayLayout.Appearance = appearance1;
            this.totalesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance90.ImageBackground = global::Administracion.Properties.Resources.Verde;
            appearance90.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance90.TextHAlignAsString = "Right";
            ultraGridColumn132.CellAppearance = appearance90;
            ultraGridColumn132.Header.Caption = "No Gravado";
            ultraGridColumn132.Header.VisiblePosition = 0;
            ultraGridColumn132.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn132.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn132.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn132.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn132.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn132.Width = 89;
            ultraGridColumn133.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance91.ImageBackground = global::Administracion.Properties.Resources.Verde;
            appearance91.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance91.TextHAlignAsString = "Right";
            ultraGridColumn133.CellAppearance = appearance91;
            ultraGridColumn133.Header.VisiblePosition = 1;
            ultraGridColumn133.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn133.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn133.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn133.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn133.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn133.Width = 92;
            ultraGridColumn134.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance92.ImageBackground = global::Administracion.Properties.Resources.Verde;
            appearance92.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance92.TextHAlignAsString = "Right";
            ultraGridColumn134.CellAppearance = appearance92;
            ultraGridColumn134.Header.VisiblePosition = 2;
            ultraGridColumn134.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn134.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn134.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn134.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn134.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn134.Width = 87;
            ultraGridColumn135.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance93.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance93.ImageBackground")));
            appearance93.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance93.TextHAlignAsString = "Right";
            ultraGridColumn135.CellAppearance = appearance93;
            ultraGridColumn135.Header.VisiblePosition = 3;
            ultraGridColumn135.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn135.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn135.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn135.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn135.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn135.Width = 87;
            ultraGridColumn136.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance94.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance94.ImageBackground")));
            appearance94.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance94.TextHAlignAsString = "Right";
            ultraGridColumn136.CellAppearance = appearance94;
            ultraGridColumn136.Header.VisiblePosition = 4;
            ultraGridColumn136.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn136.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn136.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn136.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn136.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn136.Width = 87;
            ultraGridColumn137.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance95.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance95.ImageBackground")));
            appearance95.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            appearance95.TextHAlignAsString = "Right";
            ultraGridColumn137.CellAppearance = appearance95;
            ultraGridColumn137.Header.VisiblePosition = 5;
            ultraGridColumn137.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn137.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn137.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn137.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn137.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn137.Width = 87;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn132,
            ultraGridColumn133,
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137});
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.Left;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.totalesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.totalesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.totalesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.totalesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.totalesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance9;
            this.totalesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.totalesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.totalesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.totalesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.totalesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.totalesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.totalesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance10.BackColor = System.Drawing.Color.Transparent;
            this.totalesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.Control;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.totalesUltraGrid.DisplayLayout.Override.CellAppearance = appearance11;
            this.totalesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance12.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.totalesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance12;
            this.totalesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance13.ForeColor = System.Drawing.Color.Red;
            this.totalesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance13;
            this.totalesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.totalesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance15.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.totalesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.totalesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance16;
            this.totalesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.totalesUltraGrid.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.None;
            this.totalesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.totalesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.totalesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalesUltraGrid.Location = new System.Drawing.Point(0, 486);
            this.totalesUltraGrid.Name = "totalesUltraGrid";
            this.totalesUltraGrid.Size = new System.Drawing.Size(655, 62);
            this.totalesUltraGrid.TabIndex = 65;
            // 
            // FormFacturaTotalmenteManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 603);
            this.Controls.Add(this.totalesUltraGrid);
            this.Controls.Add(this.ultraPanel1);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Controls.Add(this.ultraDropDownPrefijo);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(357, 194);
            this.Name = "FormFacturaTotalmenteManual";
            this.Text = "Factura Manual";
            this.Load += new System.EventHandler(this.Form_FacturaTotalmenteManual_Load);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrefijo, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraPanel1, 0);
            this.Controls.SetChildIndex(this.totalesUltraGrid, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobantesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrefijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            this.ultraPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalesUltraGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsComprobantes dsComprobantes;
        private System.Windows.Forms.BindingSource comprobantesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid comprobantesUltraGrid;
        private WS.DsPuntosDeVenta dsPuntosDeVenta;
        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrefijo;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private WS.DsNegocios dsNegocios;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPorcentajeIVA;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private WS.DsParametros dsParametros1;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private WS.DsTiposDeComprobante dsTiposDeComprobante;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeComprobante;
        private Infragistics.Win.UltraWinGrid.UltraGrid totalesUltraGrid;
    }
}
