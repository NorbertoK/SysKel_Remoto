using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Dirección.Properties;
using Dirección.WS;

namespace Dirección
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipalLoad(object sender, EventArgs e)
        {
            var empresa = Settings.Default.Empresa == "CEC" ? "C E C" : Settings.Default.Empresa;
            Text = "SysKel" + " - " +
                   empresa + " - Dirección";
            if (Program.IdUsuario != 0)
            {
                var nombreUsuario = new Service().NombreDelUsuario(Program.IdUsuario, Program.Pin);
                if (nombreUsuario.Length != 0)
                    Text = Text + " - " + nombreUsuario;
            }

            // Aquí empieza a cambiar el color del fondo.
            foreach (Control ctl in Controls)
                try
                {
                    var ctlMdi = (MdiClient) ctl;
                    ctlMdi.BackColor = BackColor;
                }
                catch (InvalidCastException)
                {
                }
            dsLicencia.Merge(new Service().GetLicencia(Settings.Default.Empresa, Program.Pin));
            if (dsLicencia.Licencias.Rows.Count == 0)
            {
                Program.TieneLicencia = false;
            }
            else
            {
                Program.TieneLicencia = true;
                Program.VigenciaLicencia =
                    Encriptacion.FechaVigencia(dsLicencia.Licencias.Rows[0]["Licencia"].ToString());
            }
            backgroundWorker1.RunWorkerAsync();
            if (Program.TieneLicencia &&
                (Program.VigenciaLicencia - new Service().HoraActual(Program.Pin)).Days >= 11)
                return;
            var formAbout = new FormAbout {StartPosition = FormStartPosition.CenterScreen};
            formAbout.ShowDialog();
        }

        private void CrearFormularioHijo(Form f)
        {
            // a flag to store if the child form is opened or not
            var found = false;

            // get all of the MDI children in an array
            var charr = MdiChildren;

            if (charr.Length == 0) // no child form is opened
            {
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(0, 0);
                f.Show();
            }
            else // child forms are opened
            {
                foreach (var chform in charr)
                {
                    if (chform.Name != f.Name) continue;
                    chform.Activate();
                    found = true;
                    break; // exit loop
                    // false if the form is not found
                }

                if (found == false)
                {
                    f.MdiParent = this;
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(0, 0);
                    f.Show();
                }
                else
                {
                    f.Close();
                }
            }
        }

        private void AyudaDeCentauroToolStripMenuItemClick(object sender, EventArgs e)
        {
            Process.Start(helpProvider1.HelpNamespace);
        }

        private void FormPrincipalFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length <= 0) return;
            MessageBox.Show("Debe cerrar todas las ventanas.", "El programa no puede terminar.", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void CambiarLaContraseñaToolStripMenuItem1Click(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormCambioDeClave());
        }


        private void RetiroDeValoresToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormRetiro());
        }

        private void ReintegroDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            CrearFormularioHijo(new FormReintegro());
        }


        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Encriptacion.TieneLicenciaVigente()) return;
            dsSistemas.Merge(new Service().GetSistemas(Program.Pin));
            backgroundWorker1.ReportProgress(14);
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            backgroundWorker1.ReportProgress(20);
            dsAutorizacionesDelUsuario.Merge(new Service().GetAutorizacionesDelUsuario(Program.Usu, Program.Pin));
            backgroundWorker1.ReportProgress(23);
            dsUsuariosLista.Merge(new Service().GetUsuariosLista(Program.Pin));
            backgroundWorker1.ReportProgress(24);
        }

        private void BackgroundWorker1ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Comienzan las autorizaciones a los menúes.
            menuStrip1.Refresh();
            labelEspere.Visible = false;
            progressBar1.Visible = false;
            menuStrip1.Enabled = true;
        }

        private void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var f = new FormAbout {StartPosition = FormStartPosition.CenterScreen};
            f.ShowDialog();
        }
    }
}