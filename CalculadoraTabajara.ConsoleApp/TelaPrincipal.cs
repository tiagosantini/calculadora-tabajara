using System;

namespace CalculadoraTabajara.ConsoleApp
{
    public static class TelaPrincipal
    {
        public static void MostrarMenu()
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
        }

        public static double ObterPrimeiroNumero()
        {
            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());
            return primeiroNumero;
        }

        public static double ObterSegundoNumero()
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
    }
}
