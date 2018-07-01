using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = ClassLibraryPractice.Class1.Addition(10, 5);
            Assert.AreEqual(result, 15);

        }
    }
}
