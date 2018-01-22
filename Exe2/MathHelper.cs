using System;
using System.Linq;

namespace Exe2
{
    public static class MathHelper
    {
        public static bool SequenceOdd(int[] numeros)
        {
            return numeros.All(i => i.IsOdd());
        }

        public static bool SequenceEven(int[] numeros)
        {
            return numeros.All(i => i.IsEven());
        }
    }
}
