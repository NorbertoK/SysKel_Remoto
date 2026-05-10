using System;
using Administracion.Properties;
using Administracion.WS;
using CrystalDecisions.CrystalReports.Engine;

namespace Administracion
{
    public partial class FormRepComprobantesDeFactura : FormCR
    {
        public string Proceso { private get; set; }
        public string Desde { private get; set; }
        public string Hasta { private get; set; }
        public int IdComprobante { get; set; }
        public string Resumen { private get; set; }
        public string Comprobantes { private get; set; }
        public string Prefijo { private get; set; }

        private void FormRepConstanciasDeAfiliacionLoad(object sender, EventArgs e)
        {
            ReportClass cr = crComprobantesDeFacturas31;
            ReportClass crCResumen;
            if (Settings.Default.Empresa == "SAE")
            {
                if (Comprobantes == "C")
                    cr = crComprobantesDeFacturas31;
                if (Comprobantes == "A")
                    cr = crFacturaA_Clientes;
                if (Comprobantes == "B")
                    cr = crFacturaB_Clientes;
                crCResumen = crComprobantesDeFacturasConResumen31;
            }

            else
            {
                cr = crComprobantesDeFacturas1;
                crCResumen = crComprobantesDeFacturasConResumen1;
            }
            var aux = new Service {Timeout = 60 * 60 * 1000};
            if (Resumen == "Si")
            {
                crystalReportViewer1.ReportSource = crCResumen;
                dsComprobantesDeFacturas1.Merge(
                    aux.GetComprobantesDeFacturas(Desde, Hasta, Comprobantes, Prefijo, Program.Pin));
            }
            else
            {
                crystalReportViewer1.ReportSource = cr;
                if (Proceso == "Nada")
                {
                    dsComprobantesDeFacturas1.Merge(IdComprobante != 0
                        ? aux.GetComprobanteDeFactura(IdComprobante, Program.Pin)
                        : aux.GetComprobantesDeFacturas(Desde, Hasta, Comprobantes, Prefijo, Program.Pin));
                }
                else
                {
                    dsComprobantesDeFacturas1.Merge(aux.GetComprobantesDeFacturasPorProceso(Proceso, Program.Pin));
                    new Service().EliminarProceso(Proceso, Program.Pin);
                }
            }
            cr.SetDataSource(dsComprobantesDeFacturas1);
        }
    }
}