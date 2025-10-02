using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia { get; set; }
        public string Descricao { get; set; }

        public Feriado(int dia, string descricao)
        {
            Dia = dia;
            Descricao = descricao;
        }

        // Implementação do método CompareTo
        public int CompareTo(Feriado other)
        {
            if (other == null) return 1;
            //Ordem crescente
            return this.Dia.CompareTo(other.Dia);

            //Ordem decrescente 
            //return other.Dia.CompareTo(this.Dia);
        }
    }
}
