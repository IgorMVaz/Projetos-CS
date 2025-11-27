using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float nFun = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float nHoras = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = nHoras * valorHora;

            Console.WriteLine();
            Console.WriteLine("Dados do Funcionário");
            Console.WriteLine("NUMBER = " + nFun);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
