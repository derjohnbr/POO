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
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Base = 5;
            obj3.Altura = 10;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 2.5;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Base = 5;
            obj5.Altura = 10;
            obj5.ImprimeArea();
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
}
