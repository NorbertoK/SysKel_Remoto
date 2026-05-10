using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    partial class FormRemesa
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
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Remesas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador", -1, "ultraDropDownCobradores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Caja");
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReceptor", -1, "ultraDropDownReceptor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza", -1, "ultraDropDownEntidadesDeCobranza", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesRemesas_Remesas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Remesas_ValoresRemesas");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesRemesas_Remesas", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobanteRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReferencia");
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteReferencia");
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteCobrado");
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HacerNdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("CountComprobante", Infragistics.Win.UltraWinGrid.SummaryType.Count, null, "idReferencia", 2, true, "FK_ComprobantesRemesas_Remesas", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "idReferencia", 2, true);
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumComprobantes", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteCobrado", 4, true, "FK_ComprobantesRemesas_Remesas", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "ImporteCobrado", 4, true);
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Remesas_ValoresRemesas", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor", -1, "ultraDropDownTiposDeValores", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco", -1, "ultraDropDownBancos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCheque");
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumValores", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Importe", 3, true, "FK_Remesas_ValoresRemesas", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Importe", 3, true);
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Bancos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EntidadesDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MascaraTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNumero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereVencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNombreTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDocTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereTelTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereConvenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereSucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereJubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeValores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsEfectivo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SePagaCon");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            this.remesasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.remesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemesas = new Administracion.WS.DsRemesas();
            this.ultraCurrencyEditorSumComprobantes = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraCurrencyEditorSumValores = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDropDownCobradores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.cobradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCobradores = new Administracion.WS.DsEmpleadosLista();
            this.tiposDeValoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeValores = new Administracion.WS.DsTiposDeValores();
            this.ultraDropDownBancos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBancos = new Administracion.WS.DsBancos();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Administracion.WS.DsEmpleadosLista();
            this.ultraDropDownReceptor = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Administracion.WS.DsUsuariosLista();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsEntidadesDeCobranza = new Administracion.WS.DsEntidadesDeCobranza();
            this.entidadesDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownEntidadesDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownTiposDeValores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remesasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(656, 16);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(575, 16);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraLabelMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(746, 50);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraLabelMensaje, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(575, 16);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // remesasUltraGrid
            // 
            this.remesasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remesasUltraGrid.CalcManager = this.ultraCalcManager1;
            this.remesasUltraGrid.DataSource = this.remesasBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.remesasUltraGrid.DisplayLayout.Appearance = appearance11;
            ultraGridColumn114.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn114.Header.VisiblePosition = 0;
            ultraGridColumn114.Hidden = true;
            ultraGridColumn115.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn115.Header.Caption = "Cobrador";
            ultraGridColumn115.Header.VisiblePosition = 1;
            ultraGridColumn115.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn115.Width = 175;
            ultraGridColumn116.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance48.TextHAlignAsString = "Center";
            ultraGridColumn116.CellAppearance = appearance48;
            ultraGridColumn116.Header.VisiblePosition = 2;
            ultraGridColumn116.Hidden = true;
            ultraGridColumn116.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn116.MaskInput = "dd/mm/yyyy";
            ultraGridColumn116.Width = 91;
            ultraGridColumn117.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn117.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance49.TextHAlignAsString = "Center";
            ultraGridColumn117.CellAppearance = appearance49;
            ultraGridColumn117.Header.VisiblePosition = 3;
            ultraGridColumn117.Hidden = true;
            ultraGridColumn117.NullText = "Automático";
            ultraGridColumn117.Width = 98;
            ultraGridColumn118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn118.Header.Caption = "Recibe los Valores";
            ultraGridColumn118.Header.VisiblePosition = 5;
            ultraGridColumn118.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn118.Width = 174;
            ultraGridColumn119.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn119.Header.Caption = "Grabador";
            ultraGridColumn119.Header.VisiblePosition = 6;
            ultraGridColumn119.Hidden = true;
            ultraGridColumn119.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn119.Width = 232;
            ultraGridColumn120.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance50.TextHAlignAsString = "Right";
            ultraGridColumn120.CellAppearance = appearance50;
            ultraGridColumn120.Header.VisiblePosition = 7;
            ultraGridColumn120.Hidden = true;
            ultraGridColumn120.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn120.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn120.Width = 87;
            ultraGridColumn121.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn121.DefaultCellValue = "\"Cobrador\"";
            ultraGridColumn121.Header.VisiblePosition = 8;
            ultraGridColumn121.Hidden = true;
            ultraGridColumn121.Width = 92;
            ultraGridColumn122.Header.VisiblePosition = 9;
            ultraGridColumn122.Hidden = true;
            ultraGridColumn122.Width = 352;
            ultraGridColumn123.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn123.Header.Caption = "Entidad de Cobranza";
            ultraGridColumn123.Header.VisiblePosition = 4;
            ultraGridColumn123.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn123.Width = 153;
            ultraGridColumn124.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn124.Header.VisiblePosition = 10;
            ultraGridColumn125.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn125.Header.VisiblePosition = 11;
            ultraGridBand7.Columns.AddRange(new object[] {
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
            ultraGridColumn124,
            ultraGridColumn125});
            ultraGridBand7.MaxRows = 1;
            ultraGridColumn126.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn126.Header.VisiblePosition = 0;
            ultraGridColumn126.Hidden = true;
            ultraGridColumn127.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn127.Header.VisiblePosition = 1;
            ultraGridColumn127.Hidden = true;
            ultraGridColumn128.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance51.TextHAlignAsString = "Right";
            ultraGridColumn128.CellAppearance = appearance51;
            ultraGridColumn128.Header.Caption = "Referencia";
            ultraGridColumn128.Header.VisiblePosition = 2;
            ultraGridColumn128.MaskInput = "nnnnnnnnn";
            ultraGridColumn128.Width = 95;
            ultraGridColumn129.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance52.TextHAlignAsString = "Right";
            ultraGridColumn129.CellAppearance = appearance52;
            ultraGridColumn129.Header.Caption = "Importe";
            ultraGridColumn129.Header.VisiblePosition = 3;
            ultraGridColumn129.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn129.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn129.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(84, 0);
            ultraGridColumn129.Width = 101;
            ultraGridColumn130.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance53.TextHAlignAsString = "Right";
            ultraGridColumn130.CellAppearance = appearance53;
            ultraGridColumn130.Header.Caption = "Cobrado";
            ultraGridColumn130.Header.VisiblePosition = 4;
            ultraGridColumn130.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn130.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn130.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(83, 0);
            ultraGridColumn130.Width = 88;
            ultraGridColumn131.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn131.Header.VisiblePosition = 6;
            ultraGridColumn131.Width = 332;
            ultraGridColumn132.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn132.DefaultCellValue = "False";
            ultraGridColumn132.Header.Caption = "Hacer NdeC/D";
            ultraGridColumn132.Header.VisiblePosition = 5;
            ultraGridColumn132.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(85, 0);
            ultraGridColumn132.Width = 71;
            ultraGridColumn133.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn133.Header.VisiblePosition = 7;
            ultraGridColumn133.Hidden = true;
            ultraGridColumn133.Width = 71;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130,
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133});
            appearance54.FontData.BoldAsString = "True";
            appearance54.FontData.SizeInPoints = 11F;
            appearance54.TextHAlignAsString = "Left";
            ultraGridBand8.Header.Appearance = appearance54;
            ultraGridBand8.Header.Caption = "Comprobantes";
            ultraGridBand8.HeaderVisible = true;
            ultraGridBand8.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance55.FontData.BoldAsString = "True";
            appearance55.TextHAlignAsString = "Right";
            ultraGridBand8.Override.SummaryValueAppearance = appearance55;
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            summarySettings1.DisplayFormat = "Cantidad: {0:#####}";
            summarySettings1.GroupBySummaryValueAppearance = appearance56;
            summarySettings2.DisplayFormat = "{0:c}";
            summarySettings2.GroupBySummaryValueAppearance = appearance57;
            ultraGridBand8.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1,
            summarySettings2});
            ultraGridBand8.SummaryFooterCaption = "";
            ultraGridColumn134.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn134.Header.VisiblePosition = 0;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn134.Width = 70;
            ultraGridColumn135.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn135.Header.VisiblePosition = 1;
            ultraGridColumn135.Hidden = true;
            ultraGridColumn135.Width = 54;
            ultraGridColumn136.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn136.Header.Caption = "Tipo de Valor";
            ultraGridColumn136.Header.VisiblePosition = 2;
            ultraGridColumn136.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn136.Width = 110;
            ultraGridColumn137.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance58.TextHAlignAsString = "Right";
            ultraGridColumn137.CellAppearance = appearance58;
            ultraGridColumn137.Header.VisiblePosition = 3;
            ultraGridColumn137.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn137.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn137.Width = 73;
            ultraGridColumn138.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn138.Header.VisiblePosition = 7;
            ultraGridColumn138.Width = 182;
            ultraGridColumn139.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn139.Header.Caption = "Banco";
            ultraGridColumn139.Header.VisiblePosition = 4;
            ultraGridColumn139.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn139.Width = 80;
            ultraGridColumn140.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance59.TextHAlignAsString = "Right";
            ultraGridColumn140.CellAppearance = appearance59;
            ultraGridColumn140.Header.Caption = "Cheque Nº";
            ultraGridColumn140.Header.VisiblePosition = 5;
            ultraGridColumn140.Width = 78;
            ultraGridColumn141.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance60.TextHAlignAsString = "Center";
            ultraGridColumn141.CellAppearance = appearance60;
            ultraGridColumn141.Header.Caption = "Fecha";
            ultraGridColumn141.Header.VisiblePosition = 6;
            ultraGridColumn141.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn141.MaskInput = "dd/mm/yyyy";
            ultraGridColumn141.Width = 76;
            ultraGridColumn142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn142.Header.VisiblePosition = 8;
            ultraGridColumn142.Hidden = true;
            ultraGridColumn142.Width = 61;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142});
            appearance61.FontData.BoldAsString = "True";
            appearance61.FontData.SizeInPoints = 11F;
            appearance61.TextHAlignAsString = "Left";
            ultraGridBand9.Header.Appearance = appearance61;
            ultraGridBand9.Header.Caption = "Valores";
            ultraGridBand9.HeaderVisible = true;
            ultraGridBand9.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            appearance62.FontData.BoldAsString = "True";
            appearance62.TextHAlignAsString = "Right";
            summarySettings3.Appearance = appearance62;
            summarySettings3.DisplayFormat = "{0:c}";
            summarySettings3.GroupBySummaryValueAppearance = appearance63;
            ultraGridBand9.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings3});
            ultraGridBand9.SummaryFooterCaption = "";
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.remesasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.remesasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.remesasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance76.BackColor = System.Drawing.SystemColors.Window;
            this.remesasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance77.ForeColor = System.Drawing.SystemColors.WindowText;
            this.remesasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance77;
            this.remesasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.remesasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.remesasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.remesasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance78.BackColor = System.Drawing.Color.Transparent;
            this.remesasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance78;
            appearance79.BackColor = System.Drawing.SystemColors.Control;
            appearance79.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.remesasUltraGrid.DisplayLayout.Override.CellAppearance = appearance79;
            this.remesasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance80.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance80.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance80.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance80.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.remesasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance80;
            this.remesasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance81.ForeColor = System.Drawing.Color.Red;
            this.remesasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance81;
            this.remesasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.remesasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance83.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.remesasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance83;
            appearance94.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.remesasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance94;
            this.remesasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remesasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.remesasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.remesasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.remesasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remesasUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.remesasUltraGrid.Name = "remesasUltraGrid";
            this.remesasUltraGrid.Size = new System.Drawing.Size(746, 450);
            this.remesasUltraGrid.TabIndex = 2;
            this.remesasUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.RemesasUltraGridAfterCellUpdate);
            this.remesasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.RemesasUltraGridInitializeRow);
            this.remesasUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.RemesasUltraGridInitializeTemplateAddRow);
            this.remesasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.RemesasUltraGridAfterEnterEditMode);
            this.remesasUltraGrid.AfterRowActivate += new System.EventHandler(this.RemesasUltraGridAfterRowActivate);
            this.remesasUltraGrid.AfterRowExpanded += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.RemesasUltraGridAfterRowExpanded);
            this.remesasUltraGrid.BeforeRowExpanded += new Infragistics.Win.UltraWinGrid.CancelableRowEventHandler(this.RemesasUltraGridBeforeRowExpanded);
            this.remesasUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.RemesasUltraGridCellListSelect);
            this.remesasUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.RemesasUltraGridBeforeCellDeactivate);
            this.remesasUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.RemesasUltraGridBeforeRowDeactivate);
            this.remesasUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.RemesasUltraGridSummaryValueChanged);
            this.remesasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remesasUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // remesasBindingSource
            // 
            this.remesasBindingSource.DataMember = "Remesas";
            this.remesasBindingSource.DataSource = this.dsRemesas;
            // 
            // dsRemesas
            // 
            this.dsRemesas.DataSetName = "DsRemesas";
            this.dsRemesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraCurrencyEditorSumComprobantes
            // 
            this.ultraCurrencyEditorSumComprobantes.Location = new System.Drawing.Point(132, 223);
            this.ultraCurrencyEditorSumComprobantes.Name = "ultraCurrencyEditorSumComprobantes";
            this.ultraCurrencyEditorSumComprobantes.Size = new System.Drawing.Size(100, 21);
            this.ultraCurrencyEditorSumComprobantes.TabIndex = 3;
            this.ultraCurrencyEditorSumComprobantes.Visible = false;
            // 
            // ultraCurrencyEditorSumValores
            // 
            this.ultraCurrencyEditorSumValores.Location = new System.Drawing.Point(132, 250);
            this.ultraCurrencyEditorSumValores.Name = "ultraCurrencyEditorSumValores";
            this.ultraCurrencyEditorSumValores.Size = new System.Drawing.Size(100, 21);
            this.ultraCurrencyEditorSumValores.TabIndex = 4;
            this.ultraCurrencyEditorSumValores.Visible = false;
            // 
            // ultraLabelMensaje
            // 
            this.ultraLabelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ultraLabelMensaje.Location = new System.Drawing.Point(184, 18);
            this.ultraLabelMensaje.Name = "ultraLabelMensaje";
            this.ultraLabelMensaje.Size = new System.Drawing.Size(51, 14);
            this.ultraLabelMensaje.TabIndex = 4;
            this.ultraLabelMensaje.Text = "Espere...";
            this.ultraLabelMensaje.Visible = false;
            // 
            // ultraDropDownCobradores
            // 
            this.ultraDropDownCobradores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCobradores.DataSource = this.cobradoresBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCobradores.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownCobradores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn107.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn107.Header.VisiblePosition = 0;
            ultraGridColumn107.Hidden = true;
            ultraGridColumn108.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn108.Header.VisiblePosition = 1;
            ultraGridColumn108.Hidden = true;
            ultraGridColumn109.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn109.Header.VisiblePosition = 2;
            ultraGridColumn109.Hidden = true;
            ultraGridColumn110.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn110.Header.VisiblePosition = 3;
            ultraGridColumn110.Hidden = true;
            ultraGridColumn111.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn111.Header.VisiblePosition = 4;
            ultraGridColumn112.Header.VisiblePosition = 5;
            ultraGridColumn112.Hidden = true;
            ultraGridColumn113.Header.VisiblePosition = 6;
            ultraGridColumn113.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111,
            ultraGridColumn112,
            ultraGridColumn113});
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCobradores.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownCobradores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCobradores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCobradores.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCobradores.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCobradores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.CardAreaAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.Control;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.CellAppearance = appearance25;
            this.ultraDropDownCobradores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderAppearance = appearance26;
            this.ultraDropDownCobradores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance27.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraDropDownCobradores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedCellAppearance = appearance28;
            appearance29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCobradores.DisplayLayout.Override.SelectedRowAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCobradores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance30;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCobradores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCobradores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCobradores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCobradores.DisplayMember = "ApelNomb";
            this.ultraDropDownCobradores.Location = new System.Drawing.Point(12, 77);
            this.ultraDropDownCobradores.Name = "ultraDropDownCobradores";
            this.ultraDropDownCobradores.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownCobradores.TabIndex = 20;
            this.ultraDropDownCobradores.ValueMember = "idEmpleado";
            this.ultraDropDownCobradores.Visible = false;
            this.ultraDropDownCobradores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCobradoresBeforeDropDown);
            this.ultraDropDownCobradores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCobradoresFilterRow);
            // 
            // cobradoresBindingSource
            // 
            this.cobradoresBindingSource.DataMember = "EmpleadosLista";
            this.cobradoresBindingSource.DataSource = this.dsCobradores;
            // 
            // dsCobradores
            // 
            this.dsCobradores.DataSetName = "DsEmpleadosLista";
            this.dsCobradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ultraDropDownBancos
            // 
            this.ultraDropDownBancos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBancos.DataSource = this.bancosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBancos.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn105.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn105.Header.VisiblePosition = 0;
            ultraGridColumn105.Hidden = true;
            ultraGridColumn106.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn106.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn106.Header.VisiblePosition = 1;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn105,
            ultraGridColumn106});
            ultraGridBand5.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBancos.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownBancos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBancos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBancos.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBancos.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBancos.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBancos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBancos.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBancos.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownBancos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBancos.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownBancos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBancos.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownBancos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBancos.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBancos.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBancos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownBancos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBancos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBancos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBancos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBancos.DisplayMember = "Nombre";
            this.ultraDropDownBancos.Location = new System.Drawing.Point(253, 279);
            this.ultraDropDownBancos.Name = "ultraDropDownBancos";
            this.ultraDropDownBancos.Size = new System.Drawing.Size(241, 34);
            this.ultraDropDownBancos.TabIndex = 22;
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
            // ultraDropDownReceptor
            // 
            this.ultraDropDownReceptor.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownReceptor.DataSource = this.empleadosListaBindingSource;
            appearance84.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownReceptor.DisplayLayout.Appearance = appearance84;
            this.ultraDropDownReceptor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn98.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn98.Header.VisiblePosition = 0;
            ultraGridColumn98.Hidden = true;
            ultraGridColumn98.Width = 30;
            ultraGridColumn99.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn99.Header.VisiblePosition = 1;
            ultraGridColumn99.Hidden = true;
            ultraGridColumn99.Width = 21;
            ultraGridColumn100.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn100.Header.VisiblePosition = 2;
            ultraGridColumn100.Hidden = true;
            ultraGridColumn100.Width = 45;
            ultraGridColumn101.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn101.Header.VisiblePosition = 3;
            ultraGridColumn101.Width = 219;
            ultraGridColumn102.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn102.Header.VisiblePosition = 4;
            ultraGridColumn102.Hidden = true;
            ultraGridColumn102.Width = 194;
            ultraGridColumn103.Header.VisiblePosition = 5;
            ultraGridColumn103.Hidden = true;
            ultraGridColumn103.Width = 47;
            ultraGridColumn104.Header.VisiblePosition = 6;
            ultraGridColumn104.Hidden = true;
            ultraGridColumn104.Width = 47;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn98,
            ultraGridColumn99,
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104});
            this.ultraDropDownReceptor.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownReceptor.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownReceptor.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownReceptor.DisplayLayout.MaxBandDepth = 5;
            appearance85.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownReceptor.DisplayLayout.Override.ActiveCellAppearance = appearance85;
            appearance86.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance86.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance86.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownReceptor.DisplayLayout.Override.ActiveRowAppearance = appearance86;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownReceptor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance87.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownReceptor.DisplayLayout.Override.CardAreaAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.Control;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownReceptor.DisplayLayout.Override.CellAppearance = appearance88;
            this.ultraDropDownReceptor.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance89.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance89.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance89.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownReceptor.DisplayLayout.Override.HeaderAppearance = appearance89;
            this.ultraDropDownReceptor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance90.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownReceptor.DisplayLayout.Override.RowSelectorAppearance = appearance90;
            this.ultraDropDownReceptor.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownReceptor.DisplayLayout.Override.SelectedCellAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance92.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownReceptor.DisplayLayout.Override.SelectedRowAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownReceptor.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance93;
            this.ultraDropDownReceptor.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownReceptor.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownReceptor.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownReceptor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownReceptor.DisplayMember = "NombApel";
            this.ultraDropDownReceptor.Location = new System.Drawing.Point(256, 77);
            this.ultraDropDownReceptor.Name = "ultraDropDownReceptor";
            this.ultraDropDownReceptor.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownReceptor.TabIndex = 23;
            this.ultraDropDownReceptor.ValueMember = "idEmpleado";
            this.ultraDropDownReceptor.Visible = false;
            this.ultraDropDownReceptor.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownReceptorBeforeDropDown);
            this.ultraDropDownReceptor.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownReceptorFilterRow);
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
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance245;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn92.Header.VisiblePosition = 0;
            ultraGridColumn92.Hidden = true;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn93.Header.VisiblePosition = 1;
            ultraGridColumn93.Hidden = true;
            ultraGridColumn94.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn94.Header.VisiblePosition = 2;
            ultraGridColumn94.Hidden = true;
            ultraGridColumn95.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn95.Header.VisiblePosition = 3;
            ultraGridColumn96.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn96.Header.VisiblePosition = 4;
            ultraGridColumn96.Hidden = true;
            ultraGridColumn97.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn97.Header.VisiblePosition = 5;
            ultraGridColumn97.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownGrabador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownGrabador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownGrabador.DisplayLayout.MaxBandDepth = 5;
            appearance246.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveCellAppearance = appearance246;
            appearance247.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance247.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveRowAppearance = appearance247;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance248.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.CardAreaAppearance = appearance248;
            appearance249.BackColor = System.Drawing.SystemColors.Control;
            appearance249.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.CellAppearance = appearance249;
            this.ultraDropDownGrabador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance250.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance250.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance250.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderAppearance = appearance250;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance251.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSelectorAppearance = appearance251;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedCellAppearance = appearance252;
            appearance253.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance253.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance253.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedRowAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance254.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownGrabador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance254;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownGrabador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownGrabador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownGrabador.DisplayMember = "NombApel";
            this.ultraDropDownGrabador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(256, 118);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownGrabador.TabIndex = 50;
            this.ultraDropDownGrabador.ValueMember = "idUsuario";
            this.ultraDropDownGrabador.Visible = false;
            // 
            // dsEntidadesDeCobranza
            // 
            this.dsEntidadesDeCobranza.DataSetName = "DsEntidadesDeCobranza";
            this.dsEntidadesDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entidadesDeCobranzaBindingSource
            // 
            this.entidadesDeCobranzaBindingSource.DataMember = "EntidadesDeCobranza";
            this.entidadesDeCobranzaBindingSource.DataSource = this.dsEntidadesDeCobranza;
            // 
            // ultraDropDownEntidadesDeCobranza
            // 
            this.ultraDropDownEntidadesDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEntidadesDeCobranza.DataSource = this.entidadesDeCobranzaBindingSource;
            appearance99.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Appearance = appearance99;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn77.Header.VisiblePosition = 0;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn78.Header.VisiblePosition = 1;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn79.Header.VisiblePosition = 3;
            ultraGridColumn79.Hidden = true;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 2;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn81.Header.VisiblePosition = 4;
            ultraGridColumn81.Hidden = true;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.VisiblePosition = 5;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.Header.VisiblePosition = 6;
            ultraGridColumn83.Hidden = true;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn84.Header.VisiblePosition = 7;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn85.Header.VisiblePosition = 8;
            ultraGridColumn85.Hidden = true;
            ultraGridColumn86.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn86.Header.VisiblePosition = 9;
            ultraGridColumn86.Hidden = true;
            ultraGridColumn87.Header.VisiblePosition = 10;
            ultraGridColumn87.Hidden = true;
            ultraGridColumn88.Header.VisiblePosition = 11;
            ultraGridColumn88.Hidden = true;
            ultraGridColumn89.Header.VisiblePosition = 12;
            ultraGridColumn89.Hidden = true;
            ultraGridColumn90.Header.VisiblePosition = 13;
            ultraGridColumn90.Hidden = true;
            ultraGridColumn91.Header.VisiblePosition = 14;
            ultraGridColumn91.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn77,
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
            ultraGridColumn89,
            ultraGridColumn90,
            ultraGridColumn91});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
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
            this.ultraDropDownEntidadesDeCobranza.Location = new System.Drawing.Point(256, 156);
            this.ultraDropDownEntidadesDeCobranza.Name = "ultraDropDownEntidadesDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownEntidadesDeCobranza.TabIndex = 51;
            this.ultraDropDownEntidadesDeCobranza.ValueMember = "idEntidadDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Visible = false;
            this.ultraDropDownEntidadesDeCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownEntidadesDeCobranza_BeforeDropDown);
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
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn72.Header.VisiblePosition = 0;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn73.Header.VisiblePosition = 1;
            ultraGridColumn74.Header.VisiblePosition = 2;
            ultraGridColumn74.Hidden = true;
            ultraGridColumn75.Header.VisiblePosition = 3;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn76.Header.VisiblePosition = 4;
            ultraGridColumn76.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75,
            ultraGridColumn76});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeValores.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
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
            this.ultraDropDownTiposDeValores.Location = new System.Drawing.Point(253, 227);
            this.ultraDropDownTiposDeValores.Name = "ultraDropDownTiposDeValores";
            this.ultraDropDownTiposDeValores.Size = new System.Drawing.Size(241, 34);
            this.ultraDropDownTiposDeValores.TabIndex = 52;
            this.ultraDropDownTiposDeValores.ValueMember = "idTipoDeValor";
            this.ultraDropDownTiposDeValores.Visible = false;
            this.ultraDropDownTiposDeValores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownTiposDeValores_BeforeDropDown);
            this.ultraDropDownTiposDeValores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.ultraDropDownTiposDeValores_FilterRow);
            // 
            // FormRemesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(745, 488);
            this.Controls.Add(this.remesasUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeValores);
            this.Controls.Add(this.ultraDropDownEntidadesDeCobranza);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownReceptor);
            this.Controls.Add(this.ultraDropDownBancos);
            this.Controls.Add(this.ultraDropDownCobradores);
            this.Controls.Add(this.ultraCurrencyEditorSumValores);
            this.Controls.Add(this.ultraCurrencyEditorSumComprobantes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(752, 521);
            this.Name = "FormRemesa";
            this.Text = "Rendición";
            this.Activated += new System.EventHandler(this.FormRemesaActivated);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorSumComprobantes, 0);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorSumValores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCobradores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBancos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownReceptor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEntidadesDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeValores, 0);
            this.Controls.SetChildIndex(this.remesasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remesasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid remesasUltraGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor ultraCurrencyEditorSumComprobantes;
        private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor ultraCurrencyEditorSumValores;
        private Infragistics.Win.Misc.UltraLabel ultraLabelMensaje;
        private System.Windows.Forms.BindingSource remesasBindingSource;
        private WS.DsRemesas dsRemesas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCobradores;
        private System.Windows.Forms.BindingSource tiposDeValoresBindingSource;
        private WS.DsTiposDeValores dsTiposDeValores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBancos;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private WS.DsBancos dsBancos;
        private System.Windows.Forms.BindingSource cobradoresBindingSource;
        private WS.DsEmpleadosLista dsCobradores;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private WS.DsEmpleadosLista dsEmpleadosLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownReceptor;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private WS.DsUsuariosLista dsUsuariosLista1;
        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza;
        private System.Windows.Forms.BindingSource entidadesDeCobranzaBindingSource;
        private UltraDropDown ultraDropDownEntidadesDeCobranza;
        private UltraDropDown ultraDropDownTiposDeValores;
    }
}
