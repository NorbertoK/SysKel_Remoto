using System;
using Administracion.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administracion
{
    public partial class FormRepEstadisticaCantidadDeAfiliados : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepEstadisticaCantidadDeAfiliados()
        {
            InitializeComponent();
        }

        public string PeriodoDesde { private get; set; }
        public string PeriodoHasta { private get; set; }
        public string Modo { private get; set; }
        public int IdPlan { private get; set; }
        public string Subtitulo { private get; set; }
        public string Contar { private get; set; }

        private void FormRepEstadisticaCantidadDeAfiliadosLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crEstadisticaCantidadDeAfiliados1.DataDefinition.ParameterFields;
            dsRepAfiliadosPorEntidadDeCobranza1.Merge(
                new Service().GetEstadisticaCantidadDeAfiliados(PeriodoDesde, PeriodoHasta, Modo, IdPlan, Contar,
                    Program.Pin));
            crEstadisticaCantidadDeAfiliados1.SetDataSource(dsRepAfiliadosPorEntidadDeCobranza1);
            _crParameterFieldLocation = _crParameterFieldDefinitions["Subtitulo"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Subtitulo};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}