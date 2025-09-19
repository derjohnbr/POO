using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class Aluno
    {
        private string nome;
        private int idade;
        private double nota1;
        private double nota2;

        public string Nome => nome;

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                    idade = value;
                else
                {
                    Console.WriteLine("Erro de idade!");
                }
                
            }
        }

        public double Nota1
        {
            get => nota1;
            set => nota1 = value;
        }

        public double Nota2
        {
            get => nota2;
            set => nota2 = value;
        }

        public double Media => (nota1 + nota2) / 2.0;

        public string Situacao => Media >= 6 ? "Aprovado" : "Reprovado";

        public Aluno(string nome, int idade, double nota1, double nota2)
        {
            this.nome = nome;   
            Idade = idade;      
            Nota1 = nota1;
            Nota2 = nota2;
        }
    }
}

