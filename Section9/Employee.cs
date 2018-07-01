namespace Section9
{
    class Employee
    {
        //constructor
        public Employee(int id)
        {
            EmployeeID = id;
        }
        public Employee(string name, int id, string title)
        {
            Name = name;
            EmployeeID = id;
            JobTitle = title;
        }

        //properties
        public string Name
        {
            get;
            set;
        }

        public int EmployeeID
        {
            get;
            set;
        }

        public string JobTitle
        {
            get;
            set;
        }

        //methods
        public string JobLocation()
        {
            if(JobTitle == "Manager")
            {
                return "Boston";
            }
            else if(JobTitle == "Staff")
            {
                return "Chicago";
            }

            return "New York";
        }

        public string PayType(string title)
        {
            if (JobTitle == "Manager")
            {
                return "Salary";
            }
            else if (JobTitle == "Staff")
            {
                return "Hourly";
            }

            return "Hourly";
        }

        public string PayType(int id)
        {
            if (EmployeeID == 12345)
            {
                return "Salary";
            }
            else if (EmployeeID == 54321)
            {
                return "Hourly";
            }

            return "Hourly";
        }

        public override string ToString()
        {
            return EmployeeID + " " + Name + " Job Title: " + JobTitle;
        }

    }
}
