using System;
using System.Collections.Generic;

namespace CalculadoraTabajara.ConsoleApp
{
    public class Calculadora
    {
        private static List<string> historicoOperacoes = new List<string>();

        public string Opcao { get; internal set; }
        public string Operacao { get; internal set; }
        public string PrimeiroNumero { get; internal set; }
        public string SegundoNumero { get; internal set; }

        public Calculadora(string opcao)
        {
            Opcao = opcao;
            ObterOperacao();
        }

        public double Calcular(double primeiroNumero, double segundoNumero)
        {
            double resultado = default;

            switch (Opcao)
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

        public void ExibirHistoricoDeOperacoes()
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

        private void ObterOperacao()
        {
            switch (Opcao)
            {
                case "1":
                    Operacao = "Adição";
                    break;
                case "2":
                    Operacao = "Subtração";
                    break;
                case "3":
                    Operacao = "Multiplicação";
                    break;
                case "4":
                    Operacao = "Divisão";
                    break;
                default:
                    break;
            }
        }
    }
}