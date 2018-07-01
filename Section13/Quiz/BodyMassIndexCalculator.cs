/* BodyMassIndexCalculator
 * This class includes data members to enable users
 * to calculate a person's body mass index (BMI).
 * Imperial formula is BMI = (weight in pounds * 703)
 *       / (height in inches squared)
 */
using System;

namespace Section13.Quiz
{
    class BodyMassIndexCalculator
    {

        private int weight;
        private int heightInFeet;
        private int heightInInches;

        public BodyMassIndexCalculator()
        {
        }

        public BodyMassIndexCalculator(int lbs, int feet, int inches)
        {
            weight = lbs;
            heightInFeet = feet;
            heightInInches = inches;
        }

        public int HeightInFeet
        {
            get
            {
                return heightInFeet;
            }
            set
            {
                heightInFeet = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return heightInInches;
            }
            set
            {
                heightInInches = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public double CalculateBMI()
        {
            return (weight * 703) / Math.Pow((heightInFeet * 12 + heightInInches), 2);
        }

        public override string ToString()
        {
            return "\nBMI: " + CalculateBMI().ToString("F2");
        }

    }
}
