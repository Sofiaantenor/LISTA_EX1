using System;

namespace AMS_Ex1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeMinima = 20;
            int idadeMaxima = 50;
            int mediaIdade = (idadeMinima + idadeMaxima)/2;

            Console.WriteLine("");
            Console.WriteLine($"A média dessas idades é: {mediaIdade}");
            Console.WriteLine("");
        }
    }
}