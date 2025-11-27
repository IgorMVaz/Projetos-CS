using System;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de números a serem incluidos: ");
            int quantidade = int.Parse(Console.ReadLine());

            int dentroIntervalo = 0;
            int foraIntervalo = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Insira o número {i}: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <=20)
                {
                    dentroIntervalo++;
                }
                else
                {
                    foraIntervalo++;
                }
            }
            Console.WriteLine($"Quantidade de números dentro do intervalo [10,20]: {dentroIntervalo}");
            Console.WriteLine($"Quantidade de números fora do intervalo [10,20]: {foraIntervalo}");
        }
    }
}