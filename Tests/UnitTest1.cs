using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    [TestCategory("ArraysLists")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ar = new int[]
            {
                1,2,3,4,10,11
            };
            int result = SimpleArraySum(ar);
            Assert.AreEqual(31, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] ar = new int[]
            {
                10,20,30
            };
            int result = SimpleArraySum(ar);
            Assert.AreEqual(60,result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var list = new List<int> {1, 5, 1, 2, 3, 4, 5};
            var result = ReverseList(list);
            Assert.AreEqual("5 4 3 2 1", result);
        }

        //DON'T LOOK BELOW, IT'S THE ANSWERS!!



        private string ReverseList(List<int> list)
        {
            var uniqueList = new List<int>();
            list.Sort();
            foreach (var item in list)
            {
                if (!uniqueList.Contains(item))
                    uniqueList.Add(item);
            }
            uniqueList.Reverse();
            var finalString = "";
            foreach (var item in uniqueList)
            {
                finalString += item + " ";
            }

            finalString = finalString.TrimEnd();
            return finalString;
        }

        private int SimpleArraySum(int[] ar)
        {
            int result = 0;
            foreach (var item in ar)
            {
                result += item;
            }
            return result;
        }
    }
}
