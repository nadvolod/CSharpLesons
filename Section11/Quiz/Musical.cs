namespace Quiz
{
    class Musical : Ticket
    {
        private string performerName;
        private bool memoriabilityOnSale;
        private bool backStageOffered;
        private bool signsAutographAvailable;

        public Musical(int seatNum, string rowId,
           string nameEvent, string type, string location, string performer, string eventDateTime,
                             bool memoriability,
                            bool backStage, bool signsAutograph, double cost)
            : base(seatNum, rowId, eventDateTime, nameEvent, type, location, cost)
        {
            PerformerName = performer;
            MemoriabilityOnSale = memoriability;
            BackStageOffered = backStage;
            SignsAutographAvailable = signsAutograph;
        }

        public string PerformerName
        {
            get
            {
                return performerName;
            }
            set
            {
                performerName = value;
            }
        }

        public bool MemoriabilityOnSale
        {
            get
            {
                return memoriabilityOnSale;
            }
            set
            {
                memoriabilityOnSale = value;
            }
        }

        public bool BackStageOffered
        {
            get
            {
                return backStageOffered;
            }
            set
            {
                backStageOffered = value;
            }
        }

        public bool SignsAutographAvailable
        {
            get
            {
                return signsAutographAvailable;
            }
            set
            {
                signsAutographAvailable = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nPerformers: " + performerName;
        }
    }
}
