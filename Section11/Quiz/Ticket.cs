namespace Quiz
{
    abstract class Ticket
    {
        private int seat;
        private string row;
        private string eventDateTime;
        private string eventName;
        private string eventType;
        private string eventLocation;
        private double ticketCost;

        public Ticket(int seatNum, string rowId, string dateTime,
                         string nameEvent, string type, string location, double cost)
        {
            EventType = type;
            EventName = nameEvent;
            EventLocation = location;
            EventDateTime = dateTime;
            Seat = seatNum;
            Row = rowId;
            TicketCost = cost;
        }

        public int Seat
        {
            get
            {
                return seat;
            }
            set
            {
                seat = value;
            }
        }

        public string Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public string EventDateTime
        {
            get
            {
                return eventDateTime;
            }
            set
            {
                eventDateTime = value;
            }
        }

        public string EventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
            }
        }

        public string EventType
        {
            get
            {
                return eventType;
            }
            set
            {
                eventType = value;
            }
        }

        public string EventLocation
        {
            get
            {
                return eventLocation;
            }
            set
            {
                eventLocation = value;
            }
        }

        public double TicketCost
        {
            get
            {
                return ticketCost;
            }
            set
            {
                ticketCost = value;
            }
        }


        public override string ToString()
        {
            return eventType.ToUpper() + ":\t" + eventName +
                    "\n\tWhere:\t" + eventLocation +
                    "\n\tWhen:\t" + eventDateTime +
                    "\n\tCost:\t" + ticketCost.ToString("C") +
                    "\n\tRow - Seat:  " + row + " - " + seat;
        }
    }
}
