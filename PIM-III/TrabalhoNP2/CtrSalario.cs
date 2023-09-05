using System;

namespace TrabalhoNP2
{
    class CtrSalario
    {
        public void SalarioFinal(Salario salario, Funcionarios funcionario, ContaBancaria contaBancaria)
        {
            Console.WriteLine($"Pagamento no valor de {salario.SalarioLiquido.ToString("C")} realizado na Banco {contaBancaria.Banco}, " +
                $"agência {contaBancaria.Agencia}, conta {contaBancaria.Conta} do(a) funcionário(a) {funcionario.Nome}");
        }
    }
}
