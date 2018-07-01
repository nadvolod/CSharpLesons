using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Test_While_Loops()
        {
            int number = 1;
            while(number < 11)
            {
                //the code that will continue to execute while the statement
                //conditional is true
                Console.WriteLine(number);
                number++; //number = number + 1;
            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;

            Console.WriteLine("post increment value is: {0}", number++);

            Console.WriteLine("pre increment value is: {0}", ++number);

            Console.WriteLine("post decrement value is: {0}", number--);

            Console.WriteLine("pre decrement value is: {0}", --number);
        }

        public void Test_Sentinel_Controlled_Loop()
        {
            //cannot test in a unit test environment
            string inValue = "";
            while (inValue != "−99")
            {
                Console.Write("\nEnter value (−99 to exit): ");
                inValue = Console.ReadLine();
            }
            Console.ReadKey();


        }

        [TestMethod]
        public void Nested_Loops()
        {
            int number1 = 1;
            int number2 = 1;
            while(number1 <= 5)
            {
                while(number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;
                }//inner loop
                number1++;
            }//outer loop

        }
    }
}
