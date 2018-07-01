namespace Section12
{
    class Professor : Person, ITraveler
    {
        private string empId;
        private string subject;

        public Professor(string id, string fname, string lname, string subject, string empId)
        : base(id, lname, fname)
        {
            EmployeeID = empId;
            SubjectArea = subject;
        }

        public string EmployeeID
        {
            get
            {
                return empId;
            }

            set
            {
                empId = value;
            }
        }

        public string SubjectArea
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public string GetDestination()
        {
            return "The Beach";
        }

        public string GetStartLocation()
        {
            return "Home";
        }

        public double DetermineMiles()
        {
            return 200.0;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\n Destination: " + GetDestination() +
                "\n Start Location: " + GetStartLocation() +
                "\n Miles: " + DetermineMiles();
        }
    }
}
