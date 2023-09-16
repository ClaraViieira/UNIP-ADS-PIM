using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class SalarioLiquido
    {
        public decimal SalarioLiquidoFinal { get; set; }
        public Funcionarios Funcionario { get; set; }
        public ContaBancaria ContaBancaria { get; set; }

        public SalarioLiquido() { }

        public SalarioLiquido(decimal salarioLiquidoFinal, Funcionarios funcionario, ContaBancaria contaBancaria)
        {
            SalarioLiquidoFinal = salarioLiquidoFinal;
            Funcionario = funcionario;
            ContaBancaria = contaBancaria;
        }

        public void Salario()
        {
            Console.WriteLine($"Pagamento no valor de {SalarioLiquidoFinal.ToString("C")} realizado na Banco {ContaBancaria.Banco}, " +
                $"agência {ContaBancaria.Agencia}, conta {ContaBancaria.Conta} do(a) funcionário(a) {Funcionario.Nome}");
        }
    }
}
