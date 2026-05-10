namespace AdministracionNegocios.DsImprimirPrestacionTableAdapters
{
    public partial class ImprimirPrestacionTableAdapter
    {
        public void SetTimeOut()
        {
            foreach (var command in CommandCollection)
                command.CommandTimeout = 0;
        }
    }

    public partial class ImprimirPrestacionCtaCteTableAdapter
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
    partial class DsImprimirPrestacion
    {
        #region Nested type: ImprimirPrestacionDataTable

        partial class ImprimirPrestacionDataTable
        {
        }

        #endregion
    }
}