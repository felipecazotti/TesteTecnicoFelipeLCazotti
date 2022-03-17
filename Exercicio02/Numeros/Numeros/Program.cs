using System;
using System.Collections.Generic;
using System.Linq;

namespace Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros =
            {
                "1 2 3 44 5",
                "55 2 1 854 963 520 1 0 98 8",
                "",
                "2 3 5 44 8 99 6 55 72 3 01 25",
                "98 99 100 101 102 103 105 105",
                "1"
            };


            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i].Length == 0)
                {
                    Console.WriteLine("Lista de números vazia");
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine($"O maior número é {Maior(numeros[i])}");
                Console.WriteLine($"A soma dos valores é {Soma(numeros[i])}");
                Console.WriteLine();
            }
            
        }

        static string Maior(string lista)
        {
            List<int> numerosInt = StringToList(lista);
            int maiorValor = numerosInt.Max();
            return maiorValor.ToString();
        }

        static string Soma(string lista)
        {
            List<int> numerosInt = StringToList(lista);
            int somaValor = numerosInt.Sum();
            return somaValor.ToString();
        }

        static List<int> StringToList(string lista)
        {
            string[] numeros = lista.Split(" ");
            return numeros.Select(x => int.Parse(x)).ToList<int>();

        }
    
    }
}
