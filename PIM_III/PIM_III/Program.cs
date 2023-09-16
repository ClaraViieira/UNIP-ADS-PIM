using System;
using System.Globalization;

namespace PIM_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionarios = new Funcionarios();
            CtrFuncionarios ctrFuncionarios = new CtrFuncionarios();
            ContaBancaria contaBancaria = new ContaBancaria();
            CtrContaBancaria ctrContaBancaria = new CtrContaBancaria();
            Proventos proventos = new Proventos();
            CtrProventos ctrProventos = new CtrProventos();
            Descontos descontos = new Descontos();
            CtrDescontos ctrDescontos = new CtrDescontos();
            Salario salario = new Salario();
            CtrSalario ctrSalario = new CtrSalario();

            Console.WriteLine("INSERIR ABAIXO DADOS DO FUNCIONÁRIO" + "\n");

            Console.Write("Nome: ");
            funcionarios.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            funcionarios.SalarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("CPF: ");
            funcionarios.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionarios.RG = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            funcionarios.DataNascimento = Console.ReadLine();

            Console.Write("Estado civil: ");
            funcionarios.EstadoCivil = Console.ReadLine();

            Console.Write("Endereço completo: ");
            funcionarios.EnderecoCompleto = Console.ReadLine();

            Console.Write("PIS: ");
            funcionarios.PIS = Console.ReadLine();

            Console.Write("CTPS: ");
            funcionarios.CTPS = Console.ReadLine();

            Console.Write("Título de eleitor: ");
            funcionarios.TituloEleitor = Console.ReadLine();

            Console.Write("Reservista (se mulher, digitar 0): ");
            funcionarios.Reservista = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionarios.CargoFunc = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("INSERIR ABAIXO DADOS DA CONTA DO FUNCIONÁRIO" + "\n");

            Console.Write("Número da agência: ");
            contaBancaria.Agencia = Console.ReadLine();

            Console.Write("Número da conta: ");
            contaBancaria.Conta = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("INSERIR ABAIXO DADOS ADICIONAIS PARA GERAÇÃO DA FOLHA DE PAGAMENTO" + "\n");

            Console.Write("Funcionário possui vale transporte (S/N)? ");
            descontos.IndicadorValeTransporte = Console.ReadLine();

            Console.Write("Funcionário possui vale alimentação (S/N)? ");
            descontos.IndicadorValeAlimentacao = Console.ReadLine();

            Console.Write("Funcionário possui vale refeição (S/N)? ");
            descontos.IndicadorValeRefeicao = Console.ReadLine();

            Console.Write("Funcionário possui plano de saúde (S/N)? ");
            descontos.IndicadorPlanoSaude = Console.ReadLine();

            Console.Write("Funcionário possui plano odontológico (S/N)? ");
            descontos.IndicadorPlanoOdonto = Console.ReadLine();

            Console.Write("Quantidade de dias que o funcionário fatou, caso não haja faltas, digite 0: ");
            descontos.QtdeDiasFaltas = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantidade de dias trabalhados no mês: ");
            descontos.QtdeDiasTrabalhados = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite a quantidade de horas de adicional noturno (separado por ponto, exemplo 5.4 = 5h40min) caso tenha, caso não, digite 0: ");
            proventos.AdicionalNoturno = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade de horas extras (separado por ponto, exemplo 5.4 = 5h40min) caso tenha, caso não, digite 0: ");
            proventos.HorasExtras = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Comissão (digite o valor total de vendas mensal do funcionário caso tenha, caso não, digite 0): ");
            proventos.Comissao = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            var comissao = ctrProventos.CalcularComissao(proventos);
            var horasExtras = ctrProventos.CalcularHorasExtras(proventos, funcionarios);
            var adicionalNoturno = ctrProventos.CalcularAdicionalNoturno(proventos, funcionarios);

            descontos.SalarioBruto = funcionarios.SalarioBase + comissao + horasExtras + adicionalNoturno;

            var inss = ctrDescontos.CalcularINSS(descontos);
            var irrf = ctrDescontos.CalcularIRRF(descontos);
            var planoSaude = ctrDescontos.CalcularPlanoSaude(descontos, funcionarios);
            var planoOdonto = ctrDescontos.CalcularPlanoOdontologico(descontos, funcionarios);
            var valeTransporte = ctrDescontos.CalcularValeTransporte(descontos);
            var valeAlimentacao = ctrDescontos.CalcularValeAlimentacao(descontos);
            var valeRefeicao = ctrDescontos.CalcularValeRefeicao(descontos);

            salario.SalarioLiquido = descontos.SalarioBruto - inss - irrf - planoSaude - planoOdonto - valeAlimentacao - valeRefeicao - valeTransporte;

            string opcao = string.Empty;
            bool exbirMenu = true;

            while (exbirMenu)
            {
                Console.Clear();
                Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO");
                Console.WriteLine("1 - Dados Funcionário e Conta Bancária");
                Console.WriteLine("2 - Descrição Folha de Pagamento");
                Console.WriteLine("3 - Salário Líquido");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        ctrFuncionarios.PrintarDadosFuncionarios(funcionarios);
                        ctrContaBancaria.PrintarDadosContaBancaria(contaBancaria);
                        break;
                    case "2":
                        Console.WriteLine("PROVENTOS: " + "\n" +
                        $"Comissão: " + comissao.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Horas Extras: " + horasExtras.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Adicional Noturno: " + adicionalNoturno.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"DESCONTOS: " + "\n" +
                        $"INSS: " + inss.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"IRRF: " + irrf.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Plano de Saúde: " + planoSaude.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Plano Odontológico: " + planoOdonto.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Vale Transporte: " + valeTransporte.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Vale Alimentação: " + valeAlimentacao.ToString("C", CultureInfo.InvariantCulture) + "\n" +
                        $"Vale Refeição: " + valeRefeicao.ToString("C", CultureInfo.InvariantCulture));
                        break;
                    case "3":
                        ctrSalario.SalarioFinal(salario);
                        break;
                    case "4":
                        exbirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            Console.WriteLine("Programa finalizado com sucesso!");

            Console.ReadLine();
        }
    }
}
