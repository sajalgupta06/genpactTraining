using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExercise
{
    [TestFixture]
    internal class CalcTesting
    {
        [Test]
        public void AddTest()
        {
            Calc calculator = new Calc();
            Assert.AreEqual(8, calculator.Add(4 , 4));
        }

        [Test]
        public void SubtractTest()
        {
            Calc calculator = new Calc();
            Assert.AreEqual(1, calculator.Subtract(5, 4));
        }


        [Test]
        public void MultiplyTest()
        {
            Calc calculator = new Calc();
            Assert.AreEqual(16, calculator.Multiply(4, 4));
        }


        [Test]
        public void DivideTest()
        {
            Calc calculator = new Calc();
            Assert.AreEqual(2, calculator.Divide(8, 4));
        }

        [Test]
        public void PrimeTest()
        {
            Calc calculator = new Calc();
            Assert.AreEqual(false, calculator.IsPrime(8));
        }

    }
}
