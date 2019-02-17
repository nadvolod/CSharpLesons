namespace UnitTestProject1
{
    public class Receipt
    {

        //private variables
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerAddress;
        private string customerPhone;
        private int itemNumber;
        private string itemDesc;
        private decimal unitPrice;
        private int qtyPurchased;

        //Constructor
        public Receipt(int rNum, string purchaseDate, int cNum, string cFName, string cLName,
                       string cAddress, string cPhone, int iNum, string iDesc, decimal uPrice, int qty)
        {
            ReceiptNumber = rNum;
            DateOfPurchase = purchaseDate;
            CustomerNumber = cNum;
            CustomerFirstName = cFName;
            CustomerLastName = cLName;
            CustomerAddress = cAddress;
            CustomerPhone = cPhone;
            ItemNumber = iNum;
            ItemDesc = iDesc;
            UnitPrice = uPrice;
            QtyPurchased = qty;
        }

        //properties
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                //check that the receipt number is greater than 0
                if (value > 0)
                {
                    receiptNumber = value;
                }

            }
        }

        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                //check that the customer number is greater than 0
                if (value > 0)
                {
                    customerNumber = value;
                }

            }
        }

        public string CustomerFirstName
        {
            get
            {
                return customerFirstName;
            }
            set
            {
                customerFirstName = value;
            }
        }

        public string CustomerLastName
        {
            get
            {
                return customerLastName;
            }
            set
            {
                customerLastName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return customerPhone;
            }
            set
            {
                customerPhone = value;
            }
        }


        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            { //check that item number is greater than 0 and less than 9999
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }

            }
        }

        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }
            set
            {
                itemDesc = value;
            }

        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                //check that price is greater than 0 and less than 9999
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }

                
            }
        }

        public int QtyPurchased
        {
            get
            {
                return qtyPurchased;
            }
            set
            {
                //check that quantity is greater than 0 and less than 9999
                if (value > 0)
                {
                    qtyPurchased = value;
                }

            }
        }

        //methods
        public decimal CalculateTotalCost()
        {
            return unitPrice * qtyPurchased;
        }

        public override string ToString()
        {
            return "Customer: " + customerFirstName + " " + customerLastName +
                   "\nPhone: " + customerPhone +
                   "\nTotal Purchases: " + CalculateTotalCost().ToString("C");
        }
    }
}
