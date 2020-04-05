using System;

namespace Exam
{
    class HomeLoan : Loan
    {
        private string address;
        private int yearBuilt;
        private int sqFootage;

        public HomeLoan(string number, string first, string last, double intRate, decimal prinBorrowed, double duration,
                   int yrBuilt, int sqFeet, string add)
           : base(number, first, last, intRate, prinBorrowed, duration)
        {
            YearBuilt = yrBuilt;
            SqFootage = sqFeet;
            Address = add;
        }


        //Property yearBuilt
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

        //Property for sqFootage
        public int SqFootage
        {
            get
            {
                return sqFootage;
            }
            set
            {
                sqFootage = value;
            }
        }

        // Property for address
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

        public override decimal CalculateInterest()
        {
            var interestRate = Convert.ToDecimal(InterestRate);
            var numberOfPaymentsInMonths = Convert.ToDecimal(TermYears / 12);
            int adminFee = 5000;
            var loanPrinciple = (LoanAmount + adminFee);
            return interestRate / numberOfPaymentsInMonths * loanPrinciple;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nHome Loan Address: " + Address
            +"\n Calculated Interest :" + CalculateInterest().ToString("C");
        }
    }
}
