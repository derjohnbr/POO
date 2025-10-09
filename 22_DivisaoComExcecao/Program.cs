using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisão entre 2 números");
            try
            {
                Console.Write("Digite número 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite número 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num2 == 0) throw new DivideByZeroException();

                double resultado = (double) num1 / num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossível dividir por zero!");
            }
            finally
            {
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o programa!");
            }
        }
    }
}
