using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    partial class FormRemesaAfiliadoMostrador
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
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Remesas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Caja");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReceptor", -1, "ultraDropDownReceptor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_ComprobantesRemesas_Remesas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Remesas_ValoresRemesas");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_ComprobantesRemesas_Remesas", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobanteRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idReferencia", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteReferencia");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteCobrado");
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HacerNdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo", 0);
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumComprobantes", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteCobrado", 4, true, "FK_ComprobantesRemesas_Remesas", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, "ImporteCobrado", 4, true);
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Remesas_ValoresRemesas", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idValorRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRemesa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor", -1, "ultraDropDownTiposDeValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco", -1, "ultraDropDownBancos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCheque");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumValores", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Importe", 3, true, "FK_Remesas_ValoresRemesas", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.Right, "Importe", 3, true);
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeValores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeValor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsEfectivo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SePagaCon");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Bancos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            this.remesasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.remesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemesas = new Administracion.WS.DsRemesas();
            this.ultraCurrencyEditorSumComprobantes = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraCurrencyEditorSumValores = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
            this.ultraLabelMensaje = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDropDownTiposDeValores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeValoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeValores = new Administracion.WS.DsTiposDeValores();
            this.ultraDropDownBancos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBancos = new Administracion.WS.DsBancos();
            this.ultraDropDownReceptor = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.empleadosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpleadosLista = new Administracion.WS.DsEmpleadosLista();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Administracion.WS.DsUsuariosLista();
            this.buttonCancelar1 = new System.Windows.Forms.Button();
            this.dsIds1 = new Administracion.WS.DsIds();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remesasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumComprobantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIds1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(726, 16);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(91, 16);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelar1);
            this.panel1.Controls.Add(this.ultraLabelMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(816, 50);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraLabelMensaje, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar1, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(172, 16);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
            // 
            // remesasUltraGrid
            // 
            this.remesasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remesasUltraGrid.CalcManager = this.ultraCalcManager1;
            this.remesasUltraGrid.DataSource = this.remesasBindingSource;
            appearance71.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance71.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.remesasUltraGrid.DisplayLayout.Appearance = appearance71;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.Caption = "Cobrador";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.Width = 208;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance21.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance21;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn3.MaskInput = "dd/mm/yyyy";
            ultraGridColumn3.Width = 75;
            appearance22.TextHAlignAsString = "Right";
            ultraGridColumn4.CellAppearance = appearance22;
            ultraGridColumn4.Header.Caption = "Recibo N°";
            ultraGridColumn4.Header.ToolTipText = "Opcional. Si no se ingresa, se autogenerará.";
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.MaskInput = "nnnnnnnn";
            ultraGridColumn4.MaxLength = 8;
            ultraGridColumn4.NullText = "";
            ultraGridColumn4.Width = 112;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn5.Header.Caption = "Recibe los Valores";
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn5.Width = 211;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.Caption = "Grabador";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn6.Width = 347;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance23.TextHAlignAsString = "Right";
            ultraGridColumn7.CellAppearance = appearance23;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn7.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn7.Width = 71;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.DefaultCellValue = "Mostrador";
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn8.Width = 97;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridBand5.Columns.AddRange(new object[] {
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
            ultraGridColumn12});
            ultraGridBand5.MaxRows = 1;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 0;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 1;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance24.TextHAlignAsString = "Right";
            ultraGridColumn15.CellAppearance = appearance24;
            ultraGridColumn15.Header.Caption = "Referencia";
            ultraGridColumn15.Header.VisiblePosition = 2;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn15.MaskInput = "nnnnnnnnn";
            ultraGridColumn15.Width = 83;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance25.TextHAlignAsString = "Right";
            ultraGridColumn16.CellAppearance = appearance25;
            ultraGridColumn16.Header.Caption = "Importe";
            ultraGridColumn16.Header.VisiblePosition = 4;
            ultraGridColumn16.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn16.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn16.Width = 104;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance26.TextHAlignAsString = "Right";
            ultraGridColumn17.CellAppearance = appearance26;
            ultraGridColumn17.Header.Caption = "Cobrado";
            ultraGridColumn17.Header.VisiblePosition = 5;
            ultraGridColumn17.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn17.MaskInput = "{LOC}$ nnn,nnn,nnn.nn";
            ultraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn17.Width = 89;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn18.Header.VisiblePosition = 7;
            ultraGridColumn18.Width = 339;
            ultraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn19.DefaultCellValue = "False";
            ultraGridColumn19.Header.Caption = "Hacer NdeC/D";
            ultraGridColumn19.Header.VisiblePosition = 6;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn19.Width = 72;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn20.Header.VisiblePosition = 8;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn20.Width = 71;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance27.TextHAlignAsString = "Center";
            ultraGridColumn21.CellAppearance = appearance27;
            ultraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn21.Header.VisiblePosition = 3;
            ultraGridColumn21.Width = 83;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21});
            appearance28.FontData.BoldAsString = "True";
            appearance28.FontData.SizeInPoints = 11F;
            appearance28.TextHAlignAsString = "Left";
            ultraGridBand6.Header.Appearance = appearance28;
            ultraGridBand6.Header.Caption = "Comprobantes";
            ultraGridBand6.HeaderVisible = true;
            ultraGridBand6.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand6.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance29.FontData.BoldAsString = "True";
            appearance29.TextHAlignAsString = "Right";
            ultraGridBand6.Override.SummaryValueAppearance = appearance29;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            summarySettings1.DisplayFormat = "Total: {0:c}";
            summarySettings1.GroupBySummaryValueAppearance = appearance30;
            ultraGridBand6.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridBand6.SummaryFooterCaption = "";
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn22.Header.VisiblePosition = 0;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn22.Width = 70;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 1;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn23.Width = 63;
            ultraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn24.Header.Caption = "Tipo de Valor";
            ultraGridColumn24.Header.VisiblePosition = 2;
            ultraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn24.Width = 113;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance31.TextHAlignAsString = "Right";
            ultraGridColumn25.CellAppearance = appearance31;
            ultraGridColumn25.Header.VisiblePosition = 3;
            ultraGridColumn25.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn25.MaskInput = "{LOC}$ nnn,nnn,nnn.nn";
            ultraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(92, 0);
            ultraGridColumn25.Width = 72;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn26.Header.VisiblePosition = 7;
            ultraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(223, 0);
            ultraGridColumn26.Width = 172;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn27.Header.Caption = "Banco";
            ultraGridColumn27.Header.VisiblePosition = 4;
            ultraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn27.Width = 85;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance32.TextHAlignAsString = "Right";
            ultraGridColumn28.CellAppearance = appearance32;
            ultraGridColumn28.Header.Caption = "Cheque Nº";
            ultraGridColumn28.Header.VisiblePosition = 5;
            ultraGridColumn28.Width = 77;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance33.TextHAlignAsString = "Center";
            ultraGridColumn29.CellAppearance = appearance33;
            ultraGridColumn29.Header.Caption = "Fecha del Cheque";
            ultraGridColumn29.Header.VisiblePosition = 6;
            ultraGridColumn29.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn29.MaskInput = "dd/mm/yyyy";
            ultraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(100, 0);
            ultraGridColumn29.Width = 85;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.Header.VisiblePosition = 8;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn30.Width = 73;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30});
            appearance34.FontData.BoldAsString = "True";
            appearance34.FontData.SizeInPoints = 11F;
            appearance34.TextHAlignAsString = "Left";
            ultraGridBand7.Header.Appearance = appearance34;
            ultraGridBand7.Header.Caption = "Valores";
            ultraGridBand7.HeaderVisible = true;
            ultraGridBand7.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            appearance35.FontData.BoldAsString = "True";
            appearance35.TextHAlignAsString = "Right";
            summarySettings2.Appearance = appearance35;
            summarySettings2.DisplayFormat = "Total: {0:c}";
            summarySettings2.GroupBySummaryValueAppearance = appearance36;
            ultraGridBand7.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings2});
            ultraGridBand7.SummaryFooterCaption = "";
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.remesasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.remesasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.remesasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.remesasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance97.BackColor = System.Drawing.SystemColors.Window;
            this.remesasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance97;
            appearance98.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance98.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance98.ForeColor = System.Drawing.SystemColors.WindowText;
            this.remesasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance98;
            this.remesasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.remesasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.remesasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.remesasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.remesasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance99.BackColor = System.Drawing.Color.Transparent;
            this.remesasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance99;
            appearance100.BackColor = System.Drawing.SystemColors.Control;
            appearance100.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.remesasUltraGrid.DisplayLayout.Override.CellAppearance = appearance100;
            this.remesasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance101.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance101.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance101.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance101.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.remesasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance101;
            this.remesasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance102.ForeColor = System.Drawing.Color.Red;
            this.remesasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance102;
            this.remesasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.remesasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance103;
            appearance104.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance104.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.remesasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance104;
            appearance105.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance105.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.remesasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance105;
            this.remesasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remesasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.remesasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.remesasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.remesasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remesasUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.remesasUltraGrid.Name = "remesasUltraGrid";
            this.remesasUltraGrid.Size = new System.Drawing.Size(816, 450);
            this.remesasUltraGrid.TabIndex = 2;
            this.remesasUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.RemesasUltraGridAfterCellUpdate);
            this.remesasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.remesasUltraGrid_InitializeRow);
            this.remesasUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.RemesasUltraGridInitializeTemplateAddRow);
            this.remesasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.RemesasUltraGridAfterEnterEditMode);
            this.remesasUltraGrid.BeforeRowExpanded += new Infragistics.Win.UltraWinGrid.CancelableRowEventHandler(this.RemesasUltraGridBeforeRowExpanded);
            this.remesasUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.remesasUltraGrid_CellListSelect);
            this.remesasUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.RemesasUltraGridBeforeRowDeactivate);
            this.remesasUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.RemesasUltraGridBeforeRowsDeleted);
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
            // ultraDropDownTiposDeValores
            // 
            this.ultraDropDownTiposDeValores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeValores.DataSource = this.tiposDeValoresBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeValores.DisplayLayout.Appearance = appearance11;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.Header.VisiblePosition = 0;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn47.Header.VisiblePosition = 1;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.Header.VisiblePosition = 2;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn49.Header.VisiblePosition = 3;
            ultraGridColumn49.Hidden = true;
            ultraGridColumn50.Header.VisiblePosition = 4;
            ultraGridColumn50.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeValores.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownTiposDeValores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeValores.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeValores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeValores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeValores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeValores.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeValores.Location = new System.Drawing.Point(12, 116);
            this.ultraDropDownTiposDeValores.Name = "ultraDropDownTiposDeValores";
            this.ultraDropDownTiposDeValores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeValores.TabIndex = 21;
            this.ultraDropDownTiposDeValores.ValueMember = "idTipoDeValor";
            this.ultraDropDownTiposDeValores.Visible = false;
            this.ultraDropDownTiposDeValores.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.ultraDropDownTiposDeValores_InitializeLayout);
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
            // ultraDropDownBancos
            // 
            this.ultraDropDownBancos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBancos.DataSource = this.bancosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBancos.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn44.Header.VisiblePosition = 0;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn45.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn44,
            ultraGridColumn45});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBancos.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
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
            this.ultraDropDownBancos.Location = new System.Drawing.Point(12, 156);
            this.ultraDropDownBancos.Name = "ultraDropDownBancos";
            this.ultraDropDownBancos.Size = new System.Drawing.Size(238, 34);
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
            // ultraDropDownReceptor
            // 
            this.ultraDropDownReceptor.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownReceptor.DataSource = this.empleadosListaBindingSource;
            appearance84.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownReceptor.DisplayLayout.Appearance = appearance84;
            this.ultraDropDownReceptor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn37.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn37.Header.VisiblePosition = 0;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn37.Width = 30;
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn38.Header.VisiblePosition = 1;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn38.Width = 21;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn39.Header.VisiblePosition = 2;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn39.Width = 45;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn40.Header.VisiblePosition = 3;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn40.Width = 45;
            ultraGridColumn41.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn41.Header.VisiblePosition = 4;
            ultraGridColumn41.Width = 219;
            ultraGridColumn42.Header.VisiblePosition = 5;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn42.Width = 47;
            ultraGridColumn43.Header.VisiblePosition = 6;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn43.Width = 47;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43});
            this.ultraDropDownReceptor.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
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
            this.ultraDropDownReceptor.DisplayMember = "ApelNomb";
            this.ultraDropDownReceptor.Location = new System.Drawing.Point(256, 77);
            this.ultraDropDownReceptor.Name = "ultraDropDownReceptor";
            this.ultraDropDownReceptor.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownReceptor.TabIndex = 23;
            this.ultraDropDownReceptor.ValueMember = "idEmpleado";
            this.ultraDropDownReceptor.Visible = false;
            this.ultraDropDownReceptor.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownReceptorBeforeDropDown);
            this.ultraDropDownReceptor.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownReceptorFilterRow);
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
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance245;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn31.Header.VisiblePosition = 0;
            ultraGridColumn31.Hidden = true;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn32.Header.VisiblePosition = 1;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn33.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn33.Header.VisiblePosition = 2;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn34.Header.VisiblePosition = 3;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn35.Header.VisiblePosition = 4;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn36.Header.VisiblePosition = 5;
            ultraGridColumn36.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
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
            // buttonCancelar1
            // 
            this.buttonCancelar1.Location = new System.Drawing.Point(575, 16);
            this.buttonCancelar1.Name = "buttonCancelar1";
            this.buttonCancelar1.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar1.TabIndex = 5;
            this.buttonCancelar1.Text = "Cancelar";
            this.buttonCancelar1.UseVisualStyleBackColor = true;
            this.buttonCancelar1.Click += new System.EventHandler(this.ButtonCancelar1Click);
            // 
            // dsIds1
            // 
            this.dsIds1.DataSetName = "DsIds";
            this.dsIds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRemesaAfiliadoMostrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(815, 488);
            this.Controls.Add(this.remesasUltraGrid);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownReceptor);
            this.Controls.Add(this.ultraDropDownBancos);
            this.Controls.Add(this.ultraDropDownTiposDeValores);
            this.Controls.Add(this.ultraCurrencyEditorSumValores);
            this.Controls.Add(this.ultraCurrencyEditorSumComprobantes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(356, 193);
            this.Name = "FormRemesaAfiliadoMostrador";
            this.Tag = "Afiliados";
            this.Text = "Rendición";
            this.Load += new System.EventHandler(this.FormRemesaAfiliadoMostradorLoad);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorSumComprobantes, 0);
            this.Controls.SetChildIndex(this.ultraCurrencyEditorSumValores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeValores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBancos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownReceptor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.remesasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remesasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumComprobantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCurrencyEditorSumValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeValoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownReceptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIds1)).EndInit();
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
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeValores;
        private System.Windows.Forms.BindingSource tiposDeValoresBindingSource;
        private WS.DsTiposDeValores dsTiposDeValores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBancos;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private WS.DsBancos dsBancos;
        private System.Windows.Forms.BindingSource empleadosListaBindingSource;
        private WS.DsEmpleadosLista dsEmpleadosLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownReceptor;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private WS.DsUsuariosLista dsUsuariosLista1;
        private WS.DsIds dsIds1;
        private System.Windows.Forms.Button buttonCancelar1;
    }
}
