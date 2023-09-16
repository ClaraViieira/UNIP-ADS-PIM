using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class Proventos
    {
        public decimal AdicionalNoturno { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal Comissao { get; set; }
        public decimal Bonificacao { get; set; }
        public decimal PLR { get; set; }
        public decimal MES { get; set; }
        public decimal ProventoAdicionalNotuno { get; set; }
        public decimal ProventoHoraExtra { get; set; }
        public decimal ProventoComissao { get; set; }
        public decimal ProventoBonificacao { get; set; }
        public decimal ProventoPLR { get; set; }
        public decimal BaseSalarial { get; set; }
        public decimal SalarioBruto { get; set; }
        public Proventos() { }

        public Proventos(decimal salario)
        {
            BaseSalarial = salario;
        }

        public Proventos(decimal adicionalNoturno, decimal horasExtras, decimal comissao, decimal bonificacao, decimal plr, decimal mes, decimal baseSalarial)
        {
            AdicionalNoturno = adicionalNoturno;
            HorasExtras = horasExtras;
            Comissao = comissao;
            Bonificacao = bonificacao;
            PLR = plr;
            MES = mes;
            BaseSalarial = baseSalarial;
            CalcularAdicionalNoturno();
            CalcularHorasExtras();
            CalcularComissao();
            CalcularBonificacao();
        }

        public decimal CalcularAdicionalNoturno()
        {
            var valorPorHora = BaseSalarial / 220m;
            return ProventoAdicionalNotuno = AdicionalNoturno * (valorPorHora * 1.2m);
        }

        public decimal CalcularHorasExtras()
        {
            var valorPorHora = BaseSalarial / 220m;
            return ProventoHoraExtra = (valorPorHora * HorasExtras) * 1.5m;
        }

        public decimal CalcularComissao()
        {
            return ProventoComissao = Comissao * 0.03m;
        }

        public decimal CalcularBonificacao()
        {
            return ProventoBonificacao = Bonificacao * 0.075m;
        }

        public decimal CalcularPLR()
        {
            if (MES == 1m)
                ProventoPLR = 0m;
            else if (MES == 2m)
                ProventoPLR = 0m;
            else if (MES == 3m)
                ProventoPLR = 0m;
            else if (MES == 4m)
                ProventoPLR = 0m;
            else if (MES == 5m)
                ProventoPLR = 0m;
            else if (MES == 6m)
                ProventoPLR = 0m;
            else if (MES == 7m)
                ProventoPLR = 0m;
            else if (MES == 8m)
                ProventoPLR = 0m;
            else if (MES == 9m)
                ProventoPLR = 0m;
            else if (MES == 10m)
                ProventoPLR = 0m;
            else if (MES == 11m)
                ProventoPLR = 0m;
            else if (MES == 12m)
                ProventoPLR = (BaseSalarial / 12m) * PLR;


            return ProventoPLR;
        }

        public decimal ValorSalarioBruto()
        {
            return SalarioBruto = BaseSalarial + (ProventoAdicionalNotuno + ProventoHoraExtra + ProventoComissao + ProventoBonificacao + ProventoPLR);
        }

        public void DescricaoProventos()
        {
            Console.WriteLine($"PROVENTOS" + "\n" +
                   $"Provento Adicional Noturno no valor de {ProventoAdicionalNotuno.ToString("C")}" + "\n" +
                   $"Provento Hora Extra no valor de {ProventoHoraExtra.ToString("C")}" + "\n" +
                   $"Provento Comissão no valor de {ProventoComissao.ToString("C")}" + "\n" +
                   $"Provento Bonificação no valor de {ProventoBonificacao.ToString("C")}" + "\n" +
                   $"Provento PLR no valor de {ProventoPLR.ToString("C")}" + "\n");
        }
    }
}
