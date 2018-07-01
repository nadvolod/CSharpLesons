namespace Section9
{
    class PropertyTaxCalc
    {
        private decimal millage_rate = 10.03M;
        private decimal assessment_increase = 0.027M;
        private decimal exemption = 25000;

        public PropertyTaxCalc(string address, decimal lastYearVal, decimal thisYearVal)
        {
            PropertyAddress = address;
            LastYearValue = lastYearVal;
            ThisYearValue = thisYearVal;
        }

        public string PropertyAddress
        {
            get;
            set;
        }

        public decimal LastYearValue
        {
            get;
            set;
        }

        public decimal ThisYearValue
        {
            get;
            set;
        }


        public decimal CalculateNewAssessedValue()
        {
            return LastYearValue * (1 + assessment_increase);
        }

        public decimal CalculateTaxesDue()
        {
            return (ThisYearValue - exemption) / 1000 * millage_rate;
        }

        public decimal CalculateTaxableValue()
        {
            return ThisYearValue - exemption;
        }

        public override string ToString()
        {
            return string.Format("Property Address: {0}\n" +
                "Last Year Assessed Value: {1:C}\n" +
                "Current Assessed Value: {2:C}\n" +
                "Exemption: {3:C}\n" +
                "Taxable Value: {4:C}\n" +
                "Millage Rate: {5:C}\n" +
                "Taxes Due: {6:C}", PropertyAddress, LastYearValue, ThisYearValue, exemption,
                CalculateTaxableValue(), millage_rate, CalculateTaxesDue());
        }
    }
}
