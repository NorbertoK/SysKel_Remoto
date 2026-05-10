using System.ComponentModel;

namespace AdministracionNegocios
{
    public partial class CmpRepRenglonesAFacturar : Component
    {
        public CmpRepRenglonesAFacturar()
        {
            InitializeComponent();
        }

        public DsRepRenglonesAFacturar GetRenglonesAFacturar()
        {
            var ret = new DsRepRenglonesAFacturar();
            renglonesARevisarTableAdapter1.Fill(ret.RenglonesAFacturar);
            return ret;
        }
    }
}