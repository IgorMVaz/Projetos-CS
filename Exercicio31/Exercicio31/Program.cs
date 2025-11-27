using System;
using System.Globalization;

namespace Exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double valorEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorEmReal = ConversorDeMoeda.ConverterDolarParaReal(valorEmDolar, cotacaoDolar);
            Console.WriteLine("Valor a ser pago em reais: R$ " + valorEmReal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}