namespace AdministracionNegocios.DsEstadoDeLaCobranzaTableAdapters
{
    public partial class EstadoDeLaCobranzaTableAdapter
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
    public partial class DsEstadoDeLaCobranza
    {
    }
}