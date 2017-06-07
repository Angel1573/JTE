using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        Calc.Calc calc = new Calc.Calc();

        [TestMethod]
        public void TestSum()
        {
            int expected = 5;
            int result = calc.Sum(2, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMin()
        {
            int expected = 3;
            int result = calc.Min(5, 2);
            Assert.AreEqual(expected, result);
        }
    }
}
