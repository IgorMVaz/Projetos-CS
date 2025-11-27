using System;
using System.Globalization;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor1 == 0 && valor2 == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (valor1 == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (valor2 == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (valor1 > 0 && valor2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (valor1 < 0 && valor2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (valor1 < 0 && valor2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}