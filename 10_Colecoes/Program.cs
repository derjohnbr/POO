using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<Genérico>
            List<string> nomes = new List<string>();
            nomes.Add("Suely");
            nomes.Add("Celso");

            List<Aluno> alunos = new List<Aluno>();
            Aluno suely = new Aluno() { id = 1, Nome = "Suely"};
            AlunoEspecial celso = new AlunoEspecial() { id = 2, Nome = "Celso", Deficiencia = "Muito doido" };
            alunos.Add(suely);
            alunos.Add(celso);

            alunos.Add(new Aluno() { id = 3, Nome = "Gustavo" });
            nomes.Add(suely.Nome);

            Console.WriteLine($"Impressão dos nomes:");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine($"Impressão dos Alunos:");
            foreach (Aluno aluno in alunos)
            {
                //Console.WriteLine($"ID: {aluno.id} - Nome: {aluno.Nome}");
                aluno.ImpremirAluno();
            }

            Dictionary<int, string> dicNomes = new Dictionary<int, string>();
            dicNomes.Add(1, "Gustavo");
            dicNomes.Add(2, "Celso");
            dicNomes.Add(3, "Suely");
            //Não pode adicionar chave duplicada no Dicionário
            //dicNomes.Add(3, "Suely");

            Console.WriteLine($"Impressão dos dicNomes");
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($" - {dicNomes[i]}");
            }

            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(suely.id, suely);
            dicAlunos.Add(celso.id, celso);

            Console.WriteLine($"Impressão dos dicAlunos");
            //for (int i = 1; i <= dicAlunos.Count; i++)
            //{
            //    dicAlunos[i].ImpremirAluno();
            //}

            foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImpremirAluno();
            }

        }

        class Aluno
        { 
            public int id { get; set; }
            public string Nome { get; set; }
            public double[] Notas { get; set; }

            //virtual = pode ser sobrescrito
            public virtual void ImpremirAluno()
            {
                Console.WriteLine($"ID: {this.id} - Nome: {this.Nome}");
            }
        }

        class AlunoEspecial : Aluno
        {
            public string Deficiencia { get; set; }

            public override void ImpremirAluno()
            {
                Console.WriteLine($"ID: {this.id} - Nome: {this.Nome} - Deficiência: {this.Deficiencia}");
            }
        }
    }
}
