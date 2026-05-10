using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using AdministracionNegocios.Properties;

namespace AdministracionNegocios
{
    public partial class CmpFacturaManual : Component
    {
        public CmpFacturaManual()
        {
            InitializeComponent();
        }

        public DsFacturaManual UpdateFacturaManual(DsFacturaManual fac)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    comprobantesManualesTableAdapter1.Update(fac.ComprobantesManuales.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    detallesComprobantesManualesTableAdapter1.Update(fac.DetallesComprobantesManuales);
                    comprobantesManualesTableAdapter1.Update(fac.ComprobantesManuales);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return fac;
            }
        }

        public void HacerComprobanteFacturaManual(int idComprobante, decimal importe, bool ponerCobrador,
            bool facturaTotalmenteManual)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.HacerComprobanteFacturaManual", connection)
                    {CommandType = CommandType.StoredProcedure};
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                var xImporte = command.Parameters.Add("@importe", SqlDbType.Decimal);
                xImporte.Value = importe;
                var xPonerCobrador = command.Parameters.Add("@ponerCobrador", SqlDbType.Bit);
                xPonerCobrador.Value = ponerCobrador;
                var xFacturaTotalmenteManual = command.Parameters.Add("@facturaTotalmenteManual", SqlDbType.Bit);
                xFacturaTotalmenteManual.Value = facturaTotalmenteManual;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsComprobantesImpagosCliente GetComprobantesImpagosCliente(int idCliente)
        {
            var ret = new DsComprobantesImpagosCliente();
            comprobantesImpagosClienteTableAdapter1.Fill(ret.ComprobantesImpagosCliente, idCliente);
            return ret;
        }

        public DsComprobantesImpagosCliente GetComprobantesImpagosONoCliente(int idCliente)
        {
            var ret = new DsComprobantesImpagosCliente();
            comprobantesImpagosClienteTableAdapter1.FillByCualquierSaldo(ret.ComprobantesImpagosCliente, idCliente);
            return ret;
        }

        public DsComprobantesImpagosCliente GetComprobantesImpagosGrupo(int idGrupo)
        {
            var ret = new DsComprobantesImpagosCliente();
            comprobantesImpagosClienteTableAdapter1.FillByIdGrupo(ret.ComprobantesImpagosCliente, idGrupo);
            return ret;
        }

        public DsComprobantesImpagosCliente GetComprobantesSaldoNegCliente(int idCliente)
        {
            var ret = new DsComprobantesImpagosCliente();
            comprobantesImpagosClienteTableAdapter1.FillByClienteNegativo(ret.ComprobantesImpagosCliente, idCliente);
            return ret;
        }

        public DsComprobantesImpagosCliente GetComprobantesSaldoNegGrupo(int idGrupo)
        {
            var ret = new DsComprobantesImpagosCliente();
            comprobantesImpagosClienteTableAdapter1.FillByGrupoNegativo(ret.ComprobantesImpagosCliente, idGrupo);
            return ret;
        }

        public void InsertarEnCobranzas(int idComprobante)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.InsertarEnCobranzas", connection)
                    {CommandType = CommandType.StoredProcedure};
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsFacturasProFormaDelCliente GetFacturasProformaDelCliente(int idCliente)
        {
            var ret = new DsFacturasProFormaDelCliente();
            facturasProformaDelClienteTableAdapter1.Fill(ret.FacturasProformaDelCliente, idCliente);
            renglonesFPFdelClienteTableAdapter1.Fill(ret.RenglonesFPFDelCliente, idCliente);
            return ret;
        }

        public DsRenglonesFacturaLista GetRenglonesDeFactura(int idCliente)
        {
            var ret = new DsRenglonesFacturaLista();
            renglonesFacturaListaTableAdapter1.Fill(ret.RenglonesFacturaLista, idCliente);
            return ret;
        }
    }
}