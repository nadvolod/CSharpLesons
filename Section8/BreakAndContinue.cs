using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class BreakAndContinue
    {
        [TestMethod]
        public void Break_Keyword()
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;

                }
                total += nValue;
            }

            Assert.AreEqual(10, total);
        }


        [TestMethod]
        public void Continue_Keyword()
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    continue;

                }
                total += nValue;
            }

            Assert.AreEqual(40, total);
        }
    }
}
