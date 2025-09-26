using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nomes = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Digite pelo menos 4 nomes e [E] Imprimir ou [S] Sair:");
                string entrada = Console.ReadLine()?.Trim();

                if (string.Equals(entrada, "S", StringComparison.OrdinalIgnoreCase))
                    break; // sai do while

                if (string.Equals(entrada, "E", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Impressão dos pilhaNomes");
                    Console.WriteLine($" 1º Atendimento - {nomes.Pop()}.");
                    Console.WriteLine($" 2º Atendimento - {nomes.Pop()}.");
                    Console.WriteLine($" 3º Atendimento - {nomes.Pop()}.");

                    foreach (string nome in nomes)
                    {
                        Console.WriteLine($" - {nome}.");
                    }

                    continue;
                }

                if (string.IsNullOrWhiteSpace(entrada) || entrada.Length < 3)
                {
                    Console.WriteLine("O nome não pode ser em branco e não deve ter pelo menos 3 caracteres. Tente novamente.");
                    continue;
                }

                // adicionar nome
                nomes.Enqueue(entrada);

            }
        }
    }
}
