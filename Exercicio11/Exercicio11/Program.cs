using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o primeiro valor inteiro:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor inteiro:");
            int x2 = int.Parse(Console.ReadLine());

            if (x1 % x2 == 0 || x2 % x1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}