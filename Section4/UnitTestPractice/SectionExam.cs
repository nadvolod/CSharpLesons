using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestPractice
{
    [TestClass]
    public class SectionExam
    {
        [TestMethod]
        public void String_Ends_With_E()
        {
            string givenString = "outside";
            StringAssert.EndsWith(givenString, "e");
        }

        [TestMethod]
        public void Add_Two_Int_Get_24()
        {
            int number1 = 10;
            int number2 = 14;
            int sum = number1 + number2;
            Assert.AreEqual(sum, 24);
        }

        [TestMethod]
        public void Compare_Two_Lists()
        {
            List<int> list1 = new List<int>();
            list1.Add(5);
            list1.Add(10);
            List<int> list2 = new List<int>();
            list2.Add(5);
            list2.Add(10);
            CollectionAssert.AreEqual(list1, list2);
        }
    }
}
