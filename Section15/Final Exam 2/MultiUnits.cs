namespace Section14.Final_Exam_2
{
    class MultiUnits : Housing, IUnits
    {
        private string complexName;
        private int numberOfUnits;
        private decimal rentAmountPerUnit;

        public MultiUnits(int yrBuilt, string addr, string typeOfConstr,
                        int numberUnits, string name, decimal rentAmt)
            : base(yrBuilt, addr, typeOfConstr)
        {
            numberOfUnits = numberUnits;
            complexName = name;
            rentAmountPerUnit = rentAmt;
        }

        public int NoOfUnits
        {
            get
            {
                return numberOfUnits;
            }
            set
            {
                numberOfUnits = value;
            }
        }

        public string ComplexName
        {
            get
            {
                return complexName;
            }
            set
            {
                complexName = value;
            }
        }

        public decimal RentAmountPerUnit
        {
            get
            {
                return rentAmountPerUnit;
            }
            set
            {
                rentAmountPerUnit = value;
            }
        }

        public override decimal ProjectedRentalAmt()
        {
            return 12 * rentAmountPerUnit * numberOfUnits;
        }

        public int GetNumUnits()  // Interface's method
        {
            return numberOfUnits;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Units: " + GetNumUnits() +
                "\nPer Unit Rent: " + rentAmountPerUnit.ToString("C") +
                "\n\nProjected Annual Rent From This Address: " + ProjectedRentalAmt().ToString("C");
        }
    }
}
