using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section12.Exam
{
    [TestClass]
    [TestCategory("InterfaceExam")]
    public class Exam
    {
        //In this exam, you must make the 2 tests below pass without changing a 
        //single line of code in the tests.
        //You basically need to fix all of the compilation errors and make the tests pass, 
        //without touching the tests.
        [TestMethod]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual(pageObject1.PageName, "Page Name 1");
        }
        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual(pageObject2.PageName, "Page Name 2");
        }
    }
}
