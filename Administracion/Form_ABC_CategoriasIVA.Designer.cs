using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    partial class FormABCCategoriasIVA
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturaE", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeCE", -1, "ultraDropDownTiposDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeDE", -1, "ultraDropDownTiposDeComprobante");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeComprobante", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNegativo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DiscriminaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsFactura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TablaAFIP");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            this.categoriasIVAUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CategoriasIVA = new Administracion.WS.DsCategoriasIVA();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ultraDropDownTiposDeComprobante = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_TiposDeComprobante = new Administracion.WS.DsTiposDeComprobante();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVAUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(563, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(482, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Size = new System.Drawing.Size(653, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(401, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // categoriasIVAUltraGrid
            // 
            this.categoriasIVAUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriasIVAUltraGrid.DataSource = this.categoriasIVABindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.categoriasIVAUltraGrid.DisplayLayout.Appearance = appearance1;
            this.categoriasIVAUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 93;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Width = 89;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(29, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(29, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Width = 74;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.Caption = "Exige CUIT";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(41, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(41, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Width = 65;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn5.Width = 96;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn6.Width = 98;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn7.Width = 98;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn8.Width = 49;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn9.Width = 47;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn10.Width = 47;
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
            ultraGridColumn10});
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.categoriasIVAUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.categoriasIVAUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.categoriasIVAUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.categoriasIVAUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.CellAppearance = appearance5;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.categoriasIVAUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.categoriasIVAUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoriasIVAUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.categoriasIVAUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.categoriasIVAUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.categoriasIVAUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.categoriasIVAUltraGrid.Name = "categoriasIVAUltraGrid";
            this.categoriasIVAUltraGrid.Size = new System.Drawing.Size(653, 396);
            this.categoriasIVAUltraGrid.TabIndex = 2;
            this.categoriasIVAUltraGrid.AfterEnterEditMode += new System.EventHandler(this.CategoriasIVAUltraGridAfterEnterEditMode);
            this.categoriasIVAUltraGrid.AfterRowsDeleted += new System.EventHandler(this.CategoriasIVAUltraGridAfterRowsDeleted);
            this.categoriasIVAUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoriasIVAUltraGrid_KeyDown);
            // 
            // categoriasIVABindingSource
            // 
            this.categoriasIVABindingSource.DataSource = this.ds_CategoriasIVA;
            this.categoriasIVABindingSource.Position = 0;
            // 
            // ds_CategoriasIVA
            // 
            this.ds_CategoriasIVA.DataSetName = "DsCategoriasIVA";
            this.ds_CategoriasIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeComprobante
            // 
            this.ultraDropDownTiposDeComprobante.DataSource = this.tiposDeComprobanteBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Appearance = appearance11;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn11.Header.VisiblePosition = 0;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn12.Header.VisiblePosition = 1;
            ultraGridColumn12.Width = 150;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 2;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 3;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 4;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.VisiblePosition = 5;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.Header.VisiblePosition = 6;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.Header.VisiblePosition = 7;
            ultraGridColumn18.Hidden = true;
            ultraGridColumn19.Header.VisiblePosition = 8;
            ultraGridColumn19.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownTiposDeComprobante.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeComprobante.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeComprobante.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeComprobante.Location = new System.Drawing.Point(202, 207);
            this.ultraDropDownTiposDeComprobante.Name = "ultraDropDownTiposDeComprobante";
            this.ultraDropDownTiposDeComprobante.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeComprobante.TabIndex = 10;
            this.ultraDropDownTiposDeComprobante.ValueMember = "idTipoDeComprobante";
            this.ultraDropDownTiposDeComprobante.Visible = false;
            this.ultraDropDownTiposDeComprobante.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownTiposDeComprobante_BeforeDropDown);
            // 
            // tiposDeComprobanteBindingSource
            // 
            this.tiposDeComprobanteBindingSource.DataMember = "TiposDeComprobante";
            this.tiposDeComprobanteBindingSource.DataSource = this.ds_TiposDeComprobante;
            // 
            // ds_TiposDeComprobante
            // 
            this.ds_TiposDeComprobante.DataSetName = "DsTiposDeComprobante";
            this.ds_TiposDeComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormABCCategoriasIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(652, 434);
            this.Controls.Add(this.categoriasIVAUltraGrid);
            this.Controls.Add(this.ultraDropDownTiposDeComprobante);
            this.Name = "FormABCCategoriasIVA";
            this.Text = "Categorías de IVA";
            this.Activated += new System.EventHandler(this.FormABCCategoriasIVAActivated);
            this.Load += new System.EventHandler(this.FormABCCategoriasIVALoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeComprobante, 0);
            this.Controls.SetChildIndex(this.categoriasIVAUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVAUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_TiposDeComprobante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid categoriasIVAUltraGrid;
        private Administracion.WS.DsCategoriasIVA ds_CategoriasIVA;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeComprobante;
        private System.Windows.Forms.BindingSource tiposDeComprobanteBindingSource;
        private Administracion.WS.DsTiposDeComprobante ds_TiposDeComprobante;
    }
}
