using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            float cPeca1, nPecas1, vUnit1;
            float cPeca2, nPecas2, vUnit2;

            string[] valores = Console.ReadLine().Split(' ');
            cPeca1 = float.Parse(valores[0]);
            nPecas1 = float.Parse(valores[1]);
            vUnit1 = float.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cPeca2 = float.Parse(valores[0]);
            nPecas2 = float.Parse(valores[1]);
            vUnit2 = float.Parse(valores[2], CultureInfo.InvariantCulture);

            float total = (nPecas1 * vUnit1) + (nPecas2 * vUnit2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}