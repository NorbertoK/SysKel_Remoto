using System;
using Administracion.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administracion
{
    public partial class FormRepListadoAfiliadosDeBaja : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepListadoAfiliadosDeBaja()
        {
            InitializeComponent();
        }

        public string Desde { private get; set; }
        public string Hasta { private get; set; }
        public string Modo { private get; set; }
        public int IdPlan { private get; set; }
        public string Titulo { private get; set; }

        private void FormRepListadoAfiliadosDeBaja_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_ListadoAfiliadosDeBaja1.DataDefinition.ParameterFields;
            dsListadoAfiliadosDeBaja1.Merge(
                new Service().GetAfiliadosDeBaja(Desde, Hasta, Modo, IdPlan,
                    Program.Pin));
            CR_ListadoAfiliadosDeBaja1.SetDataSource(dsListadoAfiliadosDeBaja1);
            _crParameterFieldLocation = _crParameterFieldDefinitions["Titulo"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Titulo};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}