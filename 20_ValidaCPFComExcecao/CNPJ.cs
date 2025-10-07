using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _20_ValidaCPFComExcecao
{
    public class CNPJ : IDocumento
    {
        public string Numero { get; }

        public CNPJ(string numero)
        {
            Numero = Regex.Replace(numero ?? "", @"\D", "");

            if (this.Numero.Length != 14) throw new Exception("O CPF deve ter 11 dígitos!"); ;
            if (this.Numero.Distinct().Count() == 1) throw new Exception("Todos os número do CPF não podem ser iguais!");
        }

        public bool Validar()
        {
            var cnpj = Numero;           

            int[] p1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] p2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int d1 = Calc(cnpj.Substring(0, 12), p1);
            int d2 = Calc(cnpj.Substring(0, 12) + d1, p2);

            return d1 == (cnpj[12] - '0') && d2 == (cnpj[13] - '0');
        }

        private static int Calc(string nums, int[] pesos)
        {
            int soma = 0;
            for (int i = 0; i < pesos.Length; i++)
                soma += (nums[i] - '0') * pesos[i];
            int r = soma % 11;
            return r < 2 ? 0 : 11 - r;
        }
    }
}
