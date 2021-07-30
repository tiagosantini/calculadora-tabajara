using System;

namespace CalculadoraTabajara.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculadora calculadora = null;

            while (true)
            {
                TelaPrincipal.MostrarMenu();

                calculadora = new Calculadora(Console.ReadLine());

                if (calculadora.Opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;

                else if (calculadora.Opcao == "5")
                {
                    calculadora.ExibirHistoricoDeOperacoes();
                    continue;
                }

                Console.Clear();

                Console.WriteLine($"Nova operação de {calculadora.Operacao}\n");

                double resultado = 
                    calculadora.Calcular(TelaPrincipal.ObterPrimeiroNumero(), TelaPrincipal.ObterSegundoNumero());

                Console.WriteLine($"\nO resultado da operação de {calculadora.Operacao} é: {resultado}");

                Console.ReadKey();
            }
        }

    }
}
