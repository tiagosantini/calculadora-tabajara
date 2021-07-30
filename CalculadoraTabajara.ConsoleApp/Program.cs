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
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Digite a operação que deseja realizar:\n");

                Console.WriteLine("Digite 1 para realizar cálculos de Adição");
                Console.WriteLine("Digite 2 para realizar cálculos de Subtração");
                Console.WriteLine("Digite S para sair");

                Console.Write("Opcao: ");
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

                    default:
                        break;
                }

                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.Clear();

                Console.WriteLine($"Nova operação de {operacao}\n");

                Console.Write("Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0.0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;

                    default: break;
                }


                Console.WriteLine($"\nO resultado da operação de {operacao} é: {resultado}");

                Console.ReadKey();
            }
        }
    }
}
