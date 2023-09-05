using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class Descontos
    {
        public decimal DescontoIRRF { get; set; }
        public decimal DescontoINSS { get; set; }
        public decimal DescontoValeTransporte { get; set; }
        public decimal DescontoValeRefeicao { get; set; }
        public decimal DescontoValeAlimentacao { get; set; }
        public decimal DescontoPlanoSaude { get; set; }
        public decimal DescontoPlanoOdontologico { get; set; }
        public decimal DescontoFalta { get; set; }
        public decimal QtdeDiasFaltas { get; set; }
        public string ValeTransporte { get; set; }
        public string ValeRefeicao { get; set; }
        public string ValeAlimentacao { get; set; }
        public string PlanoSaude { get; set; }
        public string PlanoOdontologico { get; set; }
        public decimal QtdeDiasTrabalhados { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal SalarioLiquido { get; set; }

        public Descontos() { }

        public Descontos(decimal salarioBruto)
        {
            SalarioBruto = salarioBruto;
        }

        public Descontos(decimal qtdeDiasTrabalhados, string valeTransporte, string valeRefeicao, string valeAlimentacao, string planoSaude, string planoOdontologico, decimal qtdeDiasFaltas, decimal salarioBruto, decimal salarioBase)
        {
            QtdeDiasTrabalhados = qtdeDiasTrabalhados;
            ValeTransporte = valeTransporte;
            ValeRefeicao = valeRefeicao;
            ValeAlimentacao = valeAlimentacao;
            PlanoSaude = planoSaude;
            PlanoOdontologico = planoOdontologico;
            QtdeDiasFaltas = qtdeDiasFaltas;
            SalarioBruto = salarioBruto;
            SalarioBase = salarioBase;
            CalcularIFFR();
            CalcularINSS();
            CalcularValeTransporte();
            CalcularValeRefeicao();
            CalcularValeAlimentacao();
            CalcularPlanoSaude();
            CalcularPlanoOdontologico();
            CalcularFalta();
        }

        public decimal CalcularINSS()
        {
            if (SalarioBruto <= 1320)
                return DescontoINSS = SalarioBruto * 0.075m;
            else if (SalarioBruto <= 2571.29m)
                return DescontoINSS = SalarioBruto * 0.09m;
            else if (SalarioBruto <= 3856.94m)
                return DescontoINSS = SalarioBruto * 0.12m;
            else
                return DescontoINSS = SalarioBruto * 0.14m;

            //Até R$ 1.320,00 – 7,50 % – Sem parcela a deduzir
            //De R$ 1.320,01 até R$ 2.571,29 – 9,00 % – Parcela a deduzir: 19,80
            //De R$ 2.571,30 até R$ 3.856,94 – 12,00 % – Parcela a deduzir: 96,94
            //De R$ 3.856,95 até R$ 7.507,49 – 14,00 % – Parcela a deduzir: 174,08
        }

        public decimal CalcularIFFR()
        {
            if (SalarioBruto <= 2112m)
                return DescontoIRRF = 0m;
            else if (SalarioBruto <= 2826.65m)
                return DescontoIRRF = (SalarioBruto * 0.075m) - 142.80m;
            else if (SalarioBruto <= 3751.05m)
                return DescontoIRRF = (SalarioBruto * 0.15m) - 354.80m;
            else if (SalarioBruto <= 4664.68m)
                return DescontoIRRF = (SalarioBruto * 0.225m) - 636.13m;
            else
                return DescontoIRRF = (SalarioBruto * 0.275m) - 869.36m;

            //Faixa 1: Até R$ 2.112,00: isento
            //Faixa 2: De R$ 2.112,01 até R$ 2.826,65: 7,5 %
            //Faixa 3: De R$ 2.826,66 até R$ 3.751,05: 15 %
            //Faixa 4: De R$ 3.751,06 até R$ 4.664,68: 22,5 %
            //Faixa 5: Acima de R$ 4.664,68: 27,5 %

            //Faixa 1: zero
            //Faixa 2: R$ 142,80
            //Faixa 3: R$ 354,80
            //Faixa 4: R$ 636,13
            //Faixa 5: R$ 869,36
        }

        public decimal CalcularValeTransporte()
        {
            if (ValeRefeicao == "S")
            {
                if (QtdeDiasFaltas == 0)
                {
                    //Passagem Campinas ida e volta: 10,80
                    decimal valeTransporteoPorDia = 10.80m;
                    return DescontoValeTransporte = (valeTransporteoPorDia * QtdeDiasTrabalhados) * 0.06m;
                }
                else
                {
                    decimal valeTransporteoPorDia = 10.80m;
                    return DescontoValeTransporte = (valeTransporteoPorDia * (QtdeDiasTrabalhados - QtdeDiasFaltas)) * 0.06m;
                }
            }
            else
                return DescontoValeTransporte = 0m;
        }

        public decimal CalcularValeAlimentacao()
        {
            if (ValeAlimentacao == "S")
            {
                decimal valeAlimentacao = 400m;
                return DescontoValeAlimentacao = valeAlimentacao * 0.10m;
            }
            else
                return DescontoValeAlimentacao = 0m;
        }

        public decimal CalcularValeRefeicao()
        {
            if (ValeRefeicao == "S")
            {
                if (QtdeDiasFaltas == 0)
                {
                    decimal valeRefeicaoPorDia = 16m;
                    return DescontoValeRefeicao = (valeRefeicaoPorDia * QtdeDiasTrabalhados) * 0.10m;
                }
                else
                {
                    decimal valeRefeicaoPorDia = 10.80m;
                    return DescontoValeTransporte = (valeRefeicaoPorDia * (QtdeDiasTrabalhados - QtdeDiasFaltas)) * 0.10m;
                }
            }
            else
                return DescontoValeRefeicao = 0m;

        }

        public decimal CalcularPlanoSaude()
        {
            if (PlanoSaude == "S")
                return DescontoPlanoSaude = SalarioBase * 0.03m;
            else
                return DescontoPlanoSaude = 0m;
        }

        public decimal CalcularPlanoOdontologico()
        {
            if (PlanoSaude == "S")
                return DescontoPlanoOdontologico = SalarioBase * 0.02m;
            else
                return DescontoPlanoSaude = 0m;
        }

        public decimal CalcularFalta()
        {
            if (QtdeDiasFaltas == 0m)
                return DescontoFalta;
            else
                return DescontoFalta = (SalarioBase / 30m) * QtdeDiasFaltas;
        }

        public decimal ValorSalarioLiquido()
        {
            return SalarioLiquido = SalarioBruto - (DescontoINSS + DescontoIRRF + DescontoValeTransporte + DescontoValeRefeicao
                + DescontoValeAlimentacao + DescontoPlanoSaude + DescontoPlanoOdontologico + DescontoFalta);
        }

        public void DescricaoDescontos()
        {
            Console.WriteLine($"DESCONTOS" + "\n" +
                   $"Desconto IRRF no valor de {DescontoIRRF.ToString("C")}" + "\n" +
                   $"Desconto INSS no valor de {DescontoINSS.ToString("C")}" + "\n" +
                   $"Desconto Vale Transporte no valor de {DescontoValeTransporte.ToString("C")}" + "\n" +
                   $"Desconto Vale Alimentação no valor de {DescontoValeAlimentacao.ToString("C")}" + "\n" +
                   $"Desconto Vale Refeição no valor de {DescontoValeRefeicao.ToString("C")}" + "\n" +
                   $"Desconto Plano de Saúde no valor de {DescontoPlanoSaude.ToString("C")}" + "\n" +
                   $"Desconto de Faltas no valor de {DescontoFalta.ToString("C")}" + "\n" +
                   $"Desconto Plano Odontológico no valor de {DescontoPlanoOdontologico.ToString("C")}");
        }
    }
}
