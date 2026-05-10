namespace AdministracionNegocios.DsRepPadronTableAdapters
{
    public partial class PadronTableAdapter
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
    partial class DsRepPadron
    {
    }
}