using System;
using System.Linq;

namespace Inverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numeros = {15485448, 2195498, 12, 98716549, 9999998999, 1654891};
            string[] numerosTexto = new string[numeros.Length]; 
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosTexto[i] = numeros[i].ToString();
            }

            for (int i = 0; i < numerosTexto.Length; i++)
            {
                Console.WriteLine($"{numerosTexto[i]} -> {InverterTexto(numerosTexto[i])}");
            }
        }

        static string InverterTexto(string texto)
        {
            char[] textoChar = texto.ToCharArray();
            Array.Reverse(textoChar);
            return new string(textoChar);
        }
    }
}


