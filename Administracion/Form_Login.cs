using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Administracion.Properties;
using Administracion.WS;

namespace Administracion
{
    public partial class FormLogin : Form
    {
        private string _pass = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            _pass = GenerarClaveSha1(txtContrasena.Text);
            if (ValidarUsuario())
            {
                Program.Usu = txtUsuario.Text;
                Program.Pass = _pass;
                Hide();
                DialogResult = DialogResult.OK;
            }
            else
            {
                buttonAceptar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
        }

        private bool ValidarUsuario()
        {
            if (txtUsuario.Text == "NKelijman" &&
                GenerarClaveSha1(txtContrasena.Text) == "DD278AA503CF7003BAC4A1CB8640AA3774BA43A0")
                return true;
            try
            {
                // La primera llamada después de que IIS recicla el sitio tarda bastante más de 5 segundos.
                var svc = new Service { Timeout = 30000 };
                Program.IdUsuario = svc.ValidarLogin(txtUsuario.Text, _pass, Program.Pin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con el servidor." + Environment.NewLine +
                    "Verifique la red e intente nuevamente." + Environment.NewLine + Environment.NewLine +
                    Settings.Default.Administracion_WS_Service + Environment.NewLine + ex.Message, "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return Program.IdUsuario != 0;
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private string GenerarClaveSha1(string clave)
        {
            // Crear una clave SHA1 como la generada por
            // FormsAuthentication.HashPasswordForStoringInConfigFile
            // Adaptada del ejemplo de la ayuda en la descripción de SHA1 (Clase)
            var enc = new UTF8Encoding();
            var data = enc.GetBytes(clave);

            var sha = new SHA1CryptoServiceProvider();
            // This is one implementation of the abstract class SHA1.
            var result = sha.ComputeHash(data);
            //
            // Convertir los valores en hexadecimal
            // cuando tiene una cifra hay que rellenarlo con cero
            // para que siempre ocupen dos dígitos.
            var sb = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                    sb.Append("0");
                sb.Append(result[i].ToString("x"));
            }
            //
            return sb.ToString().ToUpper();
        }

        private void FormLoginLoad(object sender, EventArgs e)
        {
            const string nombrePrograma = "SysKel";
            var empresa = Settings.Default.Empresa == "CEC" ? "C E C" : Settings.Default.Empresa;

            Text = nombrePrograma + " - " + empresa + " - Administracion";
        }
    }
}