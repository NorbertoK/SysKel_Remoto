namespace Administracion
{
    partial class FormPagarCompras
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ComprasImpagas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Comprobante");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca", 0);
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            this.proveedoresUltraCombo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProveedores = new Administracion.WS.DsProveedores();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.comprasImpagasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprasImpagasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComprasImpagas = new Administracion.WS.DsComprasImpagas();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprasImpagas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(541, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(206, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Size = new System.Drawing.Size(631, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(460, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // proveedoresUltraCombo
            // 
            this.proveedoresUltraCombo.DataSource = this.proveedoresBindingSource;
            ultraGridColumn60.Header.VisiblePosition = 0;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn61.Header.VisiblePosition = 1;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn62.Header.VisiblePosition = 2;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn63.Header.VisiblePosition = 3;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn64.Header.VisiblePosition = 4;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn65.Header.VisiblePosition = 5;
            ultraGridColumn66.Header.VisiblePosition = 6;
            ultraGridColumn66.Hidden = true;
            ultraGridColumn67.Header.VisiblePosition = 7;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn68.Header.VisiblePosition = 8;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn69.Header.VisiblePosition = 9;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn70.Header.VisiblePosition = 10;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.Header.VisiblePosition = 11;
            ultraGridColumn72.Header.VisiblePosition = 12;
            ultraGridColumn73.Header.VisiblePosition = 13;
            ultraGridColumn74.Header.VisiblePosition = 14;
            ultraGridBand1.Columns.AddRange(new object[] {
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
            ultraGridColumn74});
            ultraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal;
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn75.Header.VisiblePosition = 0;
            ultraGridColumn76.Header.VisiblePosition = 1;
            ultraGridColumn77.Header.VisiblePosition = 2;
            ultraGridColumn78.Header.VisiblePosition = 3;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77,
            ultraGridColumn78});
            ultraGridColumn79.Header.VisiblePosition = 0;
            ultraGridColumn80.Header.VisiblePosition = 1;
            ultraGridColumn81.Header.VisiblePosition = 2;
            ultraGridColumn82.Header.VisiblePosition = 3;
            ultraGridColumn83.Header.VisiblePosition = 4;
            ultraGridColumn84.Header.VisiblePosition = 5;
            ultraGridColumn85.Header.VisiblePosition = 6;
            ultraGridColumn86.Header.VisiblePosition = 7;
            ultraGridColumn87.Header.VisiblePosition = 8;
            ultraGridColumn88.Header.VisiblePosition = 9;
            ultraGridColumn89.Header.VisiblePosition = 10;
            ultraGridColumn90.Header.VisiblePosition = 11;
            ultraGridColumn91.Header.VisiblePosition = 12;
            ultraGridColumn92.Header.VisiblePosition = 13;
            ultraGridColumn93.Header.VisiblePosition = 14;
            ultraGridBand3.Columns.AddRange(new object[] {
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
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93});
            ultraGridColumn94.Header.VisiblePosition = 0;
            ultraGridColumn95.Header.VisiblePosition = 1;
            ultraGridColumn96.Header.VisiblePosition = 2;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96});
            ultraGridColumn97.Header.VisiblePosition = 0;
            ultraGridColumn98.Header.VisiblePosition = 1;
            ultraGridColumn99.Header.VisiblePosition = 2;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn97,
            ultraGridColumn98,
            ultraGridColumn99});
            ultraGridColumn100.Header.VisiblePosition = 0;
            ultraGridColumn101.Header.VisiblePosition = 1;
            ultraGridColumn102.Header.VisiblePosition = 2;
            ultraGridColumn103.Header.VisiblePosition = 3;
            ultraGridColumn104.Header.VisiblePosition = 4;
            ultraGridColumn105.Header.VisiblePosition = 5;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104,
            ultraGridColumn105});
            ultraGridColumn106.Header.VisiblePosition = 0;
            ultraGridColumn107.Header.VisiblePosition = 1;
            ultraGridColumn108.Header.VisiblePosition = 2;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn106,
            ultraGridColumn107,
            ultraGridColumn108});
            ultraGridColumn109.Header.VisiblePosition = 0;
            ultraGridColumn110.Header.VisiblePosition = 1;
            ultraGridColumn111.Header.VisiblePosition = 2;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111});
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.proveedoresUltraCombo.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.proveedoresUltraCombo.DisplayMember = "NombreCompleto";
            this.proveedoresUltraCombo.Location = new System.Drawing.Point(74, 12);
            this.proveedoresUltraCombo.Name = "proveedoresUltraCombo";
            this.proveedoresUltraCombo.Size = new System.Drawing.Size(456, 22);
            this.proveedoresUltraCombo.TabIndex = 2;
            this.proveedoresUltraCombo.ValueMember = "idProveedor";
            this.proveedoresUltraCombo.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.proveedoresUltraCombo_BeforeDropDown);
            this.proveedoresUltraCombo.ValueChanged += new System.EventHandler(this.ProveedoresUltraComboValueChanged);
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
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(12, 16);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(56, 14);
            this.ultraLabel1.TabIndex = 3;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // comprasImpagasUltraGrid
            // 
            this.comprasImpagasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasImpagasUltraGrid.DataSource = this.comprasImpagasBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprasImpagasUltraGrid.DisplayLayout.Appearance = appearance1;
            ultraGridColumn112.Header.VisiblePosition = 0;
            ultraGridColumn112.Hidden = true;
            appearance12.TextHAlignAsString = "Center";
            ultraGridColumn113.CellAppearance = appearance12;
            ultraGridColumn113.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn113.Header.Caption = "Factura";
            ultraGridColumn113.Header.VisiblePosition = 2;
            ultraGridColumn113.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn113.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn113.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn113.MaskInput = "####-########";
            ultraGridColumn113.Width = 92;
            appearance13.TextHAlignAsString = "Center";
            ultraGridColumn114.CellAppearance = appearance13;
            ultraGridColumn114.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn114.Header.VisiblePosition = 3;
            ultraGridColumn114.Width = 69;
            appearance17.TextHAlignAsString = "Right";
            ultraGridColumn115.CellAppearance = appearance17;
            ultraGridColumn115.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn115.Header.VisiblePosition = 5;
            ultraGridColumn115.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            appearance18.TextHAlignAsString = "Right";
            ultraGridColumn116.CellAppearance = appearance18;
            ultraGridColumn116.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn116.Header.VisiblePosition = 6;
            ultraGridColumn116.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn117.Header.VisiblePosition = 4;
            ultraGridColumn117.Width = 238;
            ultraGridColumn118.DataType = typeof(bool);
            ultraGridColumn118.DefaultCellValue = false;
            ultraGridColumn118.Header.VisiblePosition = 1;
            ultraGridColumn118.Width = 34;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn112,
            ultraGridColumn113,
            ultraGridColumn114,
            ultraGridColumn115,
            ultraGridColumn116,
            ultraGridColumn117,
            ultraGridColumn118});
            ultraGridBand9.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand9.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.comprasImpagasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.comprasImpagasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprasImpagasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprasImpagasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance10.ForeColor = System.Drawing.Color.Red;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance10;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance15.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprasImpagasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance16;
            this.comprasImpagasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprasImpagasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprasImpagasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprasImpagasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprasImpagasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comprasImpagasUltraGrid.Location = new System.Drawing.Point(0, 73);
            this.comprasImpagasUltraGrid.Name = "comprasImpagasUltraGrid";
            this.comprasImpagasUltraGrid.Size = new System.Drawing.Size(628, 285);
            this.comprasImpagasUltraGrid.TabIndex = 3;
            this.comprasImpagasUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ComprasImpagasUltraGridCellChange);
            this.comprasImpagasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprasImpagasUltraGrid_KeyDown);
            // 
            // comprasImpagasBindingSource
            // 
            this.comprasImpagasBindingSource.DataMember = "ComprasImpagas";
            this.comprasImpagasBindingSource.DataSource = this.dsComprasImpagas;
            // 
            // dsComprasImpagas
            // 
            this.dsComprasImpagas.DataSetName = "DsComprasImpagas";
            this.dsComprasImpagas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(12, 46);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(161, 13);
            this.labelMensaje.TabIndex = 9;
            this.labelMensaje.Text = "No hay compras con saldo.";
            this.labelMensaje.Visible = false;
            // 
            // FormPagarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(630, 396);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.comprasImpagasUltraGrid);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.proveedoresUltraCombo);
            this.Name = "FormPagarCompras";
            this.Text = "Pagar Compras";
            this.Load += new System.EventHandler(this.FormPagarComprasLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.proveedoresUltraCombo, 0);
            this.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.Controls.SetChildIndex(this.comprasImpagasUltraGrid, 0);
            this.Controls.SetChildIndex(this.labelMensaje, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasImpagasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprasImpagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WS.DsProveedores dsProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo proveedoresUltraCombo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private WS.DsComprasImpagas dsComprasImpagas;
        private System.Windows.Forms.BindingSource comprasImpagasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid comprasImpagasUltraGrid;
        private System.Windows.Forms.Label labelMensaje;
    }
}
