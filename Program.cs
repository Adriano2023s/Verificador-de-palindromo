using System;

namespace Verificador_palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua palavra \n");
            string palavra = Console.ReadLine();

            if (Ehpalindromo(palavra))
            {
                Console.WriteLine($"{palavra}, é um palíndromo");
            }
            else
            {
                Console.WriteLine($"{palavra}, não é um palíndromo");
            }
        }

        static bool Ehpalindromo(string palavra)
        {
            int comprimento = palavra.Length;

            for (int i = 0; i < comprimento / 2; i++)
            {
                if (palavra[i] != palavra[comprimento - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}