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
            int[] a1 = new int[] { 0, 7, 1 };
            int[] a2 = new int[] { 2, 0, 1 };
            int[] a3 = new int[] { 3, 4, 1 };
            int[] b1 = new int[] { 3, 4, 1 };
            int[] b2 = new int[] { 0, 5, 1 };
            int[] b3 = new int[] { 6, 6, 6 };
            var a = new Matrix(a1, a2, a3);
            var b = new Matrix(b1, b2, b3);
            var result = a.oursum(a, b);
            Assert.AreEqual(result.a[0], 3);
            Assert.AreEqual(result.a[1], 11);
            Assert.AreEqual(result.a[2], 2);
            Assert.AreEqual(result.b[0], 2);
            Assert.AreEqual(result.b[1], 5);
            Assert.AreEqual(result.b[2], 2);
            Assert.AreEqual(result.c[0], 9);
            Assert.AreEqual(result.c[1], 10);
            Assert.AreEqual(result.c[2], 7);
        }
    }
}
