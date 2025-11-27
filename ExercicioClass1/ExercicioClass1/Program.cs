using System;
using System.Globalization;

namespace ExercicioClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite o salário da primeira pessoa: ");
            pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Digite o nome da segunda pessoa:");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Digite o salário da segunda pessoa: ");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (pessoa1.Salario + pessoa2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media);
        }
    }
}
