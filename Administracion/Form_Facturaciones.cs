using System;
using System.Windows.Forms;
using Administracion.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administracion
{
    public partial class FormFacturaciones : Form1
    {
        public FormFacturaciones()
        {
            InitializeComponent();
        }

        private void FormFacturacionesLoad(object sender, EventArgs e)
        {
            dsFacturaciones.Merge(new Service().GetFacturaciones(Program.Pin));
        }

        private void facturacionesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                facturacionesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void facturacionesUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}