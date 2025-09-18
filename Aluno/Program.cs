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
            // ===== Entrada de dados =====
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            // ===== Criação do objeto (Nome é somente leitura via construtor) =====
            Aluno aluno = new Aluno(nome);
            aluno.setIdade(idade);
            aluno.setNota1(n1);
            aluno.setNota2(n2);

            // ===== Saída =====
            aluno.ImprimirResumo();

            // (Opcional) pequeno menu para alterar notas/idade e ver o resultado
            while (true)
            {
                Console.Write("\nOperação [I] Alterar Idade  [N] Alterar Notas  [E] Sair: ");
                string op = Console.ReadLine().Trim().ToUpper();

                if (op == "I")
                {
                    Console.Write("Nova idade: ");
                    int novaIdade = int.Parse(Console.ReadLine());
                    aluno.setIdade(novaIdade);
                    aluno.ImprimirResumo();
                }
                else if (op == "N")
                {
                    Console.Write("Nova Nota 1: ");
                    double nova1 = double.Parse(Console.ReadLine());
                    Console.Write("Nova Nota 2: ");
                    double nova2 = double.Parse(Console.ReadLine());
                    aluno.setNota1(nova1);
                    aluno.setNota2(nova2);
                    aluno.ImprimirResumo();
                }
                else if (op == "E")
                {
                    Console.WriteLine($"\nAluno: {aluno.getNome()} | Idade: {aluno.getIdade()} | " +
                                      $"Média: {aluno.getMedia():F2} | Situação: {aluno.getSituacao()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Operação inválida.");
                }
            }
        }
    }

    // ===================== Classe Aluno (mesmo padrão da Conta) =====================
    public class Aluno
    {
        // --- nome: somente leitura, inicializado no construtor ---
        private string nome;
        public string getNome()
        {
            return nome;
        }

        public Aluno(string nome)
        {
            this.nome = nome;
        }

        // --- idade: não pode ser negativa ---
        private int idade;
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            if (idade >= 0)
                this.idade = idade;
            else
                this.idade = 0; // força 0 se for negativo
        }

        // --- notas: podem ser lidas/alteradas livremente ---
        private double nota1;
        private double nota2;

        public double getNota1()
        {
            return nota1;
        }
        public void setNota1(double valor)
        {
            nota1 = valor;
        }

        public double getNota2()
        {
            return nota2;
        }
        public void setNota2(double valor)
        {
            nota2 = valor;
        }

        // --- média: somente leitura (calculada) ---
        public double getMedia()
        {
            return (nota1 + nota2) / 2.0;
        }

        // --- situação: somente leitura (depende da média) ---
        public string getSituacao()
        {
            return getMedia() >= 6.0 ? "Aprovado" : "Reprovado";
        }

        // --- impressão no console (igual ao ImprimirSaldo da Conta) ---
        public void ImprimirResumo()
        {
            Console.WriteLine($"\n=== RESUMO DO ALUNO ===");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Nota 1: {nota1}");
            Console.WriteLine($"Nota 2: {nota2}");
            Console.WriteLine($"Média: {getMedia():F2}");
            Console.WriteLine($"Situação: {getSituacao()}");
        }
    }
}
