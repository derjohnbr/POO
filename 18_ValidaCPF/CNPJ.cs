using System.Linq;
using System.Text.RegularExpressions;

namespace ValidadorCPF
{
    public class CNPJ : IDocumento
    {
        public string Numero { get; }

        public CNPJ(string numero)
        {
            Numero = Regex.Replace(numero ?? "", @"\D", "");
        }

        public bool Validar()
        {
            var cnpj = Numero;
            if (cnpj.Length != 14) return false;
            if (cnpj.Distinct().Count() == 1) return false;

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
