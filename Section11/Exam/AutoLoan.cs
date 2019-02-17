using System;

namespace Exam
{
    class AutoLoan :Loan
    {
        private int yearBuilt;
        private string model;
        private string make;
        private string autoColor;

        public AutoLoan(string number, string first, string last, double intRate, decimal prinBorrowed,
                double duration, int yr, string mod,
                string carMake, string color)
            : base(number, first, last, intRate, prinBorrowed, duration)
        {
            YearBuilt = yr;
            Model = mod;
            Make = carMake;
            AutoColor = color;
        }

        // Property for yearBuilt
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

        //Property for model
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        // Property for make
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string AutoColor
        {
            get
            {
                return autoColor;
            }
            set
            {
                autoColor = value;
            }
        }

        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(TermYears) / 12M) *
                (LoanAmount + 1000));
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nType of Car: " +
                YearBuilt + " " +
                AutoColor + " " + Model
                + "\n Calculated Interest :" + CalculateInterest().ToString("C");

        }
    }
}
