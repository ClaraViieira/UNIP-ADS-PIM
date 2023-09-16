using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class Ferias
    {
        public decimal BaseSalarial { get; set; }
        public decimal QtdeDiasFerias { get; set; }
        public decimal SalarioFerias { get; set; }
        public decimal QtdeHorasExtrasFerias { get; set; }
        public decimal DescontoINSS { get; set; }
        public decimal DescontoIRRF { get; set; }
        public decimal ValorFerias { get; set; }
        public decimal ValorUmTercoFerias { get; set; }
        public Funcionarios Funcionario { get; set; }
        public ContaBancaria ContaBancaria { get; set; }


        public Ferias() { }

        public Ferias(decimal baseSalarial, decimal qtdeDiasFerias, decimal qtdeHorasExtrasFerias, Funcionarios funcionario, ContaBancaria contaBancaria)
        {
            BaseSalarial = baseSalarial;
            QtdeDiasFerias = qtdeDiasFerias;
            QtdeHorasExtrasFerias = qtdeHorasExtrasFerias;
            Funcionario = funcionario;
            ContaBancaria = contaBancaria;
            CalcularFerias();
        }

        public decimal CalcularFerias()
        {
            if (QtdeHorasExtrasFerias == 0)
            {
                ValorFerias = (BaseSalarial / 30m) * QtdeDiasFerias;
                ValorUmTercoFerias = ValorFerias / 3;
                DescontoINSS = CalcularINSSFerias(ValorFerias);
                DescontoIRRF = CalcularIRRFFerias(ValorFerias);
                var descontos = DescontoINSS + DescontoIRRF;
                return SalarioFerias = (ValorFerias + ValorUmTercoFerias) - descontos;
            }
            else
            {
                var qtdeHorasExtrasFerias = CalcularHorasExtrasFerias(QtdeHorasExtrasFerias);
                ValorFerias = ((BaseSalarial + qtdeHorasExtrasFerias) / 30m) * QtdeDiasFerias;
                ValorUmTercoFerias = ValorFerias / 3;
                DescontoINSS = CalcularINSSFerias(ValorFerias);
                DescontoIRRF = CalcularIRRFFerias(ValorFerias);
                var descontos = DescontoINSS + DescontoIRRF;
                return SalarioFerias = (ValorFerias + ValorUmTercoFerias) - descontos;
            }
        }

        public decimal CalcularINSSFerias(decimal valorFerias)
        {
            if(valorFerias <= 1320)
                return DescontoINSS = valorFerias * 0.075m;
            else if (valorFerias <= 2571.29m)
                return DescontoINSS = valorFerias * 0.09m;
            else if (valorFerias <= 3856.94m)
                return DescontoINSS = valorFerias * 0.12m;
            else
                return DescontoINSS = valorFerias * 0.14m;
        }

        public decimal CalcularIRRFFerias(decimal valorFerias)
        {
            if (valorFerias <= 2112m)
                return DescontoIRRF = 0m;
            else if (valorFerias <= 2826.65m)
                return DescontoIRRF = (valorFerias * 0.075m) - 142.80m;
            else if (valorFerias <= 3751.05m)
                return DescontoIRRF = (valorFerias * 0.15m) - 354.80m;
            else if (valorFerias <= 4664.68m)
                return DescontoIRRF = (valorFerias * 0.225m) - 636.13m;
            else
                return DescontoIRRF = (valorFerias * 0.275m) - 869.36m;
        }

        public decimal CalcularHorasExtrasFerias(decimal qtdeHorasExtrasFerias)
        {
            var valorPorHora = BaseSalarial / 220m;
            var descontoHoraExtra = 0m;
            return descontoHoraExtra = (valorPorHora * qtdeHorasExtrasFerias) * 1.5m;
        }

        public void PrintarFerias()
        {
            if (QtdeDiasFerias == 0)
                Console.WriteLine("Funionário não possui férias.");
            else
                Console.WriteLine($"FÉRIAS" + "\n" +
                       $"Desconto INSS no valor de {DescontoINSS.ToString("C")}" + "\n" +
                       $"Desconto IRRF no valor de {DescontoIRRF.ToString("C")}" + "\n" +
                       $"Salário férias no valor de {ValorFerias.ToString("C")}" + "\n" +
                       $"1/3 das férias no valor de {ValorUmTercoFerias.ToString("C")}" + "\n\n" +
                       $"Pagamento das férias no valor de {SalarioFerias.ToString("C")} realizado na Banco {ContaBancaria.Banco}, " +
                       $"agência {ContaBancaria.Agencia}, conta {ContaBancaria.Conta} do(a) funcionário(a) {Funcionario.Nome}");

        }
    }
}
