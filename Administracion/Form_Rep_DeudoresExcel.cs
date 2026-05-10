using System;

namespace Administracion
{
    public partial class FormRepDeudoresExcel : FormCR
    {
        public FormRepDeudoresExcel()
        {
            InitializeComponent();
        }

        public AdministracionNegocios.DsDeudores DsDeudoresTraidos { private get; set; }

        private void FormRepDeudoresExcelLoad(object sender, EventArgs e)
        {
            crDeudoresExcel1.SetDataSource(DsDeudoresTraidos);
        }
    }
}