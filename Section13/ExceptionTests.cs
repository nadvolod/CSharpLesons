using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section13
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void Test_Exceptions()
        {
            int totalScores = 10;
            int countOfScores = 0;

            if(countOfScores == 0 || totalScores == 0)
            {

            }
            else
            {
                double average = totalScores / countOfScores;
            }
            
        }

        [TestMethod]
        public void Test_Division()
        {
            ExceptionHelper.DivisionTest();
        }

        [TestMethod]
        public void Test_StateCheck()
        {
            try
            {
                ExceptionHelper.CheckStateOk("MA");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        [TestMethod]
        public void Test_StateCheckCustom()
        {
            try
            {
                ExceptionHelper.CheckStateCustom("MA");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
