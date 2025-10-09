using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma Nota de 0 a 10: ");
            try 
            {
                double nota = Convert.ToDouble(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    throw new NotaInvalidaException("A nota deve ser entre 0 e 10.");
                }
                else
                {
                    Console.WriteLine($"Nota válida: {nota}");
                }
            }
            catch (NotaInvalidaException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
            }
        }
    }
}
