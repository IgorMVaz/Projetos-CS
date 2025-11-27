using System;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Os divisores do numero são:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}