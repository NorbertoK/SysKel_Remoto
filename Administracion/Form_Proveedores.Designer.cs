namespace Administracion
{
    partial class FormProveedores
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
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalNegocios", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Porcentaje", 3, true, "FK_NegociosDelProveedor_Proveedores", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance("TotalNegocios");
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidades");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Rubros", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AdmiteValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturaE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeCE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeDE");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            this.proveedoresUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Proveedores = new Administracion.WS.DsProveedores();
            this.ultraDropDownRubros = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRubros = new Administracion.WS.DsRubros();
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNegocios = new Administracion.WS.DsNegocios();
            this.localidadesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidadesLista = new Administracion.WS.DsLocalidadesLista();
            this.dsCallesLista = new Administracion.WS.DsCallesLista();
            this.bindingSourceCalle = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Administracion.WS.DsBarrios();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategoriasIVA = new Administracion.WS.DsCategoriasIVA();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownLocalidades = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownCalle = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsParametros = new AdministracionNegocios.DsParametros();
            this.ds_TiposDeComprobante = new Administracion.WS.DsTiposDeComprobante();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownTiposDeComprobante = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(667, 16);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(222, 16);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(757, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(586, 16);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // proveedoresUltraGrid
            // 
            this.proveedoresUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedoresUltraGrid.DataSource = this.proveedoresBindingSource;
            appearance93.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.proveedoresUltraGrid.DisplayLayout.Appearance = appearance93;
            ultraGridColumn91.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn91.Header.VisiblePosition = 0;
            ultraGridColumn91.Hidden = true;
            ultraGridColumn91.Width = 77;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn92.DefaultCellValue = "True";
            ultraGridColumn92.Header.VisiblePosition = 6;
            ultraGridColumn92.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn92.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn92.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(48, 0);
            ultraGridColumn92.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(48, 0);
            ultraGridColumn92.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn92.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn92.TabIndex = 3;
            ultraGridColumn92.Width = 72;
            ultraGridColumn93.Header.Caption = "Razón Social";
            ultraGridColumn93.Header.VisiblePosition = 1;
            ultraGridColumn93.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn93.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn93.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(376, 0);
            ultraGridColumn93.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(376, 18);
            ultraGridColumn93.RowLayoutColumnInfo.SpanX = 11;
            ultraGridColumn93.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn93.TabIndex = 1;
            ultraGridColumn93.Width = 133;
            ultraGridColumn94.Header.Caption = "Nombre Fantasía";
            ultraGridColumn94.Header.VisiblePosition = 2;
            ultraGridColumn94.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn94.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn94.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(258, 0);
            ultraGridColumn94.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(258, 18);
            ultraGridColumn94.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn94.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn94.TabIndex = 2;
            ultraGridColumn94.Width = 127;
            appearance36.TextHAlignAsString = "Center";
            ultraGridColumn95.CellAppearance = appearance36;
            ultraGridColumn95.Header.VisiblePosition = 3;
            ultraGridColumn95.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn95.MaskInput = "##-##,###,###-#";
            ultraGridColumn95.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn95.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn95.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn95.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(93, 0);
            ultraGridColumn95.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn95.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn95.TabIndex = 6;
            ultraGridColumn95.Width = 125;
            ultraGridColumn96.Header.VisiblePosition = 4;
            ultraGridColumn96.Hidden = true;
            ultraGridColumn96.Width = 106;
            ultraGridColumn97.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn97.Header.Caption = "Rubro";
            ultraGridColumn97.Header.VisiblePosition = 5;
            ultraGridColumn97.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn97.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn97.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn97.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn97.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn97.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn97.TabIndex = 8;
            ultraGridColumn97.Width = 68;
            ultraGridColumn98.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn98.Header.Caption = "Categoría IVA";
            ultraGridColumn98.Header.VisiblePosition = 7;
            ultraGridColumn98.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn98.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(135, 0);
            ultraGridColumn98.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(135, 0);
            ultraGridColumn98.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn98.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn98.TabIndex = 5;
            ultraGridColumn99.Header.Caption = "Ingresos Brutos";
            ultraGridColumn99.Header.VisiblePosition = 8;
            ultraGridColumn99.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn99.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn99.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(129, 0);
            ultraGridColumn99.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(91, 0);
            ultraGridColumn99.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn99.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn99.TabIndex = 7;
            ultraGridColumn100.Header.VisiblePosition = 9;
            ultraGridColumn100.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn100.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn100.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(682, 0);
            ultraGridColumn100.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(376, 0);
            ultraGridColumn100.RowLayoutColumnInfo.SpanX = 11;
            ultraGridColumn100.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn101.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn101.Header.Caption = "Tipo de Comprobante";
            ultraGridColumn101.Header.VisiblePosition = 10;
            ultraGridColumn101.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn101.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn101.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn101.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn102.Header.VisiblePosition = 11;
            ultraGridColumn103.Header.VisiblePosition = 12;
            ultraGridColumn104.Header.VisiblePosition = 13;
            ultraGridColumn105.Header.VisiblePosition = 14;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97,
            ultraGridColumn98,
            ultraGridColumn99,
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104,
            ultraGridColumn105});
            appearance37.FontData.BoldAsString = "True";
            appearance37.FontData.SizeInPoints = 10F;
            appearance37.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance37;
            ultraGridBand1.Header.Caption = "Proveedor";
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn106.Header.VisiblePosition = 0;
            ultraGridColumn106.Hidden = true;
            ultraGridColumn106.Width = 223;
            ultraGridColumn107.Header.VisiblePosition = 1;
            ultraGridColumn107.Hidden = true;
            ultraGridColumn107.Width = 132;
            ultraGridColumn108.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn108.Header.Caption = "Negocio";
            ultraGridColumn108.Header.VisiblePosition = 2;
            ultraGridColumn108.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(165, 0);
            ultraGridColumn108.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn108.Width = 431;
            appearance38.TextHAlignAsString = "Right";
            ultraGridColumn109.CellAppearance = appearance38;
            ultraGridColumn109.Header.Caption = "%";
            ultraGridColumn109.Header.VisiblePosition = 3;
            ultraGridColumn109.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn109.MaskInput = "nnn%";
            ultraGridColumn109.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(69, 0);
            ultraGridColumn109.Width = 178;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn106,
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109});
            appearance39.FontData.BoldAsString = "True";
            appearance39.FontData.SizeInPoints = 10F;
            appearance39.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance39;
            ultraGridBand2.Header.Caption = "Negocios";
            ultraGridBand2.Header.TextOrientation = new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            ultraGridBand2.HeaderVisible = true;
            ultraGridBand2.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            appearance51.FontData.BoldAsString = "True";
            appearance51.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance51;
            summarySettings1.DisplayFormat = "Total {0:###}%";
            summarySettings1.GroupBySummaryValueAppearance = appearance52;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridBand2.SummaryFooterCaption = "";
            ultraGridBand2.VisiblePosition = 10;
            ultraGridColumn110.Header.VisiblePosition = 0;
            ultraGridColumn110.Hidden = true;
            ultraGridColumn111.DefaultCellValue = "True";
            ultraGridColumn111.Header.VisiblePosition = 1;
            ultraGridColumn111.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn111.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn111.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(69, 56);
            ultraGridColumn111.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(69, 0);
            ultraGridColumn111.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn111.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn111.Width = 214;
            ultraGridColumn112.DefaultCellValue = "True";
            ultraGridColumn112.Header.Caption = "Pago";
            ultraGridColumn112.Header.VisiblePosition = 2;
            ultraGridColumn112.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn112.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn112.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(69, 56);
            ultraGridColumn112.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(69, 0);
            ultraGridColumn112.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn112.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn112.Width = 311;
            ultraGridColumn113.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn113.Header.Caption = "Calle";
            ultraGridColumn113.Header.VisiblePosition = 3;
            ultraGridColumn113.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn113.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(162, 0);
            ultraGridColumn113.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(162, 0);
            ultraGridColumn113.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn113.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn114.Header.Caption = "Número";
            ultraGridColumn114.Header.VisiblePosition = 4;
            ultraGridColumn114.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn114.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn114.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(65, 0);
            ultraGridColumn114.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn114.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn114.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn115.Header.VisiblePosition = 5;
            ultraGridColumn115.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn115.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn115.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(43, 0);
            ultraGridColumn115.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn115.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn115.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn116.Header.VisiblePosition = 6;
            ultraGridColumn116.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn116.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn116.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn116.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(84, 0);
            ultraGridColumn116.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn116.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn117.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn117.Header.Caption = "entre";
            ultraGridColumn117.Header.VisiblePosition = 7;
            ultraGridColumn117.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn117.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(0, 18);
            ultraGridColumn117.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn117.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn117.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn118.Header.Caption = "y";
            ultraGridColumn118.Header.VisiblePosition = 8;
            ultraGridColumn118.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn118.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn118.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn118.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn118.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn119.Header.VisiblePosition = 9;
            ultraGridColumn119.Hidden = true;
            ultraGridColumn120.Header.VisiblePosition = 10;
            ultraGridColumn120.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn120.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn120.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(356, 56);
            ultraGridColumn120.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn120.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn121.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn121.Header.Caption = "Barrio";
            ultraGridColumn121.Header.VisiblePosition = 11;
            ultraGridColumn121.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn121.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn121.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            ultraGridColumn121.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(123, 0);
            ultraGridColumn121.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn121.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn121.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn122.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn122.Header.Caption = "Localidad";
            ultraGridColumn122.Header.VisiblePosition = 12;
            ultraGridColumn122.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn122.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn122.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(138, 0);
            ultraGridColumn122.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(138, 0);
            ultraGridColumn122.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn122.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn122.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn123.Header.VisiblePosition = 13;
            ultraGridColumn123.Hidden = true;
            ultraGridColumn124.Header.VisiblePosition = 14;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn110,
            ultraGridColumn111,
            ultraGridColumn112,
            ultraGridColumn113,
            ultraGridColumn114,
            ultraGridColumn115,
            ultraGridColumn116,
            ultraGridColumn117,
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122,
            ultraGridColumn123,
            ultraGridColumn124});
            appearance55.FontData.BoldAsString = "True";
            appearance55.FontData.SizeInPoints = 10F;
            appearance55.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance55;
            ultraGridBand3.Header.Caption = "Direcciones";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.MaxRows = 2;
            ultraGridBand3.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand4.CardSettings.ShowCaption = false;
            ultraGridBand4.CardView = true;
            ultraGridColumn125.Header.VisiblePosition = 0;
            ultraGridColumn125.Hidden = true;
            ultraGridColumn125.Width = 195;
            ultraGridColumn126.Header.VisiblePosition = 1;
            ultraGridColumn126.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn126.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn126.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(114, 0);
            ultraGridColumn126.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn126.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn126.Width = 311;
            ultraGridColumn127.Header.VisiblePosition = 2;
            ultraGridColumn127.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn125,
            ultraGridColumn126,
            ultraGridColumn127});
            appearance56.FontData.BoldAsString = "True";
            appearance56.FontData.SizeInPoints = 10F;
            appearance56.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance56;
            ultraGridBand4.Header.Caption = "Tel. Dirección";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.MaxRows = 7;
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn128.Header.VisiblePosition = 0;
            ultraGridColumn128.Hidden = true;
            ultraGridColumn129.Header.VisiblePosition = 1;
            ultraGridColumn129.Width = 214;
            ultraGridColumn130.Header.VisiblePosition = 2;
            ultraGridColumn130.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130});
            appearance57.FontData.BoldAsString = "True";
            appearance57.FontData.SizeInPoints = 10F;
            appearance57.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance57;
            ultraGridBand5.Header.Caption = "e-mail";
            ultraGridBand5.HeaderVisible = true;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn131.Header.VisiblePosition = 0;
            ultraGridColumn131.Hidden = true;
            ultraGridColumn132.Header.VisiblePosition = 1;
            ultraGridColumn132.Width = 214;
            ultraGridColumn133.Header.VisiblePosition = 2;
            ultraGridColumn133.Width = 311;
            ultraGridColumn134.Header.VisiblePosition = 3;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn135.Header.VisiblePosition = 4;
            ultraGridColumn136.Header.VisiblePosition = 5;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133,
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136});
            appearance58.FontData.BoldAsString = "True";
            appearance58.FontData.SizeInPoints = 10F;
            appearance58.TextHAlignAsString = "Left";
            ultraGridBand6.Header.Appearance = appearance58;
            ultraGridBand6.Header.Caption = "Contactos";
            ultraGridBand6.HeaderVisible = true;
            ultraGridBand7.CardSettings.ShowCaption = false;
            ultraGridBand7.CardView = true;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn137.Header.VisiblePosition = 0;
            ultraGridColumn137.Hidden = true;
            ultraGridColumn138.Header.VisiblePosition = 1;
            ultraGridColumn139.Header.VisiblePosition = 2;
            ultraGridColumn139.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139});
            appearance80.FontData.BoldAsString = "True";
            appearance80.FontData.SizeInPoints = 10F;
            appearance80.TextHAlignAsString = "Left";
            ultraGridBand7.Header.Appearance = appearance80;
            ultraGridBand7.Header.Caption = "Teléfonos";
            ultraGridBand7.HeaderVisible = true;
            ultraGridBand7.MaxRows = 7;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn140.Header.VisiblePosition = 0;
            ultraGridColumn140.Hidden = true;
            ultraGridColumn140.Width = 120;
            ultraGridColumn141.Header.VisiblePosition = 1;
            ultraGridColumn141.Width = 195;
            ultraGridColumn142.Header.VisiblePosition = 2;
            ultraGridColumn142.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142});
            appearance84.FontData.BoldAsString = "True";
            appearance84.FontData.SizeInPoints = 10F;
            appearance84.TextHAlignAsString = "Left";
            ultraGridBand8.Header.Appearance = appearance84;
            ultraGridBand8.Header.Caption = "e-mail";
            ultraGridBand8.HeaderVisible = true;
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.proveedoresUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.proveedoresUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.proveedoresUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            this.proveedoresUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance106.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance106.ForeColor = System.Drawing.SystemColors.WindowText;
            this.proveedoresUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance106;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance107.BackColor = System.Drawing.Color.Transparent;
            this.proveedoresUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.Control;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.proveedoresUltraGrid.DisplayLayout.Override.CellAppearance = appearance108;
            this.proveedoresUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance109.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance109.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.proveedoresUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance109;
            this.proveedoresUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance110.ForeColor = System.Drawing.Color.Red;
            this.proveedoresUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance110;
            this.proveedoresUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.proveedoresUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance111;
            appearance112.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.proveedoresUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.proveedoresUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance113;
            this.proveedoresUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.proveedoresUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.proveedoresUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.proveedoresUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.proveedoresUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.proveedoresUltraGrid.Location = new System.Drawing.Point(12, -4);
            this.proveedoresUltraGrid.MaximumSize = new System.Drawing.Size(742, 561);
            this.proveedoresUltraGrid.MinimumSize = new System.Drawing.Size(742, 561);
            this.proveedoresUltraGrid.Name = "proveedoresUltraGrid";
            this.proveedoresUltraGrid.Size = new System.Drawing.Size(742, 561);
            this.proveedoresUltraGrid.TabIndex = 2;
            this.proveedoresUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ProveedoresUltraGrid_InitializeRow);
            this.proveedoresUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ProveedoresUltraGridAfterEnterEditMode);
            this.proveedoresUltraGrid.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.ProveedoresUltraGrid_AfterRowUpdate);
            this.proveedoresUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ProveedoresUltraGrid_CellChange);
            this.proveedoresUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.proveedoresUltraGrid_BeforeCellDeactivate);
            this.proveedoresUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.ProveedoresUltraGrid_BeforeRowDeactivate);
            this.proveedoresUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.ProveedoresUltraGrid_BeforeRowsDeleted);
            this.proveedoresUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.proveedoresUltraGrid_KeyDown);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.ds_Proveedores;
            // 
            // ds_Proveedores
            // 
            this.ds_Proveedores.DataSetName = "DsProveedores";
            this.ds_Proveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownRubros
            // 
            this.ultraDropDownRubros.DataSource = this.rubrosBindingSource;
            appearance61.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRubros.DisplayLayout.Appearance = appearance61;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn53.Header.VisiblePosition = 0;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn54.Header.VisiblePosition = 1;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn55.Header.VisiblePosition = 2;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn56.Header.VisiblePosition = 3;
            ultraGridColumn57.Header.VisiblePosition = 4;
            ultraGridColumn57.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57});
            ultraGridBand9.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridBand9.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRubros.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownRubros.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRubros.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRubros.DisplayLayout.MaxBandDepth = 5;
            appearance62.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveCellAppearance = appearance62;
            appearance63.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance63.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance63.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveRowAppearance = appearance63;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance74.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.CardAreaAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.Control;
            appearance75.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.CellAppearance = appearance75;
            this.ultraDropDownRubros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance76.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance76.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance76.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance76.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderAppearance = appearance76;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance77.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSelectorAppearance = appearance77;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedCellAppearance = appearance78;
            appearance79.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance79.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedRowAppearance = appearance79;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRubros.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRubros.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRubros.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRubros.DisplayMember = "NombreCompleto";
            this.ultraDropDownRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRubros.Location = new System.Drawing.Point(233, 273);
            this.ultraDropDownRubros.Name = "ultraDropDownRubros";
            this.ultraDropDownRubros.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownRubros.TabIndex = 28;
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
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance59.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance59;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn58.Header.VisiblePosition = 0;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn59.Header.VisiblePosition = 1;
            ultraGridColumn59.Hidden = true;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn60.Header.VisiblePosition = 2;
            ultraGridColumn61.Header.VisiblePosition = 3;
            ultraGridColumn61.Hidden = true;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61});
            ultraGridBand10.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand10.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance60.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance60;
            appearance81.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance81.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance81;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance82.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.Control;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance83;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance14;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance15.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance15;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance16;
            appearance53.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance53.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance54;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(233, 313);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownNegocios.TabIndex = 29;
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
            // localidadesListaBindingSource
            // 
            this.localidadesListaBindingSource.DataMember = "LocalidadesLista";
            this.localidadesListaBindingSource.DataSource = this.dsLocalidadesLista;
            // 
            // dsLocalidadesLista
            // 
            this.dsLocalidadesLista.DataSetName = "DsLocalidadesLista";
            this.dsLocalidadesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCallesLista
            // 
            this.dsCallesLista.DataSetName = "DsCallesLista";
            this.dsCallesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceCalle
            // 
            this.bindingSourceCalle.DataMember = "Calles";
            this.bindingSourceCalle.DataSource = this.dsCallesLista;
            // 
            // dsBarrios
            // 
            this.dsBarrios.DataSetName = "DsBarrios";
            this.dsBarrios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataSource = this.dsBarrios;
            this.barriosBindingSource.Position = 0;
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
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.DataSource = this.barriosBindingSource;
            appearance64.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance64.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance64;
            this.ultraDropDownBarrios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.Header.VisiblePosition = 0;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn62.Width = 57;
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn63.Header.VisiblePosition = 1;
            ultraGridColumn63.Width = 231;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn64.Header.VisiblePosition = 2;
            ultraGridColumn64.Hidden = true;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64});
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance65.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance65;
            appearance66.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance66.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance66.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance66;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance67.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.Control;
            appearance68.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance68;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance69.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance69.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance69.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance69;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance70.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance70;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance72.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance72;
            appearance73.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance73;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.DropDownWidth = 250;
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(233, 393);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownBarrios.TabIndex = 71;
            this.ultraDropDownBarrios.ValueMember = "idBarrio";
            this.ultraDropDownBarrios.Visible = false;
            this.ultraDropDownBarrios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownBarriosBeforeDropDown);
            this.ultraDropDownBarrios.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarriosFilterRow);
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownCategoriasIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.Header.VisiblePosition = 0;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn66.Header.VisiblePosition = 1;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.Header.VisiblePosition = 2;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn68.Header.VisiblePosition = 3;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn69.Header.VisiblePosition = 4;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn70.Header.VisiblePosition = 5;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.Header.VisiblePosition = 6;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn72.Header.VisiblePosition = 7;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn73.Header.VisiblePosition = 8;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn74.Header.VisiblePosition = 9;
            ultraGridColumn74.Hidden = true;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74});
            ultraGridBand12.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand12.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance26.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance26;
            appearance27.BackColor = System.Drawing.SystemColors.Control;
            appearance27.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance27;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance28.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance28.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance28.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance28;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance29.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance29;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance31.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance31;
            appearance32.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance32;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(233, 233);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCategoriasIVA.TabIndex = 76;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            this.ultraDropDownCategoriasIVA.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCategoriasIVABeforeDropDown);
            // 
            // ultraDropDownLocalidades
            // 
            this.ultraDropDownLocalidades.DataSource = this.localidadesListaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidades.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownLocalidades.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn75.Header.VisiblePosition = 0;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn75.Width = 91;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn76.Header.VisiblePosition = 1;
            ultraGridColumn76.Width = 219;
            ultraGridColumn77.Header.VisiblePosition = 2;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn77.Width = 58;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77});
            this.ultraDropDownLocalidades.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownLocalidades.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidades.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidades.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidades.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidades.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidades.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidades.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownLocalidades.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidades.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownLocalidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidades.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownLocalidades.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidades.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidades.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidades.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownLocalidades.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidades.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidades.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidades.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidades.Location = new System.Drawing.Point(233, 434);
            this.ultraDropDownLocalidades.Name = "ultraDropDownLocalidades";
            this.ultraDropDownLocalidades.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownLocalidades.TabIndex = 77;
            this.ultraDropDownLocalidades.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidades.Visible = false;
            this.ultraDropDownLocalidades.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadesRowSelected);
            // 
            // ultraDropDownCalle
            // 
            this.ultraDropDownCalle.DataSource = this.bindingSourceCalle;
            appearance174.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance174.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalle.DisplayLayout.Appearance = appearance174;
            this.ultraDropDownCalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn78.Header.VisiblePosition = 0;
            ultraGridColumn78.Hidden = true;
            ultraGridColumn78.Width = 39;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn79.Header.VisiblePosition = 1;
            ultraGridColumn79.Hidden = true;
            ultraGridColumn79.Width = 231;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 2;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn80.Width = 51;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn81.Header.VisiblePosition = 3;
            ultraGridColumn81.Width = 231;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81});
            this.ultraDropDownCalle.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownCalle.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalle.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalle.DisplayLayout.MaxBandDepth = 5;
            appearance175.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveCellAppearance = appearance175;
            appearance176.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance176.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance176.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveRowAppearance = appearance176;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance177.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.CardAreaAppearance = appearance177;
            appearance178.BackColor = System.Drawing.SystemColors.Control;
            appearance178.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.CellAppearance = appearance178;
            this.ultraDropDownCalle.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance179.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance179.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance179.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance179.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderAppearance = appearance179;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance180.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSelectorAppearance = appearance180;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedCellAppearance = appearance181;
            appearance182.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance182.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedRowAppearance = appearance182;
            appearance183.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance183.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalle.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance183;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalle.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalle.DisplayMember = "Nombre";
            this.ultraDropDownCalle.DropDownWidth = 250;
            this.ultraDropDownCalle.Location = new System.Drawing.Point(233, 474);
            this.ultraDropDownCalle.Name = "ultraDropDownCalle";
            this.ultraDropDownCalle.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownCalle.TabIndex = 78;
            this.ultraDropDownCalle.ValueMember = "idCalle";
            this.ultraDropDownCalle.Visible = false;
            this.ultraDropDownCalle.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCalleBeforeDropDown);
            this.ultraDropDownCalle.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalleFilterRow);
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn82.Header.VisiblePosition = 0;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn83.Header.VisiblePosition = 1;
            ultraGridColumn84.Header.VisiblePosition = 2;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn85.Header.VisiblePosition = 3;
            ultraGridColumn85.Hidden = true;
            ultraGridColumn86.Header.VisiblePosition = 4;
            ultraGridColumn86.Hidden = true;
            ultraGridColumn87.Header.VisiblePosition = 5;
            ultraGridColumn87.Hidden = true;
            ultraGridColumn88.Header.VisiblePosition = 6;
            ultraGridColumn88.Hidden = true;
            ultraGridColumn89.Header.VisiblePosition = 7;
            ultraGridColumn89.Hidden = true;
            ultraGridColumn90.Header.VisiblePosition = 8;
            ultraGridColumn90.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85,
            ultraGridColumn86,
            ultraGridColumn87,
            ultraGridColumn88,
            ultraGridColumn89,
            ultraGridColumn90});
            ultraGridBand15.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand15.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
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
            this.ultraDropDownTiposDeComprobante.Location = new System.Drawing.Point(233, 353);
            this.ultraDropDownTiposDeComprobante.Name = "ultraDropDownTiposDeComprobante";
            this.ultraDropDownTiposDeComprobante.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeComprobante.TabIndex = 81;
            this.ultraDropDownTiposDeComprobante.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownTiposDeComprobante.Visible = false;
            this.ultraDropDownTiposDeComprobante.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownTiposDeComprobante_BeforeDropDown);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(756, 612);
            this.Controls.Add(this.proveedoresUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeComprobante);
            this.Controls.Add(this.ultraDropDownCalle);
            this.Controls.Add(this.ultraDropDownLocalidades);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Controls.Add(this.ultraDropDownBarrios);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownRubros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(918, 651);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormABCProveedoresLoad);
            this.Controls.SetChildIndex(this.ultraDropDownRubros, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBarrios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidades, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalle, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeComprobante, 0);
            this.Controls.SetChildIndex(this.proveedoresUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administracion.WS.DsProveedores ds_Proveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid proveedoresUltraGrid;
        private WS.DsRubros dsRubros;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRubros;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNegocios;
        private System.Windows.Forms.BindingSource localidadesListaBindingSource;
        private WS.DsLocalidadesLista dsLocalidadesLista;
        private WS.DsCallesLista dsCallesLista;
        private System.Windows.Forms.BindingSource bindingSourceCalle;
        private WS.DsBarrios dsBarrios;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidades;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalle;
        private AdministracionNegocios.DsParametros dsParametros;
        private WS.DsTiposDeComprobante ds_TiposDeComprobante;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeComprobante;
    }
}
