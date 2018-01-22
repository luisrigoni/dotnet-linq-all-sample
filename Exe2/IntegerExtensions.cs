using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2
{
    public static class IntegerExtensions
    {
        public static bool IsOdd(this int integer) // impar
        {
            return (integer % 2 == 0);
        }

        public static bool IsEven(this int integer) // pares
        {
            return (integer % 2 == 1);
        }
    }
}
