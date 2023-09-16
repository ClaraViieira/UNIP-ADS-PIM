using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class ContaBancaria
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }

        public ContaBancaria() { }
        public ContaBancaria(string banco, string agencia, string conta)
        {
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
        }
    }
}
