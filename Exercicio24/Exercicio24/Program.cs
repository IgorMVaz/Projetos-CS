using System;
using System.Globalization;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de numeros: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int a = int.Parse(line[0]);
                int b = int.Parse(line[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double resultado = (double)a / b;
                    Console.WriteLine("O resultado da divisão é " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}