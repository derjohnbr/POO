using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dicAlunos = new Dictionary<int, string>();
            Console.WriteLine("Digite RA e nome do Alunos | [N] Novo [I] Imprimir");

            while (true)
            {
                Console.Write($"Digite Opção: ");
                string entrada = Console.ReadLine()?.Trim();

                if (string.Equals(entrada, "I", StringComparison.OrdinalIgnoreCase))
                {
                    if (dicAlunos.Count == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado.");
                        continue;
                    }

                    Console.WriteLine("Lista de Alunos:");
                    foreach (var kv in dicAlunos) // kv.Key = RA, kv.Value = Nome
                        Console.WriteLine($" - RA: {kv.Key} | Nome: {kv.Value}");

                    break;
                }
                int raAluno;
                string nomeAluno;
                if (string.Equals(entrada, "N", StringComparison.OrdinalIgnoreCase))
                {
                    while (true)
                    {
                        Console.Write("RA (inteiro): ");
                        if (int.TryParse(Console.ReadLine(), out raAluno)) break;
                        Console.WriteLine("RA inválido. Tente novamente.");
                    }
                    while (true)
                    {
                        Console.Write("Nome: ");
                        nomeAluno = Console.ReadLine()?.Trim();
                        if (!string.IsNullOrWhiteSpace(nomeAluno) && nomeAluno.Length >= 3) break;
                        Console.WriteLine("Nome inválido. Tente novamente.");
                    } 
                    dicAlunos.Add(raAluno, nomeAluno);
                }
            }
        }
    }
}
