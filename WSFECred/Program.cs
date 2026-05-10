using System;
using System.Data.SqlClient;
using WSFECred.Properties;

namespace WSFECred
{
    internal class Program
    {
        public static void Main()
        {
            // Crear objeto interface Web Service de Factura Electrónica de Mercado Interno
            dynamic wsfeCred = Activator.CreateInstance(Type.GetTypeFromProgID("WSFECred"));
            Console.WriteLine("Versión: " + wsfeCred.Version);
            Console.ReadLine();
            int vigencia;
            string token = null;
            string sign = null;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT TOP 1 CASE WHEN VigenciaWSFECred > GETDATE() THEN 1 ELSE 0 END FROM dbo.Parametros",
                        connection);
                connection.Open();
                vigencia = (int) command.ExecuteScalar();
            }
            if (vigencia == 0)
            {
                Console.WriteLine("No tiene vigencia.");
                Console.ReadLine();
            }
            else
            {
                using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
                {
                    var command =
                        new SqlCommand(
                            "SELECT TOP 1 TokenWSFECred FROM dbo.Parametros",
                            connection);
                    connection.Open();
                    token = command.ExecuteScalar().ToString();
                }
                using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
                {
                    var command =
                        new SqlCommand(
                            "SELECT TOP 1 Sign_WSFECred FROM dbo.Parametros",
                            connection);
                    connection.Open();
                    sign = command.ExecuteScalar().ToString();
                }
            }

            // Setear tocken y sing de autorización (pasos previos)
            wsfeCred.Token = token;
            wsfeCred.Sign = sign;

            // CUIT del emisor (debe estar registrado en la AFIP)
            wsfeCred.Cuit = "33642934649";

            // Conectar al Servicio Web de Facturación
            wsfeCred.Conectar("","https://serviciosjava.afip.gob.ar/wsfecred/FECredService?wsdl");

            // Llamo a un servicio nulo, para obtener el estado del servidor (opcional)
            wsfeCred.Dummy();
            Console.WriteLine("appserver status " + wsfeCred.AppServerStatus);
            Console.WriteLine("dbserver status " + wsfeCred.DbServerStatus);
            Console.WriteLine("authserver status " + wsfeCred.AuthServerStatus);
            Console.WriteLine();
            Console.WriteLine("XmlRequest: " + wsfeCred.XmlRequest);
            Console.WriteLine();
            Console.WriteLine("XmlResponse: " + wsfeCred.XmlResponse);
            Console.ReadLine();

            //var cuit_consultar = "30500010912";
            var cuit_consultar = "20923987453";
            var minimo = wsfeCred.ConsultarMontoObligadoRecepcion(cuit_consultar);
            Console.WriteLine("CUIT: " + cuit_consultar);
            Console.WriteLine("Obligado: " + wsfeCred.Resultado);
            Console.WriteLine("Monto Desde: " + minimo);
            Console.ReadLine();
        }
    }
}