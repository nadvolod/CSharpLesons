namespace Section14.Final_Exam_2
{
    class Housing
    {
        private int yearBuilt;
        private string address;
        private string typeOfConstruction;

        public Housing(int yr, string addr, string contructionType)
        {
            yearBuilt = yr;
            address = addr;
            typeOfConstruction = contructionType;
        }

        public int YearBuilt
        {
            get
            {
                return yearBuilt;
            }
            set
            {
                yearBuilt = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string TypeOfConstruction
        {
            get
            {
                return typeOfConstruction;
            }
            set
            {
                typeOfConstruction = value;
            }
        }

        public virtual decimal ProjectedRentalAmt()
        {
            return 0M;
        }

        public override string ToString()
        {
            return "\nAddress: " + address;
        }
    }
}

