using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class DecimalOperations
    {
        //variables to hold the two double values
        static decimal number1;
        static decimal number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5M;
            number2 = 5.0M;
        }

        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5M);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            decimal difference = number1 - number2;
            Assert.AreEqual(difference, 5.5M);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            decimal product = number1 * number2;
            Assert.AreEqual(product, 52.5M);
        }

        [TestMethod]
        public void Test_Division()
        {
            decimal quotient = number1 / number2;
            Assert.AreEqual(quotient, 2.1M);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            decimal remainder = number1 % number2;
            Assert.AreEqual(remainder, 0.5M);
        }
    }
}
