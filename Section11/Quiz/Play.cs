namespace Quiz
{
    class Play : Ticket
    {
        private bool refreshmentsServed;
        private int numberOfActors;
        private string playSpecificInfo;

        public Play(int seatNum, string rowId, string dateTime,
           string nameEvent, string type, string location, bool refreshments,
           int numOfActors, string playInfo, double cost)
           : base(seatNum, rowId, dateTime, nameEvent, type, location, cost)
        {
            RefreshmentsServed = refreshments;
            PlaySpecificInfo = playInfo;
            NumberOfActors = numOfActors;

        }

        public bool RefreshmentsServed
        {
            get
            {
                return refreshmentsServed;
            }
            set
            {
                refreshmentsServed = value;
            }
        }

        public int NumberOfActors
        {
            get
            {
                return numberOfActors;
            }
            set
            {
                numberOfActors = value;
            }
        }

        public string PlaySpecificInfo
        {
            get
            {
                return playSpecificInfo;
            }
            set
            {
                playSpecificInfo = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() +
                    "\nNumber of Actors: " + numberOfActors;
        }
    }
}
