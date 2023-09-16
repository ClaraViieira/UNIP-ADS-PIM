using System;

namespace TrabalhoNP2
{
    class CtrSalario
    {
        public void SalarioFinal(Salario salario)
        {
            Console.WriteLine($"Salário Líquido: {salario.SalarioLiquido.ToString("C")}");
        }
    }
}
