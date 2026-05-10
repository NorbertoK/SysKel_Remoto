using System.ComponentModel;

namespace AdministracionNegocios
{
    public partial class CmpABCCategoriasIva : Component
    {
        public CmpABCCategoriasIva()
        {
            InitializeComponent();
        }

        public DsCategoriasIVA GetCategoriasIVA()
        {
            var ret = new DsCategoriasIVA();
            categoriasIVATableAdapter.Fill(ret.CategoriasIVA);
            return ret;
        }

        public DsCategoriasIVA UpdateCategoriasIva(DsCategoriasIVA dsCategoriasIva)
        {
            try
            {
                categoriasIVATableAdapter.Update(dsCategoriasIva.CategoriasIVA);
            }
            catch
            {
                return null;
            }
            return dsCategoriasIva;
        }
    }
}