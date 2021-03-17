/*
Agora crie uma nova classe, escreva um for que inicie uma variável n (número atual) como 1 e fatorial (resultado total) como 1. Faça seu laço entre 1 a 10 e calcule o resultado!
*/

using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;            

            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine($"Fatorial de {n} é {fatorial}!");                                
            }
            Console.ReadLine();
        }
    }
}
