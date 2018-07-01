namespace Section12
{
    class Student : Person, ITraveler
    {
        private string major;
        private string studentId;

        public Student(string id, string fname, string lname, string maj, string sId)
        : base(id, lname, fname)
        {
            StudentId = sId;
            Major = maj;
        }

        public string StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "School";
        }

        public double DetermineMiles()
        {
            return 75.0;
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
