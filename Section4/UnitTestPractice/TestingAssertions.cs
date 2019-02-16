using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPractice
{
    [TestClass]
    public class TestingAssertions
    {
        [TestMethod]
        public void AssertAreEqualInts()
        {
            int a = 1;
            int b = 2;
            Assert.AreNotEqual(a, b);
        }
        [TestMethod]
        public void AssertAreEqualObj()
        {
            Int16 a = 1;
            Int32 b = 1;
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AssertAreEqualDifferent()
        {
            string a = "1";
            int b = 1;
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]

        public void AssertAreEqualArrays()
        {
            string[] a = {"a", "b"};
            string[] b = {"a", "b"};
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]

        public void AssertAreEqualArrays2()
        {
            string[] a = {"a", "b"};
            string[] b = {"a", "c"};
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AssertAreEqualArrays3()
        {
            string[] a = {"a", "b"};
            string[] b = {"a"};
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void AssertAreEqualArrays4()
        {
            string[] a = {"a", "b"};
            string[] b = {"a"};
            Assert.AreEqual(a[0], b[0]);
        }
        [TestMethod]
        public void StringAssertTest()
        {
            string a = "ab";
            string b = "a";
            StringAssert.Contains(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void StringAssertTest2()
        {
            string a = "ab";
            string b = "c";
            StringAssert.Contains(a, b);
        }
    }
}
