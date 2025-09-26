using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();
            Console.WriteLine("Digite 10 números:/n");
            int cont = 1;
            while (true)
            {
                Console.Write($"Digite item {cont}: ");
                string entrada = Console.ReadLine()?.Trim();

                if (cont >= 10)
                    break; // sai do while             

                if (!int.TryParse(entrada, out int valor))
                {
                    Console.WriteLine("Digite somente númerios inteiros.");
                    continue;
                }

                // adicionar
                numeros.Add(valor);

                cont++;

            }

            Console.WriteLine($"Impressão dos Números sem Repetição");
            foreach (int numero in numeros)
            {
                Console.WriteLine($" - {numero}");
            }
        }
    }
}
