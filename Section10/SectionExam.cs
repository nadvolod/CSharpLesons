using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Section10
{
    [TestClass]
    public class SectionExam
    {
        [TestMethod]
        public void Test_List()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add("13.5");
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            ArrayList goodValues = CheckList(dataList);

            int sum = SumList(goodValues);

            Assert.AreEqual(147, sum);
        }

        public ArrayList CheckList(ArrayList list)
        {
            ArrayList goodVals = new ArrayList();

            foreach(var item in list)
            {
                int aValue;
                if(int.TryParse(Convert.ToString(item), out aValue) == true)
                {
                    goodVals.Add(aValue);
                }
            }

            return goodVals;
        }

        public int SumList(ArrayList list)
        {
            int sum = 0;
            foreach(int item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}
