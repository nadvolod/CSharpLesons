using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace section14
{
    [TestClass]
    [TestCategory("Delegates")]
    public class AdvancedTest
    {
        [TestMethod]
        public void DelegateTest()
        {
            DelegateDemo.Main();
        }

        [TestMethod]
        public void ImplicitCasting()
        {
            Mammal mammal = new Cat();
            Animal animal = new Cat();
        }

        [TestMethod]
        public void ExplicitCasting()
        {
            double dPi = 3.1415926535;

            int iValue = (int)dPi;
            Console.WriteLine(iValue);
        }

        [TestMethod]
        public void BoxingCasting()
        {
            double dPi = 3.1415926535;

            object oPi = (object)dPi;
            Console.WriteLine(oPi);
        }

        [TestMethod]
        public void UnboxingCasting()
        {
            double dPi = 3.1415926535;
            object oPi = (object)dPi;

            dPi = (double)oPi;
            Console.WriteLine(dPi);
        }

        delegate int del(int i);
        [TestMethod]
        public void TestLambda()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Assert.AreEqual(j, 25);
        }

        [TestMethod]
        public void TestListLambda()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        delegate void TestDelegate(string s);
        [TestMethod]
        public void TestStatementLambda()
        {
            TestDelegate del = n => {string s = n + " World";
                Console.WriteLine(s); };
        }

    }
}
