using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class CtrFuncionarios
    {
        public void PrintarDadosFuncionarios(Funcionarios funcionarios, ContaBancaria contaBancaria)
        {
            Console.WriteLine("DADOS DO FUNCIONÁRIO" + "\n\n" +
                              "Nome: " + funcionarios.Nome + "\n" +
                              "CPF: " + funcionarios.CPF + "\n" +
                              "RG: " + funcionarios.RG + "\n" +
                              "Data de nascimento: " + funcionarios.DataNascimento + "\n" +
                              "Endereço completo: " + funcionarios.EnderecoCompleto + "\n" +
                              "Estado civil: " + funcionarios.EstadoCivil + "\n" +
                              "PIS: " + funcionarios.PIS + "\n" +
                              "CTPS: " + funcionarios.CTPS + "\n" +
                              "Título de eleitor: " + funcionarios.TituloEleitor + "\n" +
                              "Reservista: " + funcionarios.Reservista + "\n" +
                              "Salário: " + funcionarios.SalarioBase + "\n" +
                              "Cargo: " + funcionarios.CargoFunc + "\n\n" +
                              "DADOS DA CONTA" + "\n\n" +
                              "Banco: " + contaBancaria.Banco + "\n" +
                              "Número da Agência: " + contaBancaria.Agencia + "\n" +
                              "Núnero da Conta: " + contaBancaria.Conta);
        }
    }
}
