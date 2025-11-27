using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Os numeros primos são:");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}