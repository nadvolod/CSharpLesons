using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Tests2
    {
        //1. All tests should have be categorized as Quiz
        //2. 3 test methods
        //3. One test checks that 1 + 1 = 2
        //4. One test automatically fails using a special assertion method
        //5. One test that checks that 10 + 10 = 21 and expects the test to fail
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);       
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This test will always fail");
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
