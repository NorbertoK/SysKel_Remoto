using System;
using Cabina.WS;

namespace Cabina
{
    public partial class FormRepPago : FormCR
    {
        public FormRepPago()
        {
            InitializeComponent();
        }

        public int IdPago { get; set; }

        private void FormRepPagoLoad(object sender, EventArgs e)
        {
            dsReportPago1.Merge(new Service().GetReportPago(IdPago, Program.Pin));
            CR_ReportPago1.SetDataSource(dsReportPago1);
        }
    }
}