using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Employee_Full_Name()
        {
            TestEmployee myEmployee = new TestEmployee("Sara", "Benett");
            string fullname = myEmployee.ReturnFullName();
            StringAssert.Equals(fullname, "Sara Benett");
        }
        
        [TestMethod]
        public void Employee_Full_Name_Sorting()
        {
            TestEmployee myEmployee = new TestEmployee("Sara", "Benett");
            string fullname = myEmployee.ReturnFullNameForSortingPurposes();
            StringAssert.Equals(fullname, "Benett, Sara");
        }
    }

    public class TestEmployee
    {
        //private variables internal to the class
        private string employeeNumber;
        private string jobDescription;
        private string department;
        private string employeeFirstName;
        private string employeeLastName;
        private string dateOfHire;
        private double salary;

        //constructors
        public TestEmployee(string empFirstName, string empLastName)
        {
            EmployeeFirstName = empFirstName;
            EmployeeLastName = empLastName;
        }
        public TestEmployee(string empNo, string empFirstName, string empLastName, string hireDate, double newSalary, string dept, string job)
        {
            EmployeeNumber = empNo;
            EmployeeFirstName = empFirstName;
            EmployeeLastName = empLastName;
            DateOfHire = hireDate;
            Salary = newSalary;
            Department = dept;
            JobDescription = job;
        }

        //properties 
        public string EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }

        public string EmployeeFirstName
        {
            get
            {
                return employeeFirstName;
            }
            set
            {
                employeeFirstName = value;
            }
        }

        public string EmployeeLastName
        {
            get
            {
                return employeeLastName;
            }
            set
            {
                employeeLastName = value;
            }
        }


        public string DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                dateOfHire = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;

            }
            set
            {
                salary = value;
            }
        }

        public string JobDescription
        {
            get
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        //methods
        public string ReturnFullName()
        {
            return EmployeeFirstName + " " + EmployeeLastName;
        }

        public string ReturnFullNameForSortingPurposes()
        {
            return EmployeeLastName + ", " + EmployeeFirstName;

        }
    }
}
