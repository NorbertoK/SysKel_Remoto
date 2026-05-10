using System.ComponentModel;

namespace AdministracionNegocios
{
    public partial class CmpCabABCMotivosDeCancelacionPrestacion : Component
    {
        public CmpCabABCMotivosDeCancelacionPrestacion()
        {
            InitializeComponent();
        }

        public DsMotivosDeCancelacionPrestacion GetMotivosDeCancelacionPrestacion()
        {
            var ret = new DsMotivosDeCancelacionPrestacion();
            motivosDeCancelacionPrestacionTableAdapter1.Fill(ret.MotivosDeCancelacionPrestacion);
            return ret;
        }

        public DsMotivosDeCancelacionPrestacion UpdateMotivosDeCancelacionPrestacion(
            DsMotivosDeCancelacionPrestacion moti)
        {
            try
            {
                motivosDeCancelacionPrestacionTableAdapter1.Update(moti.MotivosDeCancelacionPrestacion);
            }
            catch
            {
                return null;
            }
            return moti;
        }
    }
}