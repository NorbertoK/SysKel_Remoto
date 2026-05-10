using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormDespacho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PrestacionesResumen", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn267 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn268 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn269 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance294 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn270 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn271 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn272 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.Appearance appearance295 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn273 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Recurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn274 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.Appearance appearance296 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn275 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn276 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn277 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Agendada");
            Infragistics.Win.Appearance appearance297 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance298 = new Infragistics.Win.Appearance();
            Infragistics.Win.ConditionValueAppearance conditionValueAppearance1 = new Infragistics.Win.ConditionValueAppearance(new Infragistics.Win.ICondition[] {
            ((Infragistics.Win.ICondition)(new Infragistics.Win.FormulaCondition("[AlertaProgramadaNoSalio] = 1"))),
            ((Infragistics.Win.ICondition)(new Infragistics.Win.FormulaCondition("[AlertaProgramadaNoSalio] = 0")))}, new Infragistics.Win.Appearance[] {
            appearance297,
            appearance298});
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn278 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlertaProgramadaNoSalio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn279 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsAgendada", 0);
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDespacho));
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prestaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn280 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn281 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance299 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn282 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tomada");
            Infragistics.Win.Appearance appearance300 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn283 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTomador", -1, "ultraDropDownTomadores");
            Infragistics.Win.Appearance appearance301 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn284 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeCancelacion", -1, "ultraDropDownMotivosCancelacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn285 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionesTomador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn286 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono");
            Infragistics.Win.Appearance appearance302 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn287 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VistaPorElDespachador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn288 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Agendada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn289 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Terminada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn290 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo", -1, "ultraDropDownCodigos");
            Infragistics.Win.Appearance appearance303 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn291 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", 0);
            Infragistics.Win.Appearance appearance304 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn292 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Imprimir", 1);
            Infragistics.Win.Appearance appearance305 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance306 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance212 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand27 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Medicamentos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn473 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn474 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn475 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn476 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn477 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidades");
            Infragistics.Win.Appearance appearance213 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance214 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance215 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance216 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance217 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance218 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance219 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance220 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance221 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance222 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand28 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Diagnosticos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn478 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn479 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn480 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance223 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance224 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance225 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance226 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance227 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance228 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance229 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance230 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance231 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance202 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand26 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeLlamado", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn469 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn470 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn471 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaDespacho");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn472 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaMasInfo");
            Infragistics.Win.Appearance appearance203 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance204 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance205 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance206 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance207 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance208 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance209 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance210 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance211 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand25 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn466 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn467 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn468 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance193 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance194 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance195 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance196 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance197 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance198 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance199 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance200 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance201 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand24 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Practicas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn464 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn465 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand22 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Coberturas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn445 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn446 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand23 = new Infragistics.Win.UltraWinGrid.UltraGridBand("RecursosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn447 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRecurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn448 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn449 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn450 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn451 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn452 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn453 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn454 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn455 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn456 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn457 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn458 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn459 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn460 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tripulacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn461 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestinoRecurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn462 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Salidas");
            Infragistics.Win.Appearance appearance332 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn463 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Kolor", 0);
            Infragistics.Win.Appearance appearance333 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn334 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn335 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn336 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance262 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand32 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn491 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn492 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn493 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn494 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance263 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance264 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance265 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance266 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance267 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance268 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance269 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance270 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance271 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand31 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Localidades", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn489 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn490 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance255 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance256 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance257 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance258 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance259 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance260 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance261 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance272 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand33 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Lugares", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn495 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn496 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn497 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn498 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocaldad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn499 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn500 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand34 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn501 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn502 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn503 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn504 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn505 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn506 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn507 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn508 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn509 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn510 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn511 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn512 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn513 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Direcciones1");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand35 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Direcciones1", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn514 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn515 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn516 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn517 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn518 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand36 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn519 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn520 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn521 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn522 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn523 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn524 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn525 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Cotactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand37 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Cotactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn526 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn527 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn528 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn529 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn530 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance273 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance274 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance275 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance276 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance277 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance278 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance279 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance280 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance281 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance242 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand30 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeCancelacionPrestacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn487 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeCancelacionPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn488 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance243 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance244 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand21 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDestino", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn442 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn443 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn444 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPacienteABordo");
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Destinos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn293 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn294 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn295 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraSolicitada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn296 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar", -1, "ultraDropDownLugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn297 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino", -1, "ultraDropDownTiposDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn298 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.Appearance appearance307 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn299 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Destinos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn300 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_DestinosRecursos_Destinos");
            Infragistics.Win.Appearance appearance308 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Destinos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn301 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn302 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn303 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn304 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn305 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn306 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn307 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn308 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn309 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn310 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn311 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn312 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.Appearance appearance309 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_DestinosRecursos_Destinos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn313 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestinoRecurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn314 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn315 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRecurso", -1, "ultraDropDownRecursosActivos");
            Infragistics.Win.Appearance appearance310 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn316 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.Appearance appearance311 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn317 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn318 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente", -1, "ultraDropDownPacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn319 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn320 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn321 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn322 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn323 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn324 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn325 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Asignado");
            Infragistics.Win.Appearance appearance312 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn326 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida");
            Infragistics.Win.Appearance appearance313 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn327 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Llegada");
            Infragistics.Win.Appearance appearance314 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn328 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Terminado");
            Infragistics.Win.Appearance appearance315 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn329 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cancelado");
            Infragistics.Win.Appearance appearance316 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn330 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn331 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugarDeSalida", -1, "ultraDropDownLugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn332 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OtroLugarDeSalida");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn333 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDespachador", -1, "ultraDropDownDespachador");
            Infragistics.Win.Appearance appearance317 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance318 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn337 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn338 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn339 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn340 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn341 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn342 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Pacientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn343 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn344 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn345 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn346 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn347 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn348 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EdadEn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn349 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn350 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn351 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAfiliadoPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn352 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenteExterno");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn353 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn354 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn355 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn356 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Antecedentes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn357 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn358 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn359 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DatosCompletos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn360 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtraCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn361 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn362 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn363 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Evolución");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn364 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CondicionesContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn365 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__MotivosPacientes__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn366 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Diagnosticos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn367 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Medicamentos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__MotivosPacientes__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn368 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn369 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn370 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn371 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Diagnosticos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn372 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn373 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn374 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Medicamentos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn375 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentosPacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn376 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn377 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn378 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn379 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn380 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn381 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion1 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion2 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(-7);
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEmpleado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ApelNomb");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombApel");
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn382 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn383 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn384 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn385 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn386 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn387 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn388 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn389 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Pacientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn390 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn391 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn392 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn393 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn394 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.Appearance appearance319 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn395 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EdadEn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn396 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn397 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn398 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAfiliadoPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn399 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenteExterno");
            Infragistics.Win.Appearance appearance320 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn400 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura", -1, "ultraDropDownCoberturas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn401 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica", -1, "ultraDropDownPracticas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn402 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance321 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn403 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Antecedentes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn404 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato", -1, "ultraDropDownContratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn405 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico", -1, "ultraDropDownMedicos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn406 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DatosCompletos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn407 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtraCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn408 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento", -1, "ultraDropDownTiposDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn409 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.Appearance appearance322 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn410 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Evolución");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn411 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CondicionesContrato", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn412 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__MotivosPacientes__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn413 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Diagnosticos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn414 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Medicamentos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn415 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BuscarAfiliado", 0);
            Infragistics.Win.Appearance appearance323 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn416 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsAfiliado", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn417 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AtencionesAnteriores", 2);
            Infragistics.Win.Appearance appearance324 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn418 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Planes", 3);
            Infragistics.Win.Appearance appearance325 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn419 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato", 4);
            Infragistics.Win.Appearance appearance326 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance327 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout1 = new Infragistics.Win.UltraWinGrid.RowLayout("Paciente");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo1 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo2 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPrestacion", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo3 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idAfiliado", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo4 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Nombre", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo5 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Edad", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo6 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "EdadEn", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo7 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Sexo", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo8 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPrepago", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo9 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NroAfiliadoPrepago", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo10 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenteExterno", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo11 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idCobertura", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo12 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPractica", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo13 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Importe", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo14 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Antecedentes", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo15 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idContrato", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo16 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idMedico", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo17 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DatosCompletos", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo18 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ExtraCobertura", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo19 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idTipoDeDocumento", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo20 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NumeroDeDocumento", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo21 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Evolución", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo22 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CondicionesContrato", -1, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo23 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FK__MotivosPacientes__Pacientes", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo24 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FK__Diagnosticos__Pacientes", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo25 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FK__Medicamentos__Pacientes", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo26 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "BuscarAfiliado", 0, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo27 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "EsAfiliado", 1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo28 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "AtencionesAnteriores", 2, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo29 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Planes", 3, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo30 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Contrato", 4, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__MotivosPacientes__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn420 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn421 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado", -1, "ultraDropDownMotivos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn422 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn423 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.Appearance appearance328 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout2 = new Infragistics.Win.UltraWinGrid.RowLayout("Motivos");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo31 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idMotivoPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo32 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idMotivoDeLlamado", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo33 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo34 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Observaciones", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Diagnosticos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn424 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn425 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico", -1, "ultraDropDownDiagnosticos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn426 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.Appearance appearance329 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout3 = new Infragistics.Win.UltraWinGrid.RowLayout("Diagnosticos");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo35 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idDiagnosticoPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo36 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idDiagnostico", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo37 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand18 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Medicamentos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn427 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentosPacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn428 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento", -1, "ultraDropDownMedicamentos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn429 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn430 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance330 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn431 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad", 0);
            Infragistics.Win.Appearance appearance331 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand19 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Contratos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn432 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn433 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Condiciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn434 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn435 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn436 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Planes_Contratos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand20 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Planes_Contratos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn437 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn438 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn439 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn440 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn441 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance232 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand29 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn481 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn482 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn483 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn484 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn485 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn486 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance233 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance234 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance235 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance236 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance237 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance238 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance239 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance240 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance241 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.Appearance appearance282 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand38 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn531 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn532 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance283 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance284 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance285 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance286 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance287 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance288 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance289 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance290 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance291 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance292 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance293 = new Infragistics.Win.Appearance();
            this.prestacionesResumenUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.prestacionesResumenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrestacionesResumen = new Cabina.WS.DsPrestacionesResumen();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.prestacionesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.prestacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrestacion = new Cabina.WS.DsPrestacion();
            this.ultraDropDownMedicamentos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMedicamentos = new Cabina.WS.DsMedicamentos();
            this.ultraDropDownDiagnosticos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDiagnosticos = new Cabina.WS.DsDiagnosticos();
            this.ultraDropDownMotivos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeLlamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeLlamado = new Cabina.WS.DsMotivosDeLlamado();
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrepagos = new Cabina.WS.DsPrepagos();
            this.ultraDropDownPracticas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPracticas = new Cabina.WS.DsPracticas();
            this.ultraDropDownCoberturas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.coberturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCoberturas = new Cabina.WS.DsCoberturas();
            this.ultraDropDownRecursosActivos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.recursosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecursosLista = new Cabina.WS.DsRecursosLista();
            this.ultraDropDownBarrio = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Cabina.WS.DsBarrios();
            this.ultraDropDownCalles = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Cabina.WS.DsCallesLista();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidades1 = new Cabina.WS.DsLocalidades();
            this.ultraDropDownLugares = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.lugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLugares = new Cabina.WS.DsLugares();
            this.ultraDropDownMotivosCancelacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeCancelacionPrestacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeCancelacionPrestacion = new Cabina.WS.DsMotivosDeCancelacionPrestacion();
            this.ultraDropDownTiposDeDestino = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDestino = new Cabina.WS.DsTiposDeDestino();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelEstadoGeneral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.destinosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.destinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDestinos = new Cabina.WS.DsDestinos();
            this.ultraDropDownDespachador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista = new Cabina.WS.DsUsuariosLista();
            this.ultraDropDownPacientes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPacientesPrestacion = new Cabina.WS.DsPacientesPrestacion();
            this.ultraDropDownMedicos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDataSourceMedicos = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownTiposDeDocumento = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDocumento = new Cabina.WS.DsTiposDeDocumento();
            this.ultraDropDownCodigos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodigos = new Cabina.WS.DsCodigos();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pacientesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownContratos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Cabina.WS.DsContratosLista();
            this.ultraDropDownTomadores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.buttonAgregarPaciente = new System.Windows.Forms.Button();
            this.buttonReferenciaColores = new System.Windows.Forms.Button();
            this.dsBuscarAfiliados = new Cabina.WS.DsBuscarAfiliados();
            this.buscarAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDireccionLugar1 = new Cabina.WS.DsDireccionLugar();
            this.dsCabBuscarTelefono = new Cabina.WS.DsCabBuscarTelefono();
            this.dsBuscarTelefono = new Cabina.WS.DsBuscarTelefono();
            this.dsSistemas1 = new Cabina.WS.DsSistemas();
            this.dsMedicos = new Cabina.WS.DsEmpleadosLista();
            this.dsDestinosOtro = new Cabina.WS.DsDestinos();
            this.buttonCerrarPrestacion = new System.Windows.Forms.Button();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDataSourceVerAgendadas = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraComboVerAgendadas = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.dsParametros = new Cabina.WS.DsParametros();
            this.parametrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacionesResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRecursosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecursosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosCancelacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDespachador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionLugar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabBuscarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinosOtro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceVerAgendadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboVerAgendadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(811, 12);
            this.buttonAceptar.Text = "Grabar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Enabled = true;
            this.buttonAplicar.Location = new System.Drawing.Point(892, 12);
            this.buttonAplicar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAgregarPaciente);
            this.panel1.Controls.Add(this.buttonReferenciaColores);
            this.panel1.Controls.Add(this.ultraComboVerAgendadas);
            this.panel1.Controls.Add(this.ultraLabel1);
            this.panel1.Controls.Add(this.buttonCerrarPrestacion);
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Size = new System.Drawing.Size(984, 42);
            this.panel1.Controls.SetChildIndex(this.buttonCerrarPrestacion, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.panel1.Controls.SetChildIndex(this.ultraComboVerAgendadas, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonReferenciaColores, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAgregarPaciente, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(504, 12);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
            // 
            // prestacionesResumenUltraGrid
            // 
            this.prestacionesResumenUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prestacionesResumenUltraGrid.CalcManager = this.ultraCalcManager1;
            this.prestacionesResumenUltraGrid.DataSource = this.prestacionesResumenBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.prestacionesResumenUltraGrid.DisplayLayout.Appearance = appearance1;
            this.prestacionesResumenUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn267.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn267.Header.VisiblePosition = 0;
            ultraGridColumn267.Hidden = true;
            ultraGridColumn267.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time;
            ultraGridColumn267.Width = 50;
            ultraGridColumn268.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn268.Header.VisiblePosition = 1;
            ultraGridColumn268.Hidden = true;
            ultraGridColumn268.Width = 46;
            ultraGridColumn269.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance294.ForeColor = System.Drawing.SystemColors.Window;
            ultraGridColumn269.CellAppearance = appearance294;
            ultraGridColumn269.Header.Caption = "";
            ultraGridColumn269.Header.VisiblePosition = 10;
            ultraGridColumn269.LockedWidth = true;
            ultraGridColumn269.MaxWidth = 15;
            ultraGridColumn269.MinWidth = 15;
            ultraGridColumn269.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(16, 0);
            ultraGridColumn269.Width = 15;
            ultraGridColumn270.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn270.Header.Caption = "Dirección";
            ultraGridColumn270.Header.VisiblePosition = 8;
            ultraGridColumn270.Width = 200;
            ultraGridColumn271.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn271.Header.VisiblePosition = 5;
            ultraGridColumn271.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(187, 0);
            ultraGridColumn271.Width = 177;
            ultraGridColumn272.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance295.TextHAlignAsString = "Right";
            ultraGridColumn272.CellAppearance = appearance295;
            ultraGridColumn272.Header.VisiblePosition = 6;
            ultraGridColumn272.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(59, 0);
            ultraGridColumn272.Width = 62;
            ultraGridColumn273.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn273.Header.VisiblePosition = 9;
            ultraGridColumn273.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(87, 0);
            ultraGridColumn273.Width = 75;
            ultraGridColumn274.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance296.ForeColor = System.Drawing.SystemColors.Window;
            ultraGridColumn274.CellAppearance = appearance296;
            ultraGridColumn274.Header.Caption = "";
            ultraGridColumn274.Header.VisiblePosition = 2;
            ultraGridColumn274.LockedWidth = true;
            ultraGridColumn274.MaxWidth = 15;
            ultraGridColumn274.MinWidth = 15;
            ultraGridColumn274.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(22, 0);
            ultraGridColumn274.Width = 15;
            ultraGridColumn275.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn275.Header.Caption = "Motivos de Llamado";
            ultraGridColumn275.Header.VisiblePosition = 7;
            ultraGridColumn275.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(213, 0);
            ultraGridColumn275.Width = 283;
            ultraGridColumn276.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn276.Header.Caption = "Tiempo";
            ultraGridColumn276.Header.VisiblePosition = 3;
            ultraGridColumn276.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn276.MaskInput = "hh:mm:ss";
            ultraGridColumn276.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(62, 0);
            ultraGridColumn276.Width = 56;
            ultraGridColumn277.Format = "dd/MM/yyyy HH:mm";
            ultraGridColumn277.Header.VisiblePosition = 4;
            ultraGridColumn277.MaskInput = "";
            ultraGridColumn277.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            appearance297.BackColor = System.Drawing.Color.Yellow;
            appearance297.BackColor2 = System.Drawing.Color.Yellow;
            ultraGridColumn277.ValueBasedAppearance = conditionValueAppearance1;
            ultraGridColumn277.Width = 86;
            ultraGridColumn278.Header.VisiblePosition = 11;
            ultraGridColumn278.Hidden = true;
            ultraGridColumn279.DataType = typeof(bool);
            ultraGridColumn279.Formula = "if(isdbnull( [Agendada] ) &  [AlertaProgramadaNoSalio] = 0, 0 , 1 )";
            ultraGridColumn279.Header.VisiblePosition = 12;
            ultraGridColumn279.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn267,
            ultraGridColumn268,
            ultraGridColumn269,
            ultraGridColumn270,
            ultraGridColumn271,
            ultraGridColumn272,
            ultraGridColumn273,
            ultraGridColumn274,
            ultraGridColumn275,
            ultraGridColumn276,
            ultraGridColumn277,
            ultraGridColumn278,
            ultraGridColumn279});
            ultraGridBand1.Header.Enabled = false;
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.prestacionesResumenUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.prestacionesResumenUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.prestacionesResumenUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.prestacionesResumenUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance8;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance9.BackColor = System.Drawing.Color.Transparent;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.CellAppearance = appearance10;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance11;
            appearance12.ForeColor = System.Drawing.Color.Red;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance12;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance13;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            appearance15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance15;
            this.prestacionesResumenUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prestacionesResumenUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.prestacionesResumenUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.prestacionesResumenUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.prestacionesResumenUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestacionesResumenUltraGrid.ImageList = this.imageList1;
            this.prestacionesResumenUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.prestacionesResumenUltraGrid.Name = "prestacionesResumenUltraGrid";
            this.prestacionesResumenUltraGrid.Size = new System.Drawing.Size(977, 181);
            this.prestacionesResumenUltraGrid.TabIndex = 6;
            this.prestacionesResumenUltraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.PrestacionesResumenUltraGridInitializeLayout);
            this.prestacionesResumenUltraGrid.AfterRowActivate += new System.EventHandler(this.PrestacionesResumenUltraGridAfterRowActivate);
            this.prestacionesResumenUltraGrid.AfterSortChange += new Infragistics.Win.UltraWinGrid.BandEventHandler(this.PrestacionesResumenUltraGridAfterSortChange);
            this.prestacionesResumenUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prestacionesResumenUltraGrid_KeyDown);
            this.prestacionesResumenUltraGrid.MouseEnter += new System.EventHandler(this.PrestacionesResumenUltraGridMouseEnter);
            this.prestacionesResumenUltraGrid.MouseLeave += new System.EventHandler(this.PrestacionesResumenUltraGridMouseLeave);
            this.prestacionesResumenUltraGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrestacionesResumenUltraGridMouseUp);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // prestacionesResumenBindingSource
            // 
            this.prestacionesResumenBindingSource.DataMember = "PrestacionesResumen";
            this.prestacionesResumenBindingSource.DataSource = this.dsPrestacionesResumen;
            // 
            // dsPrestacionesResumen
            // 
            this.dsPrestacionesResumen.DataSetName = "DsPrestacionesResumen";
            this.dsPrestacionesResumen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            // 
            // prestacionesUltraGrid
            // 
            this.prestacionesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prestacionesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.prestacionesUltraGrid.DataSource = this.prestacionesBindingSource1;
            this.prestacionesUltraGrid.DisplayLayout.AddNewBox.Prompt = "Agregar...";
            this.prestacionesUltraGrid.DisplayLayout.AddNewBox.Style = Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.prestacionesUltraGrid.DisplayLayout.Appearance = appearance16;
            this.prestacionesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn280.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn280.Header.VisiblePosition = 0;
            ultraGridColumn280.Hidden = true;
            ultraGridColumn280.Width = 29;
            ultraGridColumn281.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn281.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance299.TextHAlignAsString = "Center";
            ultraGridColumn281.CellAppearance = appearance299;
            ultraGridColumn281.Header.Caption = "Prestación";
            ultraGridColumn281.Header.VisiblePosition = 5;
            ultraGridColumn281.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn281.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn281.MaskInput = "{LOC}nn,nnn,nnn";
            ultraGridColumn281.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn281.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn281.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn281.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(64, 0);
            ultraGridColumn281.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn281.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn281.Width = 48;
            ultraGridColumn282.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn282.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance300.TextHAlignAsString = "Center";
            ultraGridColumn282.CellAppearance = appearance300;
            ultraGridColumn282.Header.VisiblePosition = 1;
            ultraGridColumn282.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn282.MaskInput = "{date} hh:mm";
            ultraGridColumn282.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn282.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn282.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(97, 0);
            ultraGridColumn282.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(97, 0);
            ultraGridColumn282.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn282.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn282.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime;
            ultraGridColumn282.Width = 43;
            ultraGridColumn283.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn283.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance301.TextHAlignAsString = "Center";
            ultraGridColumn283.CellAppearance = appearance301;
            ultraGridColumn283.Header.Caption = "Tomador";
            ultraGridColumn283.Header.VisiblePosition = 2;
            ultraGridColumn283.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn283.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn283.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(110, 0);
            ultraGridColumn283.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(110, 0);
            ultraGridColumn283.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn283.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn283.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn283.Width = 34;
            ultraGridColumn284.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn284.Header.Caption = "Motivo Cancelación";
            ultraGridColumn284.Header.VisiblePosition = 3;
            ultraGridColumn284.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn284.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn284.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn284.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn284.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn284.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn284.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn284.Width = 75;
            ultraGridColumn285.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn285.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn285.Header.Caption = "Observaciones";
            ultraGridColumn285.Header.VisiblePosition = 4;
            ultraGridColumn285.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn285.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn285.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(129, 0);
            ultraGridColumn285.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(129, 0);
            ultraGridColumn285.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn285.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn285.VertScrollBar = true;
            ultraGridColumn285.Width = 70;
            ultraGridColumn286.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance302.TextHAlignAsString = "Center";
            ultraGridColumn286.CellAppearance = appearance302;
            ultraGridColumn286.Header.Caption = "Teléfono";
            ultraGridColumn286.Header.VisiblePosition = 6;
            ultraGridColumn286.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn286.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn286.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 0);
            ultraGridColumn286.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(76, 0);
            ultraGridColumn286.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn286.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn286.Width = 38;
            ultraGridColumn287.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn287.Header.VisiblePosition = 8;
            ultraGridColumn287.Hidden = true;
            ultraGridColumn288.Header.VisiblePosition = 7;
            ultraGridColumn288.MaskInput = "{date} hh:mm";
            ultraGridColumn288.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn288.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn288.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(85, 0);
            ultraGridColumn288.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(85, 0);
            ultraGridColumn288.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn288.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn289.Header.VisiblePosition = 9;
            ultraGridColumn289.Hidden = true;
            ultraGridColumn290.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance303.TextHAlignAsString = "Center";
            ultraGridColumn290.Header.Appearance = appearance303;
            ultraGridColumn290.Header.Caption = "Código";
            ultraGridColumn290.Header.VisiblePosition = 10;
            ultraGridColumn290.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn290.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn290.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn290.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(64, 0);
            ultraGridColumn290.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn290.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn290.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn291.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn291.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance304.TextHAlignAsString = "Right";
            ultraGridColumn291.CellAppearance = appearance304;
            ultraGridColumn291.Formula = "if(sum([//pacientesUltraGrid/Pacientes/Importe])=0 ,\"\",\"$ \" & fixed( sum([//pacie" +
    "ntesUltraGrid/Pacientes/Importe]) , 2 , \"FALSE\" ))";
            ultraGridColumn291.Header.VisiblePosition = 11;
            ultraGridColumn291.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn291.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn291.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn291.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn291.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn291.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn292.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance305.TextHAlignAsString = "Center";
            ultraGridColumn292.CellAppearance = appearance305;
            ultraGridColumn292.Header.Caption = "";
            ultraGridColumn292.Header.VisiblePosition = 12;
            ultraGridColumn292.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn292.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn292.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn292.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(53, 0);
            ultraGridColumn292.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn292.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn292.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn280,
            ultraGridColumn281,
            ultraGridColumn282,
            ultraGridColumn283,
            ultraGridColumn284,
            ultraGridColumn285,
            ultraGridColumn286,
            ultraGridColumn287,
            ultraGridColumn288,
            ultraGridColumn289,
            ultraGridColumn290,
            ultraGridColumn291,
            ultraGridColumn292});
            appearance306.FontData.BoldAsString = "True";
            appearance306.FontData.SizeInPoints = 11F;
            appearance306.ImageHAlign = Infragistics.Win.HAlign.Left;
            appearance306.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance306;
            ultraGridBand2.Header.Caption = "Prestación";
            ultraGridBand2.MaxRows = 1;
            ultraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand2.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.prestacionesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.prestacionesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.prestacionesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.prestacionesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            this.prestacionesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance26.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prestacionesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance26;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance27.BackColor = System.Drawing.Color.Transparent;
            this.prestacionesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.Control;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesUltraGrid.DisplayLayout.Override.CellAppearance = appearance28;
            this.prestacionesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance29.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.prestacionesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance29;
            this.prestacionesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance30.ForeColor = System.Drawing.Color.Red;
            this.prestacionesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance30;
            this.prestacionesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.prestacionesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance31;
            appearance32.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance32.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.prestacionesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance33;
            this.prestacionesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prestacionesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.prestacionesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.prestacionesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.prestacionesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestacionesUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.prestacionesUltraGrid.Name = "prestacionesUltraGrid";
            this.prestacionesUltraGrid.Size = new System.Drawing.Size(971, 40);
            this.prestacionesUltraGrid.TabIndex = 6;
            this.prestacionesUltraGrid.AfterCellActivate += new System.EventHandler(this.PrestacionesUltraGridAfterCellActivate);
            this.prestacionesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.PrestacionesUltraGridInitializeRow);
            this.prestacionesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.prestacionesUltraGrid_AfterEnterEditMode);
            this.prestacionesUltraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PrestacionesUltraGridClickCellButton);
            this.prestacionesUltraGrid.AfterCellListCloseUp += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PrestacionesUltraGridAfterCellListCloseUp);
            // 
            // prestacionesBindingSource1
            // 
            this.prestacionesBindingSource1.DataMember = "Prestaciones";
            this.prestacionesBindingSource1.DataSource = this.dsPrestacion;
            // 
            // dsPrestacion
            // 
            this.dsPrestacion.DataSetName = "DsPrestacion";
            this.dsPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMedicamentos
            // 
            this.ultraDropDownMedicamentos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMedicamentos.DataSource = this.medicamentosBindingSource;
            appearance212.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance212.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMedicamentos.DisplayLayout.Appearance = appearance212;
            ultraGridBand27.ColHeadersVisible = false;
            ultraGridColumn473.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn473.Header.VisiblePosition = 0;
            ultraGridColumn473.Hidden = true;
            ultraGridColumn473.Width = 37;
            ultraGridColumn474.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn474.Header.VisiblePosition = 1;
            ultraGridColumn474.Width = 219;
            ultraGridColumn475.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn475.Header.VisiblePosition = 2;
            ultraGridColumn475.Hidden = true;
            ultraGridColumn475.Width = 44;
            ultraGridColumn476.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn476.Header.VisiblePosition = 3;
            ultraGridColumn476.Hidden = true;
            ultraGridColumn476.Width = 62;
            ultraGridColumn477.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn477.Header.VisiblePosition = 4;
            ultraGridColumn477.Hidden = true;
            ultraGridColumn477.Width = 44;
            ultraGridBand27.Columns.AddRange(new object[] {
            ultraGridColumn473,
            ultraGridColumn474,
            ultraGridColumn475,
            ultraGridColumn476,
            ultraGridColumn477});
            this.ultraDropDownMedicamentos.DisplayLayout.BandsSerializer.Add(ultraGridBand27);
            this.ultraDropDownMedicamentos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMedicamentos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMedicamentos.DisplayLayout.MaxBandDepth = 5;
            appearance213.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.ActiveCellAppearance = appearance213;
            appearance214.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance214.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance214.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance214.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.ActiveRowAppearance = appearance214;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance215.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.CardAreaAppearance = appearance215;
            appearance216.BackColor = System.Drawing.SystemColors.Control;
            appearance216.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance216.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.CellAppearance = appearance216;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance217.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance217.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance217.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance217.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance217.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.HeaderAppearance = appearance217;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance218.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.RowSelectorAppearance = appearance218;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance219.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.SelectedCellAppearance = appearance219;
            appearance220.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance220.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance220.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.SelectedRowAppearance = appearance220;
            appearance221.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance221.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance221;
            this.ultraDropDownMedicamentos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMedicamentos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMedicamentos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMedicamentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMedicamentos.DisplayMember = "Nombre";
            this.ultraDropDownMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMedicamentos.Location = new System.Drawing.Point(244, 419);
            this.ultraDropDownMedicamentos.Name = "ultraDropDownMedicamentos";
            this.ultraDropDownMedicamentos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMedicamentos.TabIndex = 43;
            this.ultraDropDownMedicamentos.ValueMember = "idMedicamento";
            this.ultraDropDownMedicamentos.Visible = false;
            this.ultraDropDownMedicamentos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMedicamentosBeforeDropDown);
            this.ultraDropDownMedicamentos.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownMedicamentosFilterRow);
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "Medicamentos";
            this.medicamentosBindingSource.DataSource = this.dsMedicamentos;
            // 
            // dsMedicamentos
            // 
            this.dsMedicamentos.DataSetName = "DsMedicamentos";
            this.dsMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownDiagnosticos
            // 
            this.ultraDropDownDiagnosticos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownDiagnosticos.DataSource = this.diagnosticosBindingSource;
            appearance222.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance222.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance222.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownDiagnosticos.DisplayLayout.Appearance = appearance222;
            ultraGridBand28.ColHeadersVisible = false;
            ultraGridColumn478.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn478.Header.VisiblePosition = 0;
            ultraGridColumn478.Hidden = true;
            ultraGridColumn478.Width = 60;
            ultraGridColumn479.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn479.Header.VisiblePosition = 1;
            ultraGridColumn479.Hidden = true;
            ultraGridColumn479.Width = 98;
            ultraGridColumn480.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn480.Header.VisiblePosition = 2;
            ultraGridColumn480.Width = 219;
            ultraGridBand28.Columns.AddRange(new object[] {
            ultraGridColumn478,
            ultraGridColumn479,
            ultraGridColumn480});
            this.ultraDropDownDiagnosticos.DisplayLayout.BandsSerializer.Add(ultraGridBand28);
            this.ultraDropDownDiagnosticos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownDiagnosticos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownDiagnosticos.DisplayLayout.MaxBandDepth = 5;
            appearance223.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.ActiveCellAppearance = appearance223;
            appearance224.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance224.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance224.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance224.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.ActiveRowAppearance = appearance224;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance225.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.CardAreaAppearance = appearance225;
            appearance226.BackColor = System.Drawing.SystemColors.Control;
            appearance226.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance226.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.CellAppearance = appearance226;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance227.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance227.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance227.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance227.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance227.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.HeaderAppearance = appearance227;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance228.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.RowSelectorAppearance = appearance228;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance229.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.SelectedCellAppearance = appearance229;
            appearance230.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance230.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance230.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.SelectedRowAppearance = appearance230;
            appearance231.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance231.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance231;
            this.ultraDropDownDiagnosticos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownDiagnosticos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownDiagnosticos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownDiagnosticos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownDiagnosticos.DisplayMember = "Nombre";
            this.ultraDropDownDiagnosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownDiagnosticos.Location = new System.Drawing.Point(244, 381);
            this.ultraDropDownDiagnosticos.Name = "ultraDropDownDiagnosticos";
            this.ultraDropDownDiagnosticos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownDiagnosticos.TabIndex = 42;
            this.ultraDropDownDiagnosticos.ValueMember = "idDiagnostico";
            this.ultraDropDownDiagnosticos.Visible = false;
            this.ultraDropDownDiagnosticos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownDiagnosticosBeforeDropDown);
            // 
            // diagnosticosBindingSource
            // 
            this.diagnosticosBindingSource.DataMember = "Diagnosticos";
            this.diagnosticosBindingSource.DataSource = this.dsDiagnosticos;
            // 
            // dsDiagnosticos
            // 
            this.dsDiagnosticos.DataSetName = "DsDiagnosticos";
            this.dsDiagnosticos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivos
            // 
            this.ultraDropDownMotivos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMotivos.DataSource = this.motivosDeLlamadoBindingSource;
            appearance202.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance202.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivos.DisplayLayout.Appearance = appearance202;
            ultraGridBand26.ColHeadersVisible = false;
            ultraGridColumn469.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn469.Header.VisiblePosition = 0;
            ultraGridColumn469.Hidden = true;
            ultraGridColumn469.Width = 49;
            ultraGridColumn470.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn470.Header.VisiblePosition = 1;
            ultraGridColumn470.Width = 219;
            ultraGridColumn471.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn471.Header.VisiblePosition = 2;
            ultraGridColumn471.Hidden = true;
            ultraGridColumn471.Width = 44;
            ultraGridColumn472.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn472.Header.VisiblePosition = 3;
            ultraGridColumn472.Hidden = true;
            ultraGridColumn472.Width = 44;
            ultraGridBand26.Columns.AddRange(new object[] {
            ultraGridColumn469,
            ultraGridColumn470,
            ultraGridColumn471,
            ultraGridColumn472});
            this.ultraDropDownMotivos.DisplayLayout.BandsSerializer.Add(ultraGridBand26);
            this.ultraDropDownMotivos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivos.DisplayLayout.MaxBandDepth = 5;
            appearance203.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivos.DisplayLayout.Override.ActiveCellAppearance = appearance203;
            appearance204.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance204.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance204.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance204.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivos.DisplayLayout.Override.ActiveRowAppearance = appearance204;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance205.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivos.DisplayLayout.Override.CardAreaAppearance = appearance205;
            appearance206.BackColor = System.Drawing.SystemColors.Control;
            appearance206.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance206.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivos.DisplayLayout.Override.CellAppearance = appearance206;
            this.ultraDropDownMotivos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance207.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance207.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance207.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance207.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance207.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivos.DisplayLayout.Override.HeaderAppearance = appearance207;
            this.ultraDropDownMotivos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance208.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivos.DisplayLayout.Override.RowSelectorAppearance = appearance208;
            this.ultraDropDownMotivos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance209.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivos.DisplayLayout.Override.SelectedCellAppearance = appearance209;
            appearance210.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance210.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance210.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivos.DisplayLayout.Override.SelectedRowAppearance = appearance210;
            appearance211.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance211.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance211;
            this.ultraDropDownMotivos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivos.DisplayMember = "Nombre";
            this.ultraDropDownMotivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivos.Location = new System.Drawing.Point(244, 343);
            this.ultraDropDownMotivos.Name = "ultraDropDownMotivos";
            this.ultraDropDownMotivos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMotivos.TabIndex = 41;
            this.ultraDropDownMotivos.ValueMember = "idMotivoDeLlamado";
            this.ultraDropDownMotivos.Visible = false;
            this.ultraDropDownMotivos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosBeforeDropDown);
            // 
            // motivosDeLlamadoBindingSource
            // 
            this.motivosDeLlamadoBindingSource.DataMember = "MotivosDeLlamado";
            this.motivosDeLlamadoBindingSource.DataSource = this.dsMotivosDeLlamado;
            // 
            // dsMotivosDeLlamado
            // 
            this.dsMotivosDeLlamado.DataSetName = "DsMotivosDeLlamado";
            this.dsMotivosDeLlamado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance192.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance192.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance192.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance192;
            ultraGridBand25.ColHeadersVisible = false;
            ultraGridColumn466.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn466.Header.VisiblePosition = 0;
            ultraGridColumn466.Hidden = true;
            ultraGridColumn466.Width = 57;
            ultraGridColumn467.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn467.Header.VisiblePosition = 1;
            ultraGridColumn467.Width = 219;
            ultraGridColumn468.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn468.Header.VisiblePosition = 2;
            ultraGridColumn468.Hidden = true;
            ultraGridColumn468.Width = 87;
            ultraGridBand25.Columns.AddRange(new object[] {
            ultraGridColumn466,
            ultraGridColumn467,
            ultraGridColumn468});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand25);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance193.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance193;
            appearance194.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance194.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance194.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance194.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance194;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance195.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance195;
            appearance196.BackColor = System.Drawing.SystemColors.Control;
            appearance196.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance196.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance196;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance197.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance197.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance197.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance197.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance197;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance198.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance198;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance199.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance199;
            appearance200.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance200.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance200.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance200;
            appearance201.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance201.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance201;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(244, 304);
            this.ultraDropDownPrepagos.Name = "ultraDropDownPrepagos";
            this.ultraDropDownPrepagos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownPrepagos.TabIndex = 40;
            this.ultraDropDownPrepagos.ValueMember = "idPrepago";
            this.ultraDropDownPrepagos.Visible = false;
            this.ultraDropDownPrepagos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPrepagosBeforeDropDown);
            // 
            // prepagosBindingSource
            // 
            this.prepagosBindingSource.DataMember = "Prepagos";
            this.prepagosBindingSource.DataSource = this.dsPrepagos;
            // 
            // dsPrepagos
            // 
            this.dsPrepagos.DataSetName = "DsPrepagos";
            this.dsPrepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPracticas
            // 
            this.ultraDropDownPracticas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPracticas.DataSource = this.practicasBindingSource;
            appearance182.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance182.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPracticas.DisplayLayout.Appearance = appearance182;
            ultraGridBand24.ColHeadersVisible = false;
            ultraGridColumn464.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn464.Header.VisiblePosition = 0;
            ultraGridColumn464.Hidden = true;
            ultraGridColumn464.Width = 40;
            ultraGridColumn465.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn465.Header.VisiblePosition = 1;
            ultraGridColumn465.Width = 219;
            ultraGridBand24.Columns.AddRange(new object[] {
            ultraGridColumn464,
            ultraGridColumn465});
            this.ultraDropDownPracticas.DisplayLayout.BandsSerializer.Add(ultraGridBand24);
            this.ultraDropDownPracticas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPracticas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPracticas.DisplayLayout.MaxBandDepth = 5;
            appearance183.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPracticas.DisplayLayout.Override.ActiveCellAppearance = appearance183;
            appearance184.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance184.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance184.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPracticas.DisplayLayout.Override.ActiveRowAppearance = appearance184;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance185.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPracticas.DisplayLayout.Override.CardAreaAppearance = appearance185;
            appearance186.BackColor = System.Drawing.SystemColors.Control;
            appearance186.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPracticas.DisplayLayout.Override.CellAppearance = appearance186;
            this.ultraDropDownPracticas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance187.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance187.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance187.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance187.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance187.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPracticas.DisplayLayout.Override.HeaderAppearance = appearance187;
            this.ultraDropDownPracticas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance188.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPracticas.DisplayLayout.Override.RowSelectorAppearance = appearance188;
            this.ultraDropDownPracticas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance189.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPracticas.DisplayLayout.Override.SelectedCellAppearance = appearance189;
            appearance190.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance190.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance190.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPracticas.DisplayLayout.Override.SelectedRowAppearance = appearance190;
            appearance191.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance191.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPracticas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance191;
            this.ultraDropDownPracticas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPracticas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPracticas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPracticas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPracticas.DisplayMember = "Nombre";
            this.ultraDropDownPracticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPracticas.Location = new System.Drawing.Point(244, 264);
            this.ultraDropDownPracticas.Name = "ultraDropDownPracticas";
            this.ultraDropDownPracticas.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownPracticas.TabIndex = 39;
            this.ultraDropDownPracticas.ValueMember = "idPractica";
            this.ultraDropDownPracticas.Visible = false;
            this.ultraDropDownPracticas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPracticasBeforeDropDown);
            // 
            // practicasBindingSource
            // 
            this.practicasBindingSource.DataMember = "Practicas";
            this.practicasBindingSource.DataSource = this.dsPracticas;
            // 
            // dsPracticas
            // 
            this.dsPracticas.DataSetName = "DsPracticas";
            this.dsPracticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCoberturas
            // 
            this.ultraDropDownCoberturas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCoberturas.DataSource = this.coberturasBindingSource;
            appearance160.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance160.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance160.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCoberturas.DisplayLayout.Appearance = appearance160;
            ultraGridBand22.ColHeadersVisible = false;
            ultraGridColumn445.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn445.Header.VisiblePosition = 0;
            ultraGridColumn445.Hidden = true;
            ultraGridColumn445.Width = 43;
            ultraGridColumn446.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn446.Header.VisiblePosition = 1;
            ultraGridColumn446.Width = 219;
            ultraGridBand22.Columns.AddRange(new object[] {
            ultraGridColumn445,
            ultraGridColumn446});
            this.ultraDropDownCoberturas.DisplayLayout.BandsSerializer.Add(ultraGridBand22);
            this.ultraDropDownCoberturas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCoberturas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCoberturas.DisplayLayout.MaxBandDepth = 5;
            appearance161.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCoberturas.DisplayLayout.Override.ActiveCellAppearance = appearance161;
            appearance162.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance162.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance162.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCoberturas.DisplayLayout.Override.ActiveRowAppearance = appearance162;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance163.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCoberturas.DisplayLayout.Override.CardAreaAppearance = appearance163;
            appearance164.BackColor = System.Drawing.SystemColors.Control;
            appearance164.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCoberturas.DisplayLayout.Override.CellAppearance = appearance164;
            this.ultraDropDownCoberturas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance165.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance165.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance165.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance165.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCoberturas.DisplayLayout.Override.HeaderAppearance = appearance165;
            this.ultraDropDownCoberturas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance166.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCoberturas.DisplayLayout.Override.RowSelectorAppearance = appearance166;
            this.ultraDropDownCoberturas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance167.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCoberturas.DisplayLayout.Override.SelectedCellAppearance = appearance167;
            appearance168.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance168.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCoberturas.DisplayLayout.Override.SelectedRowAppearance = appearance168;
            appearance169.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance169.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCoberturas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance169;
            this.ultraDropDownCoberturas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCoberturas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCoberturas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCoberturas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCoberturas.DisplayMember = "Nombre";
            this.ultraDropDownCoberturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCoberturas.Location = new System.Drawing.Point(244, 226);
            this.ultraDropDownCoberturas.Name = "ultraDropDownCoberturas";
            this.ultraDropDownCoberturas.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownCoberturas.TabIndex = 38;
            this.ultraDropDownCoberturas.ValueMember = "idCobertura";
            this.ultraDropDownCoberturas.Visible = false;
            this.ultraDropDownCoberturas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCoberturasBeforeDropDown);
            // 
            // coberturasBindingSource
            // 
            this.coberturasBindingSource.DataMember = "Coberturas";
            this.coberturasBindingSource.DataSource = this.dsCoberturas;
            // 
            // dsCoberturas
            // 
            this.dsCoberturas.DataSetName = "DsCoberturas";
            this.dsCoberturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownRecursosActivos
            // 
            this.ultraDropDownRecursosActivos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownRecursosActivos.DataSource = this.recursosListaBindingSource;
            appearance170.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance170.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance170.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRecursosActivos.DisplayLayout.Appearance = appearance170;
            ultraGridColumn447.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn447.Header.VisiblePosition = 0;
            ultraGridColumn447.Hidden = true;
            ultraGridColumn448.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn448.Header.VisiblePosition = 1;
            ultraGridColumn448.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn448.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn448.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn448.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn449.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn449.Header.VisiblePosition = 2;
            ultraGridColumn449.Hidden = true;
            ultraGridColumn450.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn450.Header.VisiblePosition = 3;
            ultraGridColumn450.Hidden = true;
            ultraGridColumn451.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn451.Header.VisiblePosition = 4;
            ultraGridColumn451.Hidden = true;
            ultraGridColumn452.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn452.Header.VisiblePosition = 5;
            ultraGridColumn452.Hidden = true;
            ultraGridColumn453.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn453.Header.VisiblePosition = 6;
            ultraGridColumn453.Hidden = true;
            ultraGridColumn454.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn454.Header.VisiblePosition = 7;
            ultraGridColumn454.Hidden = true;
            ultraGridColumn455.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn455.Header.VisiblePosition = 8;
            ultraGridColumn455.Hidden = true;
            ultraGridColumn456.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn456.Header.VisiblePosition = 9;
            ultraGridColumn456.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn456.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn456.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn456.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn457.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn457.Header.VisiblePosition = 10;
            ultraGridColumn457.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn457.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn457.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn457.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn458.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn458.Header.VisiblePosition = 11;
            ultraGridColumn458.Hidden = true;
            ultraGridColumn458.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn458.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn458.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn458.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn459.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn459.Header.Caption = "Dirección";
            ultraGridColumn459.Header.VisiblePosition = 12;
            ultraGridColumn459.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn459.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn459.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn459.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn460.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn460.Header.Caption = "Tripulación";
            ultraGridColumn460.Header.VisiblePosition = 13;
            ultraGridColumn460.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn460.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn460.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(150, 0);
            ultraGridColumn460.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn460.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn461.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn461.Header.VisiblePosition = 14;
            ultraGridColumn461.Hidden = true;
            appearance332.TextHAlignAsString = "Right";
            ultraGridColumn462.CellAppearance = appearance332;
            ultraGridColumn462.Header.VisiblePosition = 15;
            ultraGridColumn462.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn462.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn462.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn462.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn463.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance333.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance333.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ultraGridColumn463.CellAppearance = appearance333;
            ultraGridColumn463.Header.Caption = "";
            ultraGridColumn463.Header.VisiblePosition = 16;
            ultraGridColumn463.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn463.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn463.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn463.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn463.Width = 23;
            ultraGridBand23.Columns.AddRange(new object[] {
            ultraGridColumn447,
            ultraGridColumn448,
            ultraGridColumn449,
            ultraGridColumn450,
            ultraGridColumn451,
            ultraGridColumn452,
            ultraGridColumn453,
            ultraGridColumn454,
            ultraGridColumn455,
            ultraGridColumn456,
            ultraGridColumn457,
            ultraGridColumn458,
            ultraGridColumn459,
            ultraGridColumn460,
            ultraGridColumn461,
            ultraGridColumn462,
            ultraGridColumn463});
            ultraGridBand23.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRecursosActivos.DisplayLayout.BandsSerializer.Add(ultraGridBand23);
            this.ultraDropDownRecursosActivos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRecursosActivos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRecursosActivos.DisplayLayout.MaxBandDepth = 5;
            appearance173.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.ActiveCellAppearance = appearance173;
            appearance174.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance174.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance174.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.ActiveRowAppearance = appearance174;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance175.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.CardAreaAppearance = appearance175;
            appearance176.BackColor = System.Drawing.SystemColors.Control;
            appearance176.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.CellAppearance = appearance176;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance177.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance177.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance177.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance177.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance177.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.HeaderAppearance = appearance177;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance178.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.RowSelectorAppearance = appearance178;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.SelectedCellAppearance = appearance179;
            appearance180.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance180.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance180.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.SelectedRowAppearance = appearance180;
            appearance181.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance181.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance181;
            this.ultraDropDownRecursosActivos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRecursosActivos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRecursosActivos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRecursosActivos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRecursosActivos.DisplayMember = "Nombre";
            this.ultraDropDownRecursosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRecursosActivos.ImageList = this.imageList1;
            this.ultraDropDownRecursosActivos.Location = new System.Drawing.Point(244, 187);
            this.ultraDropDownRecursosActivos.Name = "ultraDropDownRecursosActivos";
            this.ultraDropDownRecursosActivos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownRecursosActivos.TabIndex = 37;
            this.ultraDropDownRecursosActivos.ValueMember = "idRecurso";
            this.ultraDropDownRecursosActivos.Visible = false;
            this.ultraDropDownRecursosActivos.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraDropDownRecursosActivosInitializeRow);
            this.ultraDropDownRecursosActivos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownRecursosActivosBeforeDropDown);
            this.ultraDropDownRecursosActivos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownRecursosActivosRowSelected);
            // 
            // recursosListaBindingSource
            // 
            this.recursosListaBindingSource.DataMember = "RecursosLista";
            this.recursosListaBindingSource.DataSource = this.dsRecursosLista;
            // 
            // dsRecursosLista
            // 
            this.dsRecursosLista.DataSetName = "DsRecursosLista";
            this.dsRecursosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownBarrio
            // 
            this.ultraDropDownBarrio.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBarrio.DataSource = this.barriosListaBindingSource;
            appearance57.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrio.DisplayLayout.Appearance = appearance57;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn334.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn334.Header.VisiblePosition = 0;
            ultraGridColumn334.Hidden = true;
            ultraGridColumn334.Width = 45;
            ultraGridColumn335.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn335.Header.VisiblePosition = 1;
            ultraGridColumn335.Width = 219;
            ultraGridColumn336.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn336.Header.VisiblePosition = 2;
            ultraGridColumn336.Hidden = true;
            ultraGridColumn336.Width = 58;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn334,
            ultraGridColumn335,
            ultraGridColumn336});
            this.ultraDropDownBarrio.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownBarrio.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrio.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrio.DisplayLayout.MaxBandDepth = 5;
            appearance58.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrio.DisplayLayout.Override.ActiveCellAppearance = appearance58;
            appearance59.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance59.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance59.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrio.DisplayLayout.Override.ActiveRowAppearance = appearance59;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance60.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrio.DisplayLayout.Override.CardAreaAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.Control;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrio.DisplayLayout.Override.CellAppearance = appearance61;
            this.ultraDropDownBarrio.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance62.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance62.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance62.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrio.DisplayLayout.Override.HeaderAppearance = appearance62;
            this.ultraDropDownBarrio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance63.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrio.DisplayLayout.Override.RowSelectorAppearance = appearance63;
            this.ultraDropDownBarrio.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrio.DisplayLayout.Override.SelectedCellAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance65.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrio.DisplayLayout.Override.SelectedRowAppearance = appearance65;
            appearance66.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrio.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance66;
            this.ultraDropDownBarrio.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrio.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrio.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrio.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrio.DisplayMember = "Nombre";
            this.ultraDropDownBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownBarrio.Location = new System.Drawing.Point(249, 210);
            this.ultraDropDownBarrio.Name = "ultraDropDownBarrio";
            this.ultraDropDownBarrio.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownBarrio.TabIndex = 36;
            this.ultraDropDownBarrio.ValueMember = "idBarrio";
            this.ultraDropDownBarrio.Visible = false;
            this.ultraDropDownBarrio.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownBarrioBeforeDropDown);
            this.ultraDropDownBarrio.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarrioFilterRow);
            // 
            // barriosListaBindingSource
            // 
            this.barriosListaBindingSource.DataMember = "BarriosLista";
            this.barriosListaBindingSource.DataSource = this.dsBarrios;
            // 
            // dsBarrios
            // 
            this.dsBarrios.DataSetName = "DsBarrios";
            this.dsBarrios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCalles
            // 
            this.ultraDropDownCalles.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCalles.DataSource = this.callesBindingSource;
            appearance262.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance262.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance262.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalles.DisplayLayout.Appearance = appearance262;
            ultraGridBand32.ColHeadersVisible = false;
            ultraGridColumn491.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn491.Header.VisiblePosition = 0;
            ultraGridColumn491.Hidden = true;
            ultraGridColumn491.Width = 30;
            ultraGridColumn492.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn492.Header.VisiblePosition = 1;
            ultraGridColumn492.Hidden = true;
            ultraGridColumn492.Width = 57;
            ultraGridColumn493.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn493.Header.VisiblePosition = 2;
            ultraGridColumn493.Hidden = true;
            ultraGridColumn493.Width = 40;
            ultraGridColumn494.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn494.Header.VisiblePosition = 3;
            ultraGridColumn494.Width = 219;
            ultraGridBand32.Columns.AddRange(new object[] {
            ultraGridColumn491,
            ultraGridColumn492,
            ultraGridColumn493,
            ultraGridColumn494});
            this.ultraDropDownCalles.DisplayLayout.BandsSerializer.Add(ultraGridBand32);
            this.ultraDropDownCalles.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalles.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalles.DisplayLayout.MaxBandDepth = 5;
            appearance263.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveCellAppearance = appearance263;
            appearance264.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance264.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance264.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance264.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveRowAppearance = appearance264;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance265.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.CardAreaAppearance = appearance265;
            appearance266.BackColor = System.Drawing.SystemColors.Control;
            appearance266.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance266.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.CellAppearance = appearance266;
            this.ultraDropDownCalles.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance267.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance267.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance267.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance267.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance267.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderAppearance = appearance267;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance268.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSelectorAppearance = appearance268;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance269.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedCellAppearance = appearance269;
            appearance270.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance270.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance270.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedRowAppearance = appearance270;
            appearance271.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance271.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalles.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance271;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalles.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalles.DisplayMember = "Nombre";
            this.ultraDropDownCalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCalles.Location = new System.Drawing.Point(0, 381);
            this.ultraDropDownCalles.Name = "ultraDropDownCalles";
            this.ultraDropDownCalles.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownCalles.TabIndex = 35;
            this.ultraDropDownCalles.ValueMember = "idCalle";
            this.ultraDropDownCalles.Visible = false;
            this.ultraDropDownCalles.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCallesBeforeDropDown);
            this.ultraDropDownCalles.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCallesFilterRow);
            // 
            // callesBindingSource
            // 
            this.callesBindingSource.DataMember = "Calles";
            this.callesBindingSource.DataSource = this.dsCallesLista;
            // 
            // dsCallesLista
            // 
            this.dsCallesLista.DataSetName = "DsCallesLista";
            this.dsCallesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownLocalidad
            // 
            this.ultraDropDownLocalidad.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidad.DataSource = this.localidadesBindingSource;
            appearance252.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance252.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance252;
            ultraGridBand31.ColHeadersVisible = false;
            ultraGridColumn489.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn489.Header.VisiblePosition = 0;
            ultraGridColumn489.Hidden = true;
            ultraGridColumn489.Width = 75;
            ultraGridColumn490.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn490.Header.VisiblePosition = 1;
            ultraGridColumn490.Width = 219;
            ultraGridBand31.Columns.AddRange(new object[] {
            ultraGridColumn489,
            ultraGridColumn490});
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand31);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance253.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance254.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance254.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance254.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance254;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance255.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance255;
            appearance256.BackColor = System.Drawing.SystemColors.Control;
            appearance256.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance256.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance256;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance257.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance257.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance257.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance257.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance257.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance257;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance258.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance258;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance259.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance259;
            appearance260.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance260.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance260.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance260;
            appearance261.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance261.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance261;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(0, 342);
            this.ultraDropDownLocalidad.Name = "ultraDropDownLocalidad";
            this.ultraDropDownLocalidad.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownLocalidad.TabIndex = 34;
            this.ultraDropDownLocalidad.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad.Visible = false;
            this.ultraDropDownLocalidad.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownLocalidadBeforeDropDown);
            this.ultraDropDownLocalidad.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadRowSelected);
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "Localidades";
            this.localidadesBindingSource.DataSource = this.dsLocalidades1;
            // 
            // dsLocalidades1
            // 
            this.dsLocalidades1.DataSetName = "DsLocalidades";
            this.dsLocalidades1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownLugares
            // 
            this.ultraDropDownLugares.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLugares.DataSource = this.lugaresBindingSource;
            appearance272.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance272.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance272.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLugares.DisplayLayout.Appearance = appearance272;
            ultraGridBand33.ColHeadersVisible = false;
            ultraGridColumn495.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn495.Header.VisiblePosition = 0;
            ultraGridColumn495.Hidden = true;
            ultraGridColumn495.Width = 41;
            ultraGridColumn496.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn496.Header.VisiblePosition = 1;
            ultraGridColumn496.Width = 219;
            ultraGridColumn497.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn497.Header.VisiblePosition = 2;
            ultraGridColumn497.Hidden = true;
            ultraGridColumn497.Width = 70;
            ultraGridColumn498.Header.VisiblePosition = 3;
            ultraGridColumn499.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn499.Header.VisiblePosition = 4;
            ultraGridColumn500.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn500.Header.VisiblePosition = 5;
            ultraGridBand33.Columns.AddRange(new object[] {
            ultraGridColumn495,
            ultraGridColumn496,
            ultraGridColumn497,
            ultraGridColumn498,
            ultraGridColumn499,
            ultraGridColumn500});
            ultraGridColumn501.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn501.Header.VisiblePosition = 0;
            ultraGridColumn501.Width = 44;
            ultraGridColumn502.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn502.Header.VisiblePosition = 1;
            ultraGridColumn502.Width = 33;
            ultraGridColumn503.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn503.Header.VisiblePosition = 2;
            ultraGridColumn503.Width = 70;
            ultraGridColumn504.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn504.Header.VisiblePosition = 3;
            ultraGridColumn504.Width = 70;
            ultraGridColumn505.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn505.Header.VisiblePosition = 4;
            ultraGridColumn505.Width = 70;
            ultraGridColumn506.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn506.Header.VisiblePosition = 5;
            ultraGridColumn506.Width = 59;
            ultraGridColumn507.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn507.Header.VisiblePosition = 6;
            ultraGridColumn507.Width = 59;
            ultraGridColumn508.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn508.Header.VisiblePosition = 7;
            ultraGridColumn508.Width = 41;
            ultraGridColumn509.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn509.Header.VisiblePosition = 8;
            ultraGridColumn509.Width = 70;
            ultraGridColumn510.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn510.Header.VisiblePosition = 10;
            ultraGridColumn510.Width = 41;
            ultraGridColumn511.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn511.Header.VisiblePosition = 11;
            ultraGridColumn511.Width = 41;
            ultraGridColumn512.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn512.Header.VisiblePosition = 9;
            ultraGridColumn512.Width = 51;
            ultraGridColumn513.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn513.Header.VisiblePosition = 12;
            ultraGridBand34.Columns.AddRange(new object[] {
            ultraGridColumn501,
            ultraGridColumn502,
            ultraGridColumn503,
            ultraGridColumn504,
            ultraGridColumn505,
            ultraGridColumn506,
            ultraGridColumn507,
            ultraGridColumn508,
            ultraGridColumn509,
            ultraGridColumn510,
            ultraGridColumn511,
            ultraGridColumn512,
            ultraGridColumn513});
            ultraGridColumn514.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn514.Header.VisiblePosition = 0;
            ultraGridColumn514.Width = 120;
            ultraGridColumn515.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn515.Header.VisiblePosition = 1;
            ultraGridColumn515.Width = 166;
            ultraGridColumn516.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn516.Header.VisiblePosition = 2;
            ultraGridColumn516.Width = 118;
            ultraGridColumn517.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn517.Header.VisiblePosition = 3;
            ultraGridColumn517.Width = 121;
            ultraGridColumn518.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn518.Header.VisiblePosition = 4;
            ultraGridColumn518.Width = 105;
            ultraGridBand35.Columns.AddRange(new object[] {
            ultraGridColumn514,
            ultraGridColumn515,
            ultraGridColumn516,
            ultraGridColumn517,
            ultraGridColumn518});
            ultraGridColumn519.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn519.Header.VisiblePosition = 0;
            ultraGridColumn519.Width = 104;
            ultraGridColumn520.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn520.Header.VisiblePosition = 1;
            ultraGridColumn520.Width = 141;
            ultraGridColumn521.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn521.Header.VisiblePosition = 2;
            ultraGridColumn521.Width = 145;
            ultraGridColumn522.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn522.Header.VisiblePosition = 3;
            ultraGridColumn522.Width = 87;
            ultraGridColumn523.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn523.Header.VisiblePosition = 4;
            ultraGridColumn523.Width = 86;
            ultraGridColumn524.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn524.Header.VisiblePosition = 5;
            ultraGridColumn524.Width = 86;
            ultraGridColumn525.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn525.Header.VisiblePosition = 6;
            ultraGridBand36.Columns.AddRange(new object[] {
            ultraGridColumn519,
            ultraGridColumn520,
            ultraGridColumn521,
            ultraGridColumn522,
            ultraGridColumn523,
            ultraGridColumn524,
            ultraGridColumn525});
            ultraGridColumn526.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn526.Header.VisiblePosition = 0;
            ultraGridColumn526.Width = 120;
            ultraGridColumn527.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn527.Header.VisiblePosition = 1;
            ultraGridColumn527.Width = 166;
            ultraGridColumn528.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn528.Header.VisiblePosition = 2;
            ultraGridColumn528.Width = 118;
            ultraGridColumn529.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn529.Header.VisiblePosition = 3;
            ultraGridColumn529.Width = 121;
            ultraGridColumn530.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn530.Header.VisiblePosition = 4;
            ultraGridColumn530.Width = 105;
            ultraGridBand37.Columns.AddRange(new object[] {
            ultraGridColumn526,
            ultraGridColumn527,
            ultraGridColumn528,
            ultraGridColumn529,
            ultraGridColumn530});
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand33);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand34);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand35);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand36);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand37);
            this.ultraDropDownLugares.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLugares.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLugares.DisplayLayout.MaxBandDepth = 5;
            appearance273.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLugares.DisplayLayout.Override.ActiveCellAppearance = appearance273;
            appearance274.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance274.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance274.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance274.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLugares.DisplayLayout.Override.ActiveRowAppearance = appearance274;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance275.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLugares.DisplayLayout.Override.CardAreaAppearance = appearance275;
            appearance276.BackColor = System.Drawing.SystemColors.Control;
            appearance276.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance276.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLugares.DisplayLayout.Override.CellAppearance = appearance276;
            this.ultraDropDownLugares.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance277.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance277.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance277.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance277.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance277.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLugares.DisplayLayout.Override.HeaderAppearance = appearance277;
            this.ultraDropDownLugares.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance278.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLugares.DisplayLayout.Override.RowSelectorAppearance = appearance278;
            this.ultraDropDownLugares.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance279.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLugares.DisplayLayout.Override.SelectedCellAppearance = appearance279;
            appearance280.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance280.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance280.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLugares.DisplayLayout.Override.SelectedRowAppearance = appearance280;
            appearance281.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance281.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLugares.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance281;
            this.ultraDropDownLugares.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLugares.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLugares.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLugares.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLugares.DisplayMember = "Nombre";
            this.ultraDropDownLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownLugares.Location = new System.Drawing.Point(0, 303);
            this.ultraDropDownLugares.Name = "ultraDropDownLugares";
            this.ultraDropDownLugares.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownLugares.TabIndex = 33;
            this.ultraDropDownLugares.ValueMember = "idLugar";
            this.ultraDropDownLugares.Visible = false;
            this.ultraDropDownLugares.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownLugaresBeforeDropDown);
            // 
            // lugaresBindingSource
            // 
            this.lugaresBindingSource.DataMember = "Lugares";
            this.lugaresBindingSource.DataSource = this.dsLugares;
            // 
            // dsLugares
            // 
            this.dsLugares.DataSetName = "DsLugares";
            this.dsLugares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivosCancelacion
            // 
            this.ultraDropDownMotivosCancelacion.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMotivosCancelacion.DataSource = this.motivosDeCancelacionPrestacionBindingSource;
            appearance242.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance242.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance242.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Appearance = appearance242;
            ultraGridBand30.ColHeadersVisible = false;
            ultraGridColumn487.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn487.Header.VisiblePosition = 0;
            ultraGridColumn487.Hidden = true;
            ultraGridColumn487.Width = 66;
            ultraGridColumn488.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn488.Header.VisiblePosition = 1;
            ultraGridColumn488.Width = 219;
            ultraGridBand30.Columns.AddRange(new object[] {
            ultraGridColumn487,
            ultraGridColumn488});
            this.ultraDropDownMotivosCancelacion.DisplayLayout.BandsSerializer.Add(ultraGridBand30);
            this.ultraDropDownMotivosCancelacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.MaxBandDepth = 5;
            appearance243.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.ActiveCellAppearance = appearance243;
            appearance244.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance244.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance244.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance244.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.ActiveRowAppearance = appearance244;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance245.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.CardAreaAppearance = appearance245;
            appearance246.BackColor = System.Drawing.SystemColors.Control;
            appearance246.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance246.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.CellAppearance = appearance246;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance247.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance247.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance247.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.HeaderAppearance = appearance247;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance248.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.RowSelectorAppearance = appearance248;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.SelectedCellAppearance = appearance249;
            appearance250.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.SelectedRowAppearance = appearance250;
            appearance251.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance251.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance251;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosCancelacion.DisplayMember = "Nombre";
            this.ultraDropDownMotivosCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivosCancelacion.Location = new System.Drawing.Point(0, 264);
            this.ultraDropDownMotivosCancelacion.Name = "ultraDropDownMotivosCancelacion";
            this.ultraDropDownMotivosCancelacion.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownMotivosCancelacion.TabIndex = 32;
            this.ultraDropDownMotivosCancelacion.ValueMember = "idMotivoDeCancelacionPrestacion";
            this.ultraDropDownMotivosCancelacion.Visible = false;
            this.ultraDropDownMotivosCancelacion.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosCancelacionBeforeDropDown);
            // 
            // motivosDeCancelacionPrestacionBindingSource
            // 
            this.motivosDeCancelacionPrestacionBindingSource.DataMember = "MotivosDeCancelacionPrestacion";
            this.motivosDeCancelacionPrestacionBindingSource.DataSource = this.dsMotivosDeCancelacionPrestacion;
            // 
            // dsMotivosDeCancelacionPrestacion
            // 
            this.dsMotivosDeCancelacionPrestacion.DataSetName = "DsMotivosDeCancelacionPrestacion";
            this.dsMotivosDeCancelacionPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeDestino
            // 
            this.ultraDropDownTiposDeDestino.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeDestino.DataSource = this.tiposDeDestinoBindingSource;
            appearance150.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance150.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance150.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Appearance = appearance150;
            ultraGridBand21.ColHeadersVisible = false;
            ultraGridColumn442.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn442.Header.VisiblePosition = 0;
            ultraGridColumn442.Hidden = true;
            ultraGridColumn442.Width = 22;
            ultraGridColumn443.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn443.Header.VisiblePosition = 1;
            ultraGridColumn443.Width = 219;
            ultraGridColumn444.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn444.Header.VisiblePosition = 2;
            ultraGridColumn444.Hidden = true;
            ultraGridColumn444.Width = 55;
            ultraGridBand21.Columns.AddRange(new object[] {
            ultraGridColumn442,
            ultraGridColumn443,
            ultraGridColumn444});
            this.ultraDropDownTiposDeDestino.DisplayLayout.BandsSerializer.Add(ultraGridBand21);
            this.ultraDropDownTiposDeDestino.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeDestino.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeDestino.DisplayLayout.MaxBandDepth = 5;
            appearance151.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.ActiveCellAppearance = appearance151;
            appearance152.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance152.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance152.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance152.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.ActiveRowAppearance = appearance152;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance153.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.CardAreaAppearance = appearance153;
            appearance154.BackColor = System.Drawing.SystemColors.Control;
            appearance154.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.CellAppearance = appearance154;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance155.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance155.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance155.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance155.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance155.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.HeaderAppearance = appearance155;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance156.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.RowSelectorAppearance = appearance156;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance157.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.SelectedCellAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance158.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance158.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.SelectedRowAppearance = appearance158;
            appearance159.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance159.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance159;
            this.ultraDropDownTiposDeDestino.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeDestino.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeDestino.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeDestino.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeDestino.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeDestino.Location = new System.Drawing.Point(488, 187);
            this.ultraDropDownTiposDeDestino.Name = "ultraDropDownTiposDeDestino";
            this.ultraDropDownTiposDeDestino.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownTiposDeDestino.TabIndex = 44;
            this.ultraDropDownTiposDeDestino.ValueMember = "idTipoDeDestino";
            this.ultraDropDownTiposDeDestino.Visible = false;
            this.ultraDropDownTiposDeDestino.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeDestinoBeforeDropDown);
            // 
            // tiposDeDestinoBindingSource
            // 
            this.tiposDeDestinoBindingSource.DataMember = "TiposDeDestino";
            this.tiposDeDestinoBindingSource.DataSource = this.dsTiposDeDestino;
            // 
            // dsTiposDeDestino
            // 
            this.dsTiposDeDestino.DataSetName = "DsTiposDeDestino";
            this.dsTiposDeDestino.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.prestacionesResumenUltraGrid);
            this.splitContainer1.Panel1.Controls.Add(this.panelEstadoGeneral);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.ultraDropDownContratos);
            this.splitContainer1.Size = new System.Drawing.Size(979, 618);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 47;
            // 
            // panelEstadoGeneral
            // 
            this.panelEstadoGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.panelEstadoGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelEstadoGeneral.Name = "panelEstadoGeneral";
            this.panelEstadoGeneral.Size = new System.Drawing.Size(977, 184);
            this.panelEstadoGeneral.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.prestacionesUltraGrid);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 46);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.destinosUltraGrid);
            this.panel3.Controls.Add(this.ultraDropDownBarrio);
            this.panel3.Controls.Add(this.ultraDropDownDespachador);
            this.panel3.Controls.Add(this.ultraDropDownPacientes);
            this.panel3.Controls.Add(this.ultraDropDownMedicos);
            this.panel3.Controls.Add(this.ultraDropDownTiposDeDocumento);
            this.panel3.Controls.Add(this.ultraDropDownCodigos);
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 381);
            this.panel3.TabIndex = 8;
            // 
            // destinosUltraGrid
            // 
            this.destinosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinosUltraGrid.CalcManager = this.ultraCalcManager1;
            this.destinosUltraGrid.DataSource = this.destinosBindingSource;
            appearance34.BackColor = System.Drawing.SystemColors.Control;
            appearance34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Appearance = appearance34;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.ButtonConnectorStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Hidden = false;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Prompt = "Agregar ...";
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Style = Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            appearance35.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.destinosUltraGrid.DisplayLayout.Appearance = appearance35;
            this.destinosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.AddButtonCaption = " Destino";
            ultraGridColumn293.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn293.Header.VisiblePosition = 0;
            ultraGridColumn293.Hidden = true;
            ultraGridColumn293.Width = 56;
            ultraGridColumn294.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn294.Header.VisiblePosition = 1;
            ultraGridColumn294.Hidden = true;
            ultraGridColumn294.Width = 66;
            ultraGridColumn295.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn295.Header.Caption = "Hora Solicitada";
            ultraGridColumn295.Header.VisiblePosition = 4;
            ultraGridColumn295.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars;
            ultraGridColumn295.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn295.Width = 91;
            ultraGridColumn296.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn296.Header.Caption = "Lugar";
            ultraGridColumn296.Header.VisiblePosition = 3;
            ultraGridColumn296.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn296.Width = 219;
            ultraGridColumn297.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn297.Header.Caption = "Tipo de Destino";
            ultraGridColumn297.Header.VisiblePosition = 2;
            ultraGridColumn297.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn297.Width = 66;
            ultraGridColumn298.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance307.FontData.BoldAsString = "True";
            appearance307.ForeColor = System.Drawing.Color.Red;
            appearance307.TextHAlignAsString = "Right";
            ultraGridColumn298.CellAppearance = appearance307;
            ultraGridColumn298.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn298.Header.VisiblePosition = 5;
            ultraGridColumn298.Width = 51;
            ultraGridColumn299.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn299.Header.VisiblePosition = 6;
            ultraGridColumn300.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn300.Header.VisiblePosition = 7;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn293,
            ultraGridColumn294,
            ultraGridColumn295,
            ultraGridColumn296,
            ultraGridColumn297,
            ultraGridColumn298,
            ultraGridColumn299,
            ultraGridColumn300});
            appearance308.FontData.BoldAsString = "True";
            appearance308.FontData.SizeInPoints = 11F;
            appearance308.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance308;
            ultraGridBand3.Header.Caption = "Destino";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.MinRows = 1;
            ultraGridBand3.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand4.AddButtonCaption = "Dirección";
            ultraGridColumn301.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn301.Header.VisiblePosition = 0;
            ultraGridColumn301.Hidden = true;
            ultraGridColumn301.Width = 32;
            ultraGridColumn302.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn302.Header.Caption = "Calle";
            ultraGridColumn302.Header.VisiblePosition = 1;
            ultraGridColumn302.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn302.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn302.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(260, 0);
            ultraGridColumn302.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(260, 0);
            ultraGridColumn302.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn302.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn302.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn302.Width = 29;
            ultraGridColumn303.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn303.Header.Caption = "Nº";
            ultraGridColumn303.Header.VisiblePosition = 2;
            ultraGridColumn303.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn303.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn303.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn303.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(61, 0);
            ultraGridColumn303.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn303.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn303.Width = 45;
            ultraGridColumn304.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn304.Header.VisiblePosition = 3;
            ultraGridColumn304.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn304.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn304.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn304.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn304.Width = 60;
            ultraGridColumn305.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn305.Header.Caption = "Depto.";
            ultraGridColumn305.Header.VisiblePosition = 4;
            ultraGridColumn305.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn305.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn305.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(58, 0);
            ultraGridColumn305.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(58, 0);
            ultraGridColumn305.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn305.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn305.Width = 55;
            ultraGridColumn306.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn306.Header.Caption = "Entre";
            ultraGridColumn306.Header.VisiblePosition = 5;
            ultraGridColumn306.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn306.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn306.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(175, 0);
            ultraGridColumn306.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(169, 0);
            ultraGridColumn306.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn306.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn306.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn306.Width = 46;
            ultraGridColumn307.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn307.Header.Caption = "y";
            ultraGridColumn307.Header.VisiblePosition = 6;
            ultraGridColumn307.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn307.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn307.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(126, 0);
            ultraGridColumn307.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(81, 0);
            ultraGridColumn307.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn307.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn307.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn307.Width = 38;
            ultraGridColumn308.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn308.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn308.Header.VisiblePosition = 7;
            ultraGridColumn308.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn308.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn308.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(183, 92);
            ultraGridColumn308.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(183, 20);
            ultraGridColumn308.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn308.RowLayoutColumnInfo.SpanY = 6;
            ultraGridColumn308.Width = 48;
            ultraGridColumn309.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn309.Header.VisiblePosition = 8;
            ultraGridColumn309.Hidden = true;
            ultraGridColumn309.Width = 30;
            ultraGridColumn310.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn310.Header.VisiblePosition = 9;
            ultraGridColumn310.Hidden = true;
            ultraGridColumn310.Width = 24;
            ultraGridColumn311.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn311.Header.Caption = "Barrio";
            ultraGridColumn311.Header.VisiblePosition = 10;
            ultraGridColumn311.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn311.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn311.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(128, 0);
            ultraGridColumn311.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(118, 0);
            ultraGridColumn311.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn311.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn311.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn311.Width = 23;
            ultraGridColumn312.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn312.Header.Caption = "Localidad";
            ultraGridColumn312.Header.VisiblePosition = 11;
            ultraGridColumn312.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn312.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn312.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(175, 0);
            ultraGridColumn312.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn312.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn312.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn301,
            ultraGridColumn302,
            ultraGridColumn303,
            ultraGridColumn304,
            ultraGridColumn305,
            ultraGridColumn306,
            ultraGridColumn307,
            ultraGridColumn308,
            ultraGridColumn309,
            ultraGridColumn310,
            ultraGridColumn311,
            ultraGridColumn312});
            appearance309.FontData.BoldAsString = "True";
            appearance309.FontData.SizeInPoints = 10F;
            appearance309.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance309;
            ultraGridBand4.Header.Caption = "Dirección";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.MaxRows = 1;
            ultraGridBand4.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand4.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand5.AddButtonCaption = "Recurso";
            ultraGridColumn313.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn313.Header.VisiblePosition = 0;
            ultraGridColumn313.Hidden = true;
            ultraGridColumn313.Width = 9;
            ultraGridColumn314.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn314.Header.VisiblePosition = 1;
            ultraGridColumn314.Hidden = true;
            ultraGridColumn314.Width = 18;
            ultraGridColumn315.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance310.TextHAlignAsString = "Center";
            ultraGridColumn315.CellAppearance = appearance310;
            ultraGridColumn315.Header.Caption = "Recurso";
            ultraGridColumn315.Header.VisiblePosition = 2;
            ultraGridColumn315.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn315.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn315.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn315.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn315.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn315.Width = 41;
            ultraGridColumn316.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance311.TextHAlignAsString = "Center";
            ultraGridColumn316.CellAppearance = appearance311;
            ultraGridColumn316.Header.Caption = "Código";
            ultraGridColumn316.Header.VisiblePosition = 3;
            ultraGridColumn316.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn316.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn316.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn316.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn316.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn316.Width = 48;
            ultraGridColumn317.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn317.Header.VisiblePosition = 4;
            ultraGridColumn317.Hidden = true;
            ultraGridColumn317.Width = 28;
            ultraGridColumn318.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn318.Header.Caption = "Paciente a Bordo";
            ultraGridColumn318.Header.VisiblePosition = 5;
            ultraGridColumn318.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn318.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn318.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(215, 0);
            ultraGridColumn318.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn318.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn318.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn318.Width = 27;
            ultraGridColumn319.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn319.Header.VisiblePosition = 6;
            ultraGridColumn319.Hidden = true;
            ultraGridColumn319.Width = 20;
            ultraGridColumn320.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn320.Header.VisiblePosition = 7;
            ultraGridColumn320.Hidden = true;
            ultraGridColumn320.Width = 18;
            ultraGridColumn321.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn321.Header.VisiblePosition = 8;
            ultraGridColumn321.Hidden = true;
            ultraGridColumn321.Width = 24;
            ultraGridColumn322.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn322.Header.VisiblePosition = 9;
            ultraGridColumn322.Hidden = true;
            ultraGridColumn322.Width = 14;
            ultraGridColumn323.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn323.Header.VisiblePosition = 10;
            ultraGridColumn323.Hidden = true;
            ultraGridColumn323.Width = 8;
            ultraGridColumn324.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn324.Header.VisiblePosition = 11;
            ultraGridColumn324.Hidden = true;
            ultraGridColumn324.Width = 14;
            ultraGridColumn325.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn325.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance312.TextHAlignAsString = "Center";
            ultraGridColumn325.CellAppearance = appearance312;
            ultraGridColumn325.Header.VisiblePosition = 12;
            ultraGridColumn325.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn325.MaskInput = "hh:mm:ss";
            ultraGridColumn325.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn325.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn325.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn325.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(85, 0);
            ultraGridColumn325.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn325.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn325.Width = 56;
            ultraGridColumn326.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn326.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance313.TextHAlignAsString = "Center";
            ultraGridColumn326.CellAppearance = appearance313;
            ultraGridColumn326.Header.VisiblePosition = 13;
            ultraGridColumn326.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn326.MaskInput = "hh:mm:ss";
            ultraGridColumn326.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn326.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn326.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn326.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn326.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn326.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn326.Width = 37;
            ultraGridColumn327.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn327.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance314.TextHAlignAsString = "Center";
            ultraGridColumn327.CellAppearance = appearance314;
            ultraGridColumn327.Header.VisiblePosition = 14;
            ultraGridColumn327.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn327.MaskInput = "hh:mm:ss";
            ultraGridColumn327.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn327.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn327.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn327.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn327.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(96, 0);
            ultraGridColumn327.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn327.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn327.Width = 29;
            ultraGridColumn328.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn328.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance315.TextHAlignAsString = "Center";
            ultraGridColumn328.CellAppearance = appearance315;
            ultraGridColumn328.Header.VisiblePosition = 15;
            ultraGridColumn328.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn328.MaskInput = "hh:mm:ss";
            ultraGridColumn328.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn328.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn328.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn328.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn328.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn328.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn328.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn328.Width = 37;
            ultraGridColumn329.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn329.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance316.TextHAlignAsString = "Center";
            ultraGridColumn329.CellAppearance = appearance316;
            ultraGridColumn329.Header.VisiblePosition = 16;
            ultraGridColumn329.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn329.MaskInput = "hh:mm:ss";
            ultraGridColumn329.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn329.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn329.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn329.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn329.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn329.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn329.Width = 56;
            ultraGridColumn330.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn330.Header.VisiblePosition = 17;
            ultraGridColumn330.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn330.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn330.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(424, 0);
            ultraGridColumn330.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(88, 0);
            ultraGridColumn330.RowLayoutColumnInfo.SpanX = 12;
            ultraGridColumn330.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn330.Width = 48;
            ultraGridColumn331.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn331.Header.Caption = "Lugar de Salida";
            ultraGridColumn331.Header.VisiblePosition = 18;
            ultraGridColumn331.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn331.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn331.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(149, 0);
            ultraGridColumn331.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn331.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn331.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn331.Width = 44;
            ultraGridColumn332.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn332.Header.Caption = "Otro Lugar de Salida";
            ultraGridColumn332.Header.VisiblePosition = 19;
            ultraGridColumn332.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn332.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn332.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(154, 0);
            ultraGridColumn332.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(116, 0);
            ultraGridColumn332.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn332.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn332.Width = 34;
            ultraGridColumn333.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn333.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance317.TextHAlignAsString = "Center";
            ultraGridColumn333.CellAppearance = appearance317;
            ultraGridColumn333.Header.Caption = "Despachador";
            ultraGridColumn333.Header.VisiblePosition = 20;
            ultraGridColumn333.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn333.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn333.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(252, 0);
            ultraGridColumn333.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn333.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn333.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn313,
            ultraGridColumn314,
            ultraGridColumn315,
            ultraGridColumn316,
            ultraGridColumn317,
            ultraGridColumn318,
            ultraGridColumn319,
            ultraGridColumn320,
            ultraGridColumn321,
            ultraGridColumn322,
            ultraGridColumn323,
            ultraGridColumn324,
            ultraGridColumn325,
            ultraGridColumn326,
            ultraGridColumn327,
            ultraGridColumn328,
            ultraGridColumn329,
            ultraGridColumn330,
            ultraGridColumn331,
            ultraGridColumn332,
            ultraGridColumn333});
            appearance318.FontData.BoldAsString = "True";
            appearance318.FontData.SizeInPoints = 10F;
            appearance318.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance318;
            ultraGridBand5.Header.Caption = "Recurso";
            ultraGridBand5.HeaderVisible = true;
            ultraGridBand5.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand5.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand5.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.destinosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.destinosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.destinosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.destinosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.destinosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.destinosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance48.BackColor = System.Drawing.SystemColors.Window;
            this.destinosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance49.ForeColor = System.Drawing.SystemColors.WindowText;
            this.destinosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance49;
            this.destinosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.destinosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.destinosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.destinosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.destinosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.destinosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.destinosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance50.BackColor = System.Drawing.Color.Transparent;
            this.destinosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.Control;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.destinosUltraGrid.DisplayLayout.Override.CellAppearance = appearance51;
            this.destinosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance52.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance52.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance52.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.destinosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance52;
            this.destinosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance53.ForeColor = System.Drawing.Color.Red;
            this.destinosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance53;
            this.destinosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.destinosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance55.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.destinosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance55;
            appearance56.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.destinosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance56;
            this.destinosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.destinosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.destinosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.destinosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.destinosUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinosUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.destinosUltraGrid.Name = "destinosUltraGrid";
            this.destinosUltraGrid.Size = new System.Drawing.Size(467, 378);
            this.destinosUltraGrid.TabIndex = 0;
            this.destinosUltraGrid.AfterCellActivate += new System.EventHandler(this.DestinosUltraGridAfterCellActivate);
            this.destinosUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DestinosUltraGridAfterCellUpdate);
            this.destinosUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.DestinosUltraGridInitializeRow);
            this.destinosUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.DestinosUltraGridInitializeTemplateAddRow);
            this.destinosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.destinosUltraGrid_AfterEnterEditMode);
            this.destinosUltraGrid.AfterRowActivate += new System.EventHandler(this.DestinosUltraGridAfterRowActivate);
            this.destinosUltraGrid.AfterRowInsert += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.DestinosUltraGridAfterRowInsert);
            this.destinosUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DestinosUltraGridCellChange);
            this.destinosUltraGrid.AfterCellListCloseUp += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DestinosUltraGridAfterCellListCloseUp);
            this.destinosUltraGrid.BeforeCellListDropDown += new Infragistics.Win.UltraWinGrid.CancelableCellEventHandler(this.DestinosUltraGridBeforeCellListDropDown);
            this.destinosUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.DestinosUltraGridBeforeRowDeactivate);
            this.destinosUltraGrid.BeforeRowInsert += new Infragistics.Win.UltraWinGrid.BeforeRowInsertEventHandler(this.DestinosUltraGridBeforeRowInsert);
            this.destinosUltraGrid.BeforeCellUpdate += new Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventHandler(this.DestinosUltraGridBeforeCellUpdate);
            this.destinosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.destinosUltraGrid_KeyDown);
            // 
            // destinosBindingSource
            // 
            this.destinosBindingSource.DataMember = "Destinos";
            this.destinosBindingSource.DataSource = this.dsDestinos;
            // 
            // dsDestinos
            // 
            this.dsDestinos.DataSetName = "DsDestinos";
            this.dsDestinos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownDespachador
            // 
            this.ultraDropDownDespachador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownDespachador.DataSource = this.usuariosListaBindingSource;
            appearance67.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance67.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownDespachador.DisplayLayout.Appearance = appearance67;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn337.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn337.Header.VisiblePosition = 0;
            ultraGridColumn337.Hidden = true;
            ultraGridColumn338.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn338.Header.VisiblePosition = 1;
            ultraGridColumn338.Hidden = true;
            ultraGridColumn339.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn339.Header.VisiblePosition = 2;
            ultraGridColumn340.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn340.Header.VisiblePosition = 3;
            ultraGridColumn340.Hidden = true;
            ultraGridColumn341.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn341.Header.VisiblePosition = 4;
            ultraGridColumn341.Hidden = true;
            ultraGridColumn342.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn342.Header.VisiblePosition = 5;
            ultraGridColumn342.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn337,
            ultraGridColumn338,
            ultraGridColumn339,
            ultraGridColumn340,
            ultraGridColumn341,
            ultraGridColumn342});
            this.ultraDropDownDespachador.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownDespachador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownDespachador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownDespachador.DisplayLayout.MaxBandDepth = 5;
            appearance68.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownDespachador.DisplayLayout.Override.ActiveCellAppearance = appearance68;
            appearance69.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance69.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance69.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownDespachador.DisplayLayout.Override.ActiveRowAppearance = appearance69;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance70.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownDespachador.DisplayLayout.Override.CardAreaAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.Control;
            appearance71.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDespachador.DisplayLayout.Override.CellAppearance = appearance71;
            this.ultraDropDownDespachador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance72.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance72.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance72.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownDespachador.DisplayLayout.Override.HeaderAppearance = appearance72;
            this.ultraDropDownDespachador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance73.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownDespachador.DisplayLayout.Override.RowSelectorAppearance = appearance73;
            this.ultraDropDownDespachador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownDespachador.DisplayLayout.Override.SelectedCellAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance75.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDespachador.DisplayLayout.Override.SelectedRowAppearance = appearance75;
            appearance76.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance76.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownDespachador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance76;
            this.ultraDropDownDespachador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownDespachador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownDespachador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownDespachador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownDespachador.DisplayMember = "NombApel";
            this.ultraDropDownDespachador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownDespachador.Location = new System.Drawing.Point(5, 250);
            this.ultraDropDownDespachador.Name = "ultraDropDownDespachador";
            this.ultraDropDownDespachador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownDespachador.TabIndex = 51;
            this.ultraDropDownDespachador.ValueMember = "idUsuario";
            this.ultraDropDownDespachador.Visible = false;
            this.ultraDropDownDespachador.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownDespachadorBeforeDropDown);
            // 
            // usuariosListaBindingSource
            // 
            this.usuariosListaBindingSource.DataMember = "UsuariosLista";
            this.usuariosListaBindingSource.DataSource = this.dsUsuariosLista;
            // 
            // dsUsuariosLista
            // 
            this.dsUsuariosLista.DataSetName = "DsUsuariosLista";
            this.dsUsuariosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPacientes
            // 
            this.ultraDropDownPacientes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPacientes.DataSource = this.pacientesBindingSource;
            appearance77.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance77.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPacientes.DisplayLayout.Appearance = appearance77;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn343.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn343.Header.VisiblePosition = 0;
            ultraGridColumn343.Hidden = true;
            ultraGridColumn343.Width = 8;
            ultraGridColumn344.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn344.Header.VisiblePosition = 1;
            ultraGridColumn344.Hidden = true;
            ultraGridColumn344.Width = 9;
            ultraGridColumn345.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn345.Header.VisiblePosition = 2;
            ultraGridColumn345.Hidden = true;
            ultraGridColumn345.Width = 10;
            ultraGridColumn346.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn346.Header.VisiblePosition = 3;
            ultraGridColumn346.Width = 219;
            ultraGridColumn347.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn347.Header.VisiblePosition = 4;
            ultraGridColumn347.Hidden = true;
            ultraGridColumn347.Width = 10;
            ultraGridColumn348.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn348.Header.VisiblePosition = 5;
            ultraGridColumn348.Hidden = true;
            ultraGridColumn348.Width = 16;
            ultraGridColumn349.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn349.Header.VisiblePosition = 6;
            ultraGridColumn349.Hidden = true;
            ultraGridColumn349.Width = 16;
            ultraGridColumn350.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn350.Header.VisiblePosition = 7;
            ultraGridColumn350.Hidden = true;
            ultraGridColumn350.Width = 11;
            ultraGridColumn351.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn351.Header.VisiblePosition = 8;
            ultraGridColumn351.Hidden = true;
            ultraGridColumn351.Width = 18;
            ultraGridColumn352.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn352.Header.VisiblePosition = 9;
            ultraGridColumn352.Hidden = true;
            ultraGridColumn352.Width = 16;
            ultraGridColumn353.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn353.Header.VisiblePosition = 10;
            ultraGridColumn353.Hidden = true;
            ultraGridColumn353.Width = 12;
            ultraGridColumn354.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn354.Header.VisiblePosition = 11;
            ultraGridColumn354.Hidden = true;
            ultraGridColumn354.Width = 11;
            ultraGridColumn355.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn355.Header.VisiblePosition = 12;
            ultraGridColumn355.Hidden = true;
            ultraGridColumn355.Width = 13;
            ultraGridColumn356.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn356.Header.VisiblePosition = 13;
            ultraGridColumn356.Hidden = true;
            ultraGridColumn356.Width = 16;
            ultraGridColumn357.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn357.Header.VisiblePosition = 14;
            ultraGridColumn357.Hidden = true;
            ultraGridColumn357.Width = 11;
            ultraGridColumn358.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn358.Header.VisiblePosition = 15;
            ultraGridColumn358.Hidden = true;
            ultraGridColumn358.Width = 10;
            ultraGridColumn359.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn359.Header.VisiblePosition = 16;
            ultraGridColumn359.Hidden = true;
            ultraGridColumn360.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn360.Header.VisiblePosition = 17;
            ultraGridColumn360.Hidden = true;
            ultraGridColumn361.Header.VisiblePosition = 18;
            ultraGridColumn361.Hidden = true;
            ultraGridColumn362.Header.VisiblePosition = 19;
            ultraGridColumn362.Hidden = true;
            ultraGridColumn363.Header.VisiblePosition = 20;
            ultraGridColumn363.Hidden = true;
            ultraGridColumn364.Header.VisiblePosition = 21;
            ultraGridColumn365.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn365.Header.VisiblePosition = 22;
            ultraGridColumn366.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn366.Header.VisiblePosition = 23;
            ultraGridColumn367.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn367.Header.VisiblePosition = 24;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn343,
            ultraGridColumn344,
            ultraGridColumn345,
            ultraGridColumn346,
            ultraGridColumn347,
            ultraGridColumn348,
            ultraGridColumn349,
            ultraGridColumn350,
            ultraGridColumn351,
            ultraGridColumn352,
            ultraGridColumn353,
            ultraGridColumn354,
            ultraGridColumn355,
            ultraGridColumn356,
            ultraGridColumn357,
            ultraGridColumn358,
            ultraGridColumn359,
            ultraGridColumn360,
            ultraGridColumn361,
            ultraGridColumn362,
            ultraGridColumn363,
            ultraGridColumn364,
            ultraGridColumn365,
            ultraGridColumn366,
            ultraGridColumn367});
            ultraGridColumn368.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn368.Header.VisiblePosition = 0;
            ultraGridColumn368.Width = 174;
            ultraGridColumn369.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn369.Header.VisiblePosition = 1;
            ultraGridColumn369.Width = 193;
            ultraGridColumn370.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn370.Header.VisiblePosition = 2;
            ultraGridColumn370.Width = 115;
            ultraGridColumn371.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn371.Header.VisiblePosition = 3;
            ultraGridColumn371.Width = 167;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn368,
            ultraGridColumn369,
            ultraGridColumn370,
            ultraGridColumn371});
            ultraGridColumn372.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn372.Header.VisiblePosition = 0;
            ultraGridColumn372.Width = 298;
            ultraGridColumn373.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn373.Header.VisiblePosition = 1;
            ultraGridColumn373.Width = 192;
            ultraGridColumn374.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn374.Header.VisiblePosition = 2;
            ultraGridColumn374.Width = 159;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn372,
            ultraGridColumn373,
            ultraGridColumn374});
            ultraGridColumn375.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn375.Header.VisiblePosition = 0;
            ultraGridColumn375.Width = 262;
            ultraGridColumn376.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn376.Header.VisiblePosition = 1;
            ultraGridColumn376.Width = 159;
            ultraGridColumn377.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn377.Header.VisiblePosition = 2;
            ultraGridColumn377.Width = 120;
            ultraGridColumn378.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn378.Header.VisiblePosition = 3;
            ultraGridColumn378.Width = 108;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn375,
            ultraGridColumn376,
            ultraGridColumn377,
            ultraGridColumn378});
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownPacientes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPacientes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPacientes.DisplayLayout.MaxBandDepth = 5;
            appearance78.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPacientes.DisplayLayout.Override.ActiveCellAppearance = appearance78;
            appearance79.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance79.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance79.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPacientes.DisplayLayout.Override.ActiveRowAppearance = appearance79;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance80.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPacientes.DisplayLayout.Override.CardAreaAppearance = appearance80;
            appearance81.BackColor = System.Drawing.SystemColors.Control;
            appearance81.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPacientes.DisplayLayout.Override.CellAppearance = appearance81;
            this.ultraDropDownPacientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance82.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance82.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance82.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance82.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPacientes.DisplayLayout.Override.HeaderAppearance = appearance82;
            this.ultraDropDownPacientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance83.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPacientes.DisplayLayout.Override.RowSelectorAppearance = appearance83;
            this.ultraDropDownPacientes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPacientes.DisplayLayout.Override.SelectedCellAppearance = appearance84;
            appearance85.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance85.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPacientes.DisplayLayout.Override.SelectedRowAppearance = appearance85;
            appearance86.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance86.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPacientes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance86;
            this.ultraDropDownPacientes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPacientes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPacientes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPacientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPacientes.DisplayMember = "Nombre";
            this.ultraDropDownPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPacientes.Location = new System.Drawing.Point(5, 169);
            this.ultraDropDownPacientes.Name = "ultraDropDownPacientes";
            this.ultraDropDownPacientes.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPacientes.TabIndex = 50;
            this.ultraDropDownPacientes.ValueMember = "idPaciente";
            this.ultraDropDownPacientes.Visible = false;
            this.ultraDropDownPacientes.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPacientesBeforeDropDown);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.dsPacientesPrestacion;
            // 
            // dsPacientesPrestacion
            // 
            this.dsPacientesPrestacion.DataSetName = "DsPacientesPrestacion";
            this.dsPacientesPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMedicos
            // 
            this.ultraDropDownMedicos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMedicos.DataSource = this.ultraDataSourceMedicos;
            appearance87.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance87.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMedicos.DisplayLayout.Appearance = appearance87;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn379.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn379.Header.VisiblePosition = 0;
            ultraGridColumn379.Hidden = true;
            ultraGridColumn379.Width = 43;
            ultraGridColumn380.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn380.Header.VisiblePosition = 1;
            ultraGridColumn380.Width = 219;
            ultraGridColumn381.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn381.Header.VisiblePosition = 2;
            ultraGridColumn381.Hidden = true;
            ultraGridColumn381.Width = 51;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn379,
            ultraGridColumn380,
            ultraGridColumn381});
            this.ultraDropDownMedicos.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownMedicos.DisplayLayout.ColScrollRegions.Add(colScrollRegion1);
            this.ultraDropDownMedicos.DisplayLayout.ColScrollRegions.Add(colScrollRegion2);
            this.ultraDropDownMedicos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMedicos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMedicos.DisplayLayout.MaxBandDepth = 5;
            appearance88.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMedicos.DisplayLayout.Override.ActiveCellAppearance = appearance88;
            appearance89.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance89.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance89.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMedicos.DisplayLayout.Override.ActiveRowAppearance = appearance89;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance90.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMedicos.DisplayLayout.Override.CardAreaAppearance = appearance90;
            appearance91.BackColor = System.Drawing.SystemColors.Control;
            appearance91.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicos.DisplayLayout.Override.CellAppearance = appearance91;
            this.ultraDropDownMedicos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance92.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance92.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance92.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance92.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMedicos.DisplayLayout.Override.HeaderAppearance = appearance92;
            this.ultraDropDownMedicos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance93.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMedicos.DisplayLayout.Override.RowSelectorAppearance = appearance93;
            this.ultraDropDownMedicos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMedicos.DisplayLayout.Override.SelectedCellAppearance = appearance94;
            appearance95.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance95.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicos.DisplayLayout.Override.SelectedRowAppearance = appearance95;
            appearance96.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance96.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMedicos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance96;
            this.ultraDropDownMedicos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMedicos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMedicos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMedicos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMedicos.DisplayMember = "ApelNomb";
            this.ultraDropDownMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMedicos.Location = new System.Drawing.Point(5, 212);
            this.ultraDropDownMedicos.Name = "ultraDropDownMedicos";
            this.ultraDropDownMedicos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMedicos.TabIndex = 39;
            this.ultraDropDownMedicos.ValueMember = "idEmpleado";
            this.ultraDropDownMedicos.Visible = false;
            this.ultraDropDownMedicos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMedicosBeforeDropDown);
            // 
            // ultraDataSourceMedicos
            // 
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceMedicos.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3});
            // 
            // ultraDropDownTiposDeDocumento
            // 
            this.ultraDropDownTiposDeDocumento.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeDocumento.DataSource = this.tiposDeDocumentoBindingSource;
            appearance97.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance97.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Appearance = appearance97;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn382.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn382.Header.VisiblePosition = 0;
            ultraGridColumn382.Hidden = true;
            ultraGridColumn382.Width = 85;
            ultraGridColumn383.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn383.Header.VisiblePosition = 1;
            ultraGridColumn383.Hidden = true;
            ultraGridColumn383.Width = 231;
            ultraGridColumn384.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn384.Header.VisiblePosition = 2;
            ultraGridColumn384.Width = 231;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn382,
            ultraGridColumn383,
            ultraGridColumn384});
            this.ultraDropDownTiposDeDocumento.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownTiposDeDocumento.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.MaxBandDepth = 5;
            appearance98.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.ActiveCellAppearance = appearance98;
            appearance99.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance99.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance99.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.ActiveRowAppearance = appearance99;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance100.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.CardAreaAppearance = appearance100;
            appearance101.BackColor = System.Drawing.SystemColors.Control;
            appearance101.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.CellAppearance = appearance101;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance102.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance102.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance102.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance102.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.HeaderAppearance = appearance102;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance103.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.RowSelectorAppearance = appearance103;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.SelectedCellAppearance = appearance104;
            appearance105.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance105.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance105.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.SelectedRowAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance106.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance106;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeDocumento.DisplayMember = "Iniciales";
            this.ultraDropDownTiposDeDocumento.DropDownWidth = 250;
            this.ultraDropDownTiposDeDocumento.Location = new System.Drawing.Point(249, 250);
            this.ultraDropDownTiposDeDocumento.Name = "ultraDropDownTiposDeDocumento";
            this.ultraDropDownTiposDeDocumento.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeDocumento.TabIndex = 52;
            this.ultraDropDownTiposDeDocumento.ValueMember = "idTipoDeDocumento";
            this.ultraDropDownTiposDeDocumento.Visible = false;
            // 
            // tiposDeDocumentoBindingSource
            // 
            this.tiposDeDocumentoBindingSource.DataMember = "TiposDeDocumento";
            this.tiposDeDocumentoBindingSource.DataSource = this.dsTiposDeDocumento;
            // 
            // dsTiposDeDocumento
            // 
            this.dsTiposDeDocumento.DataSetName = "DsTiposDeDocumento";
            this.dsTiposDeDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCodigos
            // 
            this.ultraDropDownCodigos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCodigos.DataSource = this.codigosBindingSource;
            appearance107.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance107.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCodigos.DisplayLayout.Appearance = appearance107;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn385.Header.VisiblePosition = 0;
            ultraGridColumn385.Hidden = true;
            ultraGridColumn386.Header.VisiblePosition = 1;
            ultraGridColumn387.Header.VisiblePosition = 2;
            ultraGridColumn387.Hidden = true;
            ultraGridColumn388.Header.VisiblePosition = 3;
            ultraGridColumn388.Hidden = true;
            ultraGridColumn389.Header.VisiblePosition = 4;
            ultraGridColumn389.Hidden = true;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn385,
            ultraGridColumn386,
            ultraGridColumn387,
            ultraGridColumn388,
            ultraGridColumn389});
            this.ultraDropDownCodigos.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownCodigos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCodigos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCodigos.DisplayLayout.MaxBandDepth = 5;
            appearance108.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveCellAppearance = appearance108;
            appearance109.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance109.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveRowAppearance = appearance109;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance110.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.CardAreaAppearance = appearance110;
            appearance111.BackColor = System.Drawing.SystemColors.Control;
            appearance111.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.CellAppearance = appearance111;
            this.ultraDropDownCodigos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance112.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance112.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderAppearance = appearance112;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance113.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSelectorAppearance = appearance113;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedCellAppearance = appearance114;
            appearance115.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance115.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance115.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedRowAppearance = appearance115;
            appearance116.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance116.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCodigos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance116;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCodigos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCodigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCodigos.DisplayMember = "Nombre";
            this.ultraDropDownCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCodigos.Location = new System.Drawing.Point(247, 172);
            this.ultraDropDownCodigos.Name = "ultraDropDownCodigos";
            this.ultraDropDownCodigos.Size = new System.Drawing.Size(223, 32);
            this.ultraDropDownCodigos.TabIndex = 53;
            this.ultraDropDownCodigos.ValueMember = "idCodigo";
            this.ultraDropDownCodigos.Visible = false;
            this.ultraDropDownCodigos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCodigosBeforeDropDown);
            // 
            // codigosBindingSource
            // 
            this.codigosBindingSource.DataMember = "Codigos";
            this.codigosBindingSource.DataSource = this.dsCodigos;
            // 
            // dsCodigos
            // 
            this.dsCodigos.DataSetName = "DsCodigos";
            this.dsCodigos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pacientesUltraGrid);
            this.panel4.Location = new System.Drawing.Point(473, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 378);
            this.panel4.TabIndex = 0;
            // 
            // pacientesUltraGrid
            // 
            this.pacientesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pacientesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.pacientesUltraGrid.DataSource = this.pacientesBindingSource;
            appearance117.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance117.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.pacientesUltraGrid.DisplayLayout.Appearance = appearance117;
            this.pacientesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn390.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn390.Header.VisiblePosition = 0;
            ultraGridColumn390.Hidden = true;
            ultraGridColumn390.Width = 17;
            ultraGridColumn391.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn391.Header.VisiblePosition = 1;
            ultraGridColumn391.Hidden = true;
            ultraGridColumn391.Width = 29;
            ultraGridColumn392.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn392.Header.VisiblePosition = 2;
            ultraGridColumn392.Hidden = true;
            ultraGridColumn392.Width = 23;
            ultraGridColumn393.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn393.Header.VisiblePosition = 3;
            ultraGridColumn393.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn393.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn393.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(404, 0);
            ultraGridColumn393.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(404, 0);
            ultraGridColumn393.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn393.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn393.Width = 48;
            ultraGridColumn394.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance319.TextHAlignAsString = "Right";
            ultraGridColumn394.CellAppearance = appearance319;
            ultraGridColumn394.Header.VisiblePosition = 4;
            ultraGridColumn394.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn394.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn394.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(115, 0);
            ultraGridColumn394.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(115, 0);
            ultraGridColumn394.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn394.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn394.Width = 25;
            ultraGridColumn395.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn395.Header.Caption = "en";
            ultraGridColumn395.Header.VisiblePosition = 5;
            ultraGridColumn395.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn395.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn395.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(118, 0);
            ultraGridColumn395.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(118, 0);
            ultraGridColumn395.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn395.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn395.Width = 42;
            ultraGridColumn396.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn396.Header.VisiblePosition = 6;
            ultraGridColumn396.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn396.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn396.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            ultraGridColumn396.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(123, 0);
            ultraGridColumn396.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn396.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn396.Width = 42;
            ultraGridColumn397.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn397.Header.Caption = "Prepago";
            ultraGridColumn397.Header.VisiblePosition = 7;
            ultraGridColumn397.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn397.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn397.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(410, 0);
            ultraGridColumn397.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(410, 0);
            ultraGridColumn397.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn397.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn397.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn397.Width = 29;
            ultraGridColumn398.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn398.Header.Caption = "Nº Af. Prepago";
            ultraGridColumn398.Header.VisiblePosition = 8;
            ultraGridColumn398.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn398.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn398.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(455, 0);
            ultraGridColumn398.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(455, 0);
            ultraGridColumn398.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn398.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn398.Width = 49;
            ultraGridColumn399.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance320.TextHAlignAsString = "Center";
            ultraGridColumn399.CellAppearance = appearance320;
            ultraGridColumn399.Header.Caption = "Incidente";
            ultraGridColumn399.Header.VisiblePosition = 9;
            ultraGridColumn399.MaxLength = 30;
            ultraGridColumn399.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn399.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn399.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(195, 0);
            ultraGridColumn399.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(195, 0);
            ultraGridColumn399.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn399.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn399.Width = 43;
            ultraGridColumn400.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn400.Header.Caption = "Cobertura";
            ultraGridColumn400.Header.VisiblePosition = 10;
            ultraGridColumn400.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn400.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn400.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(404, 0);
            ultraGridColumn400.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(404, 0);
            ultraGridColumn400.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn400.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn400.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn400.Width = 31;
            ultraGridColumn401.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn401.Header.Caption = "Práctica";
            ultraGridColumn401.Header.VisiblePosition = 11;
            ultraGridColumn401.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn401.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn401.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(461, 0);
            ultraGridColumn401.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(461, 0);
            ultraGridColumn401.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn401.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn401.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn401.Width = 28;
            ultraGridColumn402.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance321.TextHAlignAsString = "Right";
            ultraGridColumn402.CellAppearance = appearance321;
            ultraGridColumn402.Header.VisiblePosition = 12;
            ultraGridColumn402.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn402.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn402.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn402.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn402.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(174, 0);
            ultraGridColumn402.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(174, 0);
            ultraGridColumn402.RowLayoutColumnInfo.SpanX = 19;
            ultraGridColumn402.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn402.Width = 34;
            ultraGridColumn403.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn403.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn403.Header.VisiblePosition = 13;
            ultraGridColumn403.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn403.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn403.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(399, 56);
            ultraGridColumn403.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(399, 0);
            ultraGridColumn403.RowLayoutColumnInfo.SpanX = 21;
            ultraGridColumn403.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn403.VertScrollBar = true;
            ultraGridColumn403.Width = 42;
            ultraGridColumn404.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn404.Header.Caption = "Contrato";
            ultraGridColumn404.Header.VisiblePosition = 14;
            ultraGridColumn404.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn404.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn404.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(865, 0);
            ultraGridColumn404.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(865, 0);
            ultraGridColumn404.RowLayoutColumnInfo.SpanX = 9;
            ultraGridColumn404.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn404.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn405.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn405.Header.Caption = "Médico";
            ultraGridColumn405.Header.VisiblePosition = 15;
            ultraGridColumn405.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn405.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn405.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(356, 0);
            ultraGridColumn405.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(356, 0);
            ultraGridColumn405.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn405.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn405.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn406.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn406.Header.VisiblePosition = 16;
            ultraGridColumn406.Hidden = true;
            ultraGridColumn407.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn407.DefaultCellValue = "False";
            ultraGridColumn407.Header.Caption = "Extra";
            ultraGridColumn407.Header.VisiblePosition = 17;
            ultraGridColumn407.RowLayoutColumnInfo.OriginX = 29;
            ultraGridColumn407.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn407.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(135, 0);
            ultraGridColumn407.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(135, 0);
            ultraGridColumn407.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn407.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn408.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn408.Header.Caption = "Doc.";
            ultraGridColumn408.Header.VisiblePosition = 18;
            ultraGridColumn408.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn408.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn408.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(74, 0);
            ultraGridColumn408.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(74, 0);
            ultraGridColumn408.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn408.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn408.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn409.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance322.TextHAlignAsString = "Right";
            ultraGridColumn409.CellAppearance = appearance322;
            ultraGridColumn409.Header.Caption = "N° Docum.";
            ultraGridColumn409.Header.VisiblePosition = 19;
            ultraGridColumn409.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn409.MaskInput = "{LOC}nnn,nnn,nnn,nnn";
            ultraGridColumn409.MaxLength = 9;
            ultraGridColumn409.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn409.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn409.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(330, 0);
            ultraGridColumn409.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(330, 0);
            ultraGridColumn409.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn409.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn410.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn410.Header.VisiblePosition = 21;
            ultraGridColumn410.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn410.RowLayoutColumnInfo.OriginY = 12;
            ultraGridColumn410.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(1264, 38);
            ultraGridColumn410.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(1264, 0);
            ultraGridColumn410.RowLayoutColumnInfo.SpanX = 30;
            ultraGridColumn410.RowLayoutColumnInfo.SpanY = 3;
            ultraGridColumn410.VertScrollBar = true;
            ultraGridColumn411.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn411.Header.VisiblePosition = 22;
            ultraGridColumn411.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn411.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn411.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(139, 56);
            ultraGridColumn411.RowLayoutColumnInfo.SpanX = 21;
            ultraGridColumn411.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn411.VertScrollBar = true;
            ultraGridColumn412.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn412.Header.VisiblePosition = 27;
            ultraGridColumn413.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn413.Header.VisiblePosition = 28;
            ultraGridColumn414.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn414.Header.VisiblePosition = 29;
            ultraGridColumn415.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance323.TextHAlignAsString = "Center";
            ultraGridColumn415.CellAppearance = appearance323;
            ultraGridColumn415.Header.Caption = "";
            ultraGridColumn415.Header.VisiblePosition = 20;
            ultraGridColumn415.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn415.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn415.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn415.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(404, 0);
            ultraGridColumn415.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(116, 0);
            ultraGridColumn415.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn415.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn415.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn416.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn416.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn416.DataType = typeof(bool);
            ultraGridColumn416.Header.Caption = "Lista";
            ultraGridColumn416.Header.VisiblePosition = 23;
            ultraGridColumn416.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn416.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn416.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(105, 0);
            ultraGridColumn416.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(105, 0);
            ultraGridColumn416.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn416.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn417.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance324.TextHAlignAsString = "Center";
            ultraGridColumn417.CellAppearance = appearance324;
            ultraGridColumn417.Header.VisiblePosition = 24;
            ultraGridColumn417.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn417.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn417.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn417.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(318, 0);
            ultraGridColumn417.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn417.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn417.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn418.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance325.TextHAlignAsString = "Center";
            ultraGridColumn418.CellAppearance = appearance325;
            ultraGridColumn418.Header.VisiblePosition = 25;
            ultraGridColumn418.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn418.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn418.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn418.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(309, 0);
            ultraGridColumn418.RowLayoutColumnInfo.SpanX = 17;
            ultraGridColumn418.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn418.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn419.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance326.TextHAlignAsString = "Center";
            ultraGridColumn419.CellAppearance = appearance326;
            ultraGridColumn419.Header.VisiblePosition = 26;
            ultraGridColumn419.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn419.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn419.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn419.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(233, 0);
            ultraGridColumn419.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn419.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn419.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn390,
            ultraGridColumn391,
            ultraGridColumn392,
            ultraGridColumn393,
            ultraGridColumn394,
            ultraGridColumn395,
            ultraGridColumn396,
            ultraGridColumn397,
            ultraGridColumn398,
            ultraGridColumn399,
            ultraGridColumn400,
            ultraGridColumn401,
            ultraGridColumn402,
            ultraGridColumn403,
            ultraGridColumn404,
            ultraGridColumn405,
            ultraGridColumn406,
            ultraGridColumn407,
            ultraGridColumn408,
            ultraGridColumn409,
            ultraGridColumn410,
            ultraGridColumn411,
            ultraGridColumn412,
            ultraGridColumn413,
            ultraGridColumn414,
            ultraGridColumn415,
            ultraGridColumn416,
            ultraGridColumn417,
            ultraGridColumn418,
            ultraGridColumn419});
            appearance327.FontData.BoldAsString = "True";
            appearance327.FontData.SizeInPoints = 11F;
            appearance327.TextHAlignAsString = "Left";
            ultraGridBand15.Header.Appearance = appearance327;
            ultraGridBand15.Header.Caption = "Paciente";
            ultraGridBand15.HeaderVisible = true;
            ultraGridBand15.MinRows = 1;
            ultraGridBand15.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand15.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            rowLayoutColumnInfo4.OriginX = 0;
            rowLayoutColumnInfo4.OriginY = 0;
            rowLayoutColumnInfo4.PreferredCellSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo4.PreferredLabelSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo4.SpanX = 4;
            rowLayoutColumnInfo4.SpanY = 2;
            rowLayoutColumnInfo5.OriginX = 4;
            rowLayoutColumnInfo5.OriginY = 0;
            rowLayoutColumnInfo5.PreferredCellSize = new System.Drawing.Size(115, 0);
            rowLayoutColumnInfo5.PreferredLabelSize = new System.Drawing.Size(115, 0);
            rowLayoutColumnInfo5.SpanX = 2;
            rowLayoutColumnInfo5.SpanY = 2;
            rowLayoutColumnInfo6.OriginX = 6;
            rowLayoutColumnInfo6.OriginY = 0;
            rowLayoutColumnInfo6.PreferredCellSize = new System.Drawing.Size(118, 0);
            rowLayoutColumnInfo6.PreferredLabelSize = new System.Drawing.Size(118, 0);
            rowLayoutColumnInfo6.SpanX = 1;
            rowLayoutColumnInfo6.SpanY = 2;
            rowLayoutColumnInfo7.OriginX = 7;
            rowLayoutColumnInfo7.OriginY = 0;
            rowLayoutColumnInfo7.PreferredCellSize = new System.Drawing.Size(123, 0);
            rowLayoutColumnInfo7.PreferredLabelSize = new System.Drawing.Size(123, 0);
            rowLayoutColumnInfo7.SpanX = 1;
            rowLayoutColumnInfo7.SpanY = 2;
            rowLayoutColumnInfo8.OriginX = 0;
            rowLayoutColumnInfo8.OriginY = 2;
            rowLayoutColumnInfo8.PreferredCellSize = new System.Drawing.Size(410, 0);
            rowLayoutColumnInfo8.PreferredLabelSize = new System.Drawing.Size(410, 0);
            rowLayoutColumnInfo8.SpanX = 5;
            rowLayoutColumnInfo8.SpanY = 2;
            rowLayoutColumnInfo9.OriginX = 5;
            rowLayoutColumnInfo9.OriginY = 2;
            rowLayoutColumnInfo9.PreferredCellSize = new System.Drawing.Size(435, 0);
            rowLayoutColumnInfo9.PreferredLabelSize = new System.Drawing.Size(435, 0);
            rowLayoutColumnInfo9.SpanX = 4;
            rowLayoutColumnInfo9.SpanY = 2;
            rowLayoutColumnInfo10.OriginX = 8;
            rowLayoutColumnInfo10.OriginY = 8;
            rowLayoutColumnInfo10.PreferredCellSize = new System.Drawing.Size(195, 0);
            rowLayoutColumnInfo10.PreferredLabelSize = new System.Drawing.Size(195, 0);
            rowLayoutColumnInfo10.SpanX = 2;
            rowLayoutColumnInfo10.SpanY = 2;
            rowLayoutColumnInfo11.OriginX = 0;
            rowLayoutColumnInfo11.OriginY = 6;
            rowLayoutColumnInfo11.PreferredCellSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo11.PreferredLabelSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo11.SpanX = 4;
            rowLayoutColumnInfo11.SpanY = 2;
            rowLayoutColumnInfo12.OriginX = 4;
            rowLayoutColumnInfo12.OriginY = 6;
            rowLayoutColumnInfo12.PreferredCellSize = new System.Drawing.Size(451, 0);
            rowLayoutColumnInfo12.PreferredLabelSize = new System.Drawing.Size(451, 0);
            rowLayoutColumnInfo12.SpanX = 5;
            rowLayoutColumnInfo12.SpanY = 2;
            rowLayoutColumnInfo13.OriginX = 10;
            rowLayoutColumnInfo13.OriginY = 8;
            rowLayoutColumnInfo13.PreferredCellSize = new System.Drawing.Size(134, 0);
            rowLayoutColumnInfo13.PreferredLabelSize = new System.Drawing.Size(134, 0);
            rowLayoutColumnInfo13.SpanX = 19;
            rowLayoutColumnInfo13.SpanY = 2;
            rowLayoutColumnInfo14.OriginX = 9;
            rowLayoutColumnInfo14.OriginY = 0;
            rowLayoutColumnInfo14.PreferredCellSize = new System.Drawing.Size(359, 56);
            rowLayoutColumnInfo14.PreferredLabelSize = new System.Drawing.Size(359, 0);
            rowLayoutColumnInfo14.SpanX = 21;
            rowLayoutColumnInfo14.SpanY = 4;
            rowLayoutColumnInfo15.OriginX = 0;
            rowLayoutColumnInfo15.OriginY = 4;
            rowLayoutColumnInfo15.PreferredCellSize = new System.Drawing.Size(845, 0);
            rowLayoutColumnInfo15.PreferredLabelSize = new System.Drawing.Size(845, 0);
            rowLayoutColumnInfo15.SpanX = 9;
            rowLayoutColumnInfo15.SpanY = 2;
            rowLayoutColumnInfo16.OriginX = 4;
            rowLayoutColumnInfo16.OriginY = 8;
            rowLayoutColumnInfo16.PreferredCellSize = new System.Drawing.Size(356, 0);
            rowLayoutColumnInfo16.PreferredLabelSize = new System.Drawing.Size(356, 0);
            rowLayoutColumnInfo16.SpanX = 4;
            rowLayoutColumnInfo16.SpanY = 2;
            rowLayoutColumnInfo18.OriginX = 29;
            rowLayoutColumnInfo18.OriginY = 8;
            rowLayoutColumnInfo18.PreferredCellSize = new System.Drawing.Size(125, 0);
            rowLayoutColumnInfo18.PreferredLabelSize = new System.Drawing.Size(125, 0);
            rowLayoutColumnInfo18.SpanX = 1;
            rowLayoutColumnInfo18.SpanY = 2;
            rowLayoutColumnInfo19.OriginX = 0;
            rowLayoutColumnInfo19.OriginY = 8;
            rowLayoutColumnInfo19.PreferredCellSize = new System.Drawing.Size(74, 0);
            rowLayoutColumnInfo19.PreferredLabelSize = new System.Drawing.Size(74, 0);
            rowLayoutColumnInfo19.SpanX = 1;
            rowLayoutColumnInfo19.SpanY = 2;
            rowLayoutColumnInfo20.OriginX = 2;
            rowLayoutColumnInfo20.OriginY = 8;
            rowLayoutColumnInfo20.PreferredCellSize = new System.Drawing.Size(320, 0);
            rowLayoutColumnInfo20.PreferredLabelSize = new System.Drawing.Size(320, 0);
            rowLayoutColumnInfo20.SpanX = 2;
            rowLayoutColumnInfo20.SpanY = 2;
            rowLayoutColumnInfo21.OriginX = 0;
            rowLayoutColumnInfo21.OriginY = 12;
            rowLayoutColumnInfo21.PreferredCellSize = new System.Drawing.Size(1204, 38);
            rowLayoutColumnInfo21.PreferredLabelSize = new System.Drawing.Size(1204, 0);
            rowLayoutColumnInfo21.SpanX = 30;
            rowLayoutColumnInfo21.SpanY = 3;
            rowLayoutColumnInfo26.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo26.OriginX = 0;
            rowLayoutColumnInfo26.OriginY = 10;
            rowLayoutColumnInfo26.PreferredCellSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo26.PreferredLabelSize = new System.Drawing.Size(116, 0);
            rowLayoutColumnInfo26.SpanX = 4;
            rowLayoutColumnInfo26.SpanY = 2;
            rowLayoutColumnInfo27.OriginX = 8;
            rowLayoutColumnInfo27.OriginY = 0;
            rowLayoutColumnInfo27.PreferredCellSize = new System.Drawing.Size(95, 0);
            rowLayoutColumnInfo27.PreferredLabelSize = new System.Drawing.Size(95, 0);
            rowLayoutColumnInfo27.SpanX = 1;
            rowLayoutColumnInfo27.SpanY = 2;
            rowLayoutColumnInfo28.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo28.OriginX = 7;
            rowLayoutColumnInfo28.OriginY = 10;
            rowLayoutColumnInfo28.PreferredCellSize = new System.Drawing.Size(318, 0);
            rowLayoutColumnInfo28.SpanX = 6;
            rowLayoutColumnInfo28.SpanY = 2;
            rowLayoutColumnInfo29.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo29.OriginX = 13;
            rowLayoutColumnInfo29.OriginY = 10;
            rowLayoutColumnInfo29.PreferredCellSize = new System.Drawing.Size(259, 0);
            rowLayoutColumnInfo29.SpanX = 17;
            rowLayoutColumnInfo29.SpanY = 2;
            rowLayoutColumnInfo30.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo30.OriginX = 4;
            rowLayoutColumnInfo30.OriginY = 10;
            rowLayoutColumnInfo30.PreferredCellSize = new System.Drawing.Size(233, 0);
            rowLayoutColumnInfo30.SpanX = 3;
            rowLayoutColumnInfo30.SpanY = 2;
            rowLayout1.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo1,
            rowLayoutColumnInfo2,
            rowLayoutColumnInfo3,
            rowLayoutColumnInfo4,
            rowLayoutColumnInfo5,
            rowLayoutColumnInfo6,
            rowLayoutColumnInfo7,
            rowLayoutColumnInfo8,
            rowLayoutColumnInfo9,
            rowLayoutColumnInfo10,
            rowLayoutColumnInfo11,
            rowLayoutColumnInfo12,
            rowLayoutColumnInfo13,
            rowLayoutColumnInfo14,
            rowLayoutColumnInfo15,
            rowLayoutColumnInfo16,
            rowLayoutColumnInfo17,
            rowLayoutColumnInfo18,
            rowLayoutColumnInfo19,
            rowLayoutColumnInfo20,
            rowLayoutColumnInfo21,
            rowLayoutColumnInfo22,
            rowLayoutColumnInfo23,
            rowLayoutColumnInfo24,
            rowLayoutColumnInfo25,
            rowLayoutColumnInfo26,
            rowLayoutColumnInfo27,
            rowLayoutColumnInfo28,
            rowLayoutColumnInfo29,
            rowLayoutColumnInfo30});
            rowLayout1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            rowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand15.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout1});
            ultraGridBand15.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand16.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand16.CardSettings.LabelWidth = 123;
            ultraGridBand16.CardSettings.ShowCaption = false;
            ultraGridBand16.CardSettings.Style = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            ultraGridBand16.CardView = true;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn420.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn420.Header.VisiblePosition = 0;
            ultraGridColumn420.Hidden = true;
            ultraGridColumn421.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn421.Header.Caption = "";
            ultraGridColumn421.Header.VisiblePosition = 1;
            ultraGridColumn421.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn421.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn421.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn421.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn421.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn421.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn421.Width = 101;
            ultraGridColumn422.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn422.Header.VisiblePosition = 2;
            ultraGridColumn422.Hidden = true;
            ultraGridColumn423.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn423.Header.VisiblePosition = 3;
            ultraGridColumn423.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn423.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn423.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn423.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn423.RowLayoutColumnInfo.SpanY = 2;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn420,
            ultraGridColumn421,
            ultraGridColumn422,
            ultraGridColumn423});
            appearance328.FontData.BoldAsString = "True";
            appearance328.FontData.SizeInPoints = 10F;
            appearance328.TextHAlignAsString = "Left";
            ultraGridBand16.Header.Appearance = appearance328;
            ultraGridBand16.Header.Caption = "Motivos de Llamado";
            ultraGridBand16.HeaderVisible = true;
            rowLayout2.CardView = true;
            rowLayout2.CardViewStyle = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            rowLayoutColumnInfo32.OriginX = 0;
            rowLayoutColumnInfo32.OriginY = 0;
            rowLayoutColumnInfo32.PreferredCellSize = new System.Drawing.Size(102, 0);
            rowLayoutColumnInfo32.SpanX = 2;
            rowLayoutColumnInfo32.SpanY = 2;
            rowLayoutColumnInfo34.OriginX = 0;
            rowLayoutColumnInfo34.OriginY = 2;
            rowLayoutColumnInfo34.PreferredCellSize = new System.Drawing.Size(102, 0);
            rowLayoutColumnInfo34.SpanX = 2;
            rowLayoutColumnInfo34.SpanY = 2;
            rowLayout2.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo31,
            rowLayoutColumnInfo32,
            rowLayoutColumnInfo33,
            rowLayoutColumnInfo34});
            rowLayout2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand16.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout2});
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand17.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand17.CardSettings.LabelWidth = 95;
            ultraGridBand17.CardSettings.ShowCaption = false;
            ultraGridBand17.CardSettings.Style = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            ultraGridBand17.CardView = true;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn424.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn424.Header.VisiblePosition = 0;
            ultraGridColumn424.Hidden = true;
            ultraGridColumn424.Width = 100;
            ultraGridColumn425.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn425.Header.VisiblePosition = 1;
            ultraGridColumn425.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn425.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn426.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn426.Header.VisiblePosition = 2;
            ultraGridColumn426.Hidden = true;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn424,
            ultraGridColumn425,
            ultraGridColumn426});
            appearance329.FontData.BoldAsString = "True";
            appearance329.FontData.SizeInPoints = 10F;
            appearance329.TextHAlignAsString = "Left";
            ultraGridBand17.Header.Appearance = appearance329;
            ultraGridBand17.Header.Caption = "Diagnósticos";
            ultraGridBand17.HeaderVisible = true;
            rowLayout3.CardView = true;
            rowLayout3.CardViewStyle = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            rowLayoutColumnInfo36.PreferredCellSize = new System.Drawing.Size(102, 0);
            rowLayout3.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo35,
            rowLayoutColumnInfo36,
            rowLayoutColumnInfo37});
            rowLayout3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand17.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout3});
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn427.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn427.Header.VisiblePosition = 0;
            ultraGridColumn427.Hidden = true;
            ultraGridColumn428.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn428.Header.Caption = "Medicamento o Descartable";
            ultraGridColumn428.Header.VisiblePosition = 1;
            ultraGridColumn428.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn428.Width = 166;
            ultraGridColumn429.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn429.Header.VisiblePosition = 2;
            ultraGridColumn429.Hidden = true;
            ultraGridColumn430.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance330.TextHAlignAsString = "Right";
            ultraGridColumn430.CellAppearance = appearance330;
            ultraGridColumn430.Header.VisiblePosition = 3;
            ultraGridColumn430.Width = 83;
            ultraGridColumn431.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn431.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn431.Header.VisiblePosition = 4;
            ultraGridColumn431.Width = 164;
            ultraGridBand18.Columns.AddRange(new object[] {
            ultraGridColumn427,
            ultraGridColumn428,
            ultraGridColumn429,
            ultraGridColumn430,
            ultraGridColumn431});
            appearance331.FontData.BoldAsString = "True";
            appearance331.FontData.SizeInPoints = 10F;
            appearance331.TextHAlignAsString = "Left";
            ultraGridBand18.Header.Appearance = appearance331;
            ultraGridBand18.Header.Caption = "Medicamentos y Material Descartable";
            ultraGridBand18.HeaderVisible = true;
            ultraGridBand18.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand18);
            this.pacientesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.pacientesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.pacientesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance131.BackColor = System.Drawing.SystemColors.Window;
            this.pacientesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance131;
            appearance132.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance132.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pacientesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance132;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance133.BackColor = System.Drawing.Color.Transparent;
            this.pacientesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance133;
            appearance134.BackColor = System.Drawing.SystemColors.Control;
            appearance134.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.pacientesUltraGrid.DisplayLayout.Override.CellAppearance = appearance134;
            this.pacientesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance135.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance135.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance135.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance135.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.pacientesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance135;
            this.pacientesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance136.ForeColor = System.Drawing.Color.Red;
            this.pacientesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance136;
            this.pacientesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.pacientesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance138.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.pacientesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance138;
            appearance139.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance139.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.pacientesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance139;
            this.pacientesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pacientesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.pacientesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.pacientesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.pacientesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientesUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.pacientesUltraGrid.Name = "pacientesUltraGrid";
            this.pacientesUltraGrid.Size = new System.Drawing.Size(499, 378);
            this.pacientesUltraGrid.TabIndex = 0;
            this.pacientesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.PacientesUltraGridInitializeRow);
            this.pacientesUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.PacientesUltraGridInitializeTemplateAddRow);
            this.pacientesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.PacientesUltraGridAfterEnterEditMode);
            this.pacientesUltraGrid.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.PacientesUltraGridAfterRowUpdate);
            this.pacientesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PacientesUltraGridCellChange);
            this.pacientesUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PacientesUltraGridCellListSelect);
            this.pacientesUltraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PacientesUltraGridClickCellButton);
            this.pacientesUltraGrid.BeforeRowInsert += new Infragistics.Win.UltraWinGrid.BeforeRowInsertEventHandler(this.PacientesUltraGridBeforeRowInsert);
            this.pacientesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pacientesUltraGrid_KeyDown);
            this.pacientesUltraGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PacientesUltraGridKeyPress);
            // 
            // ultraDropDownContratos
            // 
            this.ultraDropDownContratos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownContratos.DataSource = this.contratosBindingSource;
            appearance140.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance140.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance140.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownContratos.DisplayLayout.Appearance = appearance140;
            ultraGridBand19.ColHeadersVisible = false;
            ultraGridColumn432.Header.VisiblePosition = 0;
            ultraGridColumn432.Hidden = true;
            ultraGridColumn433.Header.VisiblePosition = 1;
            ultraGridColumn433.Hidden = true;
            ultraGridColumn434.Header.VisiblePosition = 2;
            ultraGridColumn435.Header.VisiblePosition = 3;
            ultraGridColumn436.Header.VisiblePosition = 4;
            ultraGridBand19.Columns.AddRange(new object[] {
            ultraGridColumn432,
            ultraGridColumn433,
            ultraGridColumn434,
            ultraGridColumn435,
            ultraGridColumn436});
            ultraGridColumn437.Header.VisiblePosition = 0;
            ultraGridColumn438.Header.VisiblePosition = 1;
            ultraGridColumn439.Header.VisiblePosition = 2;
            ultraGridColumn440.Header.VisiblePosition = 3;
            ultraGridColumn441.Header.VisiblePosition = 4;
            ultraGridBand20.Columns.AddRange(new object[] {
            ultraGridColumn437,
            ultraGridColumn438,
            ultraGridColumn439,
            ultraGridColumn440,
            ultraGridColumn441});
            this.ultraDropDownContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand19);
            this.ultraDropDownContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand20);
            this.ultraDropDownContratos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownContratos.DisplayLayout.MaxBandDepth = 5;
            appearance141.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveCellAppearance = appearance141;
            appearance142.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance142.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance142.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveRowAppearance = appearance142;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance143.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.CardAreaAppearance = appearance143;
            appearance144.BackColor = System.Drawing.SystemColors.Control;
            appearance144.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.CellAppearance = appearance144;
            this.ultraDropDownContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance145.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance145.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance145.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance145.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance145.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderAppearance = appearance145;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance146.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSelectorAppearance = appearance146;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedCellAppearance = appearance147;
            appearance148.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance148.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance148.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedRowAppearance = appearance148;
            appearance149.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance149.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance149;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownContratos.DisplayMember = "Contrato";
            this.ultraDropDownContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownContratos.Location = new System.Drawing.Point(375, 199);
            this.ultraDropDownContratos.Name = "ultraDropDownContratos";
            this.ultraDropDownContratos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownContratos.TabIndex = 39;
            this.ultraDropDownContratos.ValueMember = "idContrato";
            this.ultraDropDownContratos.Visible = false;
            this.ultraDropDownContratos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownContratosBeforeDropDown);
            this.ultraDropDownContratos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownContratosRowSelected);
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "Contratos";
            this.contratosBindingSource.DataSource = this.dsContratosLista;
            // 
            // dsContratosLista
            // 
            this.dsContratosLista.DataSetName = "DsContratosLista";
            this.dsContratosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTomadores
            // 
            this.ultraDropDownTomadores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTomadores.DataSource = this.usuariosListaBindingSource;
            appearance232.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance232.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance232.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTomadores.DisplayLayout.Appearance = appearance232;
            ultraGridBand29.ColHeadersVisible = false;
            ultraGridColumn481.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn481.Header.VisiblePosition = 0;
            ultraGridColumn481.Hidden = true;
            ultraGridColumn482.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn482.Header.VisiblePosition = 1;
            ultraGridColumn482.Hidden = true;
            ultraGridColumn483.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn483.Header.VisiblePosition = 2;
            ultraGridColumn483.Hidden = true;
            ultraGridColumn484.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn484.Header.VisiblePosition = 3;
            ultraGridColumn485.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn485.Header.VisiblePosition = 4;
            ultraGridColumn485.Hidden = true;
            ultraGridColumn486.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn486.Header.VisiblePosition = 5;
            ultraGridBand29.Columns.AddRange(new object[] {
            ultraGridColumn481,
            ultraGridColumn482,
            ultraGridColumn483,
            ultraGridColumn484,
            ultraGridColumn485,
            ultraGridColumn486});
            this.ultraDropDownTomadores.DisplayLayout.BandsSerializer.Add(ultraGridBand29);
            this.ultraDropDownTomadores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTomadores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTomadores.DisplayLayout.MaxBandDepth = 5;
            appearance233.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTomadores.DisplayLayout.Override.ActiveCellAppearance = appearance233;
            appearance234.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance234.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance234.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance234.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTomadores.DisplayLayout.Override.ActiveRowAppearance = appearance234;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance235.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTomadores.DisplayLayout.Override.CardAreaAppearance = appearance235;
            appearance236.BackColor = System.Drawing.SystemColors.Control;
            appearance236.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance236.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadores.DisplayLayout.Override.CellAppearance = appearance236;
            this.ultraDropDownTomadores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance237.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance237.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance237.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance237.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance237.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTomadores.DisplayLayout.Override.HeaderAppearance = appearance237;
            this.ultraDropDownTomadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance238.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTomadores.DisplayLayout.Override.RowSelectorAppearance = appearance238;
            this.ultraDropDownTomadores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance239.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTomadores.DisplayLayout.Override.SelectedCellAppearance = appearance239;
            appearance240.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance240.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance240.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadores.DisplayLayout.Override.SelectedRowAppearance = appearance240;
            appearance241.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance241.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTomadores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance241;
            this.ultraDropDownTomadores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTomadores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTomadores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTomadores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTomadores.DisplayMember = "NombApel";
            this.ultraDropDownTomadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTomadores.Location = new System.Drawing.Point(488, 263);
            this.ultraDropDownTomadores.Name = "ultraDropDownTomadores";
            this.ultraDropDownTomadores.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownTomadores.TabIndex = 49;
            this.ultraDropDownTomadores.ValueMember = "idUsuario";
            this.ultraDropDownTomadores.Visible = false;
            this.ultraDropDownTomadores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTomadoresBeforeDropDown);
            // 
            // buttonAgregarPaciente
            // 
            this.buttonAgregarPaciente.Location = new System.Drawing.Point(500, 12);
            this.buttonAgregarPaciente.Name = "buttonAgregarPaciente";
            this.buttonAgregarPaciente.Size = new System.Drawing.Size(125, 23);
            this.buttonAgregarPaciente.TabIndex = 3;
            this.buttonAgregarPaciente.Text = "Agregar un Paciente";
            this.buttonAgregarPaciente.UseVisualStyleBackColor = true;
            this.buttonAgregarPaciente.Click += new System.EventHandler(this.ButtonAgregarPacienteClick);
            // 
            // buttonReferenciaColores
            // 
            this.buttonReferenciaColores.Location = new System.Drawing.Point(12, 12);
            this.buttonReferenciaColores.Name = "buttonReferenciaColores";
            this.buttonReferenciaColores.Size = new System.Drawing.Size(131, 23);
            this.buttonReferenciaColores.TabIndex = 5;
            this.buttonReferenciaColores.Text = "Referencia de Colores";
            this.buttonReferenciaColores.UseVisualStyleBackColor = true;
            this.buttonReferenciaColores.Click += new System.EventHandler(this.ButtonReferenciaColoresClick);
            // 
            // dsBuscarAfiliados
            // 
            this.dsBuscarAfiliados.DataSetName = "DsBuscarAfiliados";
            this.dsBuscarAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarAfiliadosBindingSource
            // 
            this.buscarAfiliadosBindingSource.DataMember = "BuscarAfiliados";
            this.buscarAfiliadosBindingSource.DataSource = this.dsBuscarAfiliados;
            // 
            // dsDireccionLugar1
            // 
            this.dsDireccionLugar1.DataSetName = "DsDireccionLugar";
            this.dsDireccionLugar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCabBuscarTelefono
            // 
            this.dsCabBuscarTelefono.DataSetName = "Dscab_BuscarTelefono";
            this.dsCabBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBuscarTelefono
            // 
            this.dsBuscarTelefono.DataSetName = "DsBuscarTelefono";
            this.dsBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas1
            // 
            this.dsSistemas1.DataSetName = "DsSistemas";
            this.dsSistemas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMedicos
            // 
            this.dsMedicos.DataSetName = "DsEmpleadosLista";
            this.dsMedicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDestinosOtro
            // 
            this.dsDestinosOtro.DataSetName = "DsDestinos";
            this.dsDestinosOtro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCerrarPrestacion
            // 
            this.buttonCerrarPrestacion.Location = new System.Drawing.Point(672, 12);
            this.buttonCerrarPrestacion.Name = "buttonCerrarPrestacion";
            this.buttonCerrarPrestacion.Size = new System.Drawing.Size(100, 23);
            this.buttonCerrarPrestacion.TabIndex = 6;
            this.buttonCerrarPrestacion.Text = "Cerrar Prestación";
            this.buttonCerrarPrestacion.UseVisualStyleBackColor = true;
            this.buttonCerrarPrestacion.Click += new System.EventHandler(this.ButtonCerrarPrestacionClick);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(167, 17);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(81, 14);
            this.ultraLabel1.TabIndex = 7;
            this.ultraLabel1.Text = "Ver agendadas";
            // 
            // ultraDataSourceVerAgendadas
            // 
            this.ultraDataSourceVerAgendadas.Band.Columns.AddRange(new object[] {
            ultraDataColumn4,
            ultraDataColumn5});
            this.ultraDataSourceVerAgendadas.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("1")),
                        ((object)("Nombre")),
                        ((object)("Próxima hora"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("3")),
                        ((object)("Nombre")),
                        ((object)("Próximas 3 hhoras"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("6")),
                        ((object)("Nombre")),
                        ((object)("Próximas 6 horas"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("12")),
                        ((object)("Nombre")),
                        ((object)("Próximas 12 horas"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("24")),
                        ((object)("Nombre")),
                        ((object)("Próximas 24 horas"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("hoy")),
                        ((object)("Nombre")),
                        ((object)("Hoy"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("semana")),
                        ((object)("Nombre")),
                        ((object)("7 días"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("todas")),
                        ((object)("Nombre")),
                        ((object)("Todas"))})});
            // 
            // ultraComboVerAgendadas
            // 
            this.ultraComboVerAgendadas.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboVerAgendadas.CalcManager = this.ultraCalcManager1;
            this.ultraComboVerAgendadas.DataSource = this.ultraDataSourceVerAgendadas;
            appearance282.BackColor = System.Drawing.SystemColors.Window;
            appearance282.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraComboVerAgendadas.DisplayLayout.Appearance = appearance282;
            ultraGridColumn531.Header.VisiblePosition = 0;
            ultraGridColumn531.Hidden = true;
            ultraGridColumn532.Header.VisiblePosition = 1;
            ultraGridBand38.Columns.AddRange(new object[] {
            ultraGridColumn531,
            ultraGridColumn532});
            this.ultraComboVerAgendadas.DisplayLayout.BandsSerializer.Add(ultraGridBand38);
            this.ultraComboVerAgendadas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboVerAgendadas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance283.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance283.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance283.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance283.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.Appearance = appearance283;
            appearance284.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.BandLabelAppearance = appearance284;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance285.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance285.BackColor2 = System.Drawing.SystemColors.Control;
            appearance285.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance285.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.PromptAppearance = appearance285;
            this.ultraComboVerAgendadas.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboVerAgendadas.DisplayLayout.MaxRowScrollRegions = 1;
            appearance286.BackColor = System.Drawing.SystemColors.Window;
            appearance286.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraComboVerAgendadas.DisplayLayout.Override.ActiveCellAppearance = appearance286;
            appearance287.BackColor = System.Drawing.SystemColors.Highlight;
            appearance287.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraComboVerAgendadas.DisplayLayout.Override.ActiveRowAppearance = appearance287;
            this.ultraComboVerAgendadas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboVerAgendadas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance288.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CardAreaAppearance = appearance288;
            appearance289.BorderColor = System.Drawing.Color.Silver;
            appearance289.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CellAppearance = appearance289;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CellPadding = 0;
            appearance290.BackColor = System.Drawing.SystemColors.Control;
            appearance290.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance290.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance290.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance290.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboVerAgendadas.DisplayLayout.Override.GroupByRowAppearance = appearance290;
            appearance291.TextHAlignAsString = "Left";
            this.ultraComboVerAgendadas.DisplayLayout.Override.HeaderAppearance = appearance291;
            this.ultraComboVerAgendadas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboVerAgendadas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance292.BackColor = System.Drawing.SystemColors.Window;
            appearance292.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboVerAgendadas.DisplayLayout.Override.RowAppearance = appearance292;
            this.ultraComboVerAgendadas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance293.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboVerAgendadas.DisplayLayout.Override.TemplateAddRowAppearance = appearance293;
            this.ultraComboVerAgendadas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboVerAgendadas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboVerAgendadas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboVerAgendadas.DisplayMember = "Nombre";
            this.ultraComboVerAgendadas.LimitToList = true;
            this.ultraComboVerAgendadas.Location = new System.Drawing.Point(254, 13);
            this.ultraComboVerAgendadas.Name = "ultraComboVerAgendadas";
            this.ultraComboVerAgendadas.Size = new System.Drawing.Size(151, 22);
            this.ultraComboVerAgendadas.TabIndex = 8;
            this.ultraComboVerAgendadas.ValueMember = "Id";
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametrosBindingSource
            // 
            this.parametrosBindingSource.DataMember = "Parametros";
            this.parametrosBindingSource.DataSource = this.dsParametros;
            // 
            // FormDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ultraDropDownTiposDeDestino);
            this.Controls.Add(this.ultraDropDownCoberturas);
            this.Controls.Add(this.ultraDropDownRecursosActivos);
            this.Controls.Add(this.ultraDropDownPracticas);
            this.Controls.Add(this.ultraDropDownPrepagos);
            this.Controls.Add(this.ultraDropDownMotivos);
            this.Controls.Add(this.ultraDropDownMedicamentos);
            this.Controls.Add(this.ultraDropDownDiagnosticos);
            this.Controls.Add(this.ultraDropDownTomadores);
            this.Controls.Add(this.ultraDropDownMotivosCancelacion);
            this.Controls.Add(this.ultraDropDownLocalidad);
            this.Controls.Add(this.ultraDropDownCalles);
            this.Controls.Add(this.ultraDropDownLugares);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormDespacho";
            this.Tag = "O";
            this.Text = "Prestaciones";
            this.Activated += new System.EventHandler(this.FormDespachoActivated);
            this.Load += new System.EventHandler(this.FormDespachoLoad);
            this.Controls.SetChildIndex(this.ultraDropDownLugares, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalles, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidad, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosCancelacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTomadores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownDiagnosticos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMedicamentos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrepagos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPracticas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownRecursosActivos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCoberturas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeDestino, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacionesResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRecursosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecursosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosCancelacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDespachador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionLugar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabBuscarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinosOtro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceVerAgendadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboVerAgendadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsPrestacionesResumen dsPrestacionesResumen;
        private System.Windows.Forms.BindingSource prestacionesResumenBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid prestacionesResumenUltraGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.ImageList imageList1;
        private Infragistics.Win.UltraWinGrid.UltraGrid prestacionesUltraGrid;
        private WS.DsMotivosDeCancelacionPrestacion dsMotivosDeCancelacionPrestacion;
        private System.Windows.Forms.BindingSource motivosDeCancelacionPrestacionBindingSource;
        private WS.DsLugares dsLugares;
        private System.Windows.Forms.BindingSource lugaresBindingSource;
        private WS.DsDireccionLugar dsDireccionLugar1;
        private WS.DsCallesLista dsCallesLista;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private WS.DsBarrios dsBarrios;
        private System.Windows.Forms.BindingSource barriosListaBindingSource;
        private WS.DsCoberturas dsCoberturas;
        private System.Windows.Forms.BindingSource coberturasBindingSource;
        private WS.DsPracticas dsPracticas;
        private System.Windows.Forms.BindingSource practicasBindingSource;
        private WS.DsPrepagos dsPrepagos;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private WS.DsMotivosDeLlamado dsMotivosDeLlamado;
        private System.Windows.Forms.BindingSource motivosDeLlamadoBindingSource;
        private WS.DsDiagnosticos dsDiagnosticos;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private WS.DsMedicamentos dsMedicamentos;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMedicamentos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownDiagnosticos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrepagos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPracticas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCoberturas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRecursosActivos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrio;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalles;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLugares;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosCancelacion;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeDestino;
        private System.Windows.Forms.BindingSource tiposDeDestinoBindingSource;
        private WS.DsTiposDeDestino dsTiposDeDestino;
        private WS.DsBuscarAfiliados dsBuscarAfiliados;
        private System.Windows.Forms.BindingSource buscarAfiliadosBindingSource;
        private WS.DsCabBuscarTelefono dsCabBuscarTelefono;
        private WS.DsBuscarTelefono dsBuscarTelefono;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private WS.DsContratosLista dsContratosLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTomadores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPacientes;
        private System.Windows.Forms.Button buttonAgregarPaciente;
        private System.Windows.Forms.Button buttonReferenciaColores;
        private System.Windows.Forms.BindingSource prestacionesBindingSource1;
        private WS.DsPrestacion dsPrestacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Infragistics.Win.UltraWinGrid.UltraGrid pacientesUltraGrid;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private WS.DsPacientesPrestacion dsPacientesPrestacion;
        private Infragistics.Win.UltraWinGrid.UltraGrid destinosUltraGrid;
        private System.Windows.Forms.BindingSource destinosBindingSource;
        private WS.DsDestinos dsDestinos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMedicos;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceMedicos;
        private WS.DsSistemas dsSistemas1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownDespachador;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private WS.DsLocalidades dsLocalidades1;
        private WS.DsEmpleadosLista dsMedicos;
        private System.Windows.Forms.BindingSource recursosListaBindingSource;
        private WS.DsRecursosLista dsRecursosLista;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private WS.DsUsuariosLista dsUsuariosLista;
        private System.Windows.Forms.Panel panelEstadoGeneral;
        private WS.DsDestinos dsDestinosOtro;
        private System.Windows.Forms.Button buttonCerrarPrestacion;
        private WS.DsTiposDeDocumento dsTiposDeDocumento;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private UltraDropDown ultraDropDownTiposDeDocumento;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceVerAgendadas;
        private UltraCombo ultraComboVerAgendadas;
        private WS.DsParametros dsParametros;
        private System.Windows.Forms.BindingSource parametrosBindingSource;
        private UltraDropDown ultraDropDownContratos;
        private UltraDropDown ultraDropDownCodigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private WS.DsCodigos dsCodigos;
    }
}
