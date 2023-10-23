using System;
using PIM_IV.Models;

namespace PIM_IV.Controllers
{
    class CtrProventos
    {
        public decimal CalcularHorasExtras(Proventos proventos, FolhaDePagamento folhaDePagamento)
        {
            TimeSpan.TryParse(proventos.HorasExtras, out TimeSpan horasExtras);

            double minutosExtras = horasExtras.TotalMinutes;
            var valorPorMinuto = folhaDePagamento.SalarioBase / (220 * 60);

            folhaDePagamento.ProventoHorasExtras = valorPorMinuto * (decimal)minutosExtras;
            folhaDePagamento.ProventoHorasExtras = Math.Round(folhaDePagamento.ProventoHorasExtras, 2);

            return folhaDePagamento.ProventoHorasExtras; 
        }

        public decimal CalcularComissao(Proventos proventos, FolhaDePagamento folhaDePagamento)
        {
            folhaDePagamento.ProventoComissao = proventos.Comissao * 0.03m;
            folhaDePagamento.ProventoComissao = Math.Round(folhaDePagamento.ProventoComissao, 2);
            return folhaDePagamento.ProventoComissao;
        }

        public decimal CalcularAdicionalNoturno(Proventos proventos, FolhaDePagamento folhaDePagamento)
        {
            TimeSpan.TryParse(proventos.AdicionalNoturno, out TimeSpan adicionalNoturno);

            double minutosAdicional = adicionalNoturno.TotalMinutes;
            var valorPorMinuto = folhaDePagamento.SalarioBase / (220 * 60);

            folhaDePagamento.ProventoAdicionalNoturno = (decimal)minutosAdicional * (valorPorMinuto * 1.2m);
            folhaDePagamento.ProventoAdicionalNoturno = Math.Round(folhaDePagamento.ProventoAdicionalNoturno, 2);

            return folhaDePagamento.ProventoAdicionalNoturno;
        }

        public decimal SalarioBruto(FolhaDePagamento folhaDePagamento)
        {
            var calculo = folhaDePagamento.ProventoAdicionalNoturno + folhaDePagamento.ProventoHorasExtras + folhaDePagamento.ProventoComissao;
            folhaDePagamento.SalarioBruto = folhaDePagamento.SalarioBase + calculo;
            folhaDePagamento.SalarioBruto = Math.Round(folhaDePagamento.SalarioBruto, 2);
            return folhaDePagamento.SalarioBruto;
        }

        public void Proventos(Proventos proventos, FolhaDePagamento folhaDePagamento)
        {
            CalcularHorasExtras(proventos, folhaDePagamento);
            CalcularComissao(proventos, folhaDePagamento);
            CalcularAdicionalNoturno(proventos, folhaDePagamento);
            SalarioBruto(folhaDePagamento);
        }
    }
}
