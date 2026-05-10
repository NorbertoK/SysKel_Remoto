namespace AdministracionNegocios.DsReportComprobantesTableAdapters
{
    public partial class ComprobantesTableAdapter
    {
        public void SetTimeOut()
        {
            foreach (var command in CommandCollection)
                command.CommandTimeout = 0;
        }
    }
}

namespace AdministracionNegocios
{
    partial class DsReportComprobantes
    {
        #region Nested type: ComprobantesDataTable

        partial class ComprobantesDataTable
        {
        }

        partial class ComprobantesDataTable
        {
        }

        #endregion
    }
}