using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand24 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Clientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza", -1, "ultraDropDownTiposDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza", -1, "ultraDropDownEntidadesDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCliente", -1, "ultraDropDownTiposDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VencimientoTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocumentoTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonoTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Convenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpresasSueldoBcoMacro", -1, "ultraDropDownEmpresasSueldoBancoMacro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Direcciones__Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contratos_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_FacturasProforma_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_EmailsClientes_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrador", 0);
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand25 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Direcciones__Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona", -1, "ultraDropDownZonas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__Direcciones");
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand26 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__Direcciones", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand27 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand28 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance193 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand29 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance205 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand30 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contratos_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Condiciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato", -1, "ultraDropDownTiposDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Ene");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Abr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("May");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Ago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Oct", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Dic");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Solicitudes_Contratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Planes_Contratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Contratos");
            Infragistics.Win.Appearance appearance206 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand31 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Solicitudes_Contratos", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AltaBajaSusp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Renovacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRegistro", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idVendedor", -1, "ultraDropDownVendedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTomadorDeBaja", -1, "ultraDropDownTomadoresDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja", -1, "ultraDropDownMotivosDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idSolicitud");
            Infragistics.Win.Appearance appearance232 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand32 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Planes_Contratos", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuota");
            Infragistics.Win.Appearance appearance233 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProteccion", -1, "ultraDropDownProtecciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CuotaAdherente");
            Infragistics.Win.Appearance appearance236 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance237 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand33 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Contratos", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF911");
            Infragistics.Win.Appearance appearance238 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand34 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF911", 9);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.Appearance appearance243 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand35 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_FacturasProforma_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion", -1, "ultraDropDownTandasDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturarMes", -1, "ultraDropDownFacturarMes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_RenglonesFacturaProforma_FacturasProforma1");
            Infragistics.Win.Appearance appearance244 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand36 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_RenglonesFacturaProforma_FacturasProforma1", 11);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRenglonFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance255 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.Appearance appearance256 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato", -1, "ultraDropDownContratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RevisarMensualmente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan", -1, "ultraDropDownPlanes");
            Infragistics.Win.Appearance appearance259 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Titulares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitarioEscrito");
            Infragistics.Win.Appearance appearance257 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand37 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_EmailsClientes_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.Appearance appearance258 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.Appearance appearance228 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance230 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance231 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance234 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance235 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance239 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance240 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance241 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance242 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand22 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn239 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn240 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn241 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn242 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance200 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand20 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Zonas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn230 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn231 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn232 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn233 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn234 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn235 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.Appearance appearance201 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance202 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance203 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance204 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand19 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn227 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn228 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn229 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance195 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance196 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance197 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance198 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance199 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand18 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn222 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn223 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn224 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn225 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereZonaDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn226 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDireccionReal");
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EntidadesDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn207 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn208 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn209 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn210 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MascaraTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn211 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNumero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn212 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereVencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn213 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNombreTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn214 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDocTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn215 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereTelTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn216 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn217 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereConvenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn218 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereSucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn219 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn220 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereJubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn221 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeContrato", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn204 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn205 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn206 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn197 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn198 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn199 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn200 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn201 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn202 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn203 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn190 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn191 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn192 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn193 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn194 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn195 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn196 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeBaja", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn188 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn189 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn183 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn184 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn185 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn186 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn187 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn178 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn179 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn180 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturaE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn181 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeCE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn182 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeDE");
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance194 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance217 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance229 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ContratosRenglonFactura", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance171 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TandasDeFacturacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand21 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn236 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn237 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn238 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PlanesDelCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Protecciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProteccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance207 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance208 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance209 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance210 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance211 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance212 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance213 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance214 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance215 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance216 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance218 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance219 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance220 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance221 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance222 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance223 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance224 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance225 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance226 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance227 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto");
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand23 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn243 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn244 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn245 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn246 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn247 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpresasSueldoBcoMacro", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpresasSueldoBcoMacro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            this.clientesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new Administracion.WS.DsClientes();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.ultraDropDownCalle = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Administracion.WS.DsCallesLista();
            this.ultraDropDownZonas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.zonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZonas = new Administracion.WS.DsZonas();
            this.ultraDropDownTiposDeCliente = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeCliente = new Administracion.WS.DsTiposDeCliente();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategoriasIVA = new Administracion.WS.DsCategoriasIVA();
            this.ultraDropDownTiposDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeCobranza = new Administracion.WS.DsTiposDeCobranza();
            this.ultraDropDownEntidadesDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.entidadesDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEntidadesDeCobranza = new Administracion.WS.DsEntidadesDeCobranza();
            this.ultraDropDownTiposDeContrato = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeContrato = new Administracion.WS.DsTiposDeContrato();
            this.ultraDropDownVendedores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.vendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVendedores = new Administracion.WS.DsEmpleadosLista();
            this.ultraDropDownTomadoresDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tomadoresDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTomadoresDeBaja = new Administracion.WS.DsEmpleadosLista();
            this.ultraDropDownMotivosDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeBaja = new Administracion.WS.DsMotivosDeBaja();
            this.ultraDropDownCodigos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodigos = new Administracion.WS.DsCodigos();
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios1 = new Administracion.WS.DsBarrios();
            this.ultraDropDownContratos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.contratosRenglonFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Administracion.WS.DsContratosLista();
            this.ultraDropDownTandasDeFacturacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tandasDeFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTandasDeFacturacion = new Administracion.WS.DsTandasDeFacturacion();
            this.dsSistemas1 = new Administracion.WS.DsSistemas();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidadesLista = new Administracion.WS.DsLocalidadesLista();
            this.dscuitRepetibles1 = new Administracion.WS.DsCUITRepetibles();
            this.dsPlanes1 = new Administracion.WS.DsPlanes();
            this.ultraDropDownPlanes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.planesDelClientebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtecciones = new Administracion.WS.DsProtecciones();
            this.proteccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownProtecciones = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Administracion.WS.DsUsuariosLista();
            this.dsPrepagos = new Administracion.WS.DsPrepagos();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDataSourceFacturarMes = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownFacturarMes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsNegocios = new Administracion.WS.DsNegocios();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsPorcentajeIVA = new Administracion.WS.DsPorcentajeIVA();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsParametros = new Administracion.WS.DsParametros();
            this.dsEmpresasSueldoBancoMacro = new Administracion.WS.DsEmpresasSueldoBancoMacro();
            this.empresasSueldoBcoMacroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownEmpresasSueldoBancoMacro = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosRenglonFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscuitRepetibles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDelClientebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProtecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceFacturarMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownFacturarMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresasSueldoBancoMacro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEmpresasSueldoBancoMacro)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(811, 13);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(730, 13);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Location = new System.Drawing.Point(1, 532);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(899, 45);
            this.panel1.Controls.SetChildIndex(this.buttonSalir, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(649, 13);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // clientesUltraGrid
            // 
            this.clientesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.clientesUltraGrid.DataSource = this.clientesBindingSource;
            appearance185.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance185.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance185.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.clientesUltraGrid.DisplayLayout.Appearance = appearance185;
            ultraGridBand24.ColHeaderLines = 2;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 15;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.Caption = "Razón Social";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(215, 0);
            ultraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(215, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Width = 39;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.Caption = "Nombre Fantasía";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(213, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(213, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Width = 37;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn4.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn4.Header.Caption = "Categoría IVA";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(94, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(94, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn4.Width = 32;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance186.TextHAlignAsString = "Center";
            ultraGridColumn5.CellAppearance = appearance186;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn5.MaskInput = "##-##,###,###-#";
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 15;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.Width = 37;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn6.Header.Caption = "Tipo de Cobranza";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn6.Width = 40;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn7.Header.Caption = "Entidad de Cobranza";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(51, 0);
            ultraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(51, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn7.Width = 46;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn8.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn8.Header.Caption = "Rubro";
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(101, 0);
            ultraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(101, 0);
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn8.Width = 36;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.Caption = "Número Tarjeta";
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(118, 0);
            ultraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(118, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn10.Header.Caption = "Vencimiento";
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(17, 0);
            ultraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(17, 0);
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.Caption = "Nombre Titular Tarjeta";
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(101, 0);
            ultraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(101, 0);
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.Caption = " Doc. Titular Tarjeta";
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn12.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(94, 0);
            ultraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(94, 0);
            ultraGridColumn12.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.Caption = "Tel. Titular Tarjeta";
            ultraGridColumn13.Header.VisiblePosition = 13;
            ultraGridColumn13.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn13.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn13.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn13.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance188.TextHAlignAsString = "Center";
            ultraGridColumn14.CellAppearance = appearance188;
            ultraGridColumn14.Header.Caption = "Ing. Brutos";
            ultraGridColumn14.Header.VisiblePosition = 12;
            ultraGridColumn14.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn14.MaskInput = "##-######-#";
            ultraGridColumn14.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn14.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(100, 0);
            ultraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(100, 0);
            ultraGridColumn14.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn14.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn15.Header.VisiblePosition = 14;
            ultraGridColumn15.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn15.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(95, 0);
            ultraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn15.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn15.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn16.Header.VisiblePosition = 16;
            ultraGridColumn16.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn16.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn16.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn16.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn17.Header.VisiblePosition = 17;
            ultraGridColumn17.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn17.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn17.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn17.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn18.Header.VisiblePosition = 18;
            ultraGridColumn18.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn18.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn18.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn18.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn19.Header.Caption = "EmpresaBcoMacro";
            ultraGridColumn19.Header.VisiblePosition = 19;
            ultraGridColumn19.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn19.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(59, 0);
            ultraGridColumn19.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(112, 0);
            ultraGridColumn19.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn19.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn20.Header.VisiblePosition = 21;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 20;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn22.Header.VisiblePosition = 22;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 23;
            ultraGridColumn24.Header.VisiblePosition = 24;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn25.Header.VisiblePosition = 15;
            ultraGridColumn25.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn25.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(100, 0);
            ultraGridColumn25.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(100, 0);
            ultraGridColumn25.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn25.RowLayoutColumnInfo.SpanY = 2;
            ultraGridBand24.Columns.AddRange(new object[] {
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
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25});
            appearance189.FontData.BoldAsString = "True";
            appearance189.FontData.SizeInPoints = 11F;
            appearance189.TextHAlignAsString = "Left";
            ultraGridBand24.Header.Appearance = appearance189;
            ultraGridBand24.Header.Caption = "Cliente";
            ultraGridBand24.HeaderVisible = true;
            ultraGridBand24.MaxRows = 1;
            ultraGridBand24.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand24.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn26.Header.VisiblePosition = 0;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn26.Width = 45;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn27.DefaultCellValue = "True";
            ultraGridColumn27.Header.VisiblePosition = 1;
            ultraGridColumn27.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn27.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 56);
            ultraGridColumn27.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(76, 0);
            ultraGridColumn27.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn27.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn27.Width = 25;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn28.DefaultCellValue = "True";
            ultraGridColumn28.Header.VisiblePosition = 2;
            ultraGridColumn28.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn28.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(0, 56);
            ultraGridColumn28.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn28.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn28.Width = 47;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn29.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn29.Header.Caption = "Calle";
            ultraGridColumn29.Header.VisiblePosition = 3;
            ultraGridColumn29.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn29.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn29.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn29.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn29.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn29.Width = 43;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.Header.Caption = "Número";
            ultraGridColumn30.Header.VisiblePosition = 4;
            ultraGridColumn30.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn30.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn30.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn30.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn30.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn30.Width = 73;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn31.Header.VisiblePosition = 5;
            ultraGridColumn31.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn31.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(52, 0);
            ultraGridColumn31.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn31.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn31.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn31.Width = 73;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn32.Header.VisiblePosition = 6;
            ultraGridColumn32.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn32.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(73, 0);
            ultraGridColumn32.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(79, 0);
            ultraGridColumn32.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn32.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn32.Width = 73;
            ultraGridColumn33.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn33.Header.Caption = "Entre";
            ultraGridColumn33.Header.VisiblePosition = 7;
            ultraGridColumn33.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn33.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn33.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn33.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn33.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn33.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn33.Width = 61;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn34.Header.Caption = "y";
            ultraGridColumn34.Header.VisiblePosition = 8;
            ultraGridColumn34.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn34.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn34.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn34.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn34.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn34.Width = 61;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn35.Header.Caption = "Zona";
            ultraGridColumn35.Header.VisiblePosition = 9;
            ultraGridColumn35.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn35.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(66, 0);
            ultraGridColumn35.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn35.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn35.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn35.Width = 43;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn36.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn36.Header.VisiblePosition = 10;
            ultraGridColumn36.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn36.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(360, 55);
            ultraGridColumn36.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn36.RowLayoutColumnInfo.SpanX = 10;
            ultraGridColumn36.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn36.Width = 73;
            ultraGridColumn37.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn37.Header.VisiblePosition = 11;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn37.Width = 44;
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn38.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn38.Header.Caption = "Barrio";
            ultraGridColumn38.Header.VisiblePosition = 12;
            ultraGridColumn38.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn38.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn38.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn38.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn38.Width = 43;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn39.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn39.Header.Caption = "Localidad";
            ultraGridColumn39.Header.VisiblePosition = 13;
            ultraGridColumn39.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn39.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(156, 0);
            ultraGridColumn39.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn39.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn40.Header.VisiblePosition = 14;
            ultraGridBand25.Columns.AddRange(new object[] {
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40});
            appearance190.FontData.BoldAsString = "True";
            appearance190.FontData.SizeInPoints = 11F;
            appearance190.TextHAlignAsString = "Left";
            ultraGridBand25.Header.Appearance = appearance190;
            ultraGridBand25.Header.Caption = "Direcciones";
            ultraGridBand25.HeaderVisible = true;
            ultraGridBand25.MaxRows = 2;
            ultraGridBand25.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand25.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand25.VisiblePosition = 1;
            ultraGridBand26.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand26.CardSettings.ShowCaption = false;
            ultraGridBand26.CardView = true;
            ultraGridBand26.ColHeadersVisible = false;
            ultraGridColumn41.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn41.Header.VisiblePosition = 0;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn41.Width = 198;
            ultraGridColumn42.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn42.Header.VisiblePosition = 1;
            ultraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn42.Width = 283;
            ultraGridColumn43.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn43.Header.VisiblePosition = 2;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn43.Width = 204;
            ultraGridBand26.Columns.AddRange(new object[] {
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43});
            appearance191.FontData.BoldAsString = "True";
            appearance191.FontData.SizeInPoints = 11F;
            appearance191.TextHAlignAsString = "Left";
            ultraGridBand26.Header.Appearance = appearance191;
            ultraGridBand26.Header.Caption = "Teléf. Dirección";
            ultraGridBand26.HeaderVisible = true;
            ultraGridBand26.MaxRows = 7;
            ultraGridBand26.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn44.Header.VisiblePosition = 0;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn44.Width = 121;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn45.Header.VisiblePosition = 1;
            ultraGridColumn45.Width = 123;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.Header.VisiblePosition = 2;
            ultraGridColumn46.Width = 91;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn47.Header.VisiblePosition = 3;
            ultraGridColumn47.Hidden = true;
            ultraGridColumn47.Width = 179;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.Header.VisiblePosition = 4;
            ultraGridColumn49.Header.VisiblePosition = 5;
            ultraGridBand27.Columns.AddRange(new object[] {
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49});
            appearance192.FontData.BoldAsString = "True";
            appearance192.FontData.SizeInPoints = 11F;
            appearance192.TextHAlignAsString = "Left";
            ultraGridBand27.Header.Appearance = appearance192;
            ultraGridBand27.Header.Caption = "Referentes";
            ultraGridBand27.HeaderVisible = true;
            ultraGridBand27.VisiblePosition = 4;
            ultraGridBand28.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand28.CardSettings.ShowCaption = false;
            ultraGridBand28.CardView = true;
            ultraGridBand28.ColHeadersVisible = false;
            ultraGridColumn50.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn50.Header.VisiblePosition = 0;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn50.Width = 206;
            ultraGridColumn51.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn51.Header.VisiblePosition = 1;
            ultraGridColumn51.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn51.Width = 702;
            ultraGridColumn52.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn52.Header.VisiblePosition = 2;
            ultraGridColumn52.Hidden = true;
            ultraGridColumn52.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(80, 0);
            ultraGridColumn52.Width = 205;
            ultraGridBand28.Columns.AddRange(new object[] {
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52});
            appearance193.FontData.BoldAsString = "True";
            appearance193.FontData.SizeInPoints = 11F;
            appearance193.TextHAlignAsString = "Left";
            ultraGridBand28.Header.Appearance = appearance193;
            ultraGridBand28.Header.Caption = "Tel. Referente";
            ultraGridBand28.HeaderVisible = true;
            ultraGridBand28.MaxRows = 7;
            ultraGridBand28.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn53.Header.VisiblePosition = 0;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn53.Width = 209;
            ultraGridColumn54.Header.VisiblePosition = 1;
            ultraGridColumn54.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(353, 0);
            ultraGridColumn54.Width = 809;
            ultraGridColumn55.Header.VisiblePosition = 2;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn55.Width = 331;
            ultraGridBand29.Columns.AddRange(new object[] {
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55});
            appearance205.FontData.BoldAsString = "True";
            appearance205.FontData.SizeInPoints = 11F;
            appearance205.TextHAlignAsString = "Left";
            ultraGridBand29.Header.Appearance = appearance205;
            ultraGridBand29.Header.Caption = "e_Mail Referente";
            ultraGridBand29.HeaderVisible = true;
            ultraGridBand29.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.Header.VisiblePosition = 0;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn56.Width = 106;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn57.Header.VisiblePosition = 1;
            ultraGridColumn57.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn57.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn57.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(297, 0);
            ultraGridColumn57.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(297, 0);
            ultraGridColumn57.RowLayoutColumnInfo.SpanX = 7;
            ultraGridColumn57.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn57.Width = 115;
            ultraGridColumn58.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn58.Header.VisiblePosition = 2;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn58.Width = 130;
            ultraGridColumn59.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn59.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn59.Header.Caption = "Datos para el Despacho";
            ultraGridColumn59.Header.VisiblePosition = 3;
            ultraGridColumn59.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn59.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(211, 55);
            ultraGridColumn59.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(211, 0);
            ultraGridColumn59.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn59.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn59.Width = 129;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn60.Header.Caption = "Tipo de Contrato";
            ultraGridColumn60.Header.VisiblePosition = 4;
            ultraGridColumn60.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn60.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn60.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(109, 0);
            ultraGridColumn60.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(96, 0);
            ultraGridColumn60.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn60.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn60.Width = 135;
            ultraGridColumn61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn61.DefaultCellValue = "100";
            ultraGridColumn61.Header.VisiblePosition = 5;
            ultraGridColumn61.LockedWidth = true;
            ultraGridColumn61.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn61.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn61.MaxLength = 27;
            ultraGridColumn61.MaxWidth = 27;
            ultraGridColumn61.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn61.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn61.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn61.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn61.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn61.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn61.Width = 27;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.DefaultCellValue = "100";
            ultraGridColumn62.Header.VisiblePosition = 6;
            ultraGridColumn62.LockedWidth = true;
            ultraGridColumn62.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn62.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn62.MaxLength = 27;
            ultraGridColumn62.MaxWidth = 27;
            ultraGridColumn62.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn62.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn62.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(41, 0);
            ultraGridColumn62.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(41, 0);
            ultraGridColumn62.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn62.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn62.Width = 27;
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn63.DefaultCellValue = "100";
            ultraGridColumn63.Header.VisiblePosition = 7;
            ultraGridColumn63.LockedWidth = true;
            ultraGridColumn63.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn63.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn63.MaxLength = 27;
            ultraGridColumn63.MaxWidth = 27;
            ultraGridColumn63.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn63.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn63.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(48, 0);
            ultraGridColumn63.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(48, 0);
            ultraGridColumn63.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn63.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn63.Width = 27;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn64.DefaultCellValue = "100";
            ultraGridColumn64.Header.VisiblePosition = 8;
            ultraGridColumn64.LockedWidth = true;
            ultraGridColumn64.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn64.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn64.MaxLength = 27;
            ultraGridColumn64.MaxWidth = 27;
            ultraGridColumn64.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn64.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn64.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(49, 0);
            ultraGridColumn64.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(49, 0);
            ultraGridColumn64.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn64.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn64.Width = 27;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.DefaultCellValue = "100";
            ultraGridColumn65.Header.VisiblePosition = 9;
            ultraGridColumn65.LockedWidth = true;
            ultraGridColumn65.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn65.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn65.MaxLength = 27;
            ultraGridColumn65.MaxWidth = 27;
            ultraGridColumn65.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn65.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn65.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(42, 0);
            ultraGridColumn65.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(42, 0);
            ultraGridColumn65.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn65.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn65.Width = 27;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn66.DefaultCellValue = "100";
            ultraGridColumn66.Header.VisiblePosition = 10;
            ultraGridColumn66.LockedWidth = true;
            ultraGridColumn66.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn66.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn66.MaxLength = 27;
            ultraGridColumn66.MaxWidth = 27;
            ultraGridColumn66.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn66.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn66.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn66.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(64, 0);
            ultraGridColumn66.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn66.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn66.Width = 27;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.DefaultCellValue = "100";
            ultraGridColumn67.Header.VisiblePosition = 11;
            ultraGridColumn67.LockedWidth = true;
            ultraGridColumn67.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn67.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn67.MaxLength = 27;
            ultraGridColumn67.MaxWidth = 27;
            ultraGridColumn67.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn67.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn67.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(58, 0);
            ultraGridColumn67.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn67.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn67.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn67.Width = 27;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn68.DefaultCellValue = "100";
            ultraGridColumn68.Header.VisiblePosition = 12;
            ultraGridColumn68.LockedWidth = true;
            ultraGridColumn68.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn68.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn68.MaxLength = 27;
            ultraGridColumn68.MaxWidth = 27;
            ultraGridColumn68.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn68.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn68.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(51, 0);
            ultraGridColumn68.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(32, 0);
            ultraGridColumn68.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn68.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn68.Width = 27;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn69.DefaultCellValue = "100";
            ultraGridColumn69.Header.VisiblePosition = 13;
            ultraGridColumn69.LockedWidth = true;
            ultraGridColumn69.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn69.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn69.MaxLength = 27;
            ultraGridColumn69.MaxWidth = 27;
            ultraGridColumn69.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn69.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(60, 0);
            ultraGridColumn69.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn69.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn69.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn69.Width = 27;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn70.DefaultCellValue = "100";
            ultraGridColumn70.Header.VisiblePosition = 14;
            ultraGridColumn70.LockedWidth = true;
            ultraGridColumn70.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn70.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn70.MaxLength = 27;
            ultraGridColumn70.MaxWidth = 27;
            ultraGridColumn70.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn70.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn70.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(40, 0);
            ultraGridColumn70.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(40, 0);
            ultraGridColumn70.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn70.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn70.Width = 27;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn71.DefaultCellValue = "100";
            ultraGridColumn71.Header.VisiblePosition = 15;
            ultraGridColumn71.LockedWidth = true;
            ultraGridColumn71.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn71.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn71.MaxLength = 27;
            ultraGridColumn71.MaxWidth = 27;
            ultraGridColumn71.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn71.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn71.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(47, 0);
            ultraGridColumn71.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(47, 0);
            ultraGridColumn71.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn71.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn71.Width = 27;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn72.DefaultCellValue = "100";
            ultraGridColumn72.Header.VisiblePosition = 17;
            ultraGridColumn72.LockedWidth = true;
            ultraGridColumn72.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn72.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn72.MaxLength = 27;
            ultraGridColumn72.MaxWidth = 27;
            ultraGridColumn72.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn72.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn72.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn72.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn72.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn72.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn72.Width = 27;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn73.Header.Caption = "Observaciones Administrativas";
            ultraGridColumn73.Header.VisiblePosition = 16;
            ultraGridColumn73.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn73.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(820, 0);
            ultraGridColumn73.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(168, 0);
            ultraGridColumn73.RowLayoutColumnInfo.SpanX = 19;
            ultraGridColumn73.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn74.Header.Caption = "Negocio";
            ultraGridColumn74.Header.VisiblePosition = 18;
            ultraGridColumn74.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn74.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn74.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(203, 0);
            ultraGridColumn74.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn74.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn74.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn75.Header.VisiblePosition = 20;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn76.Header.VisiblePosition = 19;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn77.Header.VisiblePosition = 21;
            ultraGridBand30.Columns.AddRange(new object[] {
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77});
            appearance206.FontData.BoldAsString = "True";
            appearance206.FontData.SizeInPoints = 11F;
            appearance206.TextHAlignAsString = "Left";
            ultraGridBand30.Header.Appearance = appearance206;
            ultraGridBand30.Header.Caption = "Contratos";
            ultraGridBand30.HeaderVisible = true;
            ultraGridBand30.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand30.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand30.VisiblePosition = 5;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn78.Header.Caption = "Tipo";
            ultraGridColumn78.Header.VisiblePosition = 1;
            ultraGridColumn78.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn78.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn78.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn78.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn78.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn78.Width = 73;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn79.Header.VisiblePosition = 2;
            ultraGridColumn79.Hidden = true;
            ultraGridColumn79.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn79.Width = 98;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 3;
            ultraGridColumn80.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn80.MaskInput = "dd/mm/yyyy";
            ultraGridColumn80.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn80.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn80.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(74, 0);
            ultraGridColumn80.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(74, 0);
            ultraGridColumn80.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn80.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn80.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar;
            ultraGridColumn80.Width = 51;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn81.Header.Caption = "Fin Suspensión";
            ultraGridColumn81.Header.VisiblePosition = 4;
            ultraGridColumn81.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn81.MaskInput = "dd/mm/yyyy";
            ultraGridColumn81.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn81.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(89, 0);
            ultraGridColumn81.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(89, 0);
            ultraGridColumn81.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn81.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn81.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar;
            ultraGridColumn81.Width = 72;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.Caption = "Renovación";
            ultraGridColumn82.Header.VisiblePosition = 5;
            ultraGridColumn82.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn82.MaskInput = "dd/mm/yyyy";
            ultraGridColumn82.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn82.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(73, 0);
            ultraGridColumn82.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(73, 0);
            ultraGridColumn82.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn82.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn82.Width = 62;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn83.Header.Caption = "Registro";
            ultraGridColumn83.Header.VisiblePosition = 7;
            ultraGridColumn83.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn83.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn83.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn83.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(107, 0);
            ultraGridColumn83.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(107, 0);
            ultraGridColumn83.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn83.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn83.Width = 80;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn84.Header.Caption = "Vendedor";
            ultraGridColumn84.Header.VisiblePosition = 6;
            ultraGridColumn84.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn84.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn84.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(146, 0);
            ultraGridColumn84.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn84.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn84.Width = 125;
            ultraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn85.Header.Caption = "Tomador de Baja";
            ultraGridColumn85.Header.VisiblePosition = 9;
            ultraGridColumn85.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn85.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(131, 0);
            ultraGridColumn85.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(131, 0);
            ultraGridColumn85.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn85.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn85.Width = 85;
            ultraGridColumn86.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn86.Header.Caption = "Motivo de Baja";
            ultraGridColumn86.Header.VisiblePosition = 8;
            ultraGridColumn86.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn86.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn86.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(109, 0);
            ultraGridColumn86.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(109, 0);
            ultraGridColumn86.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn86.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn86.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn86.Width = 137;
            ultraGridColumn87.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn87.Header.VisiblePosition = 10;
            ultraGridColumn87.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn87.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn87.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(689, 0);
            ultraGridColumn87.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(689, 0);
            ultraGridColumn87.RowLayoutColumnInfo.SpanX = 14;
            ultraGridColumn87.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn87.Width = 79;
            ultraGridColumn88.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn88.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn88.Header.Caption = "Grabador";
            ultraGridColumn88.Header.VisiblePosition = 11;
            ultraGridColumn88.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn88.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn88.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(107, 0);
            ultraGridColumn88.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(107, 0);
            ultraGridColumn88.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn88.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn89.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn89.Header.VisiblePosition = 0;
            ultraGridColumn89.Hidden = true;
            ultraGridColumn89.Width = 76;
            ultraGridBand31.Columns.AddRange(new object[] {
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85,
            ultraGridColumn86,
            ultraGridColumn87,
            ultraGridColumn88,
            ultraGridColumn89});
            appearance232.FontData.BoldAsString = "True";
            appearance232.FontData.SizeInPoints = 11F;
            appearance232.TextHAlignAsString = "Left";
            ultraGridBand31.Header.Appearance = appearance232;
            ultraGridBand31.Header.Caption = "Solicitudes";
            ultraGridBand31.HeaderVisible = true;
            ultraGridBand31.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand31.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn90.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn90.Header.VisiblePosition = 0;
            ultraGridColumn90.Hidden = true;
            ultraGridColumn90.Width = 127;
            ultraGridColumn91.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn91.Header.VisiblePosition = 1;
            ultraGridColumn91.Width = 104;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn92.Header.VisiblePosition = 2;
            ultraGridColumn92.Width = 91;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn93.Header.VisiblePosition = 3;
            ultraGridColumn93.Hidden = true;
            ultraGridColumn93.Width = 185;
            ultraGridColumn94.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance233.TextHAlignAsString = "Right";
            ultraGridColumn94.CellAppearance = appearance233;
            ultraGridColumn94.Header.Caption = "Cuota Titular";
            ultraGridColumn94.Header.VisiblePosition = 4;
            ultraGridColumn94.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn94.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn94.Width = 93;
            ultraGridColumn95.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn95.DefaultCellValue = "True";
            ultraGridColumn95.Header.VisiblePosition = 6;
            ultraGridColumn95.Width = 89;
            ultraGridColumn96.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn96.DefaultCellValue = "False";
            ultraGridColumn96.Header.Caption = "Padrón Externo";
            ultraGridColumn96.Header.VisiblePosition = 7;
            ultraGridColumn96.Width = 113;
            ultraGridColumn97.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn97.Header.Caption = "Protección";
            ultraGridColumn97.Header.VisiblePosition = 8;
            ultraGridColumn97.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn97.Width = 109;
            ultraGridColumn98.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn98.Header.Caption = "Prepago";
            ultraGridColumn98.Header.VisiblePosition = 9;
            ultraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn98.Width = 92;
            appearance236.TextHAlignAsString = "Right";
            ultraGridColumn99.CellAppearance = appearance236;
            ultraGridColumn99.Header.Caption = "Cuota Adherente";
            ultraGridColumn99.Header.VisiblePosition = 5;
            ultraGridColumn99.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn99.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn99.Width = 104;
            ultraGridBand32.Columns.AddRange(new object[] {
            ultraGridColumn90,
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97,
            ultraGridColumn98,
            ultraGridColumn99});
            appearance237.FontData.BoldAsString = "True";
            appearance237.FontData.SizeInPoints = 11F;
            appearance237.TextHAlignAsString = "Left";
            ultraGridBand32.Header.Appearance = appearance237;
            ultraGridBand32.Header.Caption = "Planes";
            ultraGridBand32.HeaderVisible = true;
            ultraGridColumn100.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn100.Header.VisiblePosition = 0;
            ultraGridColumn100.Hidden = true;
            ultraGridColumn100.Width = 61;
            ultraGridColumn101.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn101.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn101.Header.Caption = "Localidad";
            ultraGridColumn101.Header.VisiblePosition = 1;
            ultraGridColumn101.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn101.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn101.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn101.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn101.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn101.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn101.Width = 68;
            ultraGridColumn102.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn102.Header.Caption = "Calle";
            ultraGridColumn102.Header.VisiblePosition = 2;
            ultraGridColumn102.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn102.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn102.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(143, 0);
            ultraGridColumn102.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(143, 0);
            ultraGridColumn102.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn102.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn102.Width = 55;
            ultraGridColumn103.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn103.Header.Caption = "Número";
            ultraGridColumn103.Header.VisiblePosition = 3;
            ultraGridColumn103.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn103.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn103.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(54, 0);
            ultraGridColumn103.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(54, 0);
            ultraGridColumn103.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn103.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn103.Width = 92;
            ultraGridColumn104.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn104.Header.VisiblePosition = 4;
            ultraGridColumn104.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn104.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn104.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(47, 0);
            ultraGridColumn104.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(47, 0);
            ultraGridColumn104.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn104.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn104.Width = 92;
            ultraGridColumn105.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn105.Header.Caption = "Depto.";
            ultraGridColumn105.Header.VisiblePosition = 5;
            ultraGridColumn105.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn105.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn105.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(57, 0);
            ultraGridColumn105.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(57, 0);
            ultraGridColumn105.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn105.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn105.Width = 92;
            ultraGridColumn106.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn106.Header.Caption = "Entre";
            ultraGridColumn106.Header.VisiblePosition = 6;
            ultraGridColumn106.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn106.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn106.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(143, 0);
            ultraGridColumn106.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(143, 0);
            ultraGridColumn106.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn106.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn106.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn106.Width = 78;
            ultraGridColumn107.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn107.Header.Caption = "y";
            ultraGridColumn107.Header.VisiblePosition = 7;
            ultraGridColumn107.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn107.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn107.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(158, 0);
            ultraGridColumn107.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(158, 0);
            ultraGridColumn107.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn107.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn107.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn107.Width = 78;
            ultraGridColumn108.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn108.Header.VisiblePosition = 8;
            ultraGridColumn108.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn108.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn108.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(167, 55);
            ultraGridColumn108.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(167, 0);
            ultraGridColumn108.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn108.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn108.Width = 92;
            ultraGridColumn109.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn109.Header.VisiblePosition = 9;
            ultraGridColumn109.Hidden = true;
            ultraGridColumn109.Width = 63;
            ultraGridColumn110.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn110.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn110.Header.Caption = "Barrio";
            ultraGridColumn110.Header.VisiblePosition = 10;
            ultraGridColumn110.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn110.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn110.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn110.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn110.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn110.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn110.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn110.Width = 55;
            ultraGridColumn111.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn111.Header.VisiblePosition = 11;
            ultraGridBand33.Columns.AddRange(new object[] {
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104,
            ultraGridColumn105,
            ultraGridColumn106,
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111});
            appearance238.FontData.BoldAsString = "True";
            appearance238.FontData.SizeInPoints = 11F;
            appearance238.TextHAlignAsString = "Left";
            ultraGridBand33.Header.Appearance = appearance238;
            ultraGridBand33.Header.Caption = "Dirección del Contrato";
            ultraGridBand33.HeaderVisible = true;
            ultraGridBand33.MaxRows = 1;
            ultraGridBand33.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand33.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand34.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand34.CardSettings.ShowCaption = false;
            ultraGridBand34.CardView = true;
            ultraGridColumn112.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn112.Header.VisiblePosition = 0;
            ultraGridColumn112.Hidden = true;
            ultraGridColumn112.Width = 232;
            ultraGridColumn113.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn113.Header.VisiblePosition = 1;
            ultraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(97, 0);
            ultraGridColumn113.Width = 334;
            ultraGridColumn114.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn114.Header.VisiblePosition = 2;
            ultraGridColumn114.Hidden = true;
            ultraGridColumn114.Width = 241;
            ultraGridBand34.Columns.AddRange(new object[] {
            ultraGridColumn112,
            ultraGridColumn113,
            ultraGridColumn114});
            appearance243.FontData.BoldAsString = "True";
            appearance243.FontData.SizeInPoints = 11F;
            appearance243.TextHAlignAsString = "Left";
            ultraGridBand34.Header.Appearance = appearance243;
            ultraGridBand34.Header.Caption = "Teléfonos";
            ultraGridBand34.HeaderVisible = true;
            ultraGridBand34.MaxRows = 7;
            ultraGridBand34.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand34.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn115.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn115.Header.VisiblePosition = 0;
            ultraGridColumn115.Hidden = true;
            ultraGridColumn115.Width = 260;
            ultraGridColumn116.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn116.Header.VisiblePosition = 1;
            ultraGridColumn116.Hidden = true;
            ultraGridColumn116.Width = 141;
            ultraGridColumn117.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn117.Header.VisiblePosition = 2;
            ultraGridColumn117.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn117.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(271, 0);
            ultraGridColumn117.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn117.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn117.Width = 235;
            ultraGridColumn118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn118.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn118.Header.Caption = "Tanda de Facturación";
            ultraGridColumn118.Header.VisiblePosition = 3;
            ultraGridColumn118.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn118.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn118.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn118.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn118.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn119.Header.Caption = "Facturar Mes";
            ultraGridColumn119.Header.ToolTipText = "Las prestaciones se facturan siempre a mes vencido.";
            ultraGridColumn119.Header.VisiblePosition = 4;
            ultraGridColumn119.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn119.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn119.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn119.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn119.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn120.Header.VisiblePosition = 5;
            ultraGridBand35.Columns.AddRange(new object[] {
            ultraGridColumn115,
            ultraGridColumn116,
            ultraGridColumn117,
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120});
            appearance244.FontData.BoldAsString = "True";
            appearance244.FontData.SizeInPoints = 11F;
            appearance244.TextHAlignAsString = "Left";
            ultraGridBand35.Header.Appearance = appearance244;
            ultraGridBand35.Header.Caption = "Molde de Factura";
            ultraGridBand35.HeaderVisible = true;
            ultraGridBand35.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand35.VisiblePosition = 6;
            ultraGridColumn121.Header.VisiblePosition = 0;
            ultraGridColumn121.Hidden = true;
            appearance255.TextHAlignAsString = "Right";
            ultraGridColumn122.CellAppearance = appearance255;
            ultraGridColumn122.Header.VisiblePosition = 2;
            ultraGridColumn122.Width = 91;
            appearance256.TextHAlignAsString = "Right";
            ultraGridColumn123.CellAppearance = appearance256;
            ultraGridColumn123.Header.Caption = "Precio Unitario";
            ultraGridColumn123.Header.VisiblePosition = 3;
            ultraGridColumn123.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn123.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn124.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn124.Header.VisiblePosition = 1;
            ultraGridColumn124.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn124.Width = 104;
            ultraGridColumn125.Header.Caption = "Revisar Mensualmente";
            ultraGridColumn125.Header.VisiblePosition = 9;
            ultraGridColumn125.Width = 92;
            ultraGridColumn126.Header.VisiblePosition = 6;
            ultraGridColumn126.Hidden = true;
            appearance259.TextHAlignAsString = "Center";
            ultraGridColumn127.CellAppearance = appearance259;
            ultraGridColumn127.Header.Caption = "Plan";
            ultraGridColumn127.Header.VisiblePosition = 7;
            ultraGridColumn127.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn127.Width = 113;
            ultraGridColumn128.Header.VisiblePosition = 8;
            ultraGridColumn129.Header.Caption = "PorcentajeIVA";
            ultraGridColumn129.Header.VisiblePosition = 5;
            ultraGridColumn129.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            appearance257.TextHAlignAsString = "Right";
            ultraGridColumn130.CellAppearance = appearance257;
            ultraGridColumn130.Header.Caption = "Precio Unitario Escrito";
            ultraGridColumn130.Header.VisiblePosition = 4;
            ultraGridColumn130.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn130.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn130.Width = 104;
            ultraGridBand36.Columns.AddRange(new object[] {
            ultraGridColumn121,
            ultraGridColumn122,
            ultraGridColumn123,
            ultraGridColumn124,
            ultraGridColumn125,
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130});
            ultraGridBand36.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn131.Header.VisiblePosition = 0;
            ultraGridColumn131.Hidden = true;
            appearance258.FontData.BoldAsString = "True";
            appearance258.FontData.SizeInPoints = 11F;
            appearance258.TextHAlignAsString = "Left";
            ultraGridColumn132.Header.Appearance = appearance258;
            ultraGridColumn132.Header.Caption = "e-mail del Cliente";
            ultraGridColumn132.Header.VisiblePosition = 1;
            ultraGridColumn132.Width = 123;
            ultraGridColumn133.Header.VisiblePosition = 2;
            ultraGridColumn133.Hidden = true;
            ultraGridBand37.Columns.AddRange(new object[] {
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133});
            ultraGridBand37.MaxRows = 1;
            ultraGridBand37.VisiblePosition = 2;
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand24);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand25);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand26);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand27);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand28);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand29);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand30);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand31);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand32);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand33);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand34);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand35);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand36);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand37);
            this.clientesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.clientesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.clientesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance228.BackColor = System.Drawing.SystemColors.Window;
            this.clientesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance228;
            appearance230.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance230.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance230.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance230.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance230;
            this.clientesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.clientesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.clientesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.clientesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance231.BackColor = System.Drawing.Color.Transparent;
            this.clientesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance231;
            appearance234.BackColor = System.Drawing.SystemColors.Control;
            appearance234.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance234.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.clientesUltraGrid.DisplayLayout.Override.CellAppearance = appearance234;
            this.clientesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance235.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance235.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance235.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance235.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance235.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.clientesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance235;
            this.clientesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance239.ForeColor = System.Drawing.Color.Red;
            this.clientesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance239;
            this.clientesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance240.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.clientesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance240;
            appearance241.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance241.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance241.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.clientesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance241;
            appearance242.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance242.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.clientesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance242;
            this.clientesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clientesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.clientesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.clientesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.clientesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientesUltraGrid.Location = new System.Drawing.Point(1, 3);
            this.clientesUltraGrid.Name = "clientesUltraGrid";
            this.clientesUltraGrid.Size = new System.Drawing.Size(900, 535);
            this.clientesUltraGrid.TabIndex = 2;
            this.clientesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ClientesUltraGridInitializeRow);
            this.clientesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ClientesUltraGridAfterEnterEditMode);
            this.clientesUltraGrid.AfterRowActivate += new System.EventHandler(this.ClientesUltraGridAfterRowActivate);
            this.clientesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.ClientesUltraGridAfterRowsDeleted);
            this.clientesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ClientesUltraGridCellChange);
            this.clientesUltraGrid.BeforeExitEditMode += new Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler(this.ClientesUltraGridBeforeExitEditMode);
            this.clientesUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.ClientesUltraGridBeforeRowDeactivate);
            this.clientesUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.ClientesUltraGridBeforeRowsDeleted);
            this.clientesUltraGrid.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.clientesUltraGrid_DoubleClickCell);
            this.clientesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientesUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsClientes;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "DsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(674, 13);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Visible = false;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
            // 
            // ultraDropDownCalle
            // 
            this.ultraDropDownCalle.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCalle.DataSource = this.callesBindingSource;
            appearance149.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance149.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance149.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalle.DisplayLayout.Appearance = appearance149;
            ultraGridBand22.ColHeadersVisible = false;
            ultraGridColumn239.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn239.Header.VisiblePosition = 0;
            ultraGridColumn239.Hidden = true;
            ultraGridColumn240.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn240.Header.VisiblePosition = 1;
            ultraGridColumn240.Hidden = true;
            ultraGridColumn241.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn241.Header.VisiblePosition = 2;
            ultraGridColumn241.Hidden = true;
            ultraGridColumn242.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn242.Header.VisiblePosition = 3;
            ultraGridBand22.Columns.AddRange(new object[] {
            ultraGridColumn239,
            ultraGridColumn240,
            ultraGridColumn241,
            ultraGridColumn242});
            ultraGridBand22.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand22.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCalle.DisplayLayout.BandsSerializer.Add(ultraGridBand22);
            this.ultraDropDownCalle.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalle.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalle.DisplayLayout.MaxBandDepth = 5;
            appearance150.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveCellAppearance = appearance150;
            appearance151.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance151.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance151.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance151.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveRowAppearance = appearance151;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance152.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.CardAreaAppearance = appearance152;
            appearance153.BackColor = System.Drawing.SystemColors.Control;
            appearance153.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance153.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.CellAppearance = appearance153;
            this.ultraDropDownCalle.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance154.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance154.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance154.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance154.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderAppearance = appearance154;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance155.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSelectorAppearance = appearance155;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedCellAppearance = appearance156;
            appearance157.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance157.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance157.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedRowAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance158.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalle.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance158;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalle.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalle.DisplayMember = "Nombre";
            this.ultraDropDownCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCalle.Location = new System.Drawing.Point(12, 273);
            this.ultraDropDownCalle.Name = "ultraDropDownCalle";
            this.ultraDropDownCalle.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCalle.TabIndex = 9;
            this.ultraDropDownCalle.ValueMember = "idCalle";
            this.ultraDropDownCalle.Visible = false;
            this.ultraDropDownCalle.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCalleBeforeDropDown);
            this.ultraDropDownCalle.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalleFilterRow);
            // 
            // callesBindingSource
            // 
            this.callesBindingSource.DataMember = "Calles";
            this.callesBindingSource.DataSource = this.dsCallesLista;
            // 
            // dsCallesLista
            // 
            this.dsCallesLista.DataSetName = "DsCallesLista";
            this.dsCallesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownZonas
            // 
            this.ultraDropDownZonas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownZonas.DataSource = this.zonasBindingSource;
            appearance200.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance200.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance200.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownZonas.DisplayLayout.Appearance = appearance200;
            ultraGridBand20.ColHeadersVisible = false;
            ultraGridColumn230.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn230.Header.VisiblePosition = 0;
            ultraGridColumn230.Hidden = true;
            ultraGridColumn231.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn231.Header.VisiblePosition = 1;
            ultraGridColumn232.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn232.Header.VisiblePosition = 2;
            ultraGridColumn232.Hidden = true;
            ultraGridColumn233.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn233.Header.VisiblePosition = 3;
            ultraGridColumn233.Hidden = true;
            ultraGridColumn234.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn234.Header.VisiblePosition = 4;
            ultraGridColumn234.Hidden = true;
            ultraGridColumn235.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn235.Header.VisiblePosition = 5;
            ultraGridColumn235.Hidden = true;
            ultraGridBand20.Columns.AddRange(new object[] {
            ultraGridColumn230,
            ultraGridColumn231,
            ultraGridColumn232,
            ultraGridColumn233,
            ultraGridColumn234,
            ultraGridColumn235});
            ultraGridBand20.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand20.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownZonas.DisplayLayout.BandsSerializer.Add(ultraGridBand20);
            this.ultraDropDownZonas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownZonas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownZonas.DisplayLayout.MaxBandDepth = 5;
            appearance201.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveCellAppearance = appearance201;
            appearance202.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance202.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance202.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveRowAppearance = appearance202;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance203.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.CardAreaAppearance = appearance203;
            appearance204.BackColor = System.Drawing.SystemColors.Control;
            appearance204.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance204.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.CellAppearance = appearance204;
            this.ultraDropDownZonas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance134.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance134.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance134.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance134.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderAppearance = appearance134;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance135.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSelectorAppearance = appearance135;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedCellAppearance = appearance136;
            appearance137.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance137.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedRowAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance138.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownZonas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance138;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownZonas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownZonas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownZonas.DisplayMember = "Nombre";
            this.ultraDropDownZonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownZonas.Location = new System.Drawing.Point(256, 233);
            this.ultraDropDownZonas.Name = "ultraDropDownZonas";
            this.ultraDropDownZonas.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownZonas.TabIndex = 17;
            this.ultraDropDownZonas.ValueMember = "idZona";
            this.ultraDropDownZonas.Visible = false;
            this.ultraDropDownZonas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownZonasBeforeDropDown);
            this.ultraDropDownZonas.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownZonasFilterRow);
            // 
            // zonasBindingSource
            // 
            this.zonasBindingSource.DataMember = "Zonas";
            this.zonasBindingSource.DataSource = this.dsZonas;
            // 
            // dsZonas
            // 
            this.dsZonas.DataSetName = "DsZonas";
            this.dsZonas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeCliente
            // 
            this.ultraDropDownTiposDeCliente.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeCliente.DataSource = this.tiposDeClienteBindingSource;
            appearance119.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance119.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Appearance = appearance119;
            ultraGridBand19.ColHeadersVisible = false;
            ultraGridColumn227.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn227.Header.VisiblePosition = 0;
            ultraGridColumn227.Hidden = true;
            ultraGridColumn228.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn228.Header.VisiblePosition = 1;
            ultraGridColumn229.Header.VisiblePosition = 2;
            ultraGridColumn229.Hidden = true;
            ultraGridBand19.Columns.AddRange(new object[] {
            ultraGridColumn227,
            ultraGridColumn228,
            ultraGridColumn229});
            ultraGridBand19.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand19.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeCliente.DisplayLayout.BandsSerializer.Add(ultraGridBand19);
            this.ultraDropDownTiposDeCliente.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeCliente.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeCliente.DisplayLayout.MaxBandDepth = 5;
            appearance120.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.ActiveCellAppearance = appearance120;
            appearance121.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance121.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance121.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.ActiveRowAppearance = appearance121;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance122.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.CardAreaAppearance = appearance122;
            appearance123.BackColor = System.Drawing.SystemColors.Control;
            appearance123.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance123.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.CellAppearance = appearance123;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance195.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance195.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance195.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance195.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance195.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.HeaderAppearance = appearance195;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance196.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.RowSelectorAppearance = appearance196;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.SelectedCellAppearance = appearance197;
            appearance198.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance198.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance198.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.SelectedRowAppearance = appearance198;
            appearance199.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance199.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance199;
            this.ultraDropDownTiposDeCliente.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeCliente.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeCliente.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeCliente.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeCliente.Location = new System.Drawing.Point(258, 353);
            this.ultraDropDownTiposDeCliente.Name = "ultraDropDownTiposDeCliente";
            this.ultraDropDownTiposDeCliente.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeCliente.TabIndex = 18;
            this.ultraDropDownTiposDeCliente.ValueMember = "idTipoDeCliente";
            this.ultraDropDownTiposDeCliente.Visible = false;
            this.ultraDropDownTiposDeCliente.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeClienteBeforeDropDown);
            // 
            // tiposDeClienteBindingSource
            // 
            this.tiposDeClienteBindingSource.DataMember = "TiposDeCliente";
            this.tiposDeClienteBindingSource.DataSource = this.dsTiposDeCliente;
            // 
            // dsTiposDeCliente
            // 
            this.dsTiposDeCliente.DataSetName = "DsTiposDeCliente";
            this.dsTiposDeCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ultraDropDownTiposDeCobranza
            // 
            this.ultraDropDownTiposDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeCobranza.DataSource = this.tiposDeCobranzaBindingSource;
            appearance109.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance109.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Appearance = appearance109;
            ultraGridBand18.ColHeadersVisible = false;
            ultraGridColumn222.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn222.Header.VisiblePosition = 0;
            ultraGridColumn222.Hidden = true;
            ultraGridColumn223.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn223.Header.VisiblePosition = 1;
            ultraGridColumn224.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn224.Header.VisiblePosition = 2;
            ultraGridColumn224.Hidden = true;
            ultraGridColumn225.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn225.Header.VisiblePosition = 3;
            ultraGridColumn225.Hidden = true;
            ultraGridColumn226.Header.VisiblePosition = 4;
            ultraGridColumn226.Hidden = true;
            ultraGridBand18.Columns.AddRange(new object[] {
            ultraGridColumn222,
            ultraGridColumn223,
            ultraGridColumn224,
            ultraGridColumn225,
            ultraGridColumn226});
            ultraGridBand18.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand18.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand18);
            this.ultraDropDownTiposDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance110.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance110;
            appearance111.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance111.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance111.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance111;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance112.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.Control;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.CellAppearance = appearance113;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance114.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance114.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance114.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance114.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance114;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance115.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance115;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance116;
            appearance117.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance117.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance117;
            appearance118.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance118.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance118;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeCobranza.Location = new System.Drawing.Point(500, 273);
            this.ultraDropDownTiposDeCobranza.Name = "ultraDropDownTiposDeCobranza";
            this.ultraDropDownTiposDeCobranza.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeCobranza.TabIndex = 19;
            this.ultraDropDownTiposDeCobranza.ValueMember = "idTipoDeCobranza";
            this.ultraDropDownTiposDeCobranza.Visible = false;
            this.ultraDropDownTiposDeCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeCobranzaBeforeDropDown);
            this.ultraDropDownTiposDeCobranza.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownTiposDeCobranzaFilterRow);
            // 
            // tiposDeCobranzaBindingSource
            // 
            this.tiposDeCobranzaBindingSource.DataMember = "TiposDeCobranza";
            this.tiposDeCobranzaBindingSource.DataSource = this.dsTiposDeCobranza;
            // 
            // dsTiposDeCobranza
            // 
            this.dsTiposDeCobranza.DataSetName = "DsTiposDeCobranza";
            this.dsTiposDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownEntidadesDeCobranza
            // 
            this.ultraDropDownEntidadesDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEntidadesDeCobranza.DataSource = this.entidadesDeCobranzaBindingSource;
            appearance99.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Appearance = appearance99;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn207.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn207.Header.VisiblePosition = 0;
            ultraGridColumn207.Hidden = true;
            ultraGridColumn208.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn208.Header.VisiblePosition = 1;
            ultraGridColumn209.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn209.Header.VisiblePosition = 3;
            ultraGridColumn209.Hidden = true;
            ultraGridColumn210.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn210.Header.VisiblePosition = 2;
            ultraGridColumn210.Hidden = true;
            ultraGridColumn211.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn211.Header.VisiblePosition = 4;
            ultraGridColumn211.Hidden = true;
            ultraGridColumn212.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn212.Header.VisiblePosition = 5;
            ultraGridColumn212.Hidden = true;
            ultraGridColumn213.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn213.Header.VisiblePosition = 6;
            ultraGridColumn213.Hidden = true;
            ultraGridColumn214.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn214.Header.VisiblePosition = 7;
            ultraGridColumn214.Hidden = true;
            ultraGridColumn215.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn215.Header.VisiblePosition = 8;
            ultraGridColumn215.Hidden = true;
            ultraGridColumn216.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn216.Header.VisiblePosition = 9;
            ultraGridColumn216.Hidden = true;
            ultraGridColumn217.Header.VisiblePosition = 10;
            ultraGridColumn217.Hidden = true;
            ultraGridColumn218.Header.VisiblePosition = 11;
            ultraGridColumn218.Hidden = true;
            ultraGridColumn219.Header.VisiblePosition = 12;
            ultraGridColumn219.Hidden = true;
            ultraGridColumn220.Header.VisiblePosition = 13;
            ultraGridColumn220.Hidden = true;
            ultraGridColumn221.Header.VisiblePosition = 14;
            ultraGridColumn221.Hidden = true;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn207,
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
            ultraGridBand17.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance100.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance100;
            appearance101.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance101.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance101.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance101;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance102.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance102;
            appearance103.BackColor = System.Drawing.SystemColors.Control;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.CellAppearance = appearance103;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance104.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance104.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance104.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance104.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance104;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance105.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance105;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance106;
            appearance107.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance107.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance108;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEntidadesDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownEntidadesDeCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownEntidadesDeCobranza.Location = new System.Drawing.Point(500, 233);
            this.ultraDropDownEntidadesDeCobranza.Name = "ultraDropDownEntidadesDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownEntidadesDeCobranza.TabIndex = 20;
            this.ultraDropDownEntidadesDeCobranza.ValueMember = "idEntidadDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Visible = false;
            this.ultraDropDownEntidadesDeCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownEntidadesDeCobranzaBeforeDropDown);
            // 
            // entidadesDeCobranzaBindingSource
            // 
            this.entidadesDeCobranzaBindingSource.DataMember = "EntidadesDeCobranza";
            this.entidadesDeCobranzaBindingSource.DataSource = this.dsEntidadesDeCobranza;
            // 
            // dsEntidadesDeCobranza
            // 
            this.dsEntidadesDeCobranza.DataSetName = "DsEntidadesDeCobranza";
            this.dsEntidadesDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeContrato
            // 
            this.ultraDropDownTiposDeContrato.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeContrato.DataSource = this.tiposDeContratoBindingSource;
            appearance89.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance89.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Appearance = appearance89;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn204.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn204.Header.VisiblePosition = 0;
            ultraGridColumn204.Hidden = true;
            ultraGridColumn205.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn205.Header.VisiblePosition = 1;
            ultraGridColumn206.Header.VisiblePosition = 2;
            ultraGridColumn206.Hidden = true;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn204,
            ultraGridColumn205,
            ultraGridColumn206});
            ultraGridBand16.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeContrato.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ultraDropDownTiposDeContrato.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeContrato.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeContrato.DisplayLayout.MaxBandDepth = 5;
            appearance90.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.ActiveCellAppearance = appearance90;
            appearance91.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance91.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance91.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.ActiveRowAppearance = appearance91;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance92.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.CardAreaAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.Control;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.CellAppearance = appearance93;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance94.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance94.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance94.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance94.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.HeaderAppearance = appearance94;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance95.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.RowSelectorAppearance = appearance95;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.SelectedCellAppearance = appearance96;
            appearance97.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance97.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.SelectedRowAppearance = appearance97;
            appearance98.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance98.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance98;
            this.ultraDropDownTiposDeContrato.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeContrato.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeContrato.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeContrato.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeContrato.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeContrato.Location = new System.Drawing.Point(500, 193);
            this.ultraDropDownTiposDeContrato.Name = "ultraDropDownTiposDeContrato";
            this.ultraDropDownTiposDeContrato.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeContrato.TabIndex = 21;
            this.ultraDropDownTiposDeContrato.ValueMember = "idTipoDeContrato";
            this.ultraDropDownTiposDeContrato.Visible = false;
            this.ultraDropDownTiposDeContrato.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeContratoBeforeDropDown);
            // 
            // tiposDeContratoBindingSource
            // 
            this.tiposDeContratoBindingSource.DataMember = "TiposDeContrato";
            this.tiposDeContratoBindingSource.DataSource = this.dsTiposDeContrato;
            // 
            // dsTiposDeContrato
            // 
            this.dsTiposDeContrato.DataSetName = "DsTiposDeContrato";
            this.dsTiposDeContrato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownVendedores
            // 
            this.ultraDropDownVendedores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownVendedores.DataSource = this.vendedoresBindingSource;
            appearance79.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance79.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownVendedores.DisplayLayout.Appearance = appearance79;
            ultraGridColumn197.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn197.Header.VisiblePosition = 0;
            ultraGridColumn197.Hidden = true;
            ultraGridColumn197.Width = 30;
            ultraGridColumn198.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn198.Header.VisiblePosition = 1;
            ultraGridColumn198.Hidden = true;
            ultraGridColumn198.Width = 21;
            ultraGridColumn199.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn199.Header.VisiblePosition = 2;
            ultraGridColumn199.Hidden = true;
            ultraGridColumn199.Width = 45;
            ultraGridColumn200.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn200.Header.VisiblePosition = 3;
            ultraGridColumn200.Hidden = true;
            ultraGridColumn200.Width = 45;
            ultraGridColumn201.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn201.Header.VisiblePosition = 4;
            ultraGridColumn201.Width = 231;
            ultraGridColumn202.Header.VisiblePosition = 6;
            ultraGridColumn202.Hidden = true;
            ultraGridColumn203.Header.VisiblePosition = 5;
            ultraGridColumn203.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn197,
            ultraGridColumn198,
            ultraGridColumn199,
            ultraGridColumn200,
            ultraGridColumn201,
            ultraGridColumn202,
            ultraGridColumn203});
            this.ultraDropDownVendedores.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownVendedores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownVendedores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownVendedores.DisplayLayout.MaxBandDepth = 5;
            appearance80.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownVendedores.DisplayLayout.Override.ActiveCellAppearance = appearance80;
            appearance81.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance81.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownVendedores.DisplayLayout.Override.ActiveRowAppearance = appearance81;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance82.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownVendedores.DisplayLayout.Override.CardAreaAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.Control;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedores.DisplayLayout.Override.CellAppearance = appearance83;
            this.ultraDropDownVendedores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance84.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance84.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance84.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance84.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownVendedores.DisplayLayout.Override.HeaderAppearance = appearance84;
            this.ultraDropDownVendedores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance85.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownVendedores.DisplayLayout.Override.RowSelectorAppearance = appearance85;
            this.ultraDropDownVendedores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownVendedores.DisplayLayout.Override.SelectedCellAppearance = appearance86;
            appearance87.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance87.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedores.DisplayLayout.Override.SelectedRowAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownVendedores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance88;
            this.ultraDropDownVendedores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownVendedores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownVendedores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownVendedores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownVendedores.DisplayMember = "ApelNomb";
            this.ultraDropDownVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownVendedores.Location = new System.Drawing.Point(502, 313);
            this.ultraDropDownVendedores.Name = "ultraDropDownVendedores";
            this.ultraDropDownVendedores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownVendedores.TabIndex = 22;
            this.ultraDropDownVendedores.ValueMember = "idEmpleado";
            this.ultraDropDownVendedores.Visible = false;
            this.ultraDropDownVendedores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownVendedoresBeforeDropDown);
            this.ultraDropDownVendedores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownVendedoresFilterRow);
            // 
            // vendedoresBindingSource
            // 
            this.vendedoresBindingSource.DataMember = "EmpleadosLista";
            this.vendedoresBindingSource.DataSource = this.dsVendedores;
            // 
            // dsVendedores
            // 
            this.dsVendedores.DataSetName = "DsEmpleadosLista";
            this.dsVendedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTomadoresDeBaja
            // 
            this.ultraDropDownTomadoresDeBaja.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTomadoresDeBaja.DataSource = this.tomadoresDeBajaBindingSource;
            appearance69.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Appearance = appearance69;
            ultraGridColumn190.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn190.Header.VisiblePosition = 0;
            ultraGridColumn190.Hidden = true;
            ultraGridColumn190.Width = 30;
            ultraGridColumn191.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn191.Header.VisiblePosition = 1;
            ultraGridColumn191.Hidden = true;
            ultraGridColumn191.Width = 21;
            ultraGridColumn192.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn192.Header.VisiblePosition = 2;
            ultraGridColumn192.Hidden = true;
            ultraGridColumn192.Width = 45;
            ultraGridColumn193.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn193.Header.VisiblePosition = 3;
            ultraGridColumn193.Hidden = true;
            ultraGridColumn193.Width = 45;
            ultraGridColumn194.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn194.Header.VisiblePosition = 4;
            ultraGridColumn194.Width = 231;
            ultraGridColumn195.Header.VisiblePosition = 6;
            ultraGridColumn195.Hidden = true;
            ultraGridColumn196.Header.VisiblePosition = 5;
            ultraGridColumn196.Hidden = true;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn190,
            ultraGridColumn191,
            ultraGridColumn192,
            ultraGridColumn193,
            ultraGridColumn194,
            ultraGridColumn195,
            ultraGridColumn196});
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance70.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance71.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance71;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance72.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance72;
            appearance73.BackColor = System.Drawing.SystemColors.Control;
            appearance73.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CellAppearance = appearance73;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance74.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance74.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance74.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance74.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderAppearance = appearance74;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance75.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance75;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance77;
            appearance78.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance78.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance78;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTomadoresDeBaja.DisplayMember = "ApelNomb";
            this.ultraDropDownTomadoresDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTomadoresDeBaja.Location = new System.Drawing.Point(12, 313);
            this.ultraDropDownTomadoresDeBaja.Name = "ultraDropDownTomadoresDeBaja";
            this.ultraDropDownTomadoresDeBaja.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTomadoresDeBaja.TabIndex = 23;
            this.ultraDropDownTomadoresDeBaja.ValueMember = "idEmpleado";
            this.ultraDropDownTomadoresDeBaja.Visible = false;
            this.ultraDropDownTomadoresDeBaja.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTomadoresDeBajaBeforeDropDown);
            this.ultraDropDownTomadoresDeBaja.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownTomadoresDeBajaFilterRow);
            // 
            // tomadoresDeBajaBindingSource
            // 
            this.tomadoresDeBajaBindingSource.DataMember = "EmpleadosLista";
            this.tomadoresDeBajaBindingSource.DataSource = this.dsTomadoresDeBaja;
            // 
            // dsTomadoresDeBaja
            // 
            this.dsTomadoresDeBaja.DataSetName = "DsEmpleadosLista";
            this.dsTomadoresDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivosDeBaja
            // 
            this.ultraDropDownMotivosDeBaja.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMotivosDeBaja.DataSource = this.motivosDeBajaBindingSource;
            appearance61.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Appearance = appearance61;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn188.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn188.Header.VisiblePosition = 0;
            ultraGridColumn188.Hidden = true;
            ultraGridColumn189.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn189.Header.VisiblePosition = 1;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn188,
            ultraGridColumn189});
            ultraGridBand13.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownMotivosDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.MaxBandDepth = 5;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance62.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance62;
            appearance63.BackColor = System.Drawing.SystemColors.Control;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CellAppearance = appearance63;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance64.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance64.BackColor2 = System.Drawing.SystemColors.Control;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance64.FontData.BoldAsString = "False";
            appearance64.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderAppearance = appearance64;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance65.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance65;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance67.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance68;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosDeBaja.DisplayMember = "Nombre";
            this.ultraDropDownMotivosDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivosDeBaja.Location = new System.Drawing.Point(12, 353);
            this.ultraDropDownMotivosDeBaja.Name = "ultraDropDownMotivosDeBaja";
            this.ultraDropDownMotivosDeBaja.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownMotivosDeBaja.TabIndex = 24;
            this.ultraDropDownMotivosDeBaja.ValueMember = "idMotivoDeBaja";
            this.ultraDropDownMotivosDeBaja.Visible = false;
            this.ultraDropDownMotivosDeBaja.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosDeBajaBeforeDropDown);
            // 
            // motivosDeBajaBindingSource
            // 
            this.motivosDeBajaBindingSource.DataMember = "MotivosDeBaja";
            this.motivosDeBajaBindingSource.DataSource = this.dsMotivosDeBaja;
            // 
            // dsMotivosDeBaja
            // 
            this.dsMotivosDeBaja.DataSetName = "DsMotivosDeBaja";
            this.dsMotivosDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCodigos
            // 
            this.ultraDropDownCodigos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCodigos.DataSource = this.codigosBindingSource;
            appearance51.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCodigos.DisplayLayout.Appearance = appearance51;
            ultraGridBand12.ColHeadersVisible = false;
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
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn183,
            ultraGridColumn184,
            ultraGridColumn185,
            ultraGridColumn186,
            ultraGridColumn187});
            ultraGridBand12.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand12.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCodigos.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownCodigos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCodigos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCodigos.DisplayLayout.MaxBandDepth = 5;
            appearance52.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveCellAppearance = appearance52;
            appearance53.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance53.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance53.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveRowAppearance = appearance53;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance54.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.CardAreaAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.Control;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.CellAppearance = appearance55;
            this.ultraDropDownCodigos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance56.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance56.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance56.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderAppearance = appearance56;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance57.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSelectorAppearance = appearance57;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedCellAppearance = appearance58;
            appearance59.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance59.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedRowAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance60.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCodigos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance60;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCodigos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCodigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCodigos.DisplayMember = "Nombre";
            this.ultraDropDownCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCodigos.Location = new System.Drawing.Point(256, 193);
            this.ultraDropDownCodigos.Name = "ultraDropDownCodigos";
            this.ultraDropDownCodigos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCodigos.TabIndex = 25;
            this.ultraDropDownCodigos.ValueMember = "idCodigo";
            this.ultraDropDownCodigos.Visible = false;
            this.ultraDropDownCodigos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCodigosBeforeDropDown);
            // 
            // codigosBindingSource
            // 
            this.codigosBindingSource.DataMember = "Codigos";
            this.codigosBindingSource.DataSource = this.dsCodigos;
            // 
            // dsCodigos
            // 
            this.dsCodigos.DataSetName = "DsCodigos";
            this.dsCodigos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance179.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance179.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance179;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn173.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn173.Header.VisiblePosition = 0;
            ultraGridColumn173.Hidden = true;
            ultraGridColumn174.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn174.Header.VisiblePosition = 1;
            ultraGridColumn175.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn175.Header.VisiblePosition = 2;
            ultraGridColumn175.Hidden = true;
            ultraGridColumn176.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn176.Header.VisiblePosition = 3;
            ultraGridColumn176.Hidden = true;
            ultraGridColumn177.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn177.Header.VisiblePosition = 4;
            ultraGridColumn177.Hidden = true;
            ultraGridColumn178.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn178.Header.VisiblePosition = 5;
            ultraGridColumn178.Hidden = true;
            ultraGridColumn179.Header.VisiblePosition = 6;
            ultraGridColumn179.Hidden = true;
            ultraGridColumn180.Header.VisiblePosition = 7;
            ultraGridColumn181.Header.VisiblePosition = 8;
            ultraGridColumn182.Header.VisiblePosition = 9;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175,
            ultraGridColumn176,
            ultraGridColumn177,
            ultraGridColumn178,
            ultraGridColumn179,
            ultraGridColumn180,
            ultraGridColumn181,
            ultraGridColumn182});
            ultraGridBand11.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand11.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance180.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance180;
            appearance181.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance181.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance181.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance181;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance182.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance182;
            appearance183.BackColor = System.Drawing.SystemColors.Control;
            appearance183.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance183.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance183;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance184.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance184.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance184.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance184.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance184;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance187.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance187;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance194.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance194;
            appearance217.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance217.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance217.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance217;
            appearance229.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance229.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance229;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(256, 273);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCategoriasIVA.TabIndex = 26;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            this.ultraDropDownCategoriasIVA.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCategoriasIVABeforeDropDown);
            // 
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBarrios.DataSource = this.barriosBindingSource;
            appearance176.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance176.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance176;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn170.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn170.Header.VisiblePosition = 0;
            ultraGridColumn170.Hidden = true;
            ultraGridColumn171.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn171.Header.VisiblePosition = 2;
            ultraGridColumn172.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn172.Header.VisiblePosition = 1;
            ultraGridColumn172.Hidden = true;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172});
            ultraGridBand10.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand10.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance177.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance177;
            appearance178.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance178.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance178.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance178;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance36;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance37.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance37;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance40;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(12, 193);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownBarrios.TabIndex = 27;
            this.ultraDropDownBarrios.ValueMember = "idBarrio";
            this.ultraDropDownBarrios.Visible = false;
            this.ultraDropDownBarrios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownBarriosBeforeDropDown);
            this.ultraDropDownBarrios.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarriosFilterRow);
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataSource = this.dsBarrios1;
            this.barriosBindingSource.Position = 0;
            // 
            // dsBarrios1
            // 
            this.dsBarrios1.DataSetName = "DsBarrios";
            this.dsBarrios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownContratos
            // 
            this.ultraDropDownContratos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownContratos.DataSource = this.contratosRenglonFacturaBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownContratos.DisplayLayout.Appearance = appearance21;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn164.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn164.Header.VisiblePosition = 0;
            ultraGridColumn164.Hidden = true;
            ultraGridColumn165.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn165.Header.VisiblePosition = 1;
            ultraGridColumn166.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn166.Header.VisiblePosition = 2;
            ultraGridColumn166.Hidden = true;
            ultraGridColumn167.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn167.Header.VisiblePosition = 3;
            ultraGridColumn167.Hidden = true;
            ultraGridColumn168.Header.VisiblePosition = 4;
            ultraGridColumn168.Hidden = true;
            ultraGridColumn169.Header.VisiblePosition = 5;
            ultraGridColumn169.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn164,
            ultraGridColumn165,
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169});
            this.ultraDropDownContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownContratos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownContratos.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance159.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.CardAreaAppearance = appearance159;
            appearance170.BackColor = System.Drawing.SystemColors.Control;
            appearance170.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance170.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.CellAppearance = appearance170;
            this.ultraDropDownContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance171.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance171.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance171.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance171.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance171.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderAppearance = appearance171;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance172.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSelectorAppearance = appearance172;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance173.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedCellAppearance = appearance173;
            appearance174.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance174.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedRowAppearance = appearance174;
            appearance175.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance175.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance175;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownContratos.DisplayMember = "Nombre";
            this.ultraDropDownContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownContratos.Location = new System.Drawing.Point(502, 353);
            this.ultraDropDownContratos.Name = "ultraDropDownContratos";
            this.ultraDropDownContratos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownContratos.TabIndex = 28;
            this.ultraDropDownContratos.ValueMember = "idContrato";
            this.ultraDropDownContratos.Visible = false;
            this.ultraDropDownContratos.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraDropDownContratosInitializeRow);
            this.ultraDropDownContratos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownContratosBeforeDropDown);
            this.ultraDropDownContratos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownContratosRowSelected);
            // 
            // contratosRenglonFacturaBindingSource
            // 
            this.contratosRenglonFacturaBindingSource.DataMember = "ContratosRenglonFactura";
            this.contratosRenglonFacturaBindingSource.DataSource = this.dsContratosLista;
            // 
            // dsContratosLista
            // 
            this.dsContratosLista.DataSetName = "DsContratosLista";
            this.dsContratosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTandasDeFacturacion
            // 
            this.ultraDropDownTandasDeFacturacion.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTandasDeFacturacion.DataSource = this.tandasDeFacturacionBindingSource;
            appearance160.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance160.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance160.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Appearance = appearance160;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn161.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn161.Header.VisiblePosition = 0;
            ultraGridColumn161.Hidden = true;
            ultraGridColumn162.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn162.Header.VisiblePosition = 1;
            ultraGridColumn162.Width = 231;
            ultraGridColumn163.Header.VisiblePosition = 2;
            ultraGridColumn163.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn161,
            ultraGridColumn162,
            ultraGridColumn163});
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.MaxBandDepth = 5;
            appearance161.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveCellAppearance = appearance161;
            appearance162.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance162.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance162.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveRowAppearance = appearance162;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance163.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CardAreaAppearance = appearance163;
            appearance164.BackColor = System.Drawing.SystemColors.Control;
            appearance164.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CellAppearance = appearance164;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance165.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance165.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance165.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance165.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderAppearance = appearance165;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance166.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSelectorAppearance = appearance166;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance167.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedCellAppearance = appearance167;
            appearance168.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance168.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedRowAppearance = appearance168;
            appearance169.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance169.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance169;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTandasDeFacturacion.DisplayMember = "Nombre";
            this.ultraDropDownTandasDeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTandasDeFacturacion.Location = new System.Drawing.Point(12, 393);
            this.ultraDropDownTandasDeFacturacion.Name = "ultraDropDownTandasDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTandasDeFacturacion.TabIndex = 29;
            this.ultraDropDownTandasDeFacturacion.ValueMember = "idTandaDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Visible = false;
            this.ultraDropDownTandasDeFacturacion.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTandasDeFacturacionBeforeDropDown);
            // 
            // tandasDeFacturacionBindingSource
            // 
            this.tandasDeFacturacionBindingSource.DataMember = "TandasDeFacturacion";
            this.tandasDeFacturacionBindingSource.DataSource = this.dsTandasDeFacturacion;
            // 
            // dsTandasDeFacturacion
            // 
            this.dsTandasDeFacturacion.DataSetName = "DsTandasDeFacturacion";
            this.dsTandasDeFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas1
            // 
            this.dsSistemas1.DataSetName = "DsSistemas";
            this.dsSistemas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownLocalidad
            // 
            this.ultraDropDownLocalidad.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidad.DataSource = this.localidadesListaBindingSource;
            appearance139.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance139.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance139;
            ultraGridBand21.ColHeadersVisible = false;
            ultraGridColumn236.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn236.Header.VisiblePosition = 0;
            ultraGridColumn236.Hidden = true;
            ultraGridColumn237.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn237.Header.VisiblePosition = 1;
            ultraGridColumn238.Header.VisiblePosition = 2;
            ultraGridColumn238.Hidden = true;
            ultraGridBand21.Columns.AddRange(new object[] {
            ultraGridColumn236,
            ultraGridColumn237,
            ultraGridColumn238});
            ultraGridBand21.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand21.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand21);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance140.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance140;
            appearance141.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance141.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance141.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance141;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance142.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance142;
            appearance143.BackColor = System.Drawing.SystemColors.Control;
            appearance143.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance143.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance143;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance144.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance144.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance144.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance144.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance144;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance145.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance145;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance146.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance146;
            appearance147.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance147.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance147;
            appearance148.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance148.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance148;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(258, 313);
            this.ultraDropDownLocalidad.Name = "ultraDropDownLocalidad";
            this.ultraDropDownLocalidad.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownLocalidad.TabIndex = 11;
            this.ultraDropDownLocalidad.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad.Visible = false;
            this.ultraDropDownLocalidad.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownLocalidadBeforeDropDown);
            this.ultraDropDownLocalidad.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadRowSelected);
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
            // dscuitRepetibles1
            // 
            this.dscuitRepetibles1.DataSetName = "DsCUITRepetibles";
            this.dscuitRepetibles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPlanes1
            // 
            this.dsPlanes1.DataSetName = "DsPlanes";
            this.dsPlanes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPlanes
            // 
            this.ultraDropDownPlanes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPlanes.DataSource = this.planesDelClientebindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanes.DisplayLayout.Appearance = appearance1;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn156.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn156.Header.VisiblePosition = 0;
            ultraGridColumn156.Hidden = true;
            ultraGridColumn156.Width = 48;
            ultraGridColumn157.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn157.Header.VisiblePosition = 1;
            ultraGridColumn157.Width = 231;
            ultraGridColumn158.Header.VisiblePosition = 2;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn159.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn159.Header.VisiblePosition = 3;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn159.Width = 58;
            ultraGridColumn160.Header.VisiblePosition = 4;
            ultraGridColumn160.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160});
            this.ultraDropDownPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanes.DisplayMember = "Nombre";
            this.ultraDropDownPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPlanes.Location = new System.Drawing.Point(12, 233);
            this.ultraDropDownPlanes.Name = "ultraDropDownPlanes";
            this.ultraDropDownPlanes.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownPlanes.TabIndex = 30;
            this.ultraDropDownPlanes.ValueMember = "idPlan";
            this.ultraDropDownPlanes.Visible = false;
            this.ultraDropDownPlanes.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPlanesBeforeDropDown);
            this.ultraDropDownPlanes.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownPlanesFilterRow);
            // 
            // planesDelClientebindingSource
            // 
            this.planesDelClientebindingSource.DataMember = "PlanesDelCliente";
            this.planesDelClientebindingSource.DataSource = this.dsContratosLista;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.dsPlanes1;
            // 
            // dsProtecciones
            // 
            this.dsProtecciones.DataSetName = "DsProtecciones";
            this.dsProtecciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proteccionesBindingSource
            // 
            this.proteccionesBindingSource.DataMember = "Protecciones";
            this.proteccionesBindingSource.DataSource = this.dsProtecciones;
            // 
            // ultraDropDownProtecciones
            // 
            this.ultraDropDownProtecciones.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownProtecciones.DataSource = this.proteccionesBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownProtecciones.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownProtecciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn151.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn151.Header.VisiblePosition = 0;
            ultraGridColumn151.Hidden = true;
            ultraGridColumn152.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn152.Header.VisiblePosition = 1;
            ultraGridColumn153.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn153.Header.VisiblePosition = 2;
            ultraGridColumn153.Hidden = true;
            ultraGridColumn154.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn154.Header.VisiblePosition = 3;
            ultraGridColumn154.Hidden = true;
            ultraGridColumn155.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn155.Header.VisiblePosition = 4;
            ultraGridColumn155.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154,
            ultraGridColumn155});
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownProtecciones.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownProtecciones.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownProtecciones.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownProtecciones.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownProtecciones.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownProtecciones.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownProtecciones.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProtecciones.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownProtecciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownProtecciones.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownProtecciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownProtecciones.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownProtecciones.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownProtecciones.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProtecciones.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownProtecciones.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownProtecciones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownProtecciones.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownProtecciones.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownProtecciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownProtecciones.DisplayMember = "Nombre";
            this.ultraDropDownProtecciones.DropDownWidth = 0;
            this.ultraDropDownProtecciones.Location = new System.Drawing.Point(256, 393);
            this.ultraDropDownProtecciones.Name = "ultraDropDownProtecciones";
            this.ultraDropDownProtecciones.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownProtecciones.TabIndex = 31;
            this.ultraDropDownProtecciones.ValueMember = "idProteccion";
            this.ultraDropDownProtecciones.Visible = false;
            // 
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance207.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance207.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance207.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance207;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn145.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn145.Header.VisiblePosition = 0;
            ultraGridColumn145.Hidden = true;
            ultraGridColumn146.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn146.Header.VisiblePosition = 1;
            ultraGridColumn146.Hidden = true;
            ultraGridColumn147.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn147.Header.VisiblePosition = 2;
            ultraGridColumn148.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn148.Header.VisiblePosition = 3;
            ultraGridColumn148.Hidden = true;
            ultraGridColumn149.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn149.Header.VisiblePosition = 4;
            ultraGridColumn149.Hidden = true;
            ultraGridColumn150.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn150.Header.VisiblePosition = 5;
            ultraGridColumn150.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn145,
            ultraGridColumn146,
            ultraGridColumn147,
            ultraGridColumn148,
            ultraGridColumn149,
            ultraGridColumn150});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownGrabador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownGrabador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownGrabador.DisplayLayout.MaxBandDepth = 5;
            appearance208.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveCellAppearance = appearance208;
            appearance209.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance209.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance209.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance209.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveRowAppearance = appearance209;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance210.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.CardAreaAppearance = appearance210;
            appearance211.BackColor = System.Drawing.SystemColors.Control;
            appearance211.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance211.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.CellAppearance = appearance211;
            this.ultraDropDownGrabador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance212.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance212.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance212.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance212.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderAppearance = appearance212;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance213.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSelectorAppearance = appearance213;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance214.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedCellAppearance = appearance214;
            appearance215.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance215.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance215.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedRowAppearance = appearance215;
            appearance216.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance216.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownGrabador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance216;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownGrabador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownGrabador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownGrabador.DisplayMember = "NombApel";
            this.ultraDropDownGrabador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(500, 393);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownGrabador.TabIndex = 55;
            this.ultraDropDownGrabador.ValueMember = "idUsuario";
            this.ultraDropDownGrabador.Visible = false;
            // 
            // usuariosListaBindingSource
            // 
            this.usuariosListaBindingSource.DataMember = "UsuariosLista";
            this.usuariosListaBindingSource.DataSource = this.dsUsuariosLista1;
            // 
            // dsUsuariosLista1
            // 
            this.dsUsuariosLista1.DataSetName = "DsUsuariosLista";
            this.dsUsuariosLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPrepagos
            // 
            this.dsPrepagos.DataSetName = "DsPrepagos";
            this.dsPrepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepagosBindingSource
            // 
            this.prepagosBindingSource.DataMember = "Prepagos";
            this.prepagosBindingSource.DataSource = this.dsPrepagos;
            // 
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance218.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance218.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance218.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance218;
            this.ultraDropDownPrepagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn142.Header.VisiblePosition = 0;
            ultraGridColumn142.Hidden = true;
            ultraGridColumn142.Width = 57;
            ultraGridColumn143.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn143.Header.VisiblePosition = 1;
            ultraGridColumn143.Width = 231;
            ultraGridColumn144.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn144.Header.VisiblePosition = 2;
            ultraGridColumn144.Hidden = true;
            ultraGridColumn144.Width = 87;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn142,
            ultraGridColumn143,
            ultraGridColumn144});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance219.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance219;
            appearance220.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance220.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance220.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance220.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance220;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance221.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance221;
            appearance222.BackColor = System.Drawing.SystemColors.Control;
            appearance222.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance222.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance222;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance223.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance223.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance223.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance223.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance223.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance223;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance224.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance224;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance225.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance225;
            appearance226.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance226.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance226.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance226;
            appearance227.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance227.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance227;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.DropDownWidth = 250;
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(12, 433);
            this.ultraDropDownPrepagos.Name = "ultraDropDownPrepagos";
            this.ultraDropDownPrepagos.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPrepagos.TabIndex = 56;
            this.ultraDropDownPrepagos.ValueMember = "idPrepago";
            this.ultraDropDownPrepagos.Visible = false;
            // 
            // ultraDataSourceFacturarMes
            // 
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceFacturarMes.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceFacturarMes.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(-1)),
                        ((object)("Texto")),
                        ((object)("Vencido"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(0)),
                        ((object)("Texto")),
                        ((object)("Actual"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(1)),
                        ((object)("Texto")),
                        ((object)("Siguiente"))})});
            // 
            // ultraDropDownFacturarMes
            // 
            this.ultraDropDownFacturarMes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownFacturarMes.DataSource = this.ultraDataSourceFacturarMes;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownFacturarMes.DisplayLayout.Appearance = appearance245;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn140.Header.VisiblePosition = 0;
            ultraGridColumn140.Hidden = true;
            ultraGridColumn141.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn140,
            ultraGridColumn141});
            this.ultraDropDownFacturarMes.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownFacturarMes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownFacturarMes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownFacturarMes.DisplayLayout.MaxBandDepth = 5;
            appearance246.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.ActiveCellAppearance = appearance246;
            appearance247.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance247.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.ActiveRowAppearance = appearance247;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance248.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.CardAreaAppearance = appearance248;
            appearance249.BackColor = System.Drawing.SystemColors.Control;
            appearance249.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.CellAppearance = appearance249;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance250.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance250.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance250.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.HeaderAppearance = appearance250;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance251.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.RowSelectorAppearance = appearance251;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.SelectedCellAppearance = appearance252;
            appearance253.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance253.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance253.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.SelectedRowAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance254.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance254;
            this.ultraDropDownFacturarMes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownFacturarMes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownFacturarMes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownFacturarMes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownFacturarMes.DisplayMember = "Texto";
            this.ultraDropDownFacturarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownFacturarMes.Location = new System.Drawing.Point(500, 431);
            this.ultraDropDownFacturarMes.Name = "ultraDropDownFacturarMes";
            this.ultraDropDownFacturarMes.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownFacturarMes.TabIndex = 57;
            this.ultraDropDownFacturarMes.ValueMember = "Valor";
            this.ultraDropDownFacturarMes.Visible = false;
            this.ultraDropDownFacturarMes.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownFacturarMes_BeforeDropDown);
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
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance24;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn136.Header.VisiblePosition = 0;
            ultraGridColumn136.Hidden = true;
            ultraGridColumn137.Header.VisiblePosition = 1;
            ultraGridColumn137.Hidden = true;
            ultraGridColumn138.Header.VisiblePosition = 2;
            ultraGridColumn139.Header.VisiblePosition = 3;
            ultraGridColumn139.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn136,
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance26.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance26;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance27.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.Control;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance28;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance29.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance29;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance30.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance30;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance31;
            appearance32.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance32.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance33;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.DropDownWidth = 0;
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(258, 433);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownNegocios.TabIndex = 58;
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
            appearance124.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance124.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance124;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand23.ColHeadersVisible = false;
            ultraGridColumn243.Header.VisiblePosition = 0;
            ultraGridColumn243.Hidden = true;
            ultraGridColumn243.Width = 54;
            ultraGridColumn244.Header.VisiblePosition = 1;
            ultraGridColumn244.Hidden = true;
            ultraGridColumn244.Width = 45;
            ultraGridColumn245.Header.VisiblePosition = 2;
            ultraGridColumn245.Width = 231;
            ultraGridColumn246.Header.VisiblePosition = 3;
            ultraGridColumn246.Hidden = true;
            ultraGridColumn246.Width = 27;
            ultraGridColumn247.Header.VisiblePosition = 4;
            ultraGridColumn247.Hidden = true;
            ultraGridColumn247.Width = 47;
            ultraGridBand23.Columns.AddRange(new object[] {
            ultraGridColumn243,
            ultraGridColumn244,
            ultraGridColumn245,
            ultraGridColumn246,
            ultraGridColumn247});
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand23);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance125.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance126.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance126.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance126;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance127.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance127;
            appearance128.BackColor = System.Drawing.SystemColors.Control;
            appearance128.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance128;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance129.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance129.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance129.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance129.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance129;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance130.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance130;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance131;
            appearance132.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance132;
            appearance133.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance133;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.DropDownWidth = 250;
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(12, 474);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPorcentajeIVA.TabIndex = 59;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEmpresasSueldoBancoMacro
            // 
            this.dsEmpresasSueldoBancoMacro.DataSetName = "DsEmpresasSueldoBancoMacro";
            this.dsEmpresasSueldoBancoMacro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasSueldoBcoMacroBindingSource
            // 
            this.empresasSueldoBcoMacroBindingSource.DataMember = "EmpresasSueldoBcoMacro";
            this.empresasSueldoBcoMacroBindingSource.DataSource = this.dsEmpresasSueldoBancoMacro;
            // 
            // ultraDropDownEmpresasSueldoBancoMacro
            // 
            this.ultraDropDownEmpresasSueldoBancoMacro.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEmpresasSueldoBancoMacro.DataSource = this.empresasSueldoBcoMacroBindingSource;
            appearance41.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Appearance = appearance41;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn134.Header.VisiblePosition = 0;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn135.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn135.Header.VisiblePosition = 1;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn134,
            ultraGridColumn135});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.MaxBandDepth = 5;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.HeaderAppearance = appearance46;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance47.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.RowSelectorAppearance = appearance47;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.SelectedCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.SelectedRowAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayMember = "Nombre";
            this.ultraDropDownEmpresasSueldoBancoMacro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownEmpresasSueldoBancoMacro.Location = new System.Drawing.Point(258, 474);
            this.ultraDropDownEmpresasSueldoBancoMacro.Name = "ultraDropDownEmpresasSueldoBancoMacro";
            this.ultraDropDownEmpresasSueldoBancoMacro.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownEmpresasSueldoBancoMacro.TabIndex = 77;
            this.ultraDropDownEmpresasSueldoBancoMacro.ValueMember = "idEmpresasSueldoBcoMacro";
            this.ultraDropDownEmpresasSueldoBancoMacro.Visible = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(900, 574);
            this.Controls.Add(this.clientesUltraGrid);
            this.Controls.Add(this.ultraDropDownEmpresasSueldoBancoMacro);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownFacturarMes);
            this.Controls.Add(this.ultraDropDownPrepagos);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownProtecciones);
            this.Controls.Add(this.ultraDropDownPlanes);
            this.Controls.Add(this.ultraDropDownTandasDeFacturacion);
            this.Controls.Add(this.ultraDropDownContratos);
            this.Controls.Add(this.ultraDropDownBarrios);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Controls.Add(this.ultraDropDownCodigos);
            this.Controls.Add(this.ultraDropDownMotivosDeBaja);
            this.Controls.Add(this.ultraDropDownTomadoresDeBaja);
            this.Controls.Add(this.ultraDropDownVendedores);
            this.Controls.Add(this.ultraDropDownTiposDeContrato);
            this.Controls.Add(this.ultraDropDownEntidadesDeCobranza);
            this.Controls.Add(this.ultraDropDownTiposDeCobranza);
            this.Controls.Add(this.ultraDropDownTiposDeCliente);
            this.Controls.Add(this.ultraDropDownZonas);
            this.Controls.Add(this.ultraDropDownLocalidad);
            this.Controls.Add(this.ultraDropDownCalle);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(356, 193);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Activated += new System.EventHandler(this.FormClientesActivated);
            this.Load += new System.EventHandler(this.FormClientesLoad);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalle, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidad, 0);
            this.Controls.SetChildIndex(this.ultraDropDownZonas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeCliente, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEntidadesDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeContrato, 0);
            this.Controls.SetChildIndex(this.ultraDropDownVendedores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTomadoresDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCodigos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBarrios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownContratos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTandasDeFacturacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownProtecciones, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrepagos, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownFacturarMes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEmpresasSueldoBancoMacro, 0);
            this.Controls.SetChildIndex(this.clientesUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosRenglonFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscuitRepetibles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDelClientebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProtecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceFacturarMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownFacturarMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresasSueldoBancoMacro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEmpresasSueldoBancoMacro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid clientesUltraGrid;
        private System.Windows.Forms.Button buttonSalir;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private WS.DsClientes dsClientes;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalle;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private WS.DsCallesLista dsCallesLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownZonas;
        private System.Windows.Forms.BindingSource zonasBindingSource;
        private WS.DsZonas dsZonas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeCliente;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private System.Windows.Forms.BindingSource tiposDeClienteBindingSource;
        private WS.DsTiposDeCliente dsTiposDeCliente;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeCobranza;
        private System.Windows.Forms.BindingSource tiposDeCobranzaBindingSource;
        private WS.DsTiposDeCobranza dsTiposDeCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownEntidadesDeCobranza;
        private System.Windows.Forms.BindingSource entidadesDeCobranzaBindingSource;
        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeContrato;
        private System.Windows.Forms.BindingSource tiposDeContratoBindingSource;
        private WS.DsTiposDeContrato dsTiposDeContrato;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownVendedores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTomadoresDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosDeBaja;
        private System.Windows.Forms.BindingSource motivosDeBajaBindingSource;
        private WS.DsMotivosDeBaja dsMotivosDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCodigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private WS.DsCodigos dsCodigos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private WS.DsBarrios dsBarrios1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownContratos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTandasDeFacturacion;
        private System.Windows.Forms.BindingSource tandasDeFacturacionBindingSource;
        private WS.DsTandasDeFacturacion dsTandasDeFacturacion;
        private WS.DsSistemas dsSistemas1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private System.Windows.Forms.BindingSource localidadesListaBindingSource;
        private WS.DsLocalidadesLista dsLocalidadesLista;
        private WS.DsCUITRepetibles dscuitRepetibles1;
        private System.Windows.Forms.BindingSource vendedoresBindingSource;
        private WS.DsEmpleadosLista dsVendedores;
        private WS.DsEmpleadosLista dsTomadoresDeBaja;
        private System.Windows.Forms.BindingSource tomadoresDeBajaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPlanes;
        private WS.DsPlanes dsPlanes1;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private System.Windows.Forms.BindingSource contratosRenglonFacturaBindingSource;
        private WS.DsContratosLista dsContratosLista;
        private WS.DsProtecciones dsProtecciones;
        private System.Windows.Forms.BindingSource proteccionesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownProtecciones;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private WS.DsUsuariosLista dsUsuariosLista1;
        private System.Windows.Forms.BindingSource planesDelClientebindingSource;
        private WS.DsPrepagos dsPrepagos;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private UltraDropDown ultraDropDownPrepagos;
        private UltraDropDown ultraDropDownFacturarMes;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceFacturarMes;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private UltraDropDown ultraDropDownNegocios;
        private UltraDropDown ultraDropDownPorcentajeIVA;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private WS.DsParametros dsParametros;
        private WS.DsEmpresasSueldoBancoMacro dsEmpresasSueldoBancoMacro;
        private System.Windows.Forms.BindingSource empresasSueldoBcoMacroBindingSource;
        private UltraDropDown ultraDropDownEmpresasSueldoBancoMacro;
    }
}
