using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPractice
{
    [TestClass]
    public class TestExample1
    {
        static string dateOfBirthString;
        static DateTime dateOfBirth;
        static int age;
        static DateTime today;

        [ClassInitialize()]
        public static void TestExample1Initialize(TestContext testContext)
        {
            dateOfBirthString = "05/01/1999";
            age = 0;
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            //get today's date
            today = DateTime.Today;
        }

        [TestMethod]
        public void Convert_String_To_Date()
        {
            try
            { 
                dateOfBirth = DateTime.Parse(dateOfBirthString, System.Globalization.CultureInfo.InvariantCulture); 
            }
            catch(FormatException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Subtract_DOB_From_Current()
        {
            dateOfBirth = DateTime.Parse(dateOfBirthString, System.Globalization.CultureInfo.InvariantCulture);

            //subtract the user's DOB year from the current year
            age = today.Year - dateOfBirth.Year;
            Console.WriteLine(age);
            Assert.IsTrue(age >= 18);
        }


        

        [TestMethod]
        public void Compute_Users_Age()
        {
            dateOfBirth = DateTime.Parse(dateOfBirthString, System.Globalization.CultureInfo.InvariantCulture);

            //subtract the user's DOB year from the current year
            age = today.Year - dateOfBirth.Year;

            //offset the age by one if the user's birthday hasn't passed
            if (dateOfBirth > today.AddYears(-age))
            {
                age--;
            }

            Console.WriteLine(age);
            Assert.AreEqual(age, 18);
        }
    }
}
