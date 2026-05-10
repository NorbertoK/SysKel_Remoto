namespace AdministracionNegocios.DsRepListadoPorPlanTableAdapters
{
    public partial class ListadoPorPlanTableAdapter
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
    partial class DsRepListadoPorPlan
    {
        #region Nested type: ListadoPorPlanDataTable

        partial class ListadoPorPlanDataTable
        {
        }

        #endregion
    }
}