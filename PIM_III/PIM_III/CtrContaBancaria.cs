using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_III
{
    class CtrContaBancaria
    {
        public void PrintarDadosContaBancaria(ContaBancaria contaBancaria)
        {
            Console.WriteLine("DADOS DA CONTA" + 
                              "Banco: " + contaBancaria.Banco + "\n" +
                              "Número da Agência: " + contaBancaria.Agencia + "\n" +
                              "Núnero da Conta: " + contaBancaria.Conta);
        }
    }
}