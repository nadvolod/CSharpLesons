using System;

namespace Section6
{
    class Trip
    {

        private string destination;
        private double distanceTraveled;
        private decimal fuelCost;
        private double gallonsConsumed;

        public Trip(string dest, double distance, decimal cost, double gallons)
        {
            Destination = dest;
            DistanceTraveled = distance;
            FuelCost = cost;
            GallonsConsumed = gallons;
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public double DistanceTraveled
        {
            get
            {
                return distanceTraveled;
            }
            set
            {
                distanceTraveled = value;
            }
        }

        public decimal FuelCost
        {
            get
            {
                return fuelCost;
            }
            set
            {
                fuelCost = value;
            }
        }

        public double GallonsConsumed
        {
            get
            {
                return gallonsConsumed;
            }
            set
            {
                gallonsConsumed = value;
            }
        }

        public double MilesPerGallon()
        {
            return DistanceTraveled / GallonsConsumed;
        }

        public decimal CostPerMile()
        {
            return FuelCost / Convert.ToDecimal(DistanceTraveled);
        }

        public override string ToString()
        {
            return "Destination: " + Destination +
               "\nTotal Miles: " + DistanceTraveled +
                "\nFuel Consumed: " + GallonsConsumed.ToString("f1") + " gallons" +
                "\nCost: " + FuelCost.ToString("c") +
                "\nMPG: " + MilesPerGallon().ToString("f0") +
                "\nCost Per Mile: " + CostPerMile().ToString("c");
        }
    }
}
