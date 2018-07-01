using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Section14.Final_Exam_2
{
    [TestClass]
    public class HousingTest
    {
        [TestMethod]
        public void SingleFamilyTest()
        {
            List<SingleFamily> homeList = new List<SingleFamily>();

            homeList.Add(new SingleFamily(1997, "34 Winston Street", "Colonial", true, true, 900.00M,
                3, 3));
            homeList.Add(new SingleFamily(1979, "5234 Carolina Ave", "Ranch", true, false, 850.00M,
                2, 1));
            homeList.Add(new SingleFamily(2004, "54 Magnolia Court", "Craftsman", false, true, 1000.00M,
                3, 2));
            homeList.Add(new SingleFamily(2001, "6910 Reiley", "Colonial", false, false, 750.00M,
                2, 2));
            homeList.Add(new SingleFamily(2015, "76 St. Johns Ct.", "Ranch", true, true, 1500.00M,
                4, 3));

            foreach(SingleFamily home in homeList)
            {
                Console.WriteLine(home);
            }
        }

        [TestMethod]
        public void MultiUnitTest()
        {
            List<MultiUnits> complexList = new List<MultiUnits>();

            complexList.Add(new MultiUnits(2001, "8674 Victoria Lane", "Duplex", 2, "Laurel Springs", 450.00M));
            complexList.Add(new MultiUnits(2011, "9724 Bridge Street", "Apartments", 20, "Dover Grove", 550.00M));
            complexList.Add(new MultiUnits(1999, "2310 Reiley Lane", "Apartments", 44, "Lemon Square", 400.00M));
            complexList.Add(new MultiUnits(2016, "74 Winston Ave", "Apartments", 12, "Ducks Head", 600.00M));
            complexList.Add(new MultiUnits(2017, "1112 Mary Lane", "Duplex", 2, "Geneva Springs", 450.00M));


            foreach (MultiUnits home in complexList)
            {
                Console.WriteLine(home);
            }
        }

        [TestMethod]
        public void CombinedTest()
        {
            List<Housing> combinedList = new List<Housing>();

            combinedList.Add(new SingleFamily(1997, "34 Winston Street", "Colonial", true, true, 900.00M,
                3, 3));
            combinedList.Add(new SingleFamily(1979, "5234 Carolina Ave", "Ranch", true, false, 850.00M,
                2, 1));
            combinedList.Add(new SingleFamily(2004, "54 Magnolia Court", "Craftsman", false, true, 1000.00M,
                3, 2));
            combinedList.Add(new SingleFamily(2001, "6910 Reiley", "Colonial", false, false, 750.00M,
                2, 2));
            combinedList.Add(new SingleFamily(2015, "76 St. Johns Ct.", "Ranch", true, true, 1500.00M,
                4, 3));

            combinedList.Add(new MultiUnits(2001, "8674 Victoria Lane", "Duplex", 2, "Laurel Springs", 450.00M));
            combinedList.Add(new MultiUnits(2011, "9724 Bridge Street", "Apartments", 20, "Dover Grove", 550.00M));
            combinedList.Add(new MultiUnits(1999, "2310 Reiley Lane", "Apartments", 44, "Lemon Square", 400.00M));
            combinedList.Add(new MultiUnits(2016, "74 Winston Ave", "Apartments", 12, "Ducks Head", 600.00M));
            combinedList.Add(new MultiUnits(2017, "1112 Mary Lane", "Duplex", 2, "Geneva Springs", 450.00M));

            foreach (Housing home in combinedList)
            {
                Console.WriteLine("Address" + home.Address);
                Console.WriteLine("Projected Rent: " + home.ProjectedRentalAmt().ToString("C"));
            }
        }
    }
}
