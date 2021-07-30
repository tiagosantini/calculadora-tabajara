using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> historicoOperacoes = new List<string>();

            while (true)
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

                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;
                
                else if (opcao == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Histórico de Operações\n");

                    if (historicoOperacoes.Count == 0)
                        Console.WriteLine("Nenhuma operação realizada até agora!");
                    else
                        foreach (string operacaoRealizada in historicoOperacoes)
                            Console.WriteLine(operacaoRealizada);

                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                Console.WriteLine($"Nova operação de {operacao}\n");

                Console.Write("Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                double segundoNumero;
                do
                {
                    Console.Write("Digite o segundo número: ");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());

                    if(segundoNumero == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("O segundo número não pode ser zero, tente novamente.");
                        Console.ReadKey();
                    }

                } while (segundoNumero == 0);
               

                double resultado = 0.0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero;
                        historicoOperacoes.Add($"Adição: {primeiroNumero} + {segundoNumero} = {resultado}");
                        break;

                    case "2": resultado = primeiroNumero - segundoNumero;
                        historicoOperacoes.Add($"Subtração: {primeiroNumero} - {segundoNumero} = {resultado}");
                        break;

                    case "3": resultado = primeiroNumero * segundoNumero;
                        historicoOperacoes.Add($"Multiplicação: {primeiroNumero} * {segundoNumero} = {resultado}");
                        break;

                    case "4": resultado = primeiroNumero / segundoNumero;
                        historicoOperacoes.Add($"Divisão: {primeiroNumero} / {segundoNumero} = {resultado}");
                        break;

                    default:
                        break;
                }

                Console.WriteLine($"\nO resultado da operação de {operacao} é: {resultado}");

                Console.ReadKey();
            }
        }
    }
}
