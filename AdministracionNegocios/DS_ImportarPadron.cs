namespace AdministracionNegocios.DsImportarPadronTableAdapters
{
    public partial class RowTableAdapter
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
    public partial class DsImportarPadron
    {
        partial class RowDataTable
        {
        }
    }
}