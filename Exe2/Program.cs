using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var allOdd = MathHelper.SequenceOdd(numeros);

            Console.WriteLine($"Somente ímpares? {allOdd}");
            Console.Read();
        }
    }
}
