using System.ComponentModel;

namespace AdministracionNegocios
{
    public partial class CmpPrincipal : Component
    {
        public CmpPrincipal()
        {
            InitializeComponent();
        }

        public DsAutorizacionesDelUsuario GetAutorizacionesDelUsuario(string usuario)
        {
            var ret = new DsAutorizacionesDelUsuario();
            autorizacionesDelUsuarioTableAdapter1.Fill(ret.AutorizacionesDelUsuario, usuario);
            return ret;
        }
    }
}