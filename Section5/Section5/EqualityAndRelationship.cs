using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class EqualityAndRelationship
    {
        //variables to hold the two int values
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
        public void Number1_Is_Equal_Number2()
        {
           Assert.IsTrue(number1 == number2);
            
        }

        [TestMethod]
        public void Number1_Is_Not_Equal_Number2()
        {
            if(number1 != number2)
            {
                Assert.IsTrue(number1 != number2);
            }
        }

        [TestMethod]
        public void Number1_Greater_Than_Number2()
        {
            if (number1 > number2)
            {
                Assert.IsTrue(number1 > number2);
            }
        }

        [TestMethod]
        public void Number1_Greater_Than_Or_Equal_Number2()
        {
            if (number1 >= number2)
            {
                Assert.IsTrue(number1 >= number2);
            }
        }

        [TestMethod]
        public void Number1_Less_Than_Number2()
        {
            if (number1 < number2)
            {
                Assert.IsTrue(number1 < number2);
            }
            Assert.IsTrue(number1 < number2);
        }

        [TestMethod]
        public void Number1_Less_Than_Or_Equal_Number2()
        {
            Assert.IsTrue(number1 <= number2);
        }
    }
}
