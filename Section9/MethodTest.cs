using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void Test_Square()
        {
            MethodTest myTest = new MethodTest();
            int result = myTest.Square(6);
            Assert.AreEqual(36, result);
        }

        public int Square(int aValue)
        {
            return aValue * aValue;
        }

        [TestMethod]
        public void Test_Static_Square()
        {
            int result = MathHelper.Square(6);
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void Test_Static_Square_Named()
        {
            Assert.AreEqual(36, MathHelper.Square(aValue: 6));
        }

        [TestMethod]
        public void Test_Employee_Overload_String()
        {
            Employee myEmployee = new Employee("Sara Burke", 12345, "Manager");
            string result = myEmployee.PayType(myEmployee.JobTitle);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void Test_Employee_Overload_Int()
        {
            Employee myEmployee = new Employee("Sara Burke", 12345, "Manager");
            string result = myEmployee.PayType(myEmployee.EmployeeID);
            Console.WriteLine(result);

        }

        [TestMethod]
        public void Test_Named_Parameters()
        {
            int sum11 = MathHelper.AddNumber(5, 6);

            int sum12 = MathHelper.AddNumber(number1: 6, number2: 6);

            int number = 5;
            int sum13 = MathHelper.AddNumber(number, number2: 8);
        }

        [TestMethod]
        public void Test_Optional_Parameters()
        {
            int sum10 = MathHelper.AddNumber(0);

            int sum12 = MathHelper.AddNumber(2);

            int sum15 = MathHelper.AddNumber();

            int sum13 = MathHelper.AddNumber(number2: 5);
        }

        [TestMethod]
        public void Test_Out_Parameter()
        {
            int number1;
            MathHelper.NumbersOut(out number1);
            Assert.AreEqual(9, number1);

        }

        [TestMethod]
        public void Test_Ref_Parameter()
        {
            int number1 = 0;

            MathHelper.NumbersRef(ref number1);
            Assert.AreEqual(7, number1);
        }

        [TestMethod]
        public void Test_Tuples()
        {
            //create the Tuple
            Tuple<int, string, bool> myTuple =
                new Tuple<int, string, bool>(1, "cat", true);

            //access the tuple
            if (myTuple.Item1 == 1)
            {
                Console.WriteLine(myTuple.Item1);
            }
            if (myTuple.Item2 == "dog")
            {
                Console.WriteLine(myTuple.Item2);
            }
            if (myTuple.Item3)
            {
                Console.WriteLine(myTuple.Item3);
            }
        }

       

    }
 }
