namespace Administracion
{
    partial class FormRepIVACompras
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
            this.dsIVACompras1 = new Administracion.WS.DsIVACompras();
            this.CR_IVACompras1 = new Administracion.CR_IVACompras();
            ((System.ComponentModel.ISupportInitialize)(this.dsIVACompras1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.CR_IVACompras1;
            // 
            // dsIVACompras1
            // 
            this.dsIVACompras1.DataSetName = "DsIVACompras";
            this.dsIVACompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRepIVACompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 632);
            this.Name = "FormRepIVACompras";
            this.Text = "IVA Compras";
            this.Load += new System.EventHandler(this.FormRepIVACompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsIVACompras1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsIVACompras dsIVACompras1;
        private CR_IVACompras CR_IVACompras1;
    }
}
