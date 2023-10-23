using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_IV.Models
{
    class Descontos
    {
        public int QtdeDiasTrabalhados { get; set; }
        public int QtdeDiasFaltas { get; set; }
        public string IndicadorPlanoSaude { get; set; }
        public string IndicadorPlanoOdonto { get; set; }
        public string IndicadorValeTransporte { get; set; }
        public string IndicadorValeRefeicao { get; set; }
        public string IndicadorValeAlimentacao { get; set; }
    }
}
