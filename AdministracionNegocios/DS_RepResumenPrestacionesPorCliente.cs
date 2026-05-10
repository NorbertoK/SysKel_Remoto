namespace AdministracionNegocios.DsRepResumenPrestacionesPorClienteTableAdapters
{
    public partial class ResumenPrestacionesPorClienteSoloDomiciliosTableAdapter
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
    public partial class DsRepResumenPrestacionesPorCliente
    {
    }
}