namespace AdministracionNegocios.DsPrestacionesConSaldoTableAdapters
{
    public partial class PrestacionesConSaldoTableAdapter
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
    public partial class DsPrestacionesConSaldo
    {
    }
}