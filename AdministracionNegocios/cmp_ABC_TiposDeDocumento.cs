using System.ComponentModel;

namespace AdministracionNegocios
{
    public partial class CmpABCTiposDeDocumento : Component
    {
        public CmpABCTiposDeDocumento()
        {
            InitializeComponent();
        }

        public DsTiposDeDocumento GetTiposDeDocumento()
        {
            var ret = new DsTiposDeDocumento();
            tiposDeDocumentoTableAdapter1.Fill(ret.TiposDeDocumento);
            return ret;
        }

        public DsTiposDeDocumento UpdateTiposDeDocumento(DsTiposDeDocumento tipos)
        {
            try
            {
                tiposDeDocumentoTableAdapter1.Update(tipos.TiposDeDocumento);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}