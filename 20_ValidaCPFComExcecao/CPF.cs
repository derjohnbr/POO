using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _20_ValidaCPFComExcecao
{
    public class CPF : IDocumento
    {
        public string Numero { get; }

        public CPF(string numero)
        {
            // mantém só dígitos
            Numero = Regex.Replace(numero ?? string.Empty, "[^0-9]", "");

            if (this.Numero.Length != 11) throw new CPFQtdeDigitosException();
            if (this.Numero.Distinct().Count() == 1) throw new CPFMesmoNumeroException(); // todos iguais
        }

        public bool Validar()
        {
            var cpf = Numero;            

            int d1 = CalcDigito(cpf, 9);   // usa 10..2
            if (d1 != (cpf[9] - '0')) return false;

            int d2 = CalcDigito(cpf, 10);  // usa 11..2
            if (d2 != (cpf[10] - '0')) return false;

            return true;
        }

        private static int CalcDigito(string cpf, int tamanho)
        {
            int soma = 0;
            int peso = tamanho + 1;        // 9 -> 10..2 | 10 -> 11..2
            for (int i = 0; i < tamanho; i++)
                soma += (cpf[i] - '0') * (peso--);

            int resto = soma % 11;
            return (resto < 2) ? 0 : 11 - resto;
        }
    }
}
