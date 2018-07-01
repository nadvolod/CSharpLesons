using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class DoWhile
    {
        [TestMethod]
        public void Test_Do_While()
        {
            int sum = 0;
            int number = 1;
            do
            {
                sum += number;
                number++;
            }
            while (number <= 10);

            Assert.AreEqual(55, sum);
        }
    }
}
