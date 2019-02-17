using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class FloatingPointOperations
    {
        //variables to hold the two double values
        static double number1;
        static double number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Addition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(difference, 5.5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double product = number1 * number2;
            Assert.AreEqual(product, 52.5);
        }

        [TestMethod]
        public void Test_Division()
        {
            double quotient = number1 / number2;
            Assert.AreEqual(quotient, 2.1);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            double remainder = number1 % number2;
            Assert.AreEqual(remainder, 0.5);
        }
    }
}
