using System;
using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a1 = new int[2, 2]
            {
                { 6, 5 },
                { 4, 2 }
            };

            var b1 = new int[2, 2]
            {
                { 5, 6 },
                { 0, 2 }
            };

            var a = new Matrix(a1);
            var b = new Matrix(b1);
            var result = a.oursum(a, b);
            Assert.AreEqual(result[0,0], 11);
            Assert.AreEqual(result[0, 1], 11);
            Assert.AreEqual(result[1, 0], 4);
            Assert.AreEqual(result[1, 1], 4);
        }
    }
}
