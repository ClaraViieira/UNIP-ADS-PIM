using System;

namespace PIM_III
{
    class Descontos
    {
        public string IndicadorPlanoSaude { get; set; }
        public string IndicadorPlanoOdonto { get; set; }
        public string IndicadorValeAlimentacao { get; set; }
        public string IndicadorValeRefeicao { get; set; }
        public string IndicadorValeTransporte { get; set; }
        public int QtdeDiasTrabalhados { get; set; }
        public int QtdeDiasFaltas { get; set; }
        public decimal SalarioBruto { get; set; }
    }
}