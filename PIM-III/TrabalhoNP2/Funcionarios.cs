using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string EnderecoCompleto { get; set; }
        public string PIS { get; set; }
        public string CTPS { get; set; }
        public string TituloEleitor { get; set; }
        public string Reservista { get; set; }
        public ContaBancaria Conta { get; set; }
        public decimal BaseSalarial { get; set; }
        public string CargoFunc { get; set; }

        public Funcionarios() { }

        public Funcionarios(string nome) 
        {
            Nome = nome;
        }

        public Funcionarios(string nome, string cPF, string rG, string dataNascimento, string estadoCivil, string enderecoCompleto, string pIS, string cTPS, string tituloEleitor, string reservista, decimal baseSalarial, string cargoFunc, ContaBancaria conta)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            DataNascimento = dataNascimento;
            EstadoCivil = estadoCivil;
            EnderecoCompleto = enderecoCompleto;
            PIS = pIS;
            CTPS = cTPS;
            TituloEleitor = tituloEleitor;
            Reservista = reservista;
            BaseSalarial = baseSalarial;
            CargoFunc = cargoFunc;
            Conta = conta;

        }

        public void PrintarDadosFuncinario()
        {
            Console.WriteLine("DADOS DO FUNCIONÁRIO" + "\n\n" +
                              "Nome: " + Nome + "\n" +
                              "CPF: " + CPF + "\n" +
                              "RG: " + RG + "\n" +
                              "Data de nascimento: " + DataNascimento + "\n" +
                              "Endereço completo: " + EnderecoCompleto + "\n" +
                              "Estado civil: " + EstadoCivil + "\n" +
                              "PIS: " + PIS + "\n" +
                              "CTPS: " + CTPS + "\n" +
                              "Título de eleitor: " + TituloEleitor + "\n" +
                              "Reservista: " + Reservista + "\n" +
                              "Salário: " + BaseSalarial + "\n" +
                              "Cargo: " + CargoFunc + "\n\n" +
                              "DADOS DA CONTA" + "\n\n" +
                              "Banco: " + Conta.Banco + "\n" +
                              "Número da Agência: " + Conta.Agencia + "\n" +
                              "Núnero da Conta: " + Conta.Conta);
        }
    }
}
