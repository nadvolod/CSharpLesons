using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPractice
{
    [TestClass]
    public class DataTesting
    {
        public TestContext TestContext { get; set; }

        private static TestContext _testContext;

        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestInitialize]
        public void SetupTest()
        {
            Console.WriteLine(
                "TextContext.TestName='{0}'  static _testContext.TestName='{1}'",
                TestContext.TestName,
                _testContext.TestName);

            Console.WriteLine("TestDeploymentDir: {0}", TestContext.TestDeploymentDir);

            Console.WriteLine("TestLogsDir: {0}", TestContext.TestLogsDir);

            Console.WriteLine("TestName: {0}", TestContext.TestName);
        }

        [TestMethod]
        [TestCategory("Nightly"), TestCategory("Weekly")]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [TestCategory("Nightly")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Data\data.csv", "Data#csv", DataAccessMethod.Sequential)]
        public void DataTestingCSV()
        {
            // Arrange
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            string message = TestContext.DataRow[3].ToString();

            // Act
            var actual = Math.Min(a, b);

            // Assert
            Assert.AreEqual(expected, actual, message);
        }
    }
}
