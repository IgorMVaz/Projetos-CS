using System;
using System.Globalization;


namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o raio do círculo:");
           double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
              
           
           double area = Math.PI * Math.Pow(raio, 2);
              
            
           Console.WriteLine($"A área do círculo é: {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}