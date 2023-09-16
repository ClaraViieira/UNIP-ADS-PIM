using System;

namespace PIM_III
{
    class CtrSalario
    {
        public void SalarioFinal(Salario salario)
        {
            Console.WriteLine($"Salário Líquido: {salario.SalarioLiquido.ToString("C")}");
        }
    }
}
