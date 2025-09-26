using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            Console.WriteLine($"Digite pelo menos 5 nomes. (Deve ter pelo menos 3 caracteres!)\n");

            while (nomes.Count < 5)
            {
                Console.Write($"Digite o {nomes.Count + 1}º nome: ");
                string nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                {
                    Console.WriteLine("O nome não pode ser em branco e não deve ter pelo menos 3 caracteres. Tente novamente.");
                    continue;
                }
                nomes.Add(nome);
            }

            Console.WriteLine("\nNomes digitados:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
