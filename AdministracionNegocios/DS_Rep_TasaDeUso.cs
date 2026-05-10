namespace AdministracionNegocios.DsRepTasaDeUsoTableAdapters
{
    public partial class TasaDeUsoTableAdapter
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
    public partial class DsRepTasaDeUso
    {
    }
}