namespace AdministracionNegocios.DsDatosPrestacionesTableAdapters
{
    public partial class DatosPrestacionesTableAdapter
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
    public partial class DsDatosPrestaciones
    {
    }
}