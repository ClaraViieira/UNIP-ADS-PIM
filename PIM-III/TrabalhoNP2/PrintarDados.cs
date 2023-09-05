using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoNP2
{
    class PrintarDados
    {
        public void Dados()
        {
            Console.WriteLine("INSERIR ABAIXO DADOS DO FUNCIONÁRIO" + "\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("RG: ");
            string rg = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            string dataNascimento = Console.ReadLine();

            Console.Write("Estado civil: ");
            string estadoCivil = Console.ReadLine();

            Console.Write("Endereço completo: ");
            string endereco = Console.ReadLine();

            Console.Write("PIS: ");
            string pis = Console.ReadLine();

            Console.Write("CTPS: ");
            string ctps = Console.ReadLine();

            Console.Write("Título de eleitor: ");
            string tituloEleitor = Console.ReadLine();

            Console.Write("Reservista (se mulher, digitar 0): ");
            string reservista = Console.ReadLine();

            Console.Write("Cargo: ");
            string cargoFuncionario = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("INSERIR ABAIXO DADOS DA CONTA DO FUNCIONÁRIO" + "\n");

            Console.Write("Número da agência: ");
            string numeroAgencia = Console.ReadLine();

            Console.Write("Número da conta: ");
            string numeroConta = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("INSERIR ABAIXO DADOS ADICIONAIS PARA GERAÇÃO DA FOLHA DE PAGAMENTO" + "\n");

            Console.Write("Funcionário possui vale transporte? (S/N) ");
            string vt = Console.ReadLine();

            Console.Write("Funcionário possui vale alimentação? (S/N) ");
            string va = Console.ReadLine();

            Console.Write("Funcionário possui vale refeição? (S/N) ");
            string vr = Console.ReadLine();

            Console.Write("Funcionário possui plano de saúde? (S/N) ");
            string ps = Console.ReadLine();

            Console.Write("Funcionário possui plano odontológico? (S/N) ");
            string po = Console.ReadLine();

            Console.Write("Digite a quantdidade de horas de adicional noturno (separado por ponto, exemplo 5.4 = 5h40min) caso tenha, caso não, digite 0: ");
            decimal adicionalNoturno = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade de horas extras (separado por ponto, exemplo 5.4 = 5h40min) caso tenha, caso não, digite 0: ");
            decimal horaExtra = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Comissão (digite o valor total de vendas mensal do funcionário caso tenha, caso não, digite 0): ");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Bonificação (digite o valor acordado de bonificação mensal do funcionário caso tenha, caso não, digite 0): ");
            decimal bonificacao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite respectivamente o mês atual e quantidade de meses do funcionário na empresa (exemplo: 5/2): ");
            string[] calculoPlr = Console.ReadLine().Split('/');
            decimal mes = Convert.ToDecimal(calculoPlr[0]);
            decimal plr = Convert.ToDecimal(calculoPlr[1]);

            Console.Write("Quantidade de dias trabalhados no mês: ");
            decimal qtdeDiasTrabalhados = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Funcionário irá tirar férias? (S/N) ");
            string respostaFerias = Console.ReadLine();
            decimal qtdeDiasFerias = 0m;
            decimal qtdeHorasExtrasFerias = 0m;

            if (respostaFerias == "S")
            {
                Console.Write("Quantidade de dias de férias a ser tirado: ");
                qtdeDiasFerias = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Quantidade de horas extras dentro do mês, caso não tenha, digite 0: ");
                qtdeHorasExtrasFerias = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.Write("Funcionário fatou algum dia? (S/N) ");
            string respostaFalta = Console.ReadLine();
            decimal qtdeDiasFaltas = 0m;

            if (respostaFalta == "S")
            {
                Console.Write("Quantidade de dias de falta: ");
                qtdeDiasFaltas = Convert.ToDecimal(Console.ReadLine());
            }

            Console.Clear();

            Funcionarios funcionarios = new Funcionarios(nome, cpf, rg, dataNascimento, estadoCivil, endereco, pis, ctps, tituloEleitor, reservista, salarioBase, cargoFuncionario, new ContaBancaria("341 - Itaú Unibanco S/A", numeroAgencia, numeroConta));
            Proventos proventos = new Proventos(adicionalNoturno, horaExtra, comissao, bonificacao, plr, mes, salarioBase);
            var salarioBruto = proventos.ValorSalarioBruto();
            Descontos descontos = new Descontos(qtdeDiasTrabalhados, vt, vr, va, ps, po, qtdeDiasFaltas, salarioBruto, salarioBase);
            var salarioLiquido = descontos.ValorSalarioLiquido();
            SalarioLiquido salarioTotal = new SalarioLiquido(salarioLiquido, new Funcionarios(nome), new ContaBancaria("341 - Itaú Unibanco S/A", numeroAgencia, numeroConta));
            Ferias ferias = new Ferias(salarioBase, qtdeDiasFerias, qtdeHorasExtrasFerias, new Funcionarios(nome), new ContaBancaria("341 - Itaú Unibanco S/A", numeroAgencia, numeroConta));

            string opcao = string.Empty;
            bool exbirMenu = true;

            while (exbirMenu)
            {
                Console.Clear();
                Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO");
                Console.WriteLine("1 - Dados Funcionário");
                Console.WriteLine("2 - Cálculo Férias");
                Console.WriteLine("3 - Cálculo Salário");
                Console.WriteLine("4 - Descrição Folha de Pagamento");
                Console.WriteLine("5 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        funcionarios.PrintarDadosFuncinario();
                        break;
                    case "2":
                        ferias.PrintarFerias();
                        break;
                    case "3":
                        salarioTotal.Salario();
                        break;
                    case "4":
                        proventos.DescricaoProventos();
                        descontos.DescricaoDescontos();
                        break;
                    case "5":
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
