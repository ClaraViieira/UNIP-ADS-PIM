using System;

namespace PIM_IV.Models
{
    class FolhaDePagamento
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string MesReferencia { get; set; }
        public decimal ProventoHorasExtras { get; set; }
        public decimal ProventoComissao { get; set; }
        public decimal ProventoAdicionalNoturno { get; set; }
        public decimal DescontoINSS { get; set; }
        public decimal DescontoIRRF { get; set; }
        public decimal DescontoVT { get; set; }
        public decimal DescontoVA { get; set; }
        public decimal DescontoVR { get; set; }
        public decimal DescontoPO { get; set; }
        public decimal DescontoPS { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioLiquido { get; set; }

    }
}
