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
                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Digite a operação que deseja realizar: ");

                Console.WriteLine("Digite 1 para realizar cálculos de adição");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": throw new NotImplementedException(); break;

                    default: break;
                }
            }
        }
    }
}
