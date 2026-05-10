namespace Administracion
{
    partial class FormCompra
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
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Compras", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Comprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRegistro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaDePago");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosCompras_Compras");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Compras_IVACompras");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Compras_LibroDiario");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosCompras_Compras", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumNegocios", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Porcentaje", 3, true, "FK_NegociosCompras_Compras", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Porcentaje", 3, true);
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Compras_IVACompras", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idIVACompras");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNeto");
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteIVA");
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalNeto", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteNeto", 3, true, "FK_Compras_IVACompras", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalIVA", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteIVA", 4, true, "FK_Compras_IVACompras", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Compras_LibroDiario", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLibroDiario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Debe");
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Haber");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings4 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalDebe", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Debe", 3, true, "FK_Compras_LibroDiario", 3, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance("TotalDebe");
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings5 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalHaber", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Haber", 4, true, "FK_Compras_LibroDiario", 3, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Rubros", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AdmiteValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn178 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn179 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn180 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn181 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn182 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn183 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn184 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn185 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn186 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn187 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn188 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn189 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn190 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturaE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn191 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeCE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn192 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeDE");
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn193 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn194 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn195 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn196 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn197 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn198 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn199 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn200 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn201 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            this.comprasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompra = new Administracion.WS.DsCompra();
            this.ultraLabelProveedor = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboProveedor = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProveedores = new Administracion.WS.DsProveedores();
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNegocios = new Administracion.WS.DsNegocios();
            this.ultraDropDownRubros = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRubros = new Administracion.WS.DsRubros();
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPorcentajeIVA = new Administracion.WS.DsPorcentajeIVA();
            this.dsParametros = new AdministracionNegocios.DsParametros();
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategoriasIVA = new Administracion.WS.DsCategoriasIVA();
            this.dsProveedor = new Administracion.WS.DsProveedores();
            this.dsSistemas = new Administracion.WS.DsSistemas();
            this.sistemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_TiposDeComprobante = new Administracion.WS.DsTiposDeComprobante();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownTiposDeComprobante = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(694, 16);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Size = new System.Drawing.Size(96, 23);
            this.buttonAceptar.Text = "Aceptar y Pagar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(538, 16);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAplicar.Size = new System.Drawing.Size(150, 23);
            this.buttonAplicar.Text = "Aceptar y Posponer el Pago";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(805, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(457, 16);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // comprasUltraGrid
            // 
            this.comprasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasUltraGrid.DataSource = this.comprasBindingSource;
            appearance161.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance161.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprasUltraGrid.DisplayLayout.Appearance = appearance161;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            appearance1.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance1;
            ultraGridColumn3.Header.VisiblePosition = 4;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Width = 69;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn4.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn4.MaskInput = "####-########";
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(92, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(92, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Width = 83;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn5.CellAppearance = appearance2;
            ultraGridColumn5.Header.Caption = "Importe Total";
            ultraGridColumn5.Header.VisiblePosition = 9;
            ultraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn5.MaskInput = "{LOC}$ nnn,nnn,nnn.nn";
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(111, 0);
            ultraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(111, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Header.VisiblePosition = 6;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.Header.Caption = "Tipo de Comprobante";
            ultraGridColumn7.Header.VisiblePosition = 2;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(109, 0);
            ultraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(109, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 5;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(307, 0);
            ultraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(307, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Width = 69;
            ultraGridColumn10.Header.VisiblePosition = 8;
            ultraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn10.MaskInput = "##-##.###.###-#";
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(90, 0);
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.Width = 60;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn11.Header.Caption = "Categoría IVA";
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn12.CellAppearance = appearance3;
            ultraGridColumn12.Header.Caption = "Fech de ePago";
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn12.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(89, 0);
            ultraGridColumn12.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn13.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn13.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(384, 0);
            ultraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(384, 0);
            ultraGridColumn13.RowLayoutColumnInfo.SpanX = 10;
            ultraGridColumn13.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn14.Header.VisiblePosition = 15;
            ultraGridColumn15.Header.VisiblePosition = 13;
            ultraGridColumn16.Header.VisiblePosition = 14;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16});
            appearance4.FontData.BoldAsString = "True";
            appearance4.FontData.SizeInPoints = 10F;
            appearance4.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance4;
            ultraGridBand1.Header.Caption = "Compra";
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn17.Header.VisiblePosition = 0;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            ultraGridColumn18.Header.Caption = "Negocio";
            ultraGridColumn18.Header.VisiblePosition = 1;
            ultraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn18.Width = 141;
            ultraGridColumn19.Header.VisiblePosition = 2;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn19.Width = 153;
            appearance5.TextHAlignAsString = "Right";
            ultraGridColumn20.CellAppearance = appearance5;
            ultraGridColumn20.Header.VisiblePosition = 3;
            ultraGridColumn20.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn20.MaskInput = "nnn%";
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20});
            appearance6.FontData.BoldAsString = "True";
            appearance6.FontData.SizeInPoints = 10F;
            appearance6.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance6;
            ultraGridBand2.Header.Caption = "Negocios";
            ultraGridBand2.HeaderVisible = true;
            ultraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            ultraGridBand2.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance7.FontData.BoldAsString = "True";
            appearance7.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance7;
            summarySettings1.DisplayFormat = "Total {0:###}%";
            summarySettings1.GroupBySummaryValueAppearance = appearance8;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridColumn21.Header.VisiblePosition = 0;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn22.Header.VisiblePosition = 1;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn23.Header.Caption = "Porcentaje";
            ultraGridColumn23.Header.VisiblePosition = 2;
            ultraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn23.Width = 100;
            appearance9.TextHAlignAsString = "Right";
            ultraGridColumn24.CellAppearance = appearance9;
            ultraGridColumn24.Header.Caption = "Importe Neto";
            ultraGridColumn24.Header.VisiblePosition = 3;
            ultraGridColumn24.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn24.MaskInput = "{LOC}$ -nnn,nnn,nnn.nn";
            ultraGridColumn24.Width = 101;
            appearance10.TextHAlignAsString = "Right";
            ultraGridColumn25.CellAppearance = appearance10;
            ultraGridColumn25.Header.Caption = "Importe IVA";
            ultraGridColumn25.Header.VisiblePosition = 4;
            ultraGridColumn25.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn25.MaskInput = "{LOC}$ -nnn,nnn,nnn.nn";
            ultraGridColumn25.Width = 102;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25});
            appearance11.FontData.BoldAsString = "True";
            appearance11.FontData.SizeInPoints = 10F;
            appearance11.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance11;
            ultraGridBand3.Header.Caption = "IVA";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            ultraGridBand3.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance12.FontData.BoldAsString = "True";
            appearance12.TextHAlignAsString = "Right";
            summarySettings2.Appearance = appearance12;
            summarySettings2.DisplayFormat = "{0:c}";
            summarySettings2.GroupBySummaryValueAppearance = appearance13;
            appearance14.FontData.BoldAsString = "True";
            appearance14.TextHAlignAsString = "Right";
            summarySettings3.Appearance = appearance14;
            summarySettings3.DisplayFormat = "{0:c}";
            summarySettings3.GroupBySummaryValueAppearance = appearance15;
            ultraGridBand3.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings2,
            summarySettings3});
            ultraGridColumn26.Header.VisiblePosition = 0;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn27.Header.VisiblePosition = 1;
            ultraGridColumn27.Hidden = true;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            ultraGridColumn28.Header.Caption = "Rubro";
            ultraGridColumn28.Header.VisiblePosition = 2;
            ultraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn28.Width = 240;
            appearance16.TextHAlignAsString = "Right";
            ultraGridColumn29.CellAppearance = appearance16;
            ultraGridColumn29.Header.VisiblePosition = 3;
            ultraGridColumn29.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn29.MaskInput = "{LOC}$ -nnn,nnn,nnn.nn";
            ultraGridColumn29.Width = 117;
            appearance17.TextHAlignAsString = "Right";
            ultraGridColumn30.CellAppearance = appearance17;
            ultraGridColumn30.Header.VisiblePosition = 4;
            ultraGridColumn30.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn30.MaskInput = "{LOC}$ -nnn,nnn,nnn.nn";
            ultraGridColumn30.Width = 119;
            ultraGridColumn31.Header.VisiblePosition = 5;
            ultraGridColumn31.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31});
            appearance18.FontData.BoldAsString = "True";
            appearance18.FontData.SizeInPoints = 10F;
            appearance18.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance18;
            ultraGridBand4.Header.Caption = "Libro Diario";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            ultraGridBand4.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance19.FontData.BoldAsString = "True";
            appearance19.TextHAlignAsString = "Right";
            summarySettings4.Appearance = appearance19;
            summarySettings4.DisplayFormat = "{0:c}";
            summarySettings4.GroupBySummaryValueAppearance = appearance20;
            appearance21.FontData.BoldAsString = "True";
            appearance21.TextHAlignAsString = "Right";
            summarySettings5.Appearance = appearance21;
            summarySettings5.DisplayFormat = "{0:c}";
            summarySettings5.GroupBySummaryValueAppearance = appearance22;
            ultraGridBand4.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings4,
            summarySettings5});
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.comprasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance184.BackColor = System.Drawing.SystemColors.Window;
            this.comprasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance184;
            appearance185.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance185.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance185.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance185.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance185;
            this.comprasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance186.BackColor = System.Drawing.Color.Transparent;
            this.comprasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance186;
            appearance187.BackColor = System.Drawing.SystemColors.Control;
            appearance187.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance187.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasUltraGrid.DisplayLayout.Override.CellAppearance = appearance187;
            this.comprasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance188.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance188.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance188.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance188.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance188.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance188;
            this.comprasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance189.ForeColor = System.Drawing.Color.Red;
            this.comprasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance189;
            this.comprasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance190.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance190;
            appearance191.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance191.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance191;
            appearance192.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance192.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance192;
            this.comprasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comprasUltraGrid.Location = new System.Drawing.Point(3, 47);
            this.comprasUltraGrid.Name = "comprasUltraGrid";
            this.comprasUltraGrid.Size = new System.Drawing.Size(802, 540);
            this.comprasUltraGrid.TabIndex = 2;
            this.comprasUltraGrid.Visible = false;
            this.comprasUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprasUltraGrid_AfterCellUpdate);
            this.comprasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.comprasUltraGrid_InitializeRow);
            this.comprasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.comprasUltraGrid_AfterEnterEditMode);
            this.comprasUltraGrid.AfterExitEditMode += new System.EventHandler(this.comprasUltraGrid_AfterExitEditMode);
            this.comprasUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprasUltraGrid_CellChange);
            this.comprasUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.comprasUltraGrid_SummaryValueChanged);
            this.comprasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprasUltraGrid_KeyDown);
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.dsCompra;
            // 
            // dsCompra
            // 
            this.dsCompra.DataSetName = "DsCompra";
            this.dsCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelProveedor
            // 
            this.ultraLabelProveedor.AutoSize = true;
            this.ultraLabelProveedor.Location = new System.Drawing.Point(13, 13);
            this.ultraLabelProveedor.Name = "ultraLabelProveedor";
            this.ultraLabelProveedor.Size = new System.Drawing.Size(56, 14);
            this.ultraLabelProveedor.TabIndex = 3;
            this.ultraLabelProveedor.Text = "Proveedor";
            // 
            // ultraComboProveedor
            // 
            this.ultraComboProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboProveedor.DataSource = this.proveedoresBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.Window;
            appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraComboProveedor.DisplayLayout.Appearance = appearance31;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn32.Header.VisiblePosition = 0;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn33.Header.VisiblePosition = 1;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn34.Header.VisiblePosition = 2;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.Header.VisiblePosition = 3;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn36.Header.VisiblePosition = 4;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn37.Header.VisiblePosition = 5;
            ultraGridColumn38.Header.VisiblePosition = 6;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn39.Header.VisiblePosition = 7;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn40.Header.VisiblePosition = 8;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn41.Header.VisiblePosition = 9;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn42.Header.VisiblePosition = 10;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn43.Header.VisiblePosition = 11;
            ultraGridColumn44.Header.VisiblePosition = 12;
            ultraGridColumn45.Header.VisiblePosition = 13;
            ultraGridColumn46.Header.VisiblePosition = 14;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46});
            ultraGridColumn47.Header.VisiblePosition = 0;
            ultraGridColumn48.Header.VisiblePosition = 1;
            ultraGridColumn49.Header.VisiblePosition = 2;
            ultraGridColumn50.Header.VisiblePosition = 3;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50});
            ultraGridColumn51.Header.VisiblePosition = 0;
            ultraGridColumn52.Header.VisiblePosition = 1;
            ultraGridColumn53.Header.VisiblePosition = 2;
            ultraGridColumn54.Header.VisiblePosition = 3;
            ultraGridColumn55.Header.VisiblePosition = 4;
            ultraGridColumn56.Header.VisiblePosition = 5;
            ultraGridColumn57.Header.VisiblePosition = 6;
            ultraGridColumn58.Header.VisiblePosition = 7;
            ultraGridColumn59.Header.VisiblePosition = 8;
            ultraGridColumn60.Header.VisiblePosition = 9;
            ultraGridColumn61.Header.VisiblePosition = 10;
            ultraGridColumn62.Header.VisiblePosition = 11;
            ultraGridColumn148.Header.VisiblePosition = 12;
            ultraGridColumn149.Header.VisiblePosition = 13;
            ultraGridColumn150.Header.VisiblePosition = 14;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn148,
            ultraGridColumn149,
            ultraGridColumn150});
            ultraGridColumn151.Header.VisiblePosition = 0;
            ultraGridColumn152.Header.VisiblePosition = 1;
            ultraGridColumn153.Header.VisiblePosition = 2;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153});
            ultraGridColumn154.Header.VisiblePosition = 0;
            ultraGridColumn155.Header.VisiblePosition = 1;
            ultraGridColumn156.Header.VisiblePosition = 2;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn154,
            ultraGridColumn155,
            ultraGridColumn156});
            ultraGridColumn157.Header.VisiblePosition = 0;
            ultraGridColumn158.Header.VisiblePosition = 1;
            ultraGridColumn159.Header.VisiblePosition = 2;
            ultraGridColumn160.Header.VisiblePosition = 3;
            ultraGridColumn161.Header.VisiblePosition = 4;
            ultraGridColumn162.Header.VisiblePosition = 5;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160,
            ultraGridColumn161,
            ultraGridColumn162});
            ultraGridColumn163.Header.VisiblePosition = 0;
            ultraGridColumn164.Header.VisiblePosition = 1;
            ultraGridColumn165.Header.VisiblePosition = 2;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn163,
            ultraGridColumn164,
            ultraGridColumn165});
            ultraGridColumn166.Header.VisiblePosition = 0;
            ultraGridColumn167.Header.VisiblePosition = 1;
            ultraGridColumn168.Header.VisiblePosition = 2;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168});
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraComboProveedor.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance32.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.Appearance = appearance32;
            appearance33.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = appearance33;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance34.BackColor2 = System.Drawing.SystemColors.Control;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance34.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.PromptAppearance = appearance34;
            this.ultraComboProveedor.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboProveedor.DisplayLayout.MaxRowScrollRegions = 1;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraComboProveedor.DisplayLayout.Override.ActiveCellAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.Highlight;
            appearance36.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraComboProveedor.DisplayLayout.Override.ActiveRowAppearance = appearance36;
            this.ultraComboProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance37.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboProveedor.DisplayLayout.Override.CardAreaAppearance = appearance37;
            appearance38.BorderColor = System.Drawing.Color.Silver;
            appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraComboProveedor.DisplayLayout.Override.CellAppearance = appearance38;
            this.ultraComboProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboProveedor.DisplayLayout.Override.CellPadding = 0;
            appearance39.BackColor = System.Drawing.SystemColors.Control;
            appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance39.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboProveedor.DisplayLayout.Override.GroupByRowAppearance = appearance39;
            appearance113.TextHAlignAsString = "Left";
            this.ultraComboProveedor.DisplayLayout.Override.HeaderAppearance = appearance113;
            this.ultraComboProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboProveedor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance118.BackColor = System.Drawing.SystemColors.Window;
            appearance118.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboProveedor.DisplayLayout.Override.RowAppearance = appearance118;
            this.ultraComboProveedor.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance119.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboProveedor.DisplayLayout.Override.TemplateAddRowAppearance = appearance119;
            this.ultraComboProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboProveedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboProveedor.DisplayMember = "NombreCompleto";
            this.ultraComboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboProveedor.LimitToList = true;
            this.ultraComboProveedor.Location = new System.Drawing.Point(75, 9);
            this.ultraComboProveedor.Name = "ultraComboProveedor";
            this.ultraComboProveedor.Size = new System.Drawing.Size(543, 22);
            this.ultraComboProveedor.TabIndex = 4;
            this.ultraComboProveedor.ValueMember = "idProveedor";
            this.ultraComboProveedor.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraComboProveedor_BeforeDropDown);
            this.ultraComboProveedor.ValueChanged += new System.EventHandler(this.ultraComboProveedor_ValueChanged);
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
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance53.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance53;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn169.Header.VisiblePosition = 0;
            ultraGridColumn169.Hidden = true;
            ultraGridColumn170.Header.VisiblePosition = 1;
            ultraGridColumn170.Hidden = true;
            ultraGridColumn171.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn171.Header.VisiblePosition = 2;
            ultraGridColumn172.Header.VisiblePosition = 3;
            ultraGridColumn172.Hidden = true;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn169,
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172});
            ultraGridBand13.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance54.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance55.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance55.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance55;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance56.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance56;
            appearance57.BackColor = System.Drawing.SystemColors.Control;
            appearance57.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance57;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance58.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance58.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance58.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance58;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance59.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance59;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance61.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance61;
            appearance62.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance62;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(309, 366);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownNegocios.TabIndex = 33;
            this.ultraDropDownNegocios.ValueMember = "idNegocio";
            this.ultraDropDownNegocios.Visible = false;
            this.ultraDropDownNegocios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownNegocios_BeforeDropDown);
            // 
            // negociosBindingSource
            // 
            this.negociosBindingSource.DataMember = "Negocios";
            this.negociosBindingSource.DataSource = this.dsNegocios;
            // 
            // dsNegocios
            // 
            this.dsNegocios.DataSetName = "DsNegocios";
            this.dsNegocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownRubros
            // 
            this.ultraDropDownRubros.DataSource = this.rubrosBindingSource;
            appearance63.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRubros.DisplayLayout.Appearance = appearance63;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn173.Header.VisiblePosition = 0;
            ultraGridColumn173.Hidden = true;
            ultraGridColumn174.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn174.Header.VisiblePosition = 1;
            ultraGridColumn174.Hidden = true;
            ultraGridColumn175.Header.VisiblePosition = 2;
            ultraGridColumn175.Hidden = true;
            ultraGridColumn176.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn176.Header.VisiblePosition = 3;
            ultraGridColumn177.Header.VisiblePosition = 4;
            ultraGridColumn177.Hidden = true;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175,
            ultraGridColumn176,
            ultraGridColumn177});
            ultraGridBand14.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridBand14.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand14.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRubros.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownRubros.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRubros.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRubros.DisplayLayout.MaxBandDepth = 5;
            appearance64.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveCellAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance65.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance65.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveRowAppearance = appearance65;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance66.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.CardAreaAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.Control;
            appearance67.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.CellAppearance = appearance67;
            this.ultraDropDownRubros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance68.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance68.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance68.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderAppearance = appearance68;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance69.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSelectorAppearance = appearance69;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedCellAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedRowAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance72.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRubros.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance72;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRubros.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRubros.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRubros.DisplayMember = "NombreCompleto";
            this.ultraDropDownRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRubros.Location = new System.Drawing.Point(309, 326);
            this.ultraDropDownRubros.Name = "ultraDropDownRubros";
            this.ultraDropDownRubros.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownRubros.TabIndex = 32;
            this.ultraDropDownRubros.ValueMember = "idRubro";
            this.ultraDropDownRubros.Visible = false;
            this.ultraDropDownRubros.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownRubros_BeforeDropDown);
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
            // ultraDropDownPorcentajeIVA
            // 
            this.ultraDropDownPorcentajeIVA.DataSource = this.porcentajeIVABindingSource;
            appearance73.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance73;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn178.Header.VisiblePosition = 0;
            ultraGridColumn178.Hidden = true;
            ultraGridColumn179.Header.VisiblePosition = 1;
            ultraGridColumn179.Hidden = true;
            ultraGridColumn180.Header.VisiblePosition = 2;
            ultraGridColumn181.Header.VisiblePosition = 3;
            ultraGridColumn181.Hidden = true;
            ultraGridColumn182.Header.VisiblePosition = 4;
            ultraGridColumn182.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn178,
            ultraGridColumn179,
            ultraGridColumn180,
            ultraGridColumn181,
            ultraGridColumn182});
            ultraGridBand15.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand15.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance74.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance75.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance75.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance75;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance76.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.Control;
            appearance77.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance77;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance78.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance78.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance78.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance78.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance78;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance79.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance79;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance80;
            appearance81.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance81;
            appearance82.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance82.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance82;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(65, 366);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownPorcentajeIVA.TabIndex = 34;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // porcentajeIVABindingSource
            // 
            this.porcentajeIVABindingSource.DataMember = "PorcentajeIVA";
            this.porcentajeIVABindingSource.DataSource = this.dsPorcentajeIVA;
            // 
            // dsPorcentajeIVA
            // 
            this.dsPorcentajeIVA.DataSetName = "DsPorcentajeIVA";
            this.dsPorcentajeIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance83.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance83;
            this.ultraDropDownCategoriasIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn183.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn183.Header.VisiblePosition = 0;
            ultraGridColumn183.Hidden = true;
            ultraGridColumn184.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn184.Header.VisiblePosition = 1;
            ultraGridColumn185.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn185.Header.VisiblePosition = 2;
            ultraGridColumn185.Hidden = true;
            ultraGridColumn186.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn186.Header.VisiblePosition = 3;
            ultraGridColumn186.Hidden = true;
            ultraGridColumn187.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn187.Header.VisiblePosition = 4;
            ultraGridColumn187.Hidden = true;
            ultraGridColumn188.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn188.Header.VisiblePosition = 5;
            ultraGridColumn188.Hidden = true;
            ultraGridColumn189.Header.VisiblePosition = 6;
            ultraGridColumn189.Hidden = true;
            ultraGridColumn190.Header.VisiblePosition = 7;
            ultraGridColumn190.Hidden = true;
            ultraGridColumn191.Header.VisiblePosition = 8;
            ultraGridColumn191.Hidden = true;
            ultraGridColumn192.Header.VisiblePosition = 9;
            ultraGridColumn192.Hidden = true;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn183,
            ultraGridColumn184,
            ultraGridColumn185,
            ultraGridColumn186,
            ultraGridColumn187,
            ultraGridColumn188,
            ultraGridColumn189,
            ultraGridColumn190,
            ultraGridColumn191,
            ultraGridColumn192});
            ultraGridBand16.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance84.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance84;
            appearance85.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance85.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance85.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance85;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance86.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance86;
            appearance87.BackColor = System.Drawing.SystemColors.Control;
            appearance87.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance87;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance88.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance88.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance88.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance88;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance89.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance89;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance90;
            appearance91.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance91.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance92.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance92;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(247, 285);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCategoriasIVA.TabIndex = 77;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            // 
            // categoriasIVABindingSource
            // 
            this.categoriasIVABindingSource.DataMember = "CategoriasIVA";
            this.categoriasIVABindingSource.DataSource = this.dsCategoriasIVA;
            // 
            // dsCategoriasIVA
            // 
            this.dsCategoriasIVA.DataSetName = "DsCategoriasIVA";
            this.dsCategoriasIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsProveedor
            // 
            this.dsProveedor.DataSetName = "DsProveedores";
            this.dsProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas
            // 
            this.dsSistemas.DataSetName = "DsSistemas";
            this.dsSistemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemasBindingSource
            // 
            this.sistemasBindingSource.DataMember = "Sistemas";
            this.sistemasBindingSource.DataSource = this.dsSistemas;
            // 
            // ds_TiposDeComprobante
            // 
            this.ds_TiposDeComprobante.DataSetName = "DsTiposDeComprobante";
            this.ds_TiposDeComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeComprobanteBindingSource
            // 
            this.tiposDeComprobanteBindingSource.DataMember = "TiposDeComprobante";
            this.tiposDeComprobanteBindingSource.DataSource = this.ds_TiposDeComprobante;
            // 
            // ultraDropDownTiposDeComprobante
            // 
            this.ultraDropDownTiposDeComprobante.DataSource = this.tiposDeComprobanteBindingSource;
            appearance40.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Appearance = appearance40;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn193.Header.VisiblePosition = 0;
            ultraGridColumn193.Hidden = true;
            ultraGridColumn194.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn194.Header.VisiblePosition = 1;
            ultraGridColumn195.Header.VisiblePosition = 2;
            ultraGridColumn195.Hidden = true;
            ultraGridColumn196.Header.VisiblePosition = 3;
            ultraGridColumn196.Hidden = true;
            ultraGridColumn197.Header.VisiblePosition = 4;
            ultraGridColumn197.Hidden = true;
            ultraGridColumn198.Header.VisiblePosition = 5;
            ultraGridColumn198.Hidden = true;
            ultraGridColumn199.Header.VisiblePosition = 6;
            ultraGridColumn199.Hidden = true;
            ultraGridColumn200.Header.VisiblePosition = 7;
            ultraGridColumn200.Hidden = true;
            ultraGridColumn201.Header.VisiblePosition = 8;
            ultraGridColumn201.Hidden = true;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn193,
            ultraGridColumn194,
            ultraGridColumn195,
            ultraGridColumn196,
            ultraGridColumn197,
            ultraGridColumn198,
            ultraGridColumn199,
            ultraGridColumn200,
            ultraGridColumn201});
            ultraGridBand17.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraDropDownTiposDeComprobante.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.MaxBandDepth = 5;
            appearance41.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveCellAppearance = appearance41;
            appearance42.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance42.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance42.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveRowAppearance = appearance42;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance43.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CardAreaAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.Control;
            appearance44.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CellAppearance = appearance44;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance45.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance45.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance45.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderAppearance = appearance45;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance46.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSelectorAppearance = appearance46;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedCellAppearance = appearance47;
            appearance48.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance48.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedRowAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance49;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeComprobante.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeComprobante.Location = new System.Drawing.Point(65, 406);
            this.ultraDropDownTiposDeComprobante.Name = "ultraDropDownTiposDeComprobante";
            this.ultraDropDownTiposDeComprobante.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeComprobante.TabIndex = 82;
            this.ultraDropDownTiposDeComprobante.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownTiposDeComprobante.Visible = false;
            this.ultraDropDownTiposDeComprobante.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownTiposDeComprobante_BeforeDropDown);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 626);
            this.Controls.Add(this.comprasUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeComprobante);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownRubros);
            this.Controls.Add(this.ultraComboProveedor);
            this.Controls.Add(this.ultraLabelProveedor);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(357, 194);
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.Shown += new System.EventHandler(this.FormCompra_Shown);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraLabelProveedor, 0);
            this.Controls.SetChildIndex(this.ultraComboProveedor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownRubros, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeComprobante, 0);
            this.Controls.SetChildIndex(this.comprasUltraGrid, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comprasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid comprasUltraGrid;
        private WS.DsProveedores dsProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabelProveedor;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboProveedor;
        private WS.DsProveedores dsProveedor;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private WS.DsRubros dsRubros;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNegocios;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRubros;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPorcentajeIVA;
        private AdministracionNegocios.DsParametros dsParametros;
        private WS.DsSistemas dsSistemas;
        private System.Windows.Forms.BindingSource sistemasBindingSource;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private WS.DsCompra dsCompra;
        private WS.DsTiposDeComprobante ds_TiposDeComprobante;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeComprobante;
    }
}
