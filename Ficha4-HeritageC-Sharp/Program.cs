using System;
using System.Collections.Generic;

namespace Ficha4_HeritageC_Sharp
{
    class Program
    {
        static List<Funcionario> funcionarios;
        static void Main(string[] args)
        {
            funcionarios = new List<Funcionario>();
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Inserir Gerente");
                Console.WriteLine("2-Inserir Operário");
                Console.WriteLine("3-Visualizar Gerentes");
                Console.WriteLine("4-Visualizar Operários");
                Console.WriteLine("5-Visualizar Funcionários");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        inserirGerente();
                        break;
                    case 2:
                        inserirOperario();
                        break;
                    case 3:
                        visualizarGerente();
                        break;
                    case 4:
                        visualizarOperario();
                        break;
                    case 5:
                        VisualizarFuncionarios();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void inserirGerente()
        {
            Console.Clear();

            Console.WriteLine("Insira o ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a data de nascimento: AAAA/MM/DD");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o E-mail");
            string eMail = Console.ReadLine();
            Console.WriteLine("Insira o valor hora");
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a Especialidade");
            string especialidade = Console.ReadLine();
            Console.WriteLine("Insira a Extensão");
            int extensao = int.Parse(Console.ReadLine());

            funcionarios.Add(new Gerente(id,nome,dataNasc,eMail,valorHora,especialidade,extensao));

            Console.WriteLine("Gerente inserido com sucesso!");
            Console.ReadKey();
        }

        private static void inserirOperario()
        {
            Console.Clear();

            Console.WriteLine("Insira o ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a data de nascimento: AAAA/MM/DD");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o E-mail");
            string eMail = Console.ReadLine();
            Console.WriteLine("Insira o valor hora");
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o departamento");
            string departamento = Console.ReadLine();


            funcionarios.Add(new Operario(id, nome, dataNasc, eMail, valorHora, departamento));

            Console.WriteLine("Operário inserido com sucesso!");
            Console.ReadKey();
        }

        private static void visualizarGerente()
        {

            Console.Clear();
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Gerente) == funcionarios[i].GetType())
                {
                    Console.WriteLine(funcionarios[i].ToString());
                }
            }

            Console.WriteLine("Qual o ID do Gerente a alterar?");
            int op = int.Parse(Console.ReadLine());

            Console.Clear();

            int op2 = 1;
            while (op2 != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Alterar Valor Hora");
                Console.WriteLine("2-Calcular Idade");
                Console.WriteLine("3-Calcular Salário");
                Console.WriteLine("0-Sair");
                op2 = int.Parse(Console.ReadLine());

                switch (op2)
                {
                    case 0:
                        break;
                    case 1:
                        Gerente.alterarValorHora();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }



        private static void visualizarOperario()
        {
            Console.Clear();
            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (typeof(Operario) == funcionarios[i].GetType())
                {
                    Console.WriteLine(funcionarios[i].ToString());
                }
            }
            Console.ReadKey();
        }

        private static void VisualizarFuncionarios()
        {
            Console.Clear();
            for (int i = 0; i < funcionarios.Count; i++)
            {
                {
                    Console.WriteLine(funcionarios[i].ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
