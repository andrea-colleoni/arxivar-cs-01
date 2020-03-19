using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Eccezioni
{
    class CarburanteFinitoException : Exception
    {
        // override di un costruttore
        public CarburanteFinitoException(string message) : base(message)
        {
        }
    }
}
