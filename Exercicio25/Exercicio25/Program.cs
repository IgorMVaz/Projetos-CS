using System;
using System.Globalization;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            decimal numero = decimal.Parse(Console.ReadLine());

            decimal fatorial = 1;
            for (decimal i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
        }
    }
}