namespace Quiz
{
    class Lecture : Ticket
    {
        private bool projectionNeeded;
        private string lectureTopic;

        public Lecture(int seatNum, string rowId, string dateTime,
            string nameEvent, string type, string location, bool projector, string info, double cost)
            : base(seatNum, rowId, dateTime, nameEvent, type, location, cost)
        {
            ProjectionNeeded = projector;
            LectureTopic = info;
        }

        public bool ProjectionNeeded
        {
            get
            {
                return projectionNeeded;
            }
            set
            {
                projectionNeeded = value;
            }
        }

        public string LectureTopic
        {
            get
            {
                return lectureTopic;
            }
            set
            {
                lectureTopic = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nLecture Topic: " + lectureTopic;
        }
    }
}
