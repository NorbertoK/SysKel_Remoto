namespace AdministracionNegocios.DsRepConstanciasAfiliacionTableAdapters
{
    public partial class ConstanciasAfiliacionTableAdapter
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
    partial class DsRepConstanciasAfiliacion
    {
    }
}