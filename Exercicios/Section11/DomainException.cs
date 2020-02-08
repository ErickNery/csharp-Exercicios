using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Section11
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
