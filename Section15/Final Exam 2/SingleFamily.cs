namespace Section14.Final_Exam_2
{
    class SingleFamily :Housing
    {
        private int numberOfBedrooms;
        private int numberOfBathrooms;
        private bool garage;
        private bool porch;
        private decimal rentAmount;
        private double squareFeet;

        public SingleFamily(int yr, string addr, string type,
                bool grg, bool pch, decimal rentAmt, int numBeds, int numBaths)
            : base(yr, addr, type)
        {
            numberOfBathrooms = numBaths;
            numberOfBedrooms = numBeds;
            garage = grg;
            porch = pch;
            rentAmount = rentAmt;
        }

        public int NumberOfBedrooms
        {
            get
            {
                return numberOfBedrooms;
            }
            set
            {
                numberOfBedrooms = value;
            }
        }

        public int NumberOfBathrooms
        {
            get
            {
                return numberOfBathrooms;
            }
            set
            {
                numberOfBathrooms = value;
            }
        }

        public bool Garage
        {
            get
            {
                return garage;
            }
            set
            {
                garage = value;
            }
        }

        public bool Porch
        {
            get
            {
                return porch;
            }
            set
            {
                porch = value;
            }
        }

        public double SquareFeet
        {
            get
            {
                return squareFeet;
            }
            set
            {
                squareFeet = value;
            }
        }

        public decimal RentAmount
        {
            get
            {
                return rentAmount;
            }
            set
            {
                rentAmount = value;
            }
        }

        public override decimal ProjectedRentalAmt()
        {
            return 12M * rentAmount;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Bedrooms: " + numberOfBedrooms +
                "\nNumber of Bathrooms: " + numberOfBathrooms +
                "\nMonthlty Rental Rate:" + rentAmount.ToString("C") +
                "\n\nExpected Annual Rents: " + ProjectedRentalAmt().ToString("C");

        }

    }
}
