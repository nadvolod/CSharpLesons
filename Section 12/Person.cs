namespace Section12
{
    abstract class Person
    {
        private string idNumber;
        private string lastname;
        private string firstname;

        public Person(string id, string lname, string fname)
        {
            idNumber = id;
            lastname = lname;
            firstname = fname;

        }

        public override string ToString()
        {
            return "First Name: " + firstname + "\n" +
                "Last Name: " + lastname;
        }

    }
}
