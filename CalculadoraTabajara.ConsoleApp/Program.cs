using System;
using System.Collections.Generic;

namespace CalculadoraTabajara.ConsoleApp
{
    class Program
    {
        public static List<string> historicoOperacoes = new List<string>();

        static void Main(string[] args)
        {

            while (true)
            {
                string opcao = MostrarMenuPrincipal();

                string operacao = ObterOperacao(opcao);

                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;

                else if (opcao == "5")
                {
                    ExibirHistoricoDeOperacoes(historicoOperacoes);
                    continue;
                }

                Console.Clear();

                Console.WriteLine($"Nova operação de {operacao}\n");

                double primeiroNumero = ObterPrimeiroNumero();

                double segundoNumero = ObterSegundoNumero();

                double resultado = RealizarCalculo(opcao, primeiroNumero, segundoNumero);

                Console.WriteLine($"\nO resultado da operação de {operacao} é: {resultado}");

                Console.ReadKey();
            }
        }

        private static double RealizarCalculo(string opcao, double primeiroNumero, double segundoNumero)
        {
            double resultado = 0.0;

            switch (opcao)
            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes.Add($"Adição: {primeiroNumero} + {segundoNumero} = {resultado}");
                    break;

                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes.Add($"Subtração: {primeiroNumero} - {segundoNumero} = {resultado}");
                    break;

                case "3":
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes.Add($"Multiplicação: {primeiroNumero} * {segundoNumero} = {resultado}");
                    break;

                case "4":
                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes.Add($"Divisão: {primeiroNumero} / {segundoNumero} = {resultado}");
                    break;

                default:
                    break;
            }

            return resultado;
        }

        private static double ObterSegundoNumero()
        {
            double segundoNumero;
            do
            {
                Console.Write("Digite o segundo número: ");
                segundoNumero = Convert.ToDouble(Console.ReadLine());

                if (segundoNumero == 0)
                {
                    Console.Clear();
                    Console.WriteLine("O segundo número não pode ser zero, tente novamente.");
                    Console.ReadKey();
                }

            } while (segundoNumero == 0);
            return segundoNumero;
        }

        private static double ObterPrimeiroNumero()
        {
            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());
            return primeiroNumero;
        }

        private static string MostrarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara\n");

            Console.WriteLine("Digite a operação que deseja realizar:\n");

            Console.WriteLine("Digite 1 para realizar cálculos de Adição");
            Console.WriteLine("Digite 2 para realizar cálculos de Subtração");
            Console.WriteLine("Digite 3 para realizar cálculos de Multiplicação");
            Console.WriteLine("Digite 4 para realizar cálculos de Divisão");
            Console.WriteLine("Digite 5 para visualizar o histórico de operações");
            Console.WriteLine("Digite S para sair");

            Console.Write("\nOpcao: ");
            string opcao = Console.ReadLine();
            return opcao;
        }

        private static void ExibirHistoricoDeOperacoes(List<string> historicoOperacoes)
        {
            Console.Clear();
            Console.WriteLine("Histórico de Operações\n");

            if (historicoOperacoes.Count == 0)
                Console.WriteLine("Nenhuma operação realizada até agora!");
            else
                foreach (string operacaoRealizada in historicoOperacoes)
                    Console.WriteLine(operacaoRealizada);

            Console.ReadKey();
        }

        private static string ObterOperacao(string opcao)
        {
            string operacao = "";

            switch (opcao)
            {
                case "1":
                    operacao = "Adição";
                    break;
                case "2":
                    operacao = "Subtração";
                    break;
                case "3":
                    operacao = "Multiplicação";
                    break;
                case "4":
                    operacao = "Divisão";
                    break;
                default:
                    break;
            }

            return operacao;
        }
    }
}
