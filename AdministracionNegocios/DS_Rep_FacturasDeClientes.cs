namespace AdministracionNegocios.DsRepFacturasDeClientesTableAdapters
{
    public partial class FacturasDeClientesTableAdapter
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
    partial class DsRepFacturasDeClientes
    {
        #region Nested type: FacturasDeClientesDataTable

        partial class FacturasDeClientesDataTable
        {
        }

        #endregion
    }
}