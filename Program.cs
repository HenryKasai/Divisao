using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerador, denominador;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Insira o numerador da divisão: ");
            bool numeradorbool = Double.TryParse(Console.ReadLine(), out numerador);
            Console.Write("Insira o denominador da divisão: ");
            bool denominadorbool = Double.TryParse(Console.ReadLine(), out denominador);

            Console.ForegroundColor = ConsoleColor.Green;
            if(!(numeradorbool && denominadorbool))
            {
                Console.WriteLine("Valor inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            else if (denominador == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else 
            {
                double resultado = numerador / denominador;
                Console.WriteLine($"{numerador} dividido por {denominador} é igual a {resultado}.");
            }
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
