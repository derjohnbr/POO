﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    public class NotaInvalidaException : Exception
    {
        public NotaInvalidaException(string message) : base(message) { }
    }
}
