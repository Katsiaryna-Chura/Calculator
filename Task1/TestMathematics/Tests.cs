using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathematics;

namespace TestMathematics
{
    [TestClass]
    public class Tests
    {
        Calculator c;
        int a;
        int b;

        public Tests()
        {
            c = new Calculator();
            a = Int32.Parse(TestData.FirstNumber);
            b = Int32.Parse(TestData.SecondNumber);
        }

        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual((long)a + (long)b, c.Sum(a, b));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual((long)a - (long)b, c.Subtract(a, b));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual((long)a * (long)b, c.Multiply(a, b));
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual((double)a / (double)b, c.Div(a, b));
        }
    }
}
