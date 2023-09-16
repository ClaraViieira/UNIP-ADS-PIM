using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_III
{
    class CtrProventos
    {
        public decimal CalcularHorasExtras(Proventos proventos, Funcionarios funcionarios)
        {
            var valorPorHora = funcionarios.SalarioBase / 220m;
            return valorPorHora * proventos.HorasExtras;
        }

        public decimal CalcularComissao(Proventos proventos)
        {
            return proventos.Comissao * 0.03m;
        }

        public decimal CalcularAdicionalNoturno(Proventos proventos, Funcionarios funcionarios)
        {
            var valorPorHora = funcionarios.SalarioBase / 220m;
            return proventos.AdicionalNoturno * (valorPorHora * 1.2m);
        }
    }
}
