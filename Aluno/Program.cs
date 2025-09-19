using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.Write("Nome: ");
                var aluno = new Aluno(Console.ReadLine(), 0, 0, 0);

                Console.Write("Idade: ");
                aluno.Idade = int.Parse(Console.ReadLine());

                Console.Write("Nota 1: ");
                aluno.Nota1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2: ");
                aluno.Nota2 = double.Parse(Console.ReadLine());

                
                Console.WriteLine($"\n{aluno.Nome} | Idade: {aluno.Idade} | " +
                                  $"Média: {aluno.Media:F2} | Situação: {aluno.Situacao}\n");

                Console.Write("Cadastrar outro? (S/N): ");
                if (!Console.ReadLine().Trim().Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;
                Console.WriteLine();
            }
        }
    }
}
