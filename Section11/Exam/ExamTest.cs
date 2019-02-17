using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exam
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void Test_Auto_Loan_Calc()
        {
            AutoLoan car = new AutoLoan("0001", "Sara", "Baker", .075, 12000, 4, 2015, "Taurus",
                "Ford", "Blue");
            decimal interest = car.CalculateInterest();
            Assert.AreEqual(2925, interest);
            Console.WriteLine(car);
        }

        [TestMethod]
        public void Test_Home_Loan_Calc()
        {
            HomeLoan house = new HomeLoan("0001", "Sara", "Baker", .35, 210000, 30, 2010, 3000, "123 New Street");
            decimal interest = house.CalculateInterest();
            Assert.AreEqual(30100, interest);
            Console.WriteLine(house);
        }
    }
}
