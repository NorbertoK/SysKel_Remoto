using System;
using Administracion.Properties;
using Administracion.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administracion
{
    public partial class FormRepIVACompras : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private DateTime _desde = new Service().HoraActual(Program.Pin);
        private DateTime _hasta = new Service().HoraActual(Program.Pin);

        public FormRepIVACompras()
        {
            InitializeComponent();
        }

        public DateTime Desde
        {
            private get { return _desde; }
            set { _desde = value; }
        }

        public DateTime Hasta
        {
            private get { return _hasta; }
            set { _hasta = value; }
        }

        private void FormRepIVACompras_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_IVACompras1.DataDefinition.ParameterFields;
            dsIVACompras1.Merge(new Service().GetIVACompras(Desde.ToString("yyyyMMdd"),
                Hasta.ToString("yyyyMMdd"),
                Program.Pin));
            CR_IVACompras1.SetDataSource(dsIVACompras1);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Desde"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Desde};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Hasta"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Hasta};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Empresa"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Settings.Default.Empresa};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}