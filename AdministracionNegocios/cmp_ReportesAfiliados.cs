using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using AdministracionNegocios.Properties;

namespace AdministracionNegocios
{
    public partial class CmpReportesAfiliados : Component
    {
        public CmpReportesAfiliados()
        {
            InitializeComponent();
        }

        public string GetProcesoAfiliados(string altaBajaTodos,
            string soloTitulares,
            int idEntidadDeCobranza
        )
        {
            string retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.SeleccionDeAfiliados", connection)
                    {CommandType = CommandType.StoredProcedure};
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Direction = ParameterDirection.Output;
                var xAltaBajaTodos = command.Parameters.Add("@altaBajaTodos", SqlDbType.VarChar);
                xAltaBajaTodos.Value = altaBajaTodos;
                var xSoloTitulares = command.Parameters.Add("@soloTitulares", SqlDbType.VarChar);
                xSoloTitulares.Value = soloTitulares;
                var xIdEntidadDeCobranza = command.Parameters.Add("@idEntidadDeCobranza", SqlDbType.Int);
                xIdEntidadDeCobranza.Value = idEntidadDeCobranza;
                connection.Open();
                command.ExecuteNonQuery();
                retorno = xProceso.Value.ToString();
            }
            return retorno;
        }

        public string GetProcesoClientes(string altaBajaTodos,
            int idEntidadDeCobranza,
            int idTipoDeCliente,
            int idCobrador
        )
        {
            string retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.SeleccionDeClientes", connection)
                    {CommandType = CommandType.StoredProcedure};
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Direction = ParameterDirection.Output;
                var xAltaBajaTodos = command.Parameters.Add("@altaBajaTodos", SqlDbType.VarChar);
                xAltaBajaTodos.Value = altaBajaTodos;
                var xIdEntidadDeCobranza = command.Parameters.Add("@idEntidadDeCobranza", SqlDbType.Int);
                xIdEntidadDeCobranza.Value = idEntidadDeCobranza;
                var xIdTipoDeCliente = command.Parameters.Add("@idTipoDeCliente", SqlDbType.Int);
                xIdTipoDeCliente.Value = idTipoDeCliente;
                var xIdCobrador = command.Parameters.Add("@idCobrador", SqlDbType.Int);
                xIdCobrador.Value = idCobrador;
                connection.Open();
                command.ExecuteNonQuery();
                retorno = xProceso.Value.ToString();
            }
            return retorno;
        }

        public DsListaCorreo GetListaCorreo(string afiliadosOClientes, string tipoDeDireccion, string proceso)
        {
            var ret = new DsListaCorreo();
            listaCorreoTableAdapter1.SetTimeOut();
            listaCorreoTableAdapter1.Fill(ret.ListaCorreo, afiliadosOClientes, tipoDeDireccion, proceso);
            return ret;
        }
    }
}