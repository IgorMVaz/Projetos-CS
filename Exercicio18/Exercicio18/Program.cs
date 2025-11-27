using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.Write("Senha Invalida, digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}