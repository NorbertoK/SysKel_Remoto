namespace Administracion
{
    public partial class FormFacturaElectronica : Form1
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
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("SolicitudesCAE", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idSolictudCAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Error");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Resultado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CAE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Reproceso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Prefijo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("XmlRequest");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("XmlResponse");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Enviada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCliente", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FacturasSinCAE", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Token");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sign");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("tipoDoc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LocalidadCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProvinciaCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("tipoCbte");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("puntoVta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nroDoc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cbtDesde");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cbtHasta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("impTotal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("impTotConc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("impNeto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("impIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("impTrib");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("impOpEx");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fechaCbte");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fechaVencPago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fechaServDesde");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fechaServHasta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("baseImp4");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("importeIVA4");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("baseImp5");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("importeIVA5");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrefijoReferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroReferencia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("baseImp3");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("importeIVA3");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("baseImp6");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("importeIVA6");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("baseImp8");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("importeIVA8");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("baseImp9");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("importeIVA9");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("_Sign");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCbteAsoc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PuntoVtaAsoc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CbteNroAsoc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCbteAsoc");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeCEsAnulacion");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            this.dsSolicitudesCAE = new Administracion.WS.DsSolicitudesCAE();
            this.solicitudesCAEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudesCAEUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.dsFacturasSinCAE = new Administracion.WS.DsFacturasSinCAE();
            this.facturasSinCAEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasSinCAEUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCheckEditorEnviar = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudesCAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCAEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCAEUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasSinCAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasSinCAEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasSinCAEUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditorEnviar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(812, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(731, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraCheckEditorEnviar);
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Size = new System.Drawing.Size(902, 50);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraCheckEditorEnviar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(731, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsSolicitudesCAE
            // 
            this.dsSolicitudesCAE.DataSetName = "DsSolicitudesCAE";
            this.dsSolicitudesCAE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesCAEBindingSource
            // 
            this.solicitudesCAEBindingSource.DataMember = "SolicitudesCAE";
            this.solicitudesCAEBindingSource.DataSource = this.dsSolicitudesCAE;
            // 
            // solicitudesCAEUltraGrid
            // 
            this.solicitudesCAEUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solicitudesCAEUltraGrid.DataSource = this.solicitudesCAEBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.solicitudesCAEUltraGrid.DisplayLayout.Appearance = appearance11;
            this.solicitudesCAEUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn110.Header.VisiblePosition = 0;
            ultraGridColumn110.Hidden = true;
            ultraGridColumn110.Width = 78;
            ultraGridColumn111.Header.VisiblePosition = 1;
            ultraGridColumn111.MaskInput = "{date} {longtime}";
            ultraGridColumn111.Width = 62;
            ultraGridColumn112.Header.VisiblePosition = 2;
            ultraGridColumn112.Hidden = true;
            ultraGridColumn112.Width = 74;
            ultraGridColumn113.Header.VisiblePosition = 11;
            ultraGridColumn113.Width = 89;
            ultraGridColumn114.Header.VisiblePosition = 7;
            ultraGridColumn114.Width = 64;
            ultraGridColumn115.Header.VisiblePosition = 9;
            ultraGridColumn115.Width = 83;
            ultraGridColumn116.Header.VisiblePosition = 6;
            ultraGridColumn116.Width = 84;
            ultraGridColumn117.Header.VisiblePosition = 8;
            ultraGridColumn117.Hidden = true;
            ultraGridColumn117.Width = 82;
            ultraGridColumn118.Header.VisiblePosition = 12;
            ultraGridColumn118.Width = 84;
            ultraGridColumn119.Header.VisiblePosition = 5;
            ultraGridColumn119.Hidden = true;
            ultraGridColumn119.Width = 58;
            ultraGridColumn120.Header.VisiblePosition = 10;
            ultraGridColumn120.Width = 84;
            ultraGridColumn121.Header.VisiblePosition = 4;
            ultraGridColumn121.Width = 113;
            ultraGridColumn122.Header.VisiblePosition = 13;
            ultraGridColumn122.Hidden = true;
            ultraGridColumn122.Width = 78;
            ultraGridColumn123.Header.VisiblePosition = 14;
            ultraGridColumn123.Hidden = true;
            ultraGridColumn123.Width = 85;
            ultraGridColumn124.Header.VisiblePosition = 15;
            ultraGridColumn124.Width = 117;
            ultraGridColumn125.Header.VisiblePosition = 3;
            ultraGridColumn125.Width = 101;
            ultraGridBand1.Columns.AddRange(new object[] {
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
            ultraGridColumn124,
            ultraGridColumn125});
            ultraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.solicitudesCAEUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            appearance1.FontData.BoldAsString = "True";
            appearance1.FontData.SizeInPoints = 11F;
            appearance1.TextHAlignAsString = "Left";
            this.solicitudesCAEUltraGrid.DisplayLayout.CaptionAppearance = appearance1;
            this.solicitudesCAEUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.solicitudesCAEUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.solicitudesCAEUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.CellAppearance = appearance15;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.solicitudesCAEUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.solicitudesCAEUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.solicitudesCAEUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.solicitudesCAEUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.solicitudesCAEUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.solicitudesCAEUltraGrid.Location = new System.Drawing.Point(0, 262);
            this.solicitudesCAEUltraGrid.Name = "solicitudesCAEUltraGrid";
            this.solicitudesCAEUltraGrid.Size = new System.Drawing.Size(902, 311);
            this.solicitudesCAEUltraGrid.TabIndex = 2;
            this.solicitudesCAEUltraGrid.Text = "Resultados";
            // 
            // dsFacturasSinCAE
            // 
            this.dsFacturasSinCAE.DataSetName = "DsFacturasSinCAE";
            this.dsFacturasSinCAE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasSinCAEBindingSource
            // 
            this.facturasSinCAEBindingSource.DataMember = "FacturasSinCAE";
            this.facturasSinCAEBindingSource.DataSource = this.dsFacturasSinCAE;
            // 
            // facturasSinCAEUltraGrid
            // 
            this.facturasSinCAEUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facturasSinCAEUltraGrid.DataSource = this.facturasSinCAEBindingSource;
            appearance2.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.facturasSinCAEUltraGrid.DisplayLayout.Appearance = appearance2;
            this.facturasSinCAEUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn126.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn126.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn126.Header.VisiblePosition = 28;
            ultraGridColumn126.Hidden = true;
            ultraGridColumn126.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn126.Width = 74;
            ultraGridColumn127.Header.VisiblePosition = 5;
            ultraGridColumn127.Hidden = true;
            ultraGridColumn127.Width = 77;
            ultraGridColumn128.Header.VisiblePosition = 7;
            ultraGridColumn128.Hidden = true;
            ultraGridColumn128.Width = 65;
            ultraGridColumn129.Header.VisiblePosition = 4;
            ultraGridColumn129.Width = 49;
            ultraGridColumn130.Header.VisiblePosition = 10;
            ultraGridColumn130.Hidden = true;
            ultraGridColumn130.Width = 53;
            ultraGridColumn131.Header.VisiblePosition = 3;
            ultraGridColumn131.Width = 154;
            ultraGridColumn132.Header.VisiblePosition = 9;
            ultraGridColumn132.Hidden = true;
            ultraGridColumn132.Width = 24;
            ultraGridColumn133.Header.VisiblePosition = 11;
            ultraGridColumn133.Hidden = true;
            ultraGridColumn133.Width = 29;
            ultraGridColumn134.Header.VisiblePosition = 12;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn134.Width = 32;
            ultraGridColumn135.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn135.Header.VisiblePosition = 0;
            ultraGridColumn135.Hidden = true;
            ultraGridColumn135.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn135.Width = 29;
            ultraGridColumn136.Header.VisiblePosition = 6;
            ultraGridColumn136.Hidden = true;
            ultraGridColumn136.Width = 8;
            ultraGridColumn137.Header.VisiblePosition = 8;
            ultraGridColumn137.Width = 81;
            ultraGridColumn138.Header.Caption = "Número";
            ultraGridColumn138.Header.VisiblePosition = 2;
            ultraGridColumn138.Width = 73;
            ultraGridColumn139.Header.VisiblePosition = 13;
            ultraGridColumn139.Hidden = true;
            ultraGridColumn139.Width = 42;
            ultraGridColumn140.Header.VisiblePosition = 14;
            ultraGridColumn140.Width = 69;
            ultraGridColumn141.Header.VisiblePosition = 15;
            ultraGridColumn141.Hidden = true;
            ultraGridColumn141.Width = 45;
            ultraGridColumn142.Header.VisiblePosition = 16;
            ultraGridColumn142.Hidden = true;
            ultraGridColumn142.Width = 51;
            ultraGridColumn143.Header.VisiblePosition = 17;
            ultraGridColumn143.Hidden = true;
            ultraGridColumn143.Width = 45;
            ultraGridColumn144.Header.VisiblePosition = 18;
            ultraGridColumn144.Hidden = true;
            ultraGridColumn144.Width = 51;
            ultraGridColumn145.Header.VisiblePosition = 19;
            ultraGridColumn145.Hidden = true;
            ultraGridColumn145.Width = 42;
            ultraGridColumn146.Header.VisiblePosition = 20;
            ultraGridColumn146.Width = 55;
            ultraGridColumn147.Header.VisiblePosition = 21;
            ultraGridColumn147.Hidden = true;
            ultraGridColumn147.Width = 38;
            ultraGridColumn148.Header.VisiblePosition = 22;
            ultraGridColumn148.Width = 85;
            ultraGridColumn149.Header.VisiblePosition = 23;
            ultraGridColumn149.Width = 79;
            ultraGridColumn150.Header.VisiblePosition = 24;
            ultraGridColumn150.Hidden = true;
            ultraGridColumn150.Width = 69;
            ultraGridColumn151.Header.VisiblePosition = 25;
            ultraGridColumn151.Hidden = true;
            ultraGridColumn151.Width = 69;
            ultraGridColumn152.Header.VisiblePosition = 26;
            ultraGridColumn152.Hidden = true;
            ultraGridColumn152.Width = 69;
            ultraGridColumn153.Header.VisiblePosition = 27;
            ultraGridColumn153.Hidden = true;
            ultraGridColumn153.Width = 69;
            ultraGridColumn154.Header.VisiblePosition = 29;
            ultraGridColumn154.Hidden = true;
            ultraGridColumn154.Width = 71;
            ultraGridColumn155.Header.VisiblePosition = 30;
            ultraGridColumn155.Hidden = true;
            ultraGridColumn155.Width = 73;
            ultraGridColumn156.Header.VisiblePosition = 31;
            ultraGridColumn156.Hidden = true;
            ultraGridColumn156.Width = 79;
            ultraGridColumn157.Header.Caption = "Comprobante";
            ultraGridColumn157.Header.VisiblePosition = 1;
            ultraGridColumn157.Width = 41;
            ultraGridColumn158.Header.VisiblePosition = 32;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn158.Width = 52;
            ultraGridColumn159.Header.VisiblePosition = 33;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn159.Width = 55;
            ultraGridColumn160.Header.VisiblePosition = 34;
            ultraGridColumn160.Hidden = true;
            ultraGridColumn160.Width = 58;
            ultraGridColumn161.Header.VisiblePosition = 35;
            ultraGridColumn161.Hidden = true;
            ultraGridColumn161.Width = 62;
            ultraGridColumn162.Header.VisiblePosition = 36;
            ultraGridColumn162.Hidden = true;
            ultraGridColumn162.Width = 74;
            ultraGridColumn163.Header.VisiblePosition = 37;
            ultraGridColumn163.Hidden = true;
            ultraGridColumn163.Width = 79;
            ultraGridColumn164.Header.VisiblePosition = 38;
            ultraGridColumn164.Hidden = true;
            ultraGridColumn164.Width = 84;
            ultraGridColumn165.Header.VisiblePosition = 39;
            ultraGridColumn165.Hidden = true;
            ultraGridColumn165.Width = 92;
            ultraGridColumn166.Header.VisiblePosition = 40;
            ultraGridColumn166.Width = 97;
            ultraGridColumn167.Header.VisiblePosition = 41;
            ultraGridColumn167.Width = 89;
            ultraGridColumn168.Header.VisiblePosition = 42;
            ultraGridColumn168.Hidden = true;
            ultraGridColumn168.Width = 50;
            ultraGridColumn169.Header.VisiblePosition = 43;
            ultraGridColumn169.Hidden = true;
            ultraGridColumn169.Width = 65;
            ultraGridColumn170.Header.VisiblePosition = 44;
            ultraGridColumn170.Hidden = true;
            ultraGridColumn170.Width = 63;
            ultraGridColumn171.Header.VisiblePosition = 45;
            ultraGridColumn171.Hidden = true;
            ultraGridColumn171.Width = 63;
            ultraGridColumn172.Header.VisiblePosition = 46;
            ultraGridColumn172.Hidden = true;
            ultraGridColumn172.Width = 63;
            ultraGridColumn173.Header.VisiblePosition = 47;
            ultraGridColumn173.Hidden = true;
            ultraGridColumn173.Width = 63;
            ultraGridColumn174.Header.VisiblePosition = 48;
            ultraGridColumn174.Hidden = true;
            ultraGridColumn174.Width = 68;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130,
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133,
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142,
            ultraGridColumn143,
            ultraGridColumn144,
            ultraGridColumn145,
            ultraGridColumn146,
            ultraGridColumn147,
            ultraGridColumn148,
            ultraGridColumn149,
            ultraGridColumn150,
            ultraGridColumn151,
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
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169,
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172,
            ultraGridColumn173,
            ultraGridColumn174});
            ultraGridBand2.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.facturasSinCAEUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.SizeInPoints = 11F;
            appearance3.TextHAlignAsString = "Left";
            this.facturasSinCAEUltraGrid.DisplayLayout.CaptionAppearance = appearance3;
            this.facturasSinCAEUltraGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.facturasSinCAEUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.facturasSinCAEUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.facturasSinCAEUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance5.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance5;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance6.BackColor = System.Drawing.Color.Transparent;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Control;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.CellAppearance = appearance7;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.ForeColor = System.Drawing.Color.Red;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.facturasSinCAEUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance44;
            this.facturasSinCAEUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.facturasSinCAEUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.facturasSinCAEUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.facturasSinCAEUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.facturasSinCAEUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasSinCAEUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.facturasSinCAEUltraGrid.Margin = new System.Windows.Forms.Padding(0);
            this.facturasSinCAEUltraGrid.Name = "facturasSinCAEUltraGrid";
            this.facturasSinCAEUltraGrid.Size = new System.Drawing.Size(893, 235);
            this.facturasSinCAEUltraGrid.TabIndex = 2;
            this.facturasSinCAEUltraGrid.Text = "Facturas sin CAE";
            // 
            // ultraCheckEditorEnviar
            // 
            this.ultraCheckEditorEnviar.Checked = true;
            this.ultraCheckEditorEnviar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ultraCheckEditorEnviar.Location = new System.Drawing.Point(13, 18);
            this.ultraCheckEditorEnviar.Name = "ultraCheckEditorEnviar";
            this.ultraCheckEditorEnviar.Size = new System.Drawing.Size(174, 20);
            this.ultraCheckEditorEnviar.TabIndex = 3;
            this.ultraCheckEditorEnviar.Text = "Enviar las facturas por email.";
            // 
            // FormFacturaElectronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(902, 612);
            this.Controls.Add(this.solicitudesCAEUltraGrid);
            this.Controls.Add(this.facturasSinCAEUltraGrid);
            this.MaximumSize = new System.Drawing.Size(918, 651);
            this.MinimumSize = new System.Drawing.Size(918, 651);
            this.Name = "FormFacturaElectronica";
            this.Text = "Solicitud de CAE";
            this.Load += new System.EventHandler(this.FormFacturaElectronica_Load);
            this.Controls.SetChildIndex(this.facturasSinCAEUltraGrid, 0);
            this.Controls.SetChildIndex(this.solicitudesCAEUltraGrid, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudesCAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCAEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCAEUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasSinCAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasSinCAEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasSinCAEUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditorEnviar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsSolicitudesCAE dsSolicitudesCAE;
        private System.Windows.Forms.BindingSource solicitudesCAEBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid solicitudesCAEUltraGrid;
        private WS.DsFacturasSinCAE dsFacturasSinCAE;
        private System.Windows.Forms.BindingSource facturasSinCAEBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid facturasSinCAEUltraGrid;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditorEnviar;
    }
}
