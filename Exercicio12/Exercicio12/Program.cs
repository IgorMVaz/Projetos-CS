using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a hora inicial do jogo:");
        int horaInicial = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a hora final do jogo:");
        int horaFinal = int.Parse(Console.ReadLine());

        if (horaInicial != horaFinal)
        {
            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = (24 - horaInicial) + horaFinal;
            }
            Console.WriteLine($"O jogo durou {duracao} hora(s).");
        }
        else
        {
            Console.WriteLine("O jogo durou 24 hora(s).");
        }
    }
}