using System;
using System.Globalization;

namespace Exercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas = new Notas();

            Console.Write("Nome do Aluno: ");
            notas.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            notas.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = notas.CalcularMedia();
            string status = notas.VerificarAprovacao();
            double faltante = notas.FaltamteParaAprovacao();
            Console.WriteLine($"Nota Final = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(status);
            if (status == "Reprovado")
            {
                Console.WriteLine($"Faltam {faltante.ToString("F2", CultureInfo.InvariantCulture)} pontos para aprovação.");
            }
        }
    }
}