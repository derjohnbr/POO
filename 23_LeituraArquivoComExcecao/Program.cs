using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho completo do arquivo (ex.: C:\\temp\\arquivo.txt): ");
            string caminho = Console.ReadLine();

            try
            {
                string conteudo = File.ReadAllText(caminho);
                Console.WriteLine("\n--- Conteúdo do arquivo ---");
                Console.WriteLine(conteudo);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }
        }
    }
}
