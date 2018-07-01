using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section13.Exam
{
    [TestClass]
    public class ExamTester
    {
        //Create a try/catch block in each test that calls the method and catches the
        //specific exception that is produced.  Each method should be handled so that if an 
        //exception occurs, the test will still pass.
        //write out the error message that occurs so you can view it in the output

        [TestMethod]
        public void Test_Weekly_Wages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\n\nError in loop termination condition.");
                Console.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nError in parameter types.");
                Console.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("\nArithmeticException thrown.");
                Console.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }
        }
    }
}
