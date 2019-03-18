using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Part3")]
    public class Test3
    {
        private int a;
        public TestContext TestContext { get; set; }
        private static TestContext _testContext;
        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            //this.TestContext = TestContext;
            a = 1;
        }
        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single test method in a class");
        }
        [ClassInitialize]
        public static void RunBeforeAllOfTheTestMethodsStarted(TestContext testContext)
        {
            _testContext = testContext;
            Trace.Write("I will run one time before all the tests in the class started");
        }
        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.Write("I will run one time after all the tests in the class finished");
        }
        [TestMethod]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);    
            Trace.Write(TestContext.CurrentTestOutcome);           
        }
        [TestMethod]
        public void TestMethod2()
        {
            Trace.Write(TestContext.TestName);
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(1, a);
        }
    }
}
