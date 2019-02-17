using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            //given the temperature in fahrenheit use a math
            //expression to convert the temperature to celsius
            //display a output string to the console that says
            //The temp in F {given temp} is {temp} in C
            //replacing the values as necessary in the string

            double tempInF = 57;
            //To convert temperatures in degrees Fahrenheit to Celsius, subtract 32 and multiply by .5556 (or 5/9)
            double tempInC = (tempInF - 32) * .5556;
            Console.WriteLine($"The temp in F {tempInF} is {tempInC} in C");

            //check the work
            //57F should be 13.89C
            Assert.AreEqual(tempInC, 13.89, 0.001);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            //given the temperature in celsius use a math
            //expression to convert the temperature to fahrenheit
            //display a output string to the console that says
            //The temp in C {given temp} is {temp} in F
            //replacing the values as necessary in the string

            double tempInC = 12.5;
            //To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 (or 9/5) and add 32.
            double tempInF = (tempInC * 1.8) + 32;
            Console.WriteLine($"The temp in C {tempInC} is {tempInF} in F");

            //check the work
            //12.5C to F should be 54.5
            Assert.AreEqual(tempInF, 54.5);
        }
    }
}
