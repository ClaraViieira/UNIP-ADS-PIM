using System;

namespace PIM_IV.Models
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string EnderecoCompleto { get; set; }
        public string PIS { get; set; }
        public string TituloEleitor { get; set; }
        public string CTPS { get; set; }
        public string Reservista { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }
        public string IndicadorPlanoSaude { get; set; }
        public string IndicadorPlanoOdonto { get; set; }
        public string IndicadorValeTransporte { get; set; }
        public string IndicadorValeRefeicao { get; set; }
        public string IndicadorValeAlimentacao { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
    }
}
