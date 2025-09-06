using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Contrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5);
            quadrado.ImprimirArea();

            Console.WriteLine();

            Retangulo retangulo = new Retangulo(4, 6);
            retangulo.ImprimirArea();

            Console.WriteLine();

            Circulo circulo = new Circulo(3);
            circulo.ImprimirArea();

            Console.WriteLine();

            Triangulo triangulo = new Triangulo(4, 5);
            triangulo.ImprimirArea();
        }

    }

    public class Quadrado
    {
        //Atributos
        //Modificador de acesso Private
        //pode ser acessado apenas dentro da propria classe
        private int Lado;

        //Construtor
        //O Construtor serve para instanciar o objeto e
        //Inicializar os atributos
        public Quadrado(int Lado)
        {
            //this: acessa o menbro da classe
            this.Lado = Lado;
        }

        //Métodos
        public int CalculaArea()
        {
            return Lado * Lado;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrador com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        private int Largura, Altura;

        public Retangulo(int Largura, int Altura)
        {
            this.Largura = Largura;
            this.Altura = Altura;
        }

        public int CalculaArea()
        {
            return Largura * Altura;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Retangulo com largura de {Largura} e altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        private double Raio;
        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }
        public int CalculaArea()
        {
            return (int)(Math.PI * Raio * Raio);
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma área de {CalculaArea()}");
        }
    }

    public class Triangulo
    {
        private int Base, Altura;
        public Triangulo(int Base, int Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public int CalculaArea()
        {
            return (Base * Altura) / 2;
        }
        public void ImprimirArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma área de {CalculaArea()}");
        }
    }

}
