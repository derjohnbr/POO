using System;
using System.Text.RegularExpressions;

// using ValidadorCPF; // ajuste para o namespace onde estão IDocumento, CPF, CNPJ
namespace _20_ValidaCPFComExcecao
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Digite o CPF: ");
                //string cpf =  Console.ReadLine();
                //CPF objCPF = new CPF( cpf );
                try
                {
                    IDocumento documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");

                }
                finally
                {
                    Console.WriteLine($"\nPrecione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


           

            /*Console.Write("Digite o CNPJ: ");
            IDocumento documento = new CNPJ(Console.ReadLine());

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");*/
        }
    }
}
