using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void Receipt_Greater_Than_Zero()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(12233, purchase.ReceiptNumber);
        }

        [TestMethod]
        public void CustomerNo_Greater_Than_Zero()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(188, purchase.CustomerNumber);
        }

        [TestMethod]
        public void ItemNo_Greater_Than_Zero_Less_Than_9999()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(701, purchase.ItemNumber);
        }

        [TestMethod]
        public void Unit_Price_Greater_Than_Zero_Less_Than_9999()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(12.99M, purchase.UnitPrice);
        }

        [TestMethod]
        public void Quantity_Greater_Than_Zero()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(2, purchase.QtyPurchased);
        }

        [TestMethod]
        public void Receipt_Greater_Than_Zero_Invalid()
        {
            Receipt purchase = new Receipt(-1, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(0, purchase.ReceiptNumber);
        }

        [TestMethod]
        public void CustomerNo_Greater_Than_Zero_Invalid()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", -1, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(0, purchase.CustomerNumber);
        }

        [TestMethod]
        public void ItemNo_Greater_Than_Zero_Less_Than_9999_Invalid()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 10000, "Widget", 12.99M, 2);
            Assert.AreEqual(0, purchase.ItemNumber);
        }

        [TestMethod]
        public void Unit_Price_Greater_Than_Zero_Less_Than_9999_Invalid()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", -1M, 2);
            Assert.AreEqual(0M, purchase.UnitPrice);
        }

        [TestMethod]
        public void Quantity_Greater_Than_Zero_Invalid()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, -2);
            Assert.AreEqual(0, purchase.QtyPurchased);
        }

        [TestMethod]
        public void Display_Methods()
        {
            Receipt purchase = new Receipt(12233, "08/02/2017", 188, "Susan", "Abbey", "123 Any Street",
                "555-555-5555", 701, "Widget", 12.99M, 2);

            Console.WriteLine(purchase.CalculateTotalCost());
            Console.WriteLine(purchase);
        }
    }
}
