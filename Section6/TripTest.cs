using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void Test_Cost_Per_Mile()
        {
            Trip myTrip = new Trip("Grand Canyon", 1200, 120M, 40);
            Console.WriteLine(myTrip.CostPerMile());
        }

        [TestMethod]
        public void Test_Cost_Per_Gallon()
        {
            Trip myTrip = new Trip("Grand Canyon", 1200, 120M, 40);
            Console.WriteLine(myTrip.MilesPerGallon());
        }

        [TestMethod]
        public void Test_ToString()
        {
            Trip myTrip = new Trip("Grand Canyon", 1200, 120M, 40);
            Console.WriteLine(myTrip);
        }
    }
}
