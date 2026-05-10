using System.ComponentModel;

namespace AdministracionNegocios
{
    public partial class CmpRepAfiliadosPorEntidadDeCobranza : Component
    {
        public CmpRepAfiliadosPorEntidadDeCobranza()
        {
            InitializeComponent();
        }

        public DsRepAfiliadosPorEntidadDeCobranza GetAfiliadosPorEntidadDeCobranza(int id, bool soloAfiliados)
        {
            var ret = new DsRepAfiliadosPorEntidadDeCobranza();
            afiliadosPorEntidadDeCobranzaTableAdapter1.SetTimeOut();
            afiliadosPorEntidadDeCobranzaTableAdapter1.Fill(ret.AfiliadosPorEntidadDeCobranza, id, soloAfiliados);
            return ret;
        }

        public DsRepListadoFacturadoPorEntidad GetListadoFacturadoPorEntidad(int idEntidadDeCobranza, string periodo)
        {
            var ret = new DsRepListadoFacturadoPorEntidad();
            listadoFacturadoPorEntidadDeCobranzaTableAdapter1.Fill(ret.ListadoFacturadoPorEntidadDeCobranza,
                idEntidadDeCobranza, periodo);
            return ret;
        }
    }
}