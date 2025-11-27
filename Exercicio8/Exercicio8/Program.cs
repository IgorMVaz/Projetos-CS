using System;
using System.Globalization;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = float.Parse(valores[0], CultureInfo.InvariantCulture);
            B = float.Parse(valores[1], CultureInfo.InvariantCulture);
            C = float.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = 3.14159f * (C * C);
            trapezio = ((A + B) * C) / 2;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine();
            Console.WriteLine("AREA DAS FIGURAS:");
            Console.WriteLine();
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}