namespace Administracion
{
    partial class FormReportIVACompras
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.puntosDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPuntosDeVenta = new Administracion.WS.DsPuntosDeVenta();
            this.ultraLabelHasta = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelDesde = new Infragistics.Win.Misc.UltraLabel();
            this.ultraCalendarComboHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraCalendarComboDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(171, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(3, 13);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Size = new System.Drawing.Size(261, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(90, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // puntosDeVentaBindingSource
            // 
            this.puntosDeVentaBindingSource.DataMember = "PuntosDeVenta";
            this.puntosDeVentaBindingSource.DataSource = this.dsPuntosDeVenta;
            // 
            // dsPuntosDeVenta
            // 
            this.dsPuntosDeVenta.DataSetName = "DsPuntosDeVenta";
            this.dsPuntosDeVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelHasta
            // 
            this.ultraLabelHasta.Location = new System.Drawing.Point(74, 48);
            this.ultraLabelHasta.Name = "ultraLabelHasta";
            this.ultraLabelHasta.Size = new System.Drawing.Size(34, 14);
            this.ultraLabelHasta.TabIndex = 16;
            this.ultraLabelHasta.Text = "Hasta";
            // 
            // ultraLabelDesde
            // 
            this.ultraLabelDesde.Location = new System.Drawing.Point(71, 21);
            this.ultraLabelDesde.Name = "ultraLabelDesde";
            this.ultraLabelDesde.Size = new System.Drawing.Size(37, 14);
            this.ultraLabelDesde.TabIndex = 15;
            this.ultraLabelDesde.Text = "Desde";
            // 
            // ultraCalendarComboHasta
            // 
            this.ultraCalendarComboHasta.DateButtons.Add(dateButton1);
            this.ultraCalendarComboHasta.Format = "dd/MM/yyyy";
            this.ultraCalendarComboHasta.Location = new System.Drawing.Point(114, 45);
            this.ultraCalendarComboHasta.Name = "ultraCalendarComboHasta";
            this.ultraCalendarComboHasta.NonAutoSizeHeight = 21;
            this.ultraCalendarComboHasta.Size = new System.Drawing.Size(88, 21);
            this.ultraCalendarComboHasta.TabIndex = 14;
            // 
            // ultraCalendarComboDesde
            // 
            this.ultraCalendarComboDesde.DateButtons.Add(dateButton2);
            this.ultraCalendarComboDesde.Format = "dd/MM/yyyy";
            this.ultraCalendarComboDesde.Location = new System.Drawing.Point(114, 18);
            this.ultraCalendarComboDesde.Name = "ultraCalendarComboDesde";
            this.ultraCalendarComboDesde.NonAutoSizeHeight = 21;
            this.ultraCalendarComboDesde.Size = new System.Drawing.Size(88, 21);
            this.ultraCalendarComboDesde.TabIndex = 13;
            // 
            // FormReportIVACompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(265, 128);
            this.Controls.Add(this.ultraLabelHasta);
            this.Controls.Add(this.ultraLabelDesde);
            this.Controls.Add(this.ultraCalendarComboHasta);
            this.Controls.Add(this.ultraCalendarComboDesde);
            this.Name = "FormReportIVACompras";
            this.Text = "IVA Compras";
            this.Load += new System.EventHandler(this.FormReportIVACompras_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraCalendarComboDesde, 0);
            this.Controls.SetChildIndex(this.ultraCalendarComboHasta, 0);
            this.Controls.SetChildIndex(this.ultraLabelDesde, 0);
            this.Controls.SetChildIndex(this.ultraLabelHasta, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.puntosDeVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuntosDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalendarComboDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource puntosDeVentaBindingSource;
        private WS.DsPuntosDeVenta dsPuntosDeVenta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelHasta;
        private Infragistics.Win.Misc.UltraLabel ultraLabelDesde;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboHasta;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarComboDesde;
    }
}
