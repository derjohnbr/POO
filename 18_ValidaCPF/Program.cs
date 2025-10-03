using System;
using System.Text.RegularExpressions;
using ValidadorCPF;
using ValidadorDocumento;
// using ValidadorCPF; // ajuste para o namespace onde estão IDocumento, CPF, CNPJ

class Program
{
    static void Main()
    {
        Console.Write("Digite CPF ou CNPJ: ");
        string entrada = Console.ReadLine() ?? "";

        string numeros = Regex.Replace(entrada, @"\D", ""); // só dígitos

        IDocumento doc = null;
        if (numeros.Length == 11)
            doc = new CPF(entrada);
        else if (numeros.Length == 14)
            doc = new CNPJ(entrada);

        if (doc == null)
        {
            Console.WriteLine("Informe um CPF (11 dígitos) ou CNPJ (14 dígitos).");
            return;
        }

        Console.WriteLine(doc.Validar()
            ? $"{doc.GetType().Name} VÁLIDO"
            : $"{doc.GetType().Name} INVÁLIDO");
    }
}
