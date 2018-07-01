using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class PropertyTaxCalcTest
    {
        [TestMethod]
        public void Test_Calculate_Taxable_Value()
        {
            PropertyTaxCalc home1 = new PropertyTaxCalc("123 New Street", 110000, 115000);
            Assert.AreEqual(90000, home1.CalculateTaxableValue());
        }

        [TestMethod]
        public void Test_Calculate_New_Assessed_Value()
        {
            PropertyTaxCalc home1 = new PropertyTaxCalc("123 New Street", 110000, 115000);
            Assert.AreEqual(112970, home1.CalculateNewAssessedValue());
        }

        [TestMethod]
        public void Test_Class_Output()
        {
            PropertyTaxCalc home1 = new PropertyTaxCalc("123 New Street", 110000, 115000);
            Console.WriteLine(home1);

            PropertyTaxCalc home2 = new PropertyTaxCalc("556 Baker Street", 150000, 160000);
            Console.WriteLine(home2);

            PropertyTaxCalc home3 = new PropertyTaxCalc("W 1600 Street", 190000, 200000);
            Console.WriteLine(home3);
        }
    }
}
