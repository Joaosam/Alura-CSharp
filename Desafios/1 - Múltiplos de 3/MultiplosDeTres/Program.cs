/*
 Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.

Dica: Existem duas maneiras tradicionais de resolver este problema. Uma delas consiste em fazer o for, e utilizar numero % 3 para descobrir o resto da divisão de um número por 3 (o operador % se chama de módulo). Se o resto for zero, ele é divisível por 3.
 */
using System;

namespace MultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int numero = 3; numero <= 100; numero += 3)
            {                
                Console.WriteLine(numero);                               
            }
            Console.ReadLine();
        }
    }
}
