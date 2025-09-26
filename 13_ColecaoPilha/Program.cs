using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> nomes = new Stack<string>();
            Console.WriteLine("Digite pelo menos 5 nomes e [I] Imprimir o Ultimo ou [S] Sair:/n");
            int cont = 1;
            while (true)
            {                
                Console.Write($"Digite item {cont}: ");
                string entrada = Console.ReadLine()?.Trim();

                if (string.Equals(entrada, "S", StringComparison.OrdinalIgnoreCase))
                    break; // sai do while

                if (string.Equals(entrada, "I", StringComparison.OrdinalIgnoreCase))
                {
                    if (nomes.Count < 5)
                    {
                        Console.WriteLine("Você deve informar pelo menos 5 nomes para imprimir a fila. Tente novamente.");
                        continue;
                    }

                    Console.WriteLine("Impressão da fila de nomes:");
                    Console.WriteLine($" Ultimo Nome digitado: {nomes.Pop()}.");

                    continue;
                }

                if (string.IsNullOrWhiteSpace(entrada) || entrada.Length < 3)
                {
                    Console.WriteLine("O nome não pode ser em branco e não deve ter pelo menos 3 caracteres. Tente novamente.");
                    continue;
                }

                // adicionar nome
                nomes.Push(entrada);

                cont++;

            }
        }
    }
}
