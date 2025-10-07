using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPFMesmoNumeroException:Exception
    {
        public CPFMesmoNumeroException() : base("O CPF não pode conter todos os números iguais."){}
    }
}
