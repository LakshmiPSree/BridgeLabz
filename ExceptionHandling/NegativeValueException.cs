using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NegativeValueException:Exception
    {
        public NegativeValueException(string message):base(message) { }

        public override string ToString()
        {
            return $"Custom Exception:{Message}";
        }
    }
}
