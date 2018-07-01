using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class MathFunctionsTest
    {
        [TestMethod]
        public void Test_Square_Root()
        {
            Assert.AreEqual(3, MathFunctions.SquareRoot(12), 1);
        }
        [TestMethod]
        public void Test_Int_Sum()
        {
            Assert.AreEqual(18, MathFunctions.Sum(12, 6));
        }
        [TestMethod]
        public void Test_Double_Sum()
        {
            Assert.AreEqual(19.1, MathFunctions.Sum(12.5, 6.6));
        }
        [TestMethod]
        public void Test_Decimal_Sum()
        {
            Assert.AreEqual(19M, MathFunctions.Sum(12.5M, 6.5M));
        }


    }
}
