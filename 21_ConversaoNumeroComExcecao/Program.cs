using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            try
            { 
                int valor = int.Parse(Console.ReadLine());
                int dobro = valor * 2;
                Console.WriteLine($"Dobro: {dobro}");
            }
                catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }

        }
    }
}
