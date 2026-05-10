// Archivo: Form_FacturaElectronica.cs
// Target: .NET Framework 4.8 | WinForms | x64
// PATCH MiPyME 10192 v4: reintento silencioso + GuardarCAE(idComprobante, cae, vtoCAE, nro, idTipo, pin)

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Administracion.Properties;
using Administracion.WS;

// ReSharper disable InconsistentNaming

namespace Administracion
{
    public partial class FormFacturaElectronica : Form1
    {
        private string _respuesta;

        public FormFacturaElectronica()
        {
            InitializeComponent();
        }

        private void FormPruebaFacturaElectronica_Load(object sender, EventArgs e)
        {
            dsFacturasSinCAE.Merge(new Service().GetFacturasSinCAE(Program.Pin));
            if (dsFacturasSinCAE.FacturasSinCAE.Rows.Count > 0)
                buttonAceptar.Enabled = true;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            SolicitarCAE();
            MostrarResultado();
            buttonCancelar.Enabled = true;
        }

        [Localizable(false)]
        private void MostrarResultado()
        {
            var aux = new Service().UpdatesolSolicitudesCae(dsSolicitudesCAE, Program.Pin);
            if (aux == null)
                MessageBox.Show(
                    "No se grabó el archivo de Solicitudes de CAE.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            // Muestro el reporte con el resultado.
            var f = new FormRepSolicitudesCAE
            {
                DsSolicitudesTraidas = dsSolicitudesCAE,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.ShowDialog(this);
        }

        private void SolicitarCAE()
        {
            for (var i = 0; i < dsFacturasSinCAE.FacturasSinCAE.Count; i++)
            {
                var renglon = dsFacturasSinCAE.FacturasSinCAE.Rows[i];

                // =======================
                // 1) PRIMER INTENTO
                // =======================
                _respuesta = new Service().GetWsfEv1(
                    (int)renglon["tipoCbte"],
                    renglon["Token"].ToString(),
                    renglon["_Sign"].ToString(),
                    (int)renglon["tipoDoc"],
                    renglon["CUIT"].ToString(),
                    (int)renglon["puntoVta"],
                    renglon["nroDoc"].ToString(),
                    renglon["impTotal"].ToString(),
                    renglon["impTotConc"].ToString(),
                    renglon["impNeto"].ToString(),
                    renglon["impIVA"].ToString(),
                    renglon["impTrib"].ToString(),
                    renglon["impOpEx"].ToString(),
                    renglon["fechaCbte"].ToString(),
                    renglon["fechaVencPago"].ToString(),
                    renglon["fechaServDesde"].ToString(),
                    renglon["fechaServHasta"].ToString(),
                    renglon["baseImp3"].ToString(),
                    renglon["importeIVA3"].ToString(),
                    renglon["baseImp4"].ToString(),
                    renglon["importeIVA4"].ToString(),
                    renglon["baseImp5"].ToString(),
                    renglon["importeIVA5"].ToString(),
                    renglon["baseImp6"].ToString(),
                    renglon["importeIVA6"].ToString(),
                    renglon["baseImp8"].ToString(),
                    renglon["importeIVA8"].ToString(),
                    renglon["baseImp9"].ToString(),
                    renglon["importeIVA9"].ToString(),
                    renglon["tipoCbteAsoc"].ToString(),
                    renglon["puntoVtaAsoc"].ToString(),
                    renglon["cbteNroAsoc"].ToString(),
                    renglon["fechaCbteAsoc"].ToString(),
                    renglon["NdeCEsAnulacion"].ToString(),
                    renglon["condicionIVAReceptorId"].ToString(),
                    Program.Pin);

                var solicitudCAE = dsSolicitudesCAE.SolicitudesCAE.NewSolicitudesCAERow();
                solicitudCAE.Fecha = new Service().HoraActual(Program.Pin);
                solicitudCAE.idComprobante = (int)renglon["idComprobante"];
                solicitudCAE.TipoDeComprobante = renglon["TipoComprobante"].ToString();
                solicitudCAE.Prefijo = renglon["puntoVta"].ToString().PadLeft(4, '0');
                solicitudCAE.NombreCliente = renglon["NombreCliente"].ToString();

                if (!_respuesta.Contains("|"))
                {
                    solicitudCAE.Error = _respuesta;
                    MessageBox.Show(_respuesta, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                var p1 = _respuesta.Split('|');
                solicitudCAE.Resultado = p1[0];
                solicitudCAE.CAE = p1[1];
                solicitudCAE.NumeroDeComprobante = p1[2];
                renglon["cbtDesde"] = solicitudCAE.NumeroDeComprobante;
                solicitudCAE.Reproceso = p1[3];
                solicitudCAE.Observaciones = ManejoDatos.CodePage(p1[4]);
                solicitudCAE.Vencimiento = p1[5];
                solicitudCAE.XmlRequest = p1[6];
                solicitudCAE.XmlResponse = p1[7];
                solicitudCAE.Error = ManejoDatos.CodePage(p1.Length > 8 ? p1[8] : "");

                // =======================
                // 2) ¿RECHAZADA?
                // =======================
                if (solicitudCAE.Resultado == "R")
                {
                    // Rechazo por régimen MiPyME (Ley 27.440) → código 10192
                    string allErr = (solicitudCAE.Error ?? "") + "|" +
                                    (solicitudCAE.Observaciones ?? "") + "|" +
                                    (solicitudCAE.XmlResponse ?? "");
                    bool esMiPyme = allErr.Contains("10192") ||
                                    allErr.Contains("Ley 27.440") ||
                                    allErr.Contains("27.440");

                    if (esMiPyme)
                    {
                        // 2.a) Mapear AFIP normal → AFIP MiPyME + resolver idTipo interno
                        int afipActual = (int)renglon["tipoCbte"];
                        int afipMiPyme = MapearAfipMiPyme(afipActual); // A:1→201, B:6→204
                        int idTipoMiPyme = ResolverIdTipoPorAfip(afipMiPyme, renglon);

                        // 2.b) Asegurar Fecha de Vencimiento de Pago (MiPyME la exige)
                        string fvp = renglon["fechaVencPago"].ToString();
                        if (string.IsNullOrWhiteSpace(fvp) || fvp.Length != 8)
                            fvp = CalcularVencimientoPagoDefault(renglon["fechaCbte"].ToString(), 30, fvp);

                        // 2.c) Reintento con MiPyME (silencioso)
                        var respuesta2 = new Service().GetWsfEv1(
                            afipMiPyme,
                            renglon["Token"].ToString(),
                            renglon["_Sign"].ToString(),
                            (int)renglon["tipoDoc"],
                            renglon["CUIT"].ToString(),
                            (int)renglon["puntoVta"],
                            renglon["nroDoc"].ToString(),
                            renglon["impTotal"].ToString(),
                            renglon["impTotConc"].ToString(),
                            renglon["impNeto"].ToString(),
                            renglon["impIVA"].ToString(),
                            renglon["impTrib"].ToString(),
                            renglon["impOpEx"].ToString(),
                            renglon["fechaCbte"].ToString(),
                            fvp,
                            renglon["fechaServDesde"].ToString(),
                            renglon["fechaServHasta"].ToString(),
                            renglon["baseImp3"].ToString(),
                            renglon["importeIVA3"].ToString(),
                            renglon["baseImp4"].ToString(),
                            renglon["importeIVA4"].ToString(),
                            renglon["baseImp5"].ToString(),
                            renglon["importeIVA5"].ToString(),
                            renglon["baseImp6"].ToString(),
                            renglon["importeIVA6"].ToString(),
                            renglon["baseImp8"].ToString(),
                            renglon["importeIVA8"].ToString(),
                            renglon["baseImp9"].ToString(),
                            renglon["importeIVA9"].ToString(),
                            renglon["tipoCbteAsoc"].ToString(),
                            renglon["puntoVtaAsoc"].ToString(),
                            renglon["cbteNroAsoc"].ToString(),
                            renglon["fechaCbteAsoc"].ToString(),
                            renglon["NdeCEsAnulacion"].ToString(),
                            renglon["condicionIVAReceptorId"].ToString(),
                            Program.Pin);

                        if (respuesta2.Contains("|"))
                        {
                            var p2 = respuesta2.Split('|');
                            var res2 = p2[0];

                            if (res2 == "A")
                            {
                                // Éxito tras MiPyME → actualizar datos y seguir flujo de aceptada
                                solicitudCAE.Resultado = p2[0];
                                solicitudCAE.CAE = p2[1];
                                solicitudCAE.NumeroDeComprobante = p2[2];
                                solicitudCAE.Reproceso = p2[3];
                                solicitudCAE.Observaciones = ManejoDatos.CodePage(p2[4]);
                                solicitudCAE.Vencimiento = p2[5];
                                solicitudCAE.XmlRequest = p2[6];
                                solicitudCAE.XmlResponse = p2[7];
                                solicitudCAE.Error = ManejoDatos.CodePage(p2.Length > 8 ? p2[8] : "");

                                // Guardar con idTipoDeComprobante MiPyME
                                new Service().GuardarCAE(
                                    (int)renglon["idComprobante"],
                                    solicitudCAE.CAE,
                                    solicitudCAE.Vencimiento,
                                    solicitudCAE.NumeroDeComprobante,
                                    idTipoMiPyme,
                                    Program.Pin);
                            }
                            else
                            {
                                // Sigue rechazado luego de MiPyME: recién acá mostramos
                                dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                                MessageBox.Show(
                                    "Factura Rechazada (reintento MiPyME)." + Environment.NewLine +
                                    solicitudCAE.Observaciones + Environment.NewLine +
                                    solicitudCAE.Error,
                                    "Factura " + renglon["cbtDesde"]);
                                break;
                            }
                        }
                        else
                        {
                            // Respuesta inválida en reintento
                            solicitudCAE.Error = respuesta2;
                            dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                            MessageBox.Show(respuesta2, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        // Continúa flujo normal (aceptada) sin mostrar error previo
                    }
                    else
                    {
                        // Rechazo por otra causa: flujo original
                        dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                        MessageBox.Show(
                            "Factura Rechazada." + Environment.NewLine +
                            solicitudCAE.Observaciones + Environment.NewLine + solicitudCAE.Error,
                            "Factura " + renglon["cbtDesde"]);
                        break;
                    }
                }

                // =======================
                // 3) ACEPTADA (1er intento o reintento)
                // =======================
                if (solicitudCAE.Observaciones != "")
                    MessageBox.Show(
                        "Factura aceptada con observacones o errores." +
                        Environment.NewLine + solicitudCAE.Observaciones,
                        "Factura " + renglon["cbtDesde"]);

                dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                solicitudesCAEUltraGrid.Update();

                // Guardar con el idTipoDeComprobante actual del renglon (primer intento aprobado)
                int idTipoActual = ResolverIdTipoActualDesdeRenglon(renglon);
                new Service().GuardarCAE(
                    (int)renglon["idComprobante"],
                    solicitudCAE.CAE,
                    solicitudCAE.Vencimiento,
                    solicitudCAE.NumeroDeComprobante,
                    idTipoActual,
                    Program.Pin);

                var nombreArchivo = ProcesarPDF(solicitudCAE, renglon);
                if (nombreArchivo == "PDF no generado.")
                    solicitudCAE.Enviada = "PDF no generado.";
                else
                    ProcesarEmail(renglon, solicitudCAE, nombreArchivo);

                ManejoDatos.AplicarUpdate(dsFacturasSinCAE);
                facturasSinCAEUltraGrid.Refresh();
            }
        }

        // ======== Resolución de idTipoDeComprobante ========
        private static int ResolverIdTipoActualDesdeRenglon(DataRow renglon)
        {
            try
            {
                if (renglon.Table.Columns.Contains("idTipoDeComprobante"))
                    return (int)renglon["idTipoDeComprobante"];
            }
            catch { /* ignore */ }
            return 0; // fallback: el SP puede validar y rechazar 0 si no corresponde
        }

        private static int ResolverIdTipoPorAfip(int afip, DataRow renglon)
        {
            // 1) Si el DataRow ya trae la columna específica (por ejemplo, idTipoMiPyme), úsala
            if (renglon.Table.Columns.Contains("idTipoDeComprobanteMiPyme"))
            {
                try { return (int)renglon["idTipoDeComprobanteMiPyme"]; } catch { }
            }

            int actual = ResolverIdTipoActualDesdeRenglon(renglon);
            return actual != 0 ? actual : 0;
        }

        private void ProcesarEmail(DataRow renglon, WS.DsSolicitudesCAE.SolicitudesCAERow solicitudCAE,
            string nombreArchivo)
        {
            if (ultraCheckEditorEnviar.Checked && !File.Exists("c:\\MiCasa\\Estoy.txt")
            ) // Evita que se mande por correo una prueba hecha en casa.
                try
                {
                    if (renglon["Email"] == DBNull.Value || renglon["Email"].ToString() == "")
                    {
                        solicitudCAE.Enviada = "Sin dirección.";
                    }
                    else
                    {
                        var enviada = new Service().EnviarFactura(Settings.Default.Empresa, renglon["Email"].ToString(),
                            nombreArchivo, Program.Pin);
                        if (enviada)
                        {
                            solicitudCAE.Enviada = string.Format("{0:dd/MM/yyyy HH:mm}",
                                new Service().HoraActual(Program.Pin));
                            new Service().GuardarFacturaEnviada((int)renglon["idComprobante"], Program.Pin);
                        }
                        else
                        {
                            solicitudCAE.Enviada = "Error al enviar.";
                        }
                    }
                }
                catch (Exception)
                {
                    solicitudCAE.Enviada = "Error crítico.";
                }
        }

        private static string ProcesarPDF(WS.DsSolicitudesCAE.SolicitudesCAERow solicitudCAE, DataRow renglon)
        {
            var nombreArchivo = "";
            if (solicitudCAE.Resultado == @"A")
                nombreArchivo = new Service().GetPDF(
                    Settings.Default.Empresa
                    , (int)renglon["tipoDoc"]
                    , renglon["nroDoc"].ToString()
                    , (int)renglon["tipoCbte"]
                    , (int)renglon["puntoVta"]
                    , Convert.ToInt64(solicitudCAE.NumeroDeComprobante)
                    , renglon["impTotal"].ToString()
                    , renglon["impTotConc"].ToString()
                    , renglon["impNeto"].ToString()
                    , renglon["impIVA"].ToString()
                    , renglon["impTrib"].ToString()
                    , renglon["impOpEx"].ToString()
                    , ManejoDatos.FechaConBarras(renglon["fechaCbte"].ToString())
                    , ManejoDatos.FechaConBarras(renglon["fechaVencPago"].ToString())
                    , ManejoDatos.FechaConBarras(renglon["fechaServDesde"].ToString())
                    , ManejoDatos.FechaConBarras(renglon["fechaServHasta"].ToString())
                    , solicitudCAE.CAE
                    , solicitudCAE.Vencimiento
                    , renglon["CategoriaIVA"].ToString()
                    , renglon["NombreCliente"].ToString()
                    , renglon["DireccionCliente"].ToString()
                    , solicitudCAE.Observaciones
                    , renglon["LocalidadCliente"].ToString()
                    , renglon["ProvinciaCliente"].ToString()
                    , renglon["TipoReferencia"].ToString()
                    , renglon["PrefijoReferencia"].ToString()
                    , renglon["NumeroReferencia"].ToString()
                    , renglon["baseImp4"].ToString()
                    , renglon["importeIVA4"].ToString()
                    , renglon["baseImp5"].ToString()
                    , renglon["importeIVA5"].ToString()
                    , (int)renglon["idComprobante"]
                    , solicitudCAE.TipoDeComprobante
                    , solicitudCAE.Prefijo
                    , solicitudCAE.NumeroDeComprobante
                    , Program.Pin
                );
            return nombreArchivo;
        }

        private void FormFacturaElectronica_Load(object sender, System.EventArgs e)
        {
            FormPruebaFacturaElectronica_Load(sender, e);
        }

        // ================== Helpers locales ==================
        private static int MapearAfipMiPyme(int afipActual)
        {
            if (afipActual == 1) return 201; // Factura A → A MiPyME
            if (afipActual == 6) return 204; // Factura B → B MiPyME
            return afipActual;               // Otros: sin cambio
        }

        private static string CalcularVencimientoPagoDefault(string fechaCbteYyyyMMdd, int dias, string fvpOriginal)
        {
            try
            {
                var dt = DateTime.ParseExact(fechaCbteYyyyMMdd, "yyyyMMdd", null).AddDays(dias);
                return dt.ToString("yyyyMMdd");
            }
            catch
            {
                return fvpOriginal;
            }
        }
    }
}
