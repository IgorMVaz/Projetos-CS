using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do item:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do item:");
            int quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1) {
                Console.WriteLine("Total: R$ " + (4.00 * quantidade).ToString("F2"));
            }
            else if (codigo == 2) {
                Console.WriteLine("Total: R$ " + (4.50 * quantidade).ToString("F2"));
            }
            else if (codigo == 3) {
                Console.WriteLine("Total: R$ " + (5.00 * quantidade).ToString("F2"));
            }
            else if (codigo == 4) {
                Console.WriteLine("Total: R$ " + (2.00 * quantidade).ToString("F2"));
            }
            else if (codigo == 5) {
                Console.WriteLine("Total: R$ " + (1.50 * quantidade).ToString("F2"));
            }
            else {
                Console.WriteLine("Código inválido.");
            }
        }
    }
 }