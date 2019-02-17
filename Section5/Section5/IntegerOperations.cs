using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class IntegerOperations
    {
        //variables to hold the two integer values
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            int difference = number1 - number2;
            Assert.AreEqual(difference, 5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int product = number1 * number2;
            Assert.AreEqual(product, 50);
        }

        [TestMethod]
        public void Test_Division()
        {
            int quotient = number1 / number2;
            Assert.AreEqual(quotient, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int remainder = number1 % number2;
            Assert.AreEqual(remainder, 0);
        }
    }
}
