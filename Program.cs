using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Insira o numerador da divisão: ");
            decimal numerador = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Insira o denominador da divisão: ");
            decimal denominador = Convert.ToDecimal(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            if (denominador == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else 
            {
                decimal resultado = numerador / denominador;
                Console.WriteLine($"{numerador} dividido por {denominador} é igual a {resultado}.");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();

        }
    }
}
