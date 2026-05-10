namespace Administracion
{
    partial class FormReporteBancoMacro
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
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto");
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.ultraDataSourceJubilado = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraLabelJubilado = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboJubilado = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ultraDateTimeEditorPeriodo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraLabelPeriodo = new Infragistics.Win.Misc.UltraLabel();
            this.dsReporteMacro1 = new Administracion.WS.DsReporteMacro();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceJubilado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboJubilado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteMacro1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 120);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(95, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // ultraDataSourceJubilado
            // 
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceJubilado.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceJubilado.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(1)),
                        ((object)("Texto")),
                        ((object)("Sí"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(0)),
                        ((object)("Texto")),
                        ((object)("No"))})});
            // 
            // ultraLabelJubilado
            // 
            appearance2.TextHAlignAsString = "Left";
            this.ultraLabelJubilado.Appearance = appearance2;
            this.ultraLabelJubilado.Location = new System.Drawing.Point(89, 64);
            this.ultraLabelJubilado.Name = "ultraLabelJubilado";
            this.ultraLabelJubilado.Size = new System.Drawing.Size(47, 14);
            this.ultraLabelJubilado.TabIndex = 22;
            this.ultraLabelJubilado.Text = "Jubilado";
            // 
            // ultraComboJubilado
            // 
            this.ultraComboJubilado.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboJubilado.DataSource = this.ultraDataSourceJubilado;
            appearance54.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboJubilado.DisplayLayout.Appearance = appearance54;
            this.ultraComboJubilado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 439;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 25;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2});
            this.ultraComboJubilado.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboJubilado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboJubilado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance55.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance55.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboJubilado.DisplayLayout.GroupByBox.Appearance = appearance55;
            appearance56.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboJubilado.DisplayLayout.GroupByBox.BandLabelAppearance = appearance56;
            this.ultraComboJubilado.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboJubilado.DisplayLayout.GroupByBox.Hidden = true;
            appearance57.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance57.BackColor2 = System.Drawing.SystemColors.Control;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance57.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboJubilado.DisplayLayout.GroupByBox.PromptAppearance = appearance57;
            this.ultraComboJubilado.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboJubilado.DisplayLayout.MaxBandDepth = 5;
            this.ultraComboJubilado.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboJubilado.DisplayLayout.MaxRowScrollRegions = 1;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboJubilado.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboJubilado.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraComboJubilado.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboJubilado.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboJubilado.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboJubilado.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboJubilado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboJubilado.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboJubilado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboJubilado.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboJubilado.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboJubilado.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboJubilado.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraComboJubilado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboJubilado.DisplayLayout.Override.CellPadding = 0;
            this.ultraComboJubilado.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.Control;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance46.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance46.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboJubilado.DisplayLayout.Override.GroupByRowAppearance = appearance46;
            appearance47.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance47.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance47.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboJubilado.DisplayLayout.Override.HeaderAppearance = appearance47;
            this.ultraComboJubilado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboJubilado.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance48.BackColor = System.Drawing.SystemColors.Window;
            appearance48.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboJubilado.DisplayLayout.Override.RowAppearance = appearance48;
            appearance49.ForeColor = System.Drawing.Color.Red;
            this.ultraComboJubilado.DisplayLayout.Override.RowSelectorAppearance = appearance49;
            this.ultraComboJubilado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboJubilado.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboJubilado.DisplayLayout.Override.SelectedCellAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboJubilado.DisplayLayout.Override.SelectedRowAppearance = appearance51;
            appearance52.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboJubilado.DisplayLayout.Override.TemplateAddRowAppearance = appearance52;
            appearance53.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboJubilado.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance53;
            this.ultraComboJubilado.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboJubilado.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboJubilado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboJubilado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboJubilado.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboJubilado.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboJubilado.DisplayMember = "Texto";
            this.ultraComboJubilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboJubilado.LimitToList = true;
            this.ultraComboJubilado.Location = new System.Drawing.Point(142, 59);
            this.ultraComboJubilado.Name = "ultraComboJubilado";
            this.ultraComboJubilado.Size = new System.Drawing.Size(44, 22);
            this.ultraComboJubilado.TabIndex = 21;
            this.ultraComboJubilado.ValueMember = "Valor";
            this.ultraComboJubilado.ValueChanged += new System.EventHandler(this.UltraComboJubiladoValueChanged);
            // 
            // ultraDateTimeEditorPeriodo
            // 
            this.ultraDateTimeEditorPeriodo.Location = new System.Drawing.Point(142, 32);
            this.ultraDateTimeEditorPeriodo.MaskInput = "{LOC}mm/yyyy";
            this.ultraDateTimeEditorPeriodo.Name = "ultraDateTimeEditorPeriodo";
            this.ultraDateTimeEditorPeriodo.Nullable = false;
            this.ultraDateTimeEditorPeriodo.Size = new System.Drawing.Size(77, 21);
            this.ultraDateTimeEditorPeriodo.TabIndex = 19;
            // 
            // ultraLabelPeriodo
            // 
            appearance3.TextHAlignAsString = "Left";
            this.ultraLabelPeriodo.Appearance = appearance3;
            this.ultraLabelPeriodo.AutoSize = true;
            this.ultraLabelPeriodo.Location = new System.Drawing.Point(38, 36);
            this.ultraLabelPeriodo.Name = "ultraLabelPeriodo";
            this.ultraLabelPeriodo.Size = new System.Drawing.Size(98, 14);
            this.ultraLabelPeriodo.TabIndex = 20;
            this.ultraLabelPeriodo.Text = "Período a Informar";
            // 
            // dsReporteMacro1
            // 
            this.dsReporteMacro1.DataSetName = "DsReporteMacro";
            this.dsReporteMacro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteBancoMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 167);
            this.Controls.Add(this.ultraLabelJubilado);
            this.Controls.Add(this.ultraComboJubilado);
            this.Controls.Add(this.ultraDateTimeEditorPeriodo);
            this.Controls.Add(this.ultraLabelPeriodo);
            this.MaximumSize = new System.Drawing.Size(281, 206);
            this.MinimumSize = new System.Drawing.Size(281, 206);
            this.Name = "FormReporteBancoMacro";
            this.Text = "Reporte para Banco Macro";
            this.Load += new System.EventHandler(this.FormReporteBancoMacroLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelPeriodo, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorPeriodo, 0);
            this.Controls.SetChildIndex(this.ultraComboJubilado, 0);
            this.Controls.SetChildIndex(this.ultraLabelJubilado, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceJubilado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboJubilado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteMacro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceJubilado;
        private Infragistics.Win.Misc.UltraLabel ultraLabelJubilado;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboJubilado;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorPeriodo;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPeriodo;
        private WS.DsReporteMacro dsReporteMacro1;
    }
}
