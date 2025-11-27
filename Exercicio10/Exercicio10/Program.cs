using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par.");
            }
            else
            {
                Console.WriteLine("O numero é impar.");
            }
        }
    }
}