namespace AdministracionNegocios.DsDeudoresTableAdapters
{
    public partial class DeudoresTableAdapter
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
    public partial class DsDeudores
    {
        partial class DeudoresDataTable
        {
        }
    }
}