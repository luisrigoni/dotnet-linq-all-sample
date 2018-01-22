using Exe2;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exe2.Tests
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void MathHelper_SequenceOdd_FalseForMixedSequence()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            var allOdd = MathHelper.SequenceOdd(numeros);
            Assert.IsFalse(allOdd);
        }

        [TestMethod]
        public void MathHelper_SequenceOdd_CoorectOddSequence()
        {
            int[] numeros = { 1, 3, 5, 13, 21, 55, 89 };
            var allOdd = MathHelper.SequenceOdd(numeros);
            Assert.IsTrue(allOdd);
        }

        [TestMethod]
        public void MathHelper_SequenceOdd_CorrectEvenSequence()
        {
            int[] numeros = { 2, 8, 34, 144 };
            var allEven = MathHelper.SequenceEven(numeros);
            Assert.IsTrue(allEven);
        }
    }
}
