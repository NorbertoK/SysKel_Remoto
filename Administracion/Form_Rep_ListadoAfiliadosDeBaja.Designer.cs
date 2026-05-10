namespace Administracion
{
    partial class FormRepListadoAfiliadosDeBaja
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
            this.CR_ListadoAfiliadosDeBaja1 = new Administracion.CR_ListadoAfiliadosDeBaja();
            this.dsListadoAfiliadosDeBaja1 = new Administracion.WS.DsListadoAfiliadosDeBaja();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoAfiliadosDeBaja1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_ListadoAfiliadosDeBaja1;
            // 
            // dsListadoAfiliadosDeBaja1
            // 
            this.dsListadoAfiliadosDeBaja1.DataSetName = "DsListadoAfiliadosDeBaja";
            this.dsListadoAfiliadosDeBaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepListadoAfiliadosDeBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepListadoAfiliadosDeBaja";
            this.Text = "Listado de Afiliados de Baja";
            this.Load += new System.EventHandler(this.FormRepListadoAfiliadosDeBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoAfiliadosDeBaja1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_ListadoAfiliadosDeBaja CR_ListadoAfiliadosDeBaja1;
        private WS.DsListadoAfiliadosDeBaja dsListadoAfiliadosDeBaja1;
    }
}
