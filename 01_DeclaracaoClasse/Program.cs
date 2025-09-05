using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quadrado obj1 = new Quadrado();
            //obj1.Lado = 5;
            //obj1.ImprimeArea();

            //obj1.Lado = 15;
            //obj1.ImprimeArea();

            //Quadrado obj2 = new Quadrado();
            //obj2.Lado = 25;
            //obj2.ImprimeArea();

            //Retangulo obj3 = new Retangulo();
            //obj3.Base = 5;
            //obj3.Altura = 10;
            //obj3.ImprimeArea();

            //Circulo obj4 = new Circulo();
            //obj4.Raio = 2.5;
            //obj4.ImprimeArea();

            //Triangulo obj5 = new Triangulo();
            //obj5.Base = 5;
            //obj5.Altura = 10;
            //obj5.ImprimeArea();

            Conta conta1 = new Conta();
            conta1.Banco = 341;
            conta1.Agencia = "1234";
            conta1.Numero = "56789-0";
            conta1.Saldo = 1000;
            conta1.Limite = 500;

            Console.WriteLine($"Saldo atual: {conta1.ConsultaSaldo()}");
            conta1.Depositar(250);
            Console.WriteLine($"Saldo atual: {conta1.ConsultaSaldo()}");
            conta1.Sacar(500);
            Console.WriteLine($"Saldo atual: {conta1.ConsultaSaldo()}");

            Console.WriteLine();


            Aluno aluno1 = new Aluno();
            aluno1.Codigo = 1;
            aluno1.Nome = "Eder";
            aluno1.LancarNotas(1, 9.6);
            aluno1.LancarNotas(2, 8.0);
            aluno1.LancarNotas(3, 9.9);
            aluno1.LancarNotas(4, 10.0);
            //aluno1.CalculaMedia();
            Console.WriteLine($"Mensão do Aluno: {aluno1.Mencao()}");
            
        }
    }

    public class Quadrado
    {
        // Atributos
        public int Lado;
        // Métodos
        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        // Atributos
        public int Base;
        public int Altura;
        // Métodos
        public int CalculaArea()
        {
            int area = Base * Altura;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com Base de {Base} e Altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        // Atributos
        public double Raio;
        // Métodos
        public double CalculaArea()
        {
            double area = Math.PI * (Raio * Raio);
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com Raio de {Raio} possui uma área de {CalculaArea():N2}");
        }
    }

    public class Triangulo
    {
        // Atributos
        public int Base;
        public int Altura;
        // Métodos
        public double CalculaArea()
        {
            double area = (Base * Altura) / 2.0;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com Base de {Base} e Altura de {Altura} possui uma área de {CalculaArea():N2}");
        }
    }

    public class Conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo + Limite)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public double ConsultaSaldo()
        {
            return Saldo;
        }
    }

    public class  Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];
        

        public void LancarNotas(int trimestre, double nota)
        {
            Notas[trimestre - 1] = nota;
        }

        public double CalculaMedia()
        {
            double media = 0;
            foreach (double nota in Notas)
            {
                media += nota;
            }
            return media / 4.0;
        }

        public string Mencao()
        {
           
            if (CalculaMedia() >= 5.0)
                return "Aprovado";
            else
                return "Reprovado";
        }

    }
}
